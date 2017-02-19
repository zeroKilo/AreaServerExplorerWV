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
        public string filename; 
        public byte[] filebuff;
        public List<FileEntry> files;


        public PACKEditor()
        {
            InitializeComponent();
        }

        private void PACKEditor_Load(object sender, EventArgs e)
        {
            LoadStuff();
            RefreshList();
        }

        public void LoadStuff()
        {
            filebuff = FileHelper.DecryptFile(filename);
            files = FileHelper.ReadFileInfos(filebuff);
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

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                return;
            string subname = listBox1.SelectedItem.ToString();
            string ext = "*" + Path.GetExtension(subname);
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = ext + "|" + ext;
            d.FileName = subname;
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filebuff = FileHelper.ImportIntoPack(filebuff, subname, d.FileName);
                files = FileHelper.ReadFileInfos(filebuff);
                RefreshList();
                MessageBox.Show("Done.");
            }
        }

        private void saveToPACKBINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileHelper.EncryptFile(filebuff, filename);
            MessageBox.Show("Done.");
        }
    }
}
