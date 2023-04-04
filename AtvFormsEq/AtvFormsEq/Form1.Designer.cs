namespace ProjFormsAula03_04_23
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
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblX1 = new System.Windows.Forms.Label();
            this.lblDelta = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(43, 34);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(63, 31);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(63, 155);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(63, 68);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 4;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(43, 71);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(14, 13);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "B";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(63, 106);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 6;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(43, 109);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(14, 13);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "C";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblX2);
            this.groupBox1.Controls.Add(this.lblX1);
            this.groupBox1.Controls.Add(this.lblDelta);
            this.groupBox1.Location = new System.Drawing.Point(12, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 95);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(10, 79);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(29, 13);
            this.lblX2.TabIndex = 2;
            this.lblX2.Text = "X2 =";
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(10, 45);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(32, 13);
            this.lblX1.TabIndex = 1;
            this.lblX1.Text = "X1 = ";
            // 
            // lblDelta
            // 
            this.lblDelta.AutoSize = true;
            this.lblDelta.Location = new System.Drawing.Point(10, 16);
            this.lblDelta.Name = "lblDelta";
            this.lblDelta.Size = new System.Drawing.Size(54, 13);
            this.lblDelta.TabIndex = 0;
            this.lblDelta.Text = "DELTA = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 291);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblA);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.Label lblDelta;
    }
}

