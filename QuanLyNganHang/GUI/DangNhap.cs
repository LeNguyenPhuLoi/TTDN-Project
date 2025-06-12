using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#DED4CA");
            pnlLogo.BackColor = ColorTranslator.FromHtml("#000000");

            label1.ForeColor = ColorTranslator.FromHtml("#52362A");
            label2.ForeColor = ColorTranslator.FromHtml("#52362A");
            label3.ForeColor = ColorTranslator.FromHtml("#52362A");

            btnLogin.BackColor = ColorTranslator.FromHtml("#52362A");
            btnLogin.ForeColor = ColorTranslator.FromHtml("#DED4CA");
            btnThoat.BackColor = ColorTranslator.FromHtml("#DED4CA");
            btnThoat.ForeColor = ColorTranslator.FromHtml("#AF262E");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
