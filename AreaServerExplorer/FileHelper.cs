using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaServerExplorer
{
    public static class FileHelper
    {
        static byte[] key = new byte[] { 0x3B, 0x16, 0x6F, 0xD8, 0xAC, 0xB2, 0x09, 0xFC, 0xB0, 0x9D, 0xA9, 0x3A, 0xDC, 0xA1, 0x3F, 0xD2, 0x45, 0x17, 0x11, 0x03, 0xFB, 0x59, 0x5E, 0x21, 0xD3, 0x7A, 0x41, 0xE8, 0x6A, 0x34, 0xD9, 0x10, 0x66, 0x21, 0xA7, 0x21, 0xFF, 0x2E, 0x37, 0x89, 0xBF, 0x4E, 0x03, 0xEC, 0x85, 0x6B, 0x94, 0xBB, 0xD0, 0xA2, 0xEA, 0x08, 0x3A, 0xAF, 0x1E, 0x99, 0x43, 0xA6, 0x46, 0x3B, 0x50, 0xE5, 0x99, 0x58, 0xF4, 0x46, 0xD4, 0xCC, 0x6D, 0x99, 0xDC, 0xF5, 0x72, 0x51, 0xA4, 0x09, 0x2C, 0x7D, 0x51, 0xAD, 0x82, 0xFA, 0x9C, 0xC3, 0x99, 0xE7, 0x78, 0x83, 0x9B, 0x5A, 0xF5, 0xCD, 0xB8, 0x51, 0x65, 0xBD, 0x6B, 0xEC, 0xBD, 0x81, 0xFF, 0xD9, 0x3E, 0x67, 0x51, 0x0F, 0x54, 0x3A, 0xD7, 0xBF, 0xBE, 0xCF, 0xE1, 0x87, 0xEF, 0xDB, 0x1F, 0xEA, 0xB4, 0x07, 0x64, 0xFD, 0x18, 0x47, 0xA9, 0x62, 0x85, 0x67, 0x55, 0x7A, 0x2B, 0xE7, 0xBC, 0xD7, 0xA5, 0x08, 0xE5, 0xF0, 0xDA, 0x27, 0x90, 0x19, 0x22, 0x4A, 0x77, 0xB2, 0xAB, 0xF9, 0xD5, 0x9E, 0x1A, 0x4F, 0x25, 0xF7, 0x75, 0x50, 0x2C, 0xFF, 0x40, 0x7D, 0x39, 0x5A, 0xE6, 0xA6, 0xAC, 0x7B, 0x5B, 0x00, 0xB5, 0x5D, 0x00, 0x77, 0x5E, 0x73, 0xC7, 0x45, 0xCC, 0xE1, 0x97, 0xC4, 0xC1, 0xEC, 0xF2, 0x80, 0x66, 0xAF, 0xD5, 0x91, 0x48, 0x10, 0xDF, 0x28, 0xA0, 0xF3, 0xB6, 0x67, 0xD7, 0xAE, 0xA7, 0x76, 0x49, 0xBC, 0x8C, 0xD3, 0x4A, 0xB5, 0xF3, 0xE9, 0x66, 0x7D, 0x7C, 0xE5, 0xED, 0xBC, 0x83, 0xC5, 0xB0, 0x8F, 0xFF, 0xB1, 0x05, 0x7E, 0xAA, 0x8F, 0x11, 0xAD, 0x63, 0xD2, 0x46, 0x56, 0xD0, 0x92, 0x2A, 0x76, 0x47, 0xE2, 0x5A, 0xC7, 0xEF, 0x5E, 0xCF, 0xEF, 0x22, 0x03, 0x61, 0xF7, 0x16, 0x44, 0x89, 0xFE, 0xBD, 0x59, 0x6B, 0x2F, 0xE9, 0xDB };
        static Random rnd = new Random();
        
        public static string[] getFileNamesGZip(string filename)
        {
            List<string> result = new List<string>();
            byte[] buff = File.ReadAllBytes(filename);
            int pos = 0;
            while (pos  < buff.Length - 4)
            {
                if (isGzipMagic(buff, pos))
                    result.Add(ReadName(buff, pos + 10));
                pos++;
            }
            return result.ToArray();
        }

        public static byte[] unzipFile(string filename, byte[] subname)
        {
            MemoryStream result = new MemoryStream();
            byte[] buff = File.ReadAllBytes(filename);
            MemoryStream input = new MemoryStream(buff);
            int pos = 0;
            while (pos < buff.Length - subname.Length)
            {
                bool found = true;
                for(int i=0;i<subname.Length;i++)
                    if (buff[pos + i] != subname[i])
                    {
                        found = false;
                        break;
                    }
                if (found)
                    break;
                pos++;
            }
            input.Seek(pos - 10, 0);
            GZipStream stream = new GZipStream(input, CompressionMode.Decompress);
            stream.CopyTo(result);
            stream.Close();
            return result.ToArray();
        }

        public static byte[] DecryptFile(string filename)
        {
            byte[] data = File.ReadAllBytes(filename);
            MemoryStream m = new MemoryStream();
            m.Write(data, 0, 16);
            byte[] filekey = m.ToArray();
            m = new MemoryStream();
            m.Write(data, 16, data.Length - 16);
            data = m.ToArray();
            for (int i = 0; i < data.Length; i++)
                data[i] = (byte)(filekey[i % 16] ^ (data[i] + key[i % 256]));
            return data;
        }

        public static void EncryptFile(byte[] data, string filename)
        {
            byte[] filekey = new byte[16];
            for (int i = 0; i < 16; i++)
                filekey[i] = (byte)rnd.Next(256);
            MemoryStream m = new MemoryStream();
            m.Write(filekey, 0, 16);
            for (int i = 0; i < data.Length; i++)
                m.WriteByte((byte)((filekey[i % 16] ^ data[i]) - key[i % 256]));
            File.WriteAllBytes(filename, m.ToArray());
        }

        public static string ReadName(byte[] buff, int start)
        {
            string result = "";
            byte b;
            while ((b = buff[start++]) != 0)
                result += (char)b;
            return result;
        }

        public static bool isEncrypted(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            byte[] buff = new byte[4];
            fs.Read(buff, 0, 4);
            fs.Close();
            return !isGzipMagic(buff);
        }

        public static bool isGzipMagic(byte[] data, int start = 0)
        {
            if (data[start++] == 0x1F &&
                data[start++] == 0x8B &&
                data[start++] == 0x08 &&
                (data[start] == 0x08 || data[start] == 0x00))
                return true;
            return false;
        }

        public static int FindPattern(byte[] buff, byte[] pat, int start = 0)
        {
            int result = -1;
            for (int i = start; i < buff.Length - pat.Length; i++)
            {
                bool found = true;
                for (int j = 0; j < pat.Length; j++)
                    if (buff[i + j] != pat[j])
                    {
                        found = false;
                        break;
                    }
                if (found)
                    return i;
            }
            return result;
        }

        public static byte[] ImportIntoPack(byte[] packdata, string subname, string filename)
        {
            MemoryStream result = new MemoryStream();
            List<FileEntry> files = ReadFileInfos(packdata);
            byte[] filebuff = File.ReadAllBytes(filename);
            result.Write(packdata, 0, 8);
            foreach (FileEntry file in files)
            {
                result.WriteByte((byte)file.name.Length);
                result.Write(Encoding.ASCII.GetBytes(file.name), 0, file.name.Length);
                result.Write(new byte[4], 0, 4);
                if (file.name != subname)
                    result.Write(BitConverter.GetBytes(file.size), 0, 4);
                else
                    result.Write(BitConverter.GetBytes(filebuff.Length), 0, 4);
            }
            for (int i = 0; i < files.Count; i++)
            {
                FileEntry file = files[i];
                file.offset = (int)result.Position;
                if (file.name != subname)
                    result.Write(packdata, file.offset, file.size);
                else
                {
                    file.size = filebuff.Length;
                    result.Write(filebuff, 0, filebuff.Length);
                }
                files[i] = file;
            }
            result.Seek(8, 0);
            foreach (FileEntry file in files)
            {
                result.WriteByte((byte)file.name.Length);
                result.Write(Encoding.ASCII.GetBytes(file.name), 0, file.name.Length);
                result.Write(BitConverter.GetBytes(file.offset), 0, 4);
                result.Write(BitConverter.GetBytes(file.size), 0, 4);
            }
            return result.ToArray();
        }

        public static List<FileEntry> ReadFileInfos(byte[] data)
        {
            List<FileEntry> result = new List<FileEntry>();
            int count = BitConverter.ToInt32(data, 4);
            int pos = 8;
            for (int i = 0; i < count; i++)
            {
                FileEntry entry = new FileEntry();
                byte namelen = data[pos++];
                MemoryStream m = new MemoryStream();
                for (int j = 0; j < namelen; j++)
                    m.WriteByte(data[pos++]);
                entry.name = Encoding.ASCII.GetString(m.ToArray());
                entry.offset = BitConverter.ToInt32(data, pos); pos += 4;
                entry.size = BitConverter.ToInt32(data, pos); pos += 4;
                result.Add(entry);
            }
            return result;
        }

        public static void ImportSubFile(string filename, string subname, byte[] data)
        {
            byte[] buff = Encoding.ASCII.GetBytes(subname);
            MemoryStream m = new MemoryStream();
            GZipStream stream = new GZipStream(m, CompressionMode.Compress);            
            new MemoryStream(data).CopyTo(stream);
            stream.Close();
            byte[] cdata = m.ToArray();
            m = new MemoryStream();
            m.Write(cdata, 0, 3);
            m.WriteByte(8);
            m.Write(cdata, 4, 6);
            m.Write(buff, 0, buff.Length);
            m.WriteByte(0);
            m.Write(cdata, 10, cdata.Length - 10);
            while (m.Length % 0x800 != 0)
                m.WriteByte(0);
            cdata = m.ToArray();
            byte[] buff2 = File.ReadAllBytes(filename);
            int start = FindPattern(buff2, buff) - 10;
            int pos = start + 1;
            while (!isGzipMagic(buff2, pos++)) ;
            int end = pos - 1;
            MemoryStream result = new MemoryStream();
            result.Write(buff2, 0, start);
            result.Write(cdata, 0, cdata.Length);
            result.Write(buff2, end, buff2.Length - end);
            File.WriteAllBytes(filename, result.ToArray());
        }

        public static List<byte[]> ReadTEXTFile(byte[] buff)
        {
            List<byte[]> result = new List<byte[]>();
            int count = BitConverter.ToInt32(buff, 0);
            int pos = 4;
            for (int i = 0; i < count; i++) 
            {
                int len = BitConverter.ToInt32(buff, pos); pos += 4;
                byte[] buff2 = new byte[len];
                for (int j = 0; j < len; j++)
                    buff2[j] = buff[pos + j];
                result.Add(buff2);
                pos += len;
            }
            return result;
        }

        public static byte[] CompileTEXTEntries(List<byte[]> list)
        {
            MemoryStream m = new MemoryStream();
            m.Write(BitConverter.GetBytes((int)list.Count), 0, 4);
            foreach (byte[] entry in list)
            {
                m.Write(BitConverter.GetBytes((int)entry.Length), 0, 4);
                m.Write(entry, 0, entry.Length);
            }
            return m.ToArray();
        }
    }

    public class FileEntry
    {
        public string name;
        public int offset;
        public int size;
    }
}
