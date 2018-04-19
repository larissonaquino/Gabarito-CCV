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
    public partial class FormPreencher : Form
    {
        public FormPreencher()
        {
            InitializeComponent();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            Geral.dicionario_resposta = new Dictionary<int, string>();
            Geral.resposta_preenchido = false;

            bool valido = true;

            if (!comboBox1.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(1);
                Geral.dicionario_resposta.Add(1, comboBox1.Text);
            }
            else valido = false;

            if (!comboBox2.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(2);
                Geral.dicionario_resposta.Add(2, comboBox2.Text);
            }
            else valido = false;

            if (!comboBox3.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(3);
                Geral.dicionario_resposta.Add(3, comboBox3.Text);
            }
            else valido = false;

            if (!comboBox4.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(4);
                Geral.dicionario_resposta.Add(4, comboBox4.Text);
            }
            else valido = false;

            if (!comboBox5.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(5);
                Geral.dicionario_resposta.Add(5, comboBox5.Text);
            }
            else valido = false;

            if (!comboBox6.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(6);
                Geral.dicionario_resposta.Add(6, comboBox6.Text);
            }
            else valido = false;

            if (!comboBox7.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(7);
                Geral.dicionario_resposta.Add(7, comboBox7.Text);
            }
            else valido = false;

            if (!comboBox8.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(8);
                Geral.dicionario_resposta.Add(8, comboBox8.Text);
            }
            else valido = false;

            if (!comboBox9.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(9);
                Geral.dicionario_resposta.Add(9, comboBox9.Text);
            }
            else valido = false;

            if (!comboBox10.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(10);
                Geral.dicionario_resposta.Add(10, comboBox10.Text);
            }
            else valido = false;

            if (!comboBox11.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(11);
                Geral.dicionario_resposta.Add(11, comboBox11.Text);
            }
            else valido = false;

            if (!comboBox12.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(12);
                Geral.dicionario_resposta.Add(12, comboBox12.Text);
            }
            else valido = false;

            if (!comboBox13.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(13);
                Geral.dicionario_resposta.Add(13, comboBox13.Text);
            }
            else valido = false;

            if (!comboBox14.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(14);
                Geral.dicionario_resposta.Add(14, comboBox14.Text);
            }
            else valido = false;

            if (!comboBox15.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(15);
                Geral.dicionario_resposta.Add(15, comboBox15.Text);
            }
            else valido = false;

            if (!comboBox16.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(16);
                Geral.dicionario_resposta.Add(16, comboBox16.Text);
            }
            else valido = false;

            if (!comboBox17.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(17);
                Geral.dicionario_resposta.Add(17, comboBox17.Text);
            }
            else valido = false;

            if (!comboBox18.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(18);
                Geral.dicionario_resposta.Add(18, comboBox18.Text);
            }
            else valido = false;

            if (!comboBox19.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(19);
                Geral.dicionario_resposta.Add(19, comboBox19.Text);
            }
            else valido = false;

            if (!comboBox20.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(20);
                Geral.dicionario_resposta.Add(20, comboBox20.Text);
            }
            else valido = false;

            if (!comboBox21.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(21);
                Geral.dicionario_resposta.Add(21, comboBox21.Text);
            }
            else valido = false;

            if (!comboBox22.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(22);
                Geral.dicionario_resposta.Add(22, comboBox22.Text);
            }
            else valido = false;

            if (!comboBox23.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(23);
                Geral.dicionario_resposta.Add(23, comboBox23.Text);
            }
            else valido = false;

            if (!comboBox24.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(24);
                Geral.dicionario_resposta.Add(24, comboBox24.Text);
            }
            else valido = false;

            if (!comboBox25.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(25);
                Geral.dicionario_resposta.Add(25, comboBox25.Text);
            }
            else valido = false;

            if (!comboBox26.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(26);
                Geral.dicionario_resposta.Add(26, comboBox26.Text);
            }
            else valido = false;

            if (!comboBox27.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(27);
                Geral.dicionario_resposta.Add(27, comboBox27.Text);
            }
            else valido = false;

            if (!comboBox28.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(28);
                Geral.dicionario_resposta.Add(28, comboBox28.Text);
            }
            else valido = false;

            if (!comboBox29.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(29);
                Geral.dicionario_resposta.Add(29, comboBox29.Text);
            }
            else valido = false;

            if (!comboBox30.Text.Equals(""))
            {
                Geral.dicionario_resposta.Remove(30);
                Geral.dicionario_resposta.Add(30, comboBox30.Text);
            }
            else valido = false;

            if (!valido)
            {
                MessageBox.Show("Preencha todas as questões!", "ERRO!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            Geral.resposta_preenchido = true;

            MessageBox.Show("Gabarito definido com sucesso!", "Gabarito", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }
}
