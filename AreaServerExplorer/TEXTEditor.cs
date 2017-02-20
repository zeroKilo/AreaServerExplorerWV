using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaServerExplorer
{
    public partial class TEXTEditor : Form
    {
        public string filename;
        public byte[] filebuff;
        public List<byte[]> entries;
        public Encoding encoder = Encoding.GetEncoding(932);

        public TEXTEditor()
        {
            InitializeComponent();
        }

        private void TEXTEditor_Load(object sender, EventArgs e)
        {
            filebuff = FileHelper.DecryptFile(filename);
            Reload();
            RefreshList();
        }

        public void Reload()
        {
            entries = FileHelper.ReadTEXTFile(filebuff);            
        }

        public void RefreshList()
        {
            listBox1.Items.Clear();
            foreach (byte[] entry in entries)
                listBox1.Items.Add(encoder.GetString(entry));
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int n = listBox1.SelectedIndex;
            if (n == -1)
                return;
            InputForm f = new InputForm();
            f.result = entries[n];
            f.ShowDialog();
            if(f._exitOK)
            {
                entries[n] = f.result;
                filebuff = FileHelper.CompileTEXTEntries(entries);
                Reload();
                RefreshList();
                listBox1.SelectedIndex = n;
            }
        }

        private void saveExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileHelper.EncryptFile(FileHelper.CompileTEXTEntries(entries), filename);
            this.Close();
        }
    }
}
