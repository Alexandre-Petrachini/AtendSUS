namespace FilaEspera
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.ChamarSenha = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.Senhas = new System.Windows.Forms.ListBox();
            this.lbTexto = new System.Windows.Forms.Label();
            this.Paciente = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Senha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChamarSenha
            // 
            this.ChamarSenha.Location = new System.Drawing.Point(694, 35);
            this.ChamarSenha.Name = "ChamarSenha";
            this.ChamarSenha.Size = new System.Drawing.Size(90, 23);
            this.ChamarSenha.TabIndex = 1;
            this.ChamarSenha.Text = "Chamar Senha";
            this.ChamarSenha.UseVisualStyleBackColor = true;
            this.ChamarSenha.Click += new System.EventHandler(this.btnChamarSenha_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(12, 357);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(128, 96);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSenha.Visible = false;
            // 
            // Senhas
            // 
            this.Senhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senhas.FormattingEnabled = true;
            this.Senhas.ItemHeight = 24;
            this.Senhas.Location = new System.Drawing.Point(694, 81);
            this.Senhas.Name = "Senhas";
            this.Senhas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Senhas.Size = new System.Drawing.Size(86, 196);
            this.Senhas.TabIndex = 6;
            // 
            // lbTexto
            // 
            this.lbTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTexto.Location = new System.Drawing.Point(100, 246);
            this.lbTexto.Name = "lbTexto";
            this.lbTexto.Size = new System.Drawing.Size(512, 82);
            this.lbTexto.TabIndex = 5;
            this.lbTexto.Text = "Favor dirigir-se à consulta";
            this.lbTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Paciente
            // 
            this.Paciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paciente.ForeColor = System.Drawing.Color.Gold;
            this.Paciente.Location = new System.Drawing.Point(546, 554);
            this.Paciente.Name = "Paciente";
            this.Paciente.Size = new System.Drawing.Size(251, 48);
            this.Paciente.TabIndex = 7;
            this.Paciente.Text = "Data";
            this.Paciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHora
            // 
            this.lbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.ForeColor = System.Drawing.Color.Chocolate;
            this.lbHora.Location = new System.Drawing.Point(4, 542);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(212, 66);
            this.lbHora.TabIndex = 8;
            this.lbHora.Text = "Horario";
            this.lbHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FilaEspera.Properties.Resources.sus11;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.Location = new System.Drawing.Point(307, 328);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(0, 55);
            this.Senha.TabIndex = 9;
            this.Senha.Click += new System.EventHandler(this.Senha_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(809, 611);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.lbTexto);
            this.Controls.Add(this.lbHora);
            this.Controls.Add(this.Paciente);
            this.Controls.Add(this.Senhas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ChamarSenha);
            this.Controls.Add(this.lblSenha);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Senhas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.Resize += new System.EventHandler(this.Form1_Resize_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ChamarSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox Senhas;
        private System.Windows.Forms.Label lbTexto;
        private System.Windows.Forms.Label Paciente;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Senha;
    }
}

