using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Be.Windows.Forms;

namespace AreaServerExplorer
{
    public partial class PACKEditor : Form
    {
        public class FileEntry
        {
            public string name;
            public int offset;
            public int size;
        }

        public string filename; 
        public byte[] filebuff;
        public List<FileEntry> files;


        public PACKEditor()
        {
            InitializeComponent();
        }

        private void PACKEditor_Load(object sender, EventArgs e)
        {
            filebuff = FileHelper.DecryptFile(filename);
            int count = BitConverter.ToInt32(filebuff, 4);
            int pos = 8;
            byte b;
            files = new List<FileEntry>();
            for (int i = 0; i < count; i++)
            {
                FileEntry entry = new FileEntry();
                byte namelen = filebuff[pos++];
                MemoryStream m = new MemoryStream();
                for (int j = 0; j < namelen; j++)
                    m.WriteByte(filebuff[pos++]);
                entry.name = Encoding.ASCII.GetString(m.ToArray());
                entry.offset = BitConverter.ToInt32(filebuff, pos); pos += 4;
                entry.size = BitConverter.ToInt32(filebuff, pos); pos += 4;
                files.Add(entry);
            }
            RefreshList();
        }

        public void RefreshList()
        {
            listBox1.Items.Clear();
            foreach (FileEntry f in files)
                listBox1.Items.Add(f.name);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = listBox1.SelectedIndex;
            if (n == -1)
                return;
            FileEntry entry = files[n];
            byte[] buff = new byte[entry.size];
            for (int i = 0; i < entry.size; i++)
                buff[i] = filebuff[entry.offset + i];
            hb1.ByteProvider = new DynamicByteProvider(buff);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = listBox1.SelectedIndex;
            if (n == -1)
                return;
            FileEntry entry = files[n];
            byte[] buff = new byte[entry.size];
            for (int i = 0; i < entry.size; i++)
                buff[i] = filebuff[entry.offset + i];
            string ext = "*" + Path.GetExtension(entry.name);
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = ext + "|" + ext;
            d.FileName = entry.name;
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllBytes(d.FileName, buff);
                MessageBox.Show("Done.");
            }
        }
    }
}
