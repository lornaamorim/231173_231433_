using System;
using System.Windows.Forms;
using _231173_231433_.Views;

namespace _231173_231433_
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void cIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCidades form = new FrmCidades();
            form.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            Banco.CriarBanco();
        }
    }
}
