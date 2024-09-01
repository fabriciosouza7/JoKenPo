namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtPedra = new System.Windows.Forms.Button();
            this.BtPapel = new System.Windows.Forms.Button();
            this.BtTesoura = new System.Windows.Forms.Button();
            this.PicJogador = new System.Windows.Forms.PictureBox();
            this.PIcComputador = new System.Windows.Forms.PictureBox();
            this.LbDesJogador = new System.Windows.Forms.Label();
            this.LbDesComputador = new System.Windows.Forms.Label();
            this.LbPtJogador = new System.Windows.Forms.Label();
            this.LbPtComputador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbEmpate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIcComputador)).BeginInit();
            this.SuspendLayout();
            // 
            // BtPedra
            // 
            this.BtPedra.BackColor = System.Drawing.Color.White;
            this.BtPedra.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.jo;
            this.BtPedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtPedra.Location = new System.Drawing.Point(31, 266);
            this.BtPedra.Name = "BtPedra";
            this.BtPedra.Size = new System.Drawing.Size(166, 130);
            this.BtPedra.TabIndex = 0;
            this.BtPedra.Tag = "0";
            this.BtPedra.UseVisualStyleBackColor = false;
            this.BtPedra.Click += new System.EventHandler(this.ClickJogada);
            // 
            // BtPapel
            // 
            this.BtPapel.BackColor = System.Drawing.Color.White;
            this.BtPapel.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.ken;
            this.BtPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtPapel.Location = new System.Drawing.Point(204, 266);
            this.BtPapel.Name = "BtPapel";
            this.BtPapel.Size = new System.Drawing.Size(166, 130);
            this.BtPapel.TabIndex = 1;
            this.BtPapel.Tag = "1";
            this.BtPapel.UseVisualStyleBackColor = false;
            this.BtPapel.Click += new System.EventHandler(this.ClickJogada);
            // 
            // BtTesoura
            // 
            this.BtTesoura.BackColor = System.Drawing.Color.White;
            this.BtTesoura.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.po;
            this.BtTesoura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtTesoura.Location = new System.Drawing.Point(376, 266);
            this.BtTesoura.Name = "BtTesoura";
            this.BtTesoura.Size = new System.Drawing.Size(166, 130);
            this.BtTesoura.TabIndex = 2;
            this.BtTesoura.Tag = "2";
            this.BtTesoura.UseVisualStyleBackColor = false;
            this.BtTesoura.Click += new System.EventHandler(this.ClickJogada);
            // 
            // PicJogador
            // 
            this.PicJogador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicJogador.Location = new System.Drawing.Point(12, 54);
            this.PicJogador.Name = "PicJogador";
            this.PicJogador.Size = new System.Drawing.Size(150, 150);
            this.PicJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicJogador.TabIndex = 3;
            this.PicJogador.TabStop = false;
            // 
            // PIcComputador
            // 
            this.PIcComputador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PIcComputador.Location = new System.Drawing.Point(416, 54);
            this.PIcComputador.Name = "PIcComputador";
            this.PIcComputador.Size = new System.Drawing.Size(150, 150);
            this.PIcComputador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIcComputador.TabIndex = 4;
            this.PIcComputador.TabStop = false;
            // 
            // LbDesJogador
            // 
            this.LbDesJogador.AutoSize = true;
            this.LbDesJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDesJogador.Location = new System.Drawing.Point(168, 89);
            this.LbDesJogador.Name = "LbDesJogador";
            this.LbDesJogador.Size = new System.Drawing.Size(84, 25);
            this.LbDesJogador.TabIndex = 5;
            this.LbDesJogador.Text = "Jogador";
            // 
            // LbDesComputador
            // 
            this.LbDesComputador.AutoSize = true;
            this.LbDesComputador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDesComputador.Location = new System.Drawing.Point(281, 89);
            this.LbDesComputador.Name = "LbDesComputador";
            this.LbDesComputador.Size = new System.Drawing.Size(120, 25);
            this.LbDesComputador.TabIndex = 6;
            this.LbDesComputador.Text = "Computador";
            // 
            // LbPtJogador
            // 
            this.LbPtJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPtJogador.Location = new System.Drawing.Point(187, 136);
            this.LbPtJogador.Name = "LbPtJogador";
            this.LbPtJogador.Size = new System.Drawing.Size(40, 20);
            this.LbPtJogador.TabIndex = 7;
            this.LbPtJogador.Text = "0";
            this.LbPtJogador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbPtComputador
            // 
            this.LbPtComputador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPtComputador.Location = new System.Drawing.Point(344, 136);
            this.LbPtComputador.Name = "LbPtComputador";
            this.LbPtComputador.Size = new System.Drawing.Size(40, 20);
            this.LbPtComputador.TabIndex = 8;
            this.LbPtComputador.Text = "0";
            this.LbPtComputador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pedra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Papel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(411, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tesoura";
            // 
            // LbEmpate
            // 
            this.LbEmpate.AutoSize = true;
            this.LbEmpate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmpate.Location = new System.Drawing.Point(299, 18);
            this.LbEmpate.Name = "LbEmpate";
            this.LbEmpate.Size = new System.Drawing.Size(23, 25);
            this.LbEmpate.TabIndex = 13;
            this.LbEmpate.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Empates";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(578, 469);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LbEmpate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbPtComputador);
            this.Controls.Add(this.LbPtJogador);
            this.Controls.Add(this.LbDesComputador);
            this.Controls.Add(this.LbDesJogador);
            this.Controls.Add(this.PIcComputador);
            this.Controls.Add(this.PicJogador);
            this.Controls.Add(this.BtTesoura);
            this.Controls.Add(this.BtPapel);
            this.Controls.Add(this.BtPedra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jokenpo";
            ((System.ComponentModel.ISupportInitialize)(this.PicJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIcComputador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtPedra;
        private System.Windows.Forms.Button BtPapel;
        private System.Windows.Forms.Button BtTesoura;
        private System.Windows.Forms.PictureBox PicJogador;
        private System.Windows.Forms.PictureBox PIcComputador;
        private System.Windows.Forms.Label LbDesJogador;
        private System.Windows.Forms.Label LbDesComputador;
        private System.Windows.Forms.Label LbPtJogador;
        private System.Windows.Forms.Label LbPtComputador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbEmpate;
        private System.Windows.Forms.Label label5;
    }
}

