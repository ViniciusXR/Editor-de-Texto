using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_de_Texto
{
    public partial class FormSobrePC : Form
    {
        public FormSobrePC()
        {
            InitializeComponent();
            
        }

        private void FormSobrePC_Load(object sender, EventArgs e)
        {
            lblNomePC.Text += " " + Environment.MachineName;
            lblOSVer.Text += " " + Environment.OSVersion.ToString();
            lblUser.Text += " " + Environment.UserName;
            lblProcessador.Text += " " + Environment.ProcessorCount;
        }
    }
}
