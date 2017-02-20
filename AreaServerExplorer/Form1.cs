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
    public partial class Form1 : Form
    {
        public string basepath;
        public Form1()
        {
            InitializeComponent();
        }

        private void openAreaServerexeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "*.exe|*.exe";
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                basepath = Path.GetDirectoryName(d.FileName) + "\\";
                RefreshList();
            }
        }

        private void RefreshList()
        {
            string[] files = Directory.GetFiles(basepath, "*.*", SearchOption.AllDirectories);
            listBox1.Items.Clear();
            foreach (string file in files)
                if (file.ToLower().EndsWith(".bin") ||
                    file.ToLower().EndsWith(".dat"))
                    listBox1.Items.Add(file.Substring(basepath.Length));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = listBox1.SelectedIndex;
            if (n == -1)
                return;
            string filename = basepath + listBox1.SelectedItem.ToString();
            if (FileHelper.isEncrypted(filename))
            {
                gui02.BringToFront();
                openInPACKEditorToolStripMenuItem.Visible = filename.ToLower().Contains("pack.bin");
                hb2.ByteProvider = new DynamicByteProvider(FileHelper.DecryptFile(filename));
            }
            else
            {
                gui01.BringToFront();
                listBox2.Items.Clear();
                listBox2.Items.AddRange(FileHelper.getFileNamesGZip(filename));
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null || listBox2.SelectedItem == null) 
                return;
            string filename = basepath + listBox1.SelectedItem.ToString();
            byte[] subname = Encoding.ASCII.GetBytes(listBox2.SelectedItem.ToString());
            hb1.ByteProvider = new DynamicByteProvider(FileHelper.unzipFile(filename, subname));
        }

        private void extractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;
            string filename = basepath + listBox1.SelectedItem.ToString();
            string fileonly = Path.GetFileName(filename);
            string ext = "*" + Path.GetExtension(fileonly);
            byte[] buff = FileHelper.DecryptFile(filename);
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = ext + "|" + ext;
            d.FileName = fileonly;
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllBytes(d.FileName, FileHelper.DecryptFile(filename));
                MessageBox.Show("Done.");
            }
        }

        private void openInPACKEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = listBox1.SelectedIndex;
            if (n == -1)
                return;
            PACKEditor ed = new PACKEditor();
            ed.filename = basepath + listBox1.SelectedItem.ToString();
            ed.ShowDialog();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null || listBox2.SelectedItem == null)
                return;
            string filename = basepath + listBox1.SelectedItem.ToString();
            string fileonly = listBox2.SelectedItem.ToString();
            string ext = "*" + Path.GetExtension(fileonly);
            byte[] subname = Encoding.ASCII.GetBytes(fileonly);
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = ext + "|" + ext;
            d.FileName = fileonly;
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllBytes(d.FileName, FileHelper.unzipFile(filename, subname));
                MessageBox.Show("Done.");
            }
        }

        private void createPNACHFileForIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Please enter IP", "PNACH File Creator", "192.168.178.");
            if (input == "" || input.Length > 16)
                return;
            byte[] data = Encoding.UTF8.GetBytes(input);
            string r = Properties.Resources.ResourceManager.GetString("template");
            byte[] temp = new byte[24];
            for (int i = 0; i < data.Length; i++)
                temp[i] = data[i];
            r = r.Replace("#1", BitConverter.ToUInt32(temp, 0).ToString("X8"));
            r = r.Replace("#2", BitConverter.ToUInt32(temp, 4).ToString("X8"));
            r = r.Replace("#3", BitConverter.ToUInt32(temp, 8).ToString("X8"));
            r = r.Replace("#4", BitConverter.ToUInt32(temp, 12).ToString("X8"));
            r = r.Replace("#5", BitConverter.ToUInt32(temp, 16).ToString("X8"));
            r = r.Replace("#6", BitConverter.ToUInt32(temp, 20).ToString("X8"));
            SaveFileDialog d = new SaveFileDialog();
            d.Filter = "9C9D549D.pnach|9C9D549D.pnach";
            d.FileName = "9C9D549D.pnach";
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(d.FileName, r);
                MessageBox.Show("Done.");
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null || listBox2.SelectedItem == null)
                return;
            string filename = basepath + listBox1.SelectedItem.ToString();
            string fileonly = listBox2.SelectedItem.ToString();
            string ext = "*" + Path.GetExtension(fileonly);
            byte[] subname = Encoding.ASCII.GetBytes(fileonly);
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = ext + "|" + ext;
            d.FileName = fileonly;
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileHelper.ImportSubFile(filename, fileonly, File.ReadAllBytes(d.FileName));
                MessageBox.Show("Done.");
            }
        }

        private void importToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;
            string filename = basepath + listBox1.SelectedItem.ToString();
            string fileonly = Path.GetFileName(filename);
            string ext = "*" + Path.GetExtension(fileonly);
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = ext + "|" + ext;
            d.FileName = fileonly;
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileHelper.EncryptFile(File.ReadAllBytes(d.FileName), filename);
                MessageBox.Show("Done.");
            }
        }

        private void patchIPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "*.exe|*.exe";
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                byte[] buff = File.ReadAllBytes(d.FileName);
                int pos = FileHelper.FindPattern(buff, new byte[] { 0x43, 0x54, 0x61, 0x73, 0x6B, 0x47, 0x61, 0x6D, 0x65, 0x43, 0x74, 0x72, 0x6C });
                if (pos != -1)
                {
                    pos += 16;
                    string currIP = FileHelper.ReadName(buff, pos);
                    MessageBox.Show("Current IP is: " + currIP);
                    string input = Microsoft.VisualBasic.Interaction.InputBox("Please enter new IP", "Patch IP", "192.168.178.");
                    if (input != "" && input.Length < 16)
                    {
                        byte[] patch = Encoding.ASCII.GetBytes(input);
                        for (int i = 0; i < patch.Length; i++)
                            buff[pos + i] = patch[i];
                        buff[pos + input.Length] = 0;
                        File.WriteAllBytes(d.FileName, buff);
                        MessageBox.Show("Done.");
                    }
                }
            }
        }

        private void removeImportCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] pat = new byte[] { 0x8A, 0x4C, 0x28, 0x5C, 0x8A, 0x54, 0x04, 0x70, 0x3A, 0xCA, 0x75, 0x42 };
            byte[] patch = new byte[] { 0x8A, 0x4C, 0x28, 0x5C, 0x8A, 0x54, 0x04, 0x70, 0x3A, 0xCA, 0x90, 0x90 };
            PatchThisWithThat(pat, patch);
        }

        private void removeMD5CheckallBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] pat = new byte[] { 0x8B, 0x4C, 0x24, 0x10, 0x8A, 0x14, 0x01, 0x8A, 0x4C, 0x04, 0x74, 0x3A, 0xD1, 0x75, 0x77 };
            byte[] patch = new byte[] { 0x8B, 0x4C, 0x24, 0x10, 0x8A, 0x14, 0x01, 0x8A, 0x4C, 0x04, 0x74, 0x3A, 0xD1, 0x90, 0x90 };
            PatchThisWithThat(pat, patch);
        }

        private void removeSavegameCheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] pat = new byte[] { 0x8D, 0x4C, 0x0A, 0x7D, 0x8A, 0x14, 0x01, 0x8A, 0x1C, 0x30, 0x3A, 0xD3, 0x75, 0x10 };
            byte[] patch = new byte[] { 0x8D, 0x4C, 0x0A, 0x7D, 0x8A, 0x14, 0x01, 0x8A, 0x1C, 0x30, 0x3A, 0xD3, 0x90, 0x90 };
            PatchThisWithThat(pat, patch);
        }

        public void PatchThisWithThat(byte[] pat, byte[] patch)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "*.exe|*.exe";
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                byte[] buff = File.ReadAllBytes(d.FileName);
                int pos = FileHelper.FindPattern(buff, pat);
                if (pos != -1)
                {
                    for (int i = 0; i < patch.Length; i++)
                        buff[pos + i] = patch[i];
                    File.WriteAllBytes(d.FileName, buff);
                    MessageBox.Show("Done.");
                }
                else
                    MessageBox.Show("Patch position not found, maybe already patched");
            }
        }
    }
}
