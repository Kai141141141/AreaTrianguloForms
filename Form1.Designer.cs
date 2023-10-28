namespace AreaTrianguloForms
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
            this.txb1 = new System.Windows.Forms.NumericUpDown();
            this.txb2 = new System.Windows.Forms.NumericUpDown();
            this.bnt1 = new System.Windows.Forms.Button();
            this.txbBase = new System.Windows.Forms.Label();
            this.txbAltura = new System.Windows.Forms.Label();
            this.txbRes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb2)).BeginInit();
            this.SuspendLayout();
            // 
            // txb1
            // 
            this.txb1.ForeColor = System.Drawing.Color.Black;
            this.txb1.Location = new System.Drawing.Point(58, 48);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(101, 20);
            this.txb1.TabIndex = 2;
            this.txb1.ValueChanged += new System.EventHandler(this.txb1_ValueChanged);
            // 
            // txb2
            // 
            this.txb2.ForeColor = System.Drawing.Color.Black;
            this.txb2.Location = new System.Drawing.Point(58, 95);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(101, 20);
            this.txb2.TabIndex = 3;
            // 
            // bnt1
            // 
            this.bnt1.ForeColor = System.Drawing.Color.Black;
            this.bnt1.Location = new System.Drawing.Point(48, 158);
            this.bnt1.Name = "bnt1";
            this.bnt1.Size = new System.Drawing.Size(111, 30);
            this.bnt1.TabIndex = 4;
            this.bnt1.Text = "CALCULAR";
            this.bnt1.UseVisualStyleBackColor = true;
            this.bnt1.Click += new System.EventHandler(this.bnt1_Click);
            // 
            // txbBase
            // 
            this.txbBase.AutoSize = true;
            this.txbBase.BackColor = System.Drawing.SystemColors.Control;
            this.txbBase.ForeColor = System.Drawing.Color.Black;
            this.txbBase.Location = new System.Drawing.Point(12, 50);
            this.txbBase.Name = "txbBase";
            this.txbBase.Size = new System.Drawing.Size(34, 13);
            this.txbBase.TabIndex = 5;
            this.txbBase.Text = "Base:";
            this.txbBase.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbAltura
            // 
            this.txbAltura.AutoSize = true;
            this.txbAltura.BackColor = System.Drawing.SystemColors.Control;
            this.txbAltura.ForeColor = System.Drawing.Color.Black;
            this.txbAltura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txbAltura.Location = new System.Drawing.Point(12, 95);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(37, 13);
            this.txbAltura.TabIndex = 6;
            this.txbAltura.Text = "Altura:";
            this.txbAltura.Click += new System.EventHandler(this.txbAltura_Click);
            // 
            // txbRes
            // 
            this.txbRes.Enabled = false;
            this.txbRes.ForeColor = System.Drawing.Color.Black;
            this.txbRes.Location = new System.Drawing.Point(48, 212);
            this.txbRes.Name = "txbRes";
            this.txbRes.Size = new System.Drawing.Size(111, 20);
            this.txbRes.TabIndex = 7;
            this.txbRes.EnabledChanged += new System.EventHandler(this.txbRes_EnabledChanged);
            this.txbRes.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.BackgroundImage = global::AreaTrianguloForms.Properties.Resources.download2;
            this.ClientSize = new System.Drawing.Size(206, 308);
            this.Controls.Add(this.txbRes);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.txbBase);
            this.Controls.Add(this.bnt1);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.txb1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txb1;
        private System.Windows.Forms.NumericUpDown txb2;
        private System.Windows.Forms.Button bnt1;
        private System.Windows.Forms.Label txbBase;
        private System.Windows.Forms.Label txbAltura;
        private System.Windows.Forms.TextBox txbRes;
    }
}

