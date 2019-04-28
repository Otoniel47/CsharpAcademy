using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkVisualizarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVisualizarSenha.Enabled == true && txbSsenha.PasswordChar == '*')
                 txbSsenha.PasswordChar = '\0';
            else if (txbSsenha.Text != "Senha")
                 txbSsenha.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txbEmail_Enter(object sender, EventArgs e)
        {
            if (txbEmail.Text == "Nome")
            {
                txbEmail.Text = string.Empty;
                txbEmail.ForeColor = Color.Black;
            }
        }

        private void txbEmail_Leave(object sender, EventArgs e)
        {
            if (txbEmail.Text == string.Empty)
            {
                txbEmail.Text = "Nome";
                txbEmail.ForeColor = Color.Silver;
            }
        }

        private void txbSsenha_Enter(object sender, EventArgs e)
        {
            if (txbSsenha.Text == "Senha")
            {
                txbSsenha.Text = string.Empty;
                txbSsenha.ForeColor = Color.Black;
                txbSsenha.PasswordChar = '*';
            }
        }

        private void txbSsenha_Leave(object sender, EventArgs e)
        {
            if (txbSsenha.Text == string.Empty)
            {
                txbSsenha.Text = "Senha";
                txbSsenha.ForeColor = Color.Silver;
                txbSsenha.PasswordChar = '\0';
            }

        }

        //Inicio dos Eventos do botão fechar
        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.Red;
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.Transparent;
        }

        private void btnFechar_MouseDown(object sender, MouseEventArgs e)
        {
            btnFechar.BackColor = Color.Salmon;
        }
        //Fim dos Eventos do botão fechar

        //Inicio dos Eventos do botão minimizar
        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.Silver;
        }
      
        private void btnMinimizar_MouseDown(object sender, MouseEventArgs e)
        {
            btnMinimizar.BackColor = Color.LightGray;
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.Transparent;
        }
        //Fim dos Eventos do Botão minimizar
    }
}
