namespace Gabarito_CCV
{
    partial class FormPontos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPontos));
            this.lbPontuacao = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.lbErradas = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPontuacao
            // 
            resources.ApplyResources(this.lbPontuacao, "lbPontuacao");
            this.lbPontuacao.Name = "lbPontuacao";
            // 
            // listBox
            // 
            resources.ApplyResources(this.listBox, "listBox");
            this.listBox.FormattingEnabled = true;
            this.listBox.Name = "listBox";
            // 
            // lbErradas
            // 
            resources.ApplyResources(this.lbErradas, "lbErradas");
            this.lbErradas.Name = "lbErradas";
            // 
            // lbTitulo
            // 
            resources.ApplyResources(this.lbTitulo, "lbTitulo");
            this.lbTitulo.Name = "lbTitulo";
            // 
            // btVoltar
            // 
            resources.ApplyResources(this.btVoltar, "btVoltar");
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // FormPontos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.lbErradas);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.lbPontuacao);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPontos";
            this.Load += new System.EventHandler(this.FormPontos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPontuacao;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label lbErradas;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btVoltar;
    }
}