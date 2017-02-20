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
    public partial class InputForm : Form
    {
        public Encoding encoder = Encoding.GetEncoding(932);
        public bool _exitOK = false;
        public byte[] result;

        public InputForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result = encoder.GetBytes(rtb1.Text);
            _exitOK = true;
            this.Close();
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            rtb1.Text = encoder.GetString(result);
        }
    }
}
