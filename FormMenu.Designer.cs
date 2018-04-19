namespace Gabarito_CCV
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.btDefinir = new System.Windows.Forms.Button();
            this.btPreencher = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.lbVersion = new System.Windows.Forms.Label();
            this.btCreditos = new System.Windows.Forms.Button();
            this.btCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btDefinir
            // 
            this.btDefinir.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btDefinir, "btDefinir");
            this.btDefinir.Name = "btDefinir";
            this.btDefinir.UseVisualStyleBackColor = false;
            this.btDefinir.Click += new System.EventHandler(this.btDefinir_Click);
            // 
            // btPreencher
            // 
            resources.ApplyResources(this.btPreencher, "btPreencher");
            this.btPreencher.Name = "btPreencher";
            this.btPreencher.UseVisualStyleBackColor = true;
            this.btPreencher.Click += new System.EventHandler(this.btPreencher_Click);
            // 
            // btSair
            // 
            resources.ApplyResources(this.btSair, "btSair");
            this.btSair.Name = "btSair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // lbVersion
            // 
            resources.ApplyResources(this.lbVersion, "lbVersion");
            this.lbVersion.Name = "lbVersion";
            // 
            // btCreditos
            // 
            resources.ApplyResources(this.btCreditos, "btCreditos");
            this.btCreditos.Name = "btCreditos";
            this.btCreditos.UseVisualStyleBackColor = true;
            this.btCreditos.Click += new System.EventHandler(this.btCreditos_Click);
            // 
            // btCalcular
            // 
            resources.ApplyResources(this.btCalcular, "btCalcular");
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // FormMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.btCreditos);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btPreencher);
            this.Controls.Add(this.btDefinir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDefinir;
        private System.Windows.Forms.Button btPreencher;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Button btCreditos;
        private System.Windows.Forms.Button btCalcular;
    }
}