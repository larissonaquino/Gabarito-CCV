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
    public partial class FormPontos : Form
    {
        public FormPontos()
        {
            InitializeComponent();
        }

        private void FormPontos_Load(object sender, EventArgs e)
        {
            lbPontuacao.Text = "Pontuação: " + Geral.CalcularPontos();
            lbErradas.Text = "Erradas: " + Geral.getErradas();
            addListBox();
        }
        
        private void addListBox()
        {
            for (int i = 0; i < Geral.lista_dicionario.Count; i++)
                listBox.Items.Add(Geral.lista_dicionario[i]);
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
