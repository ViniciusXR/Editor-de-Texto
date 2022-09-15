namespace Editor_de_Texto
{
    partial class FormSobrePC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSobrePC));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProcessador = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblOSVer = new System.Windows.Forms.Label();
            this.lblNomePC = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProcessador);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.lblOSVer);
            this.groupBox1.Controls.Add(this.lblNomePC);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações sobre o PC";
            // 
            // lblProcessador
            // 
            this.lblProcessador.AutoSize = true;
            this.lblProcessador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProcessador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProcessador.Location = new System.Drawing.Point(0, 169);
            this.lblProcessador.Name = "lblProcessador";
            this.lblProcessador.Size = new System.Drawing.Size(246, 30);
            this.lblProcessador.TabIndex = 5;
            this.lblProcessador.Text = "Número de Processadores:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.Location = new System.Drawing.Point(0, 242);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(173, 30);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Nome do Usuário:";
            // 
            // lblOSVer
            // 
            this.lblOSVer.AutoSize = true;
            this.lblOSVer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOSVer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOSVer.Location = new System.Drawing.Point(0, 96);
            this.lblOSVer.Name = "lblOSVer";
            this.lblOSVer.Size = new System.Drawing.Size(136, 30);
            this.lblOSVer.TabIndex = 2;
            this.lblOSVer.Text = "Versão do SO:";
            // 
            // lblNomePC
            // 
            this.lblNomePC.AutoSize = true;
            this.lblNomePC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomePC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNomePC.Location = new System.Drawing.Point(0, 23);
            this.lblNomePC.Name = "lblNomePC";
            this.lblNomePC.Size = new System.Drawing.Size(129, 30);
            this.lblNomePC.TabIndex = 0;
            this.lblNomePC.Text = "Nome do PC:";
            // 
            // FormSobrePC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSobrePC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SobrePC";
            this.Load += new System.EventHandler(this.FormSobrePC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label lblNomePC;
        private Label lblOSVer;
        private Label lblUser;
        private Label lblProcessador;
    }
}