using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gabarito_CCV
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            lbVersion.Text = "Gabarito CCV " + Geral.versao;
        }

        private void btDefinir_Click(object sender, EventArgs e)
        {
            FormGabarito gabarito = new FormGabarito();
            this.Hide();
            gabarito.ShowDialog();
            this.Show();
        }

        private void btPreencher_Click(object sender, EventArgs e)
        {
            FormPreencher gabarito = new FormPreencher();
            this.Hide();
            gabarito.ShowDialog();
            this.Show();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if (!(Geral.gabarito_preenchido && Geral.resposta_preenchido))
            {
                System.Windows.Forms.MessageBox.Show("Você precisa definir os gabaritos!", "ERRO!",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }

            FormPontos pontos = new FormPontos();
            this.Hide();
            pontos.ShowDialog();
            this.Show();
        }

        private void btCreditos_Click(object sender, EventArgs e)
        {
            FormSobre sobre = new FormSobre();
            this.Hide();
            sobre.ShowDialog();
            this.Show();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja encerrar o programa?", "Sair",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Application.Exit();
        }

    }
}
