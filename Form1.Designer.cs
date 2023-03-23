namespace Calculadora_de_Equação_do_Segundo_Grau
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
            this.txtBoxA = new System.Windows.Forms.TextBox();
            this.lblX2 = new System.Windows.Forms.TextBox();
            this.txtBoxBe = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.TextBox();
            this.txtBoxC = new System.Windows.Forms.TextBox();
            this.lblEqualSign = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.grpBoxEqc = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtBoxRes = new System.Windows.Forms.TextBox();
            this.grpBoxEqc.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxA
            // 
            this.txtBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxA.Location = new System.Drawing.Point(24, 40);
            this.txtBoxA.Name = "txtBoxA";
            this.txtBoxA.Size = new System.Drawing.Size(70, 62);
            this.txtBoxA.TabIndex = 0;
            this.txtBoxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblX2
            // 
            this.lblX2.BackColor = System.Drawing.SystemColors.Menu;
            this.lblX2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX2.Location = new System.Drawing.Point(96, 48);
            this.lblX2.MaxLength = 1;
            this.lblX2.Name = "lblX2";
            this.lblX2.ReadOnly = true;
            this.lblX2.Size = new System.Drawing.Size(62, 55);
            this.lblX2.TabIndex = 1;
            this.lblX2.Text = "x²";
            // 
            // txtBoxBe
            // 
            this.txtBoxBe.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBe.Location = new System.Drawing.Point(168, 40);
            this.txtBoxBe.Name = "txtBoxBe";
            this.txtBoxBe.Size = new System.Drawing.Size(70, 62);
            this.txtBoxBe.TabIndex = 2;
            this.txtBoxBe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblX
            // 
            this.lblX.BackColor = System.Drawing.SystemColors.Menu;
            this.lblX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(240, 48);
            this.lblX.MaxLength = 1;
            this.lblX.Name = "lblX";
            this.lblX.ReadOnly = true;
            this.lblX.Size = new System.Drawing.Size(62, 55);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "x";
            // 
            // txtBoxC
            // 
            this.txtBoxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxC.Location = new System.Drawing.Point(312, 40);
            this.txtBoxC.Name = "txtBoxC";
            this.txtBoxC.Size = new System.Drawing.Size(70, 62);
            this.txtBoxC.TabIndex = 4;
            this.txtBoxC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEqualSign
            // 
            this.lblEqualSign.BackColor = System.Drawing.SystemColors.Menu;
            this.lblEqualSign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblEqualSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqualSign.Location = new System.Drawing.Point(400, 48);
            this.lblEqualSign.MaxLength = 1;
            this.lblEqualSign.Name = "lblEqualSign";
            this.lblEqualSign.ReadOnly = true;
            this.lblEqualSign.Size = new System.Drawing.Size(62, 55);
            this.lblEqualSign.TabIndex = 5;
            this.lblEqualSign.Text = "=";
            this.lblEqualSign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(480, 48);
            this.textBox7.MaxLength = 1;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(62, 55);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "0";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpBoxEqc
            // 
            this.grpBoxEqc.Controls.Add(this.txtBoxA);
            this.grpBoxEqc.Controls.Add(this.textBox7);
            this.grpBoxEqc.Controls.Add(this.lblX2);
            this.grpBoxEqc.Controls.Add(this.lblEqualSign);
            this.grpBoxEqc.Controls.Add(this.txtBoxBe);
            this.grpBoxEqc.Controls.Add(this.txtBoxC);
            this.grpBoxEqc.Controls.Add(this.lblX);
            this.grpBoxEqc.Location = new System.Drawing.Point(128, 96);
            this.grpBoxEqc.Name = "grpBoxEqc";
            this.grpBoxEqc.Size = new System.Drawing.Size(560, 128);
            this.grpBoxEqc.TabIndex = 7;
            this.grpBoxEqc.TabStop = false;
            this.grpBoxEqc.Text = "Equação";
            // 
            // btnCalcular
            // 
            this.btnCalcular.AutoSize = true;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(336, 272);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(128, 40);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtBoxRes
            // 
            this.txtBoxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRes.Location = new System.Drawing.Point(112, 352);
            this.txtBoxRes.Name = "txtBoxRes";
            this.txtBoxRes.Size = new System.Drawing.Size(576, 49);
            this.txtBoxRes.TabIndex = 8;
            this.txtBoxRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtBoxRes);
            this.Controls.Add(this.grpBoxEqc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBoxEqc.ResumeLayout(false);
            this.grpBoxEqc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxA;
        private System.Windows.Forms.TextBox lblX2;
        private System.Windows.Forms.TextBox txtBoxBe;
        private System.Windows.Forms.TextBox lblX;
        private System.Windows.Forms.TextBox txtBoxC;
        private System.Windows.Forms.TextBox lblEqualSign;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.GroupBox grpBoxEqc;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtBoxRes;
    }
}

