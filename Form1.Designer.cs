namespace solucionTaller2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDueño = new System.Windows.Forms.TextBox();
            this.TxtInquilino = new System.Windows.Forms.TextBox();
            this.TxtAdultos = new System.Windows.Forms.TextBox();
            this.TxtNiños = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblTotalPagar2 = new System.Windows.Forms.Label();
            this.CbxNumApt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "N° APT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "DUEÑO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "INQUILINO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "ADULTOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "NIÑOS";
            // 
            // TxtDueño
            // 
            this.TxtDueño.Location = new System.Drawing.Point(66, 59);
            this.TxtDueño.Name = "TxtDueño";
            this.TxtDueño.Size = new System.Drawing.Size(92, 23);
            this.TxtDueño.TabIndex = 7;
            // 
            // TxtInquilino
            // 
            this.TxtInquilino.Location = new System.Drawing.Point(155, 59);
            this.TxtInquilino.Name = "TxtInquilino";
            this.TxtInquilino.Size = new System.Drawing.Size(123, 23);
            this.TxtInquilino.TabIndex = 8;
            // 
            // TxtAdultos
            // 
            this.TxtAdultos.Location = new System.Drawing.Point(278, 59);
            this.TxtAdultos.Name = "TxtAdultos";
            this.TxtAdultos.Size = new System.Drawing.Size(74, 23);
            this.TxtAdultos.TabIndex = 9;
            // 
            // TxtNiños
            // 
            this.TxtNiños.Location = new System.Drawing.Point(349, 59);
            this.TxtNiños.Name = "TxtNiños";
            this.TxtNiños.Size = new System.Drawing.Size(56, 23);
            this.TxtNiños.TabIndex = 10;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCalcular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCalcular.Location = new System.Drawing.Point(19, 88);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(386, 38);
            this.BtnCalcular.TabIndex = 11;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTotal.Location = new System.Drawing.Point(19, 130);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(105, 18);
            this.LblTotal.TabIndex = 13;
            this.LblTotal.Text = "Total Pagar:";
            // 
            // LblTotalPagar2
            // 
            this.LblTotalPagar2.AutoSize = true;
            this.LblTotalPagar2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTotalPagar2.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTotalPagar2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblTotalPagar2.Location = new System.Drawing.Point(130, 130);
            this.LblTotalPagar2.Name = "LblTotalPagar2";
            this.LblTotalPagar2.Size = new System.Drawing.Size(25, 27);
            this.LblTotalPagar2.TabIndex = 14;
            this.LblTotalPagar2.Text = "$\r\n";
            // 
            // CbxNumApt
            // 
            this.CbxNumApt.FormattingEnabled = true;
            this.CbxNumApt.Items.AddRange(new object[] {
            "102",
            "103",
            "202",
            "203",
            "302",
            "303",
            "401",
            "402",
            "403",
            "501",
            "502"});
            this.CbxNumApt.Location = new System.Drawing.Point(19, 59);
            this.CbxNumApt.Name = "CbxNumApt";
            this.CbxNumApt.Size = new System.Drawing.Size(49, 23);
            this.CbxNumApt.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 396);
            this.Controls.Add(this.CbxNumApt);
            this.Controls.Add(this.LblTotalPagar2);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtNiños);
            this.Controls.Add(this.TxtAdultos);
            this.Controls.Add(this.TxtInquilino);
            this.Controls.Add(this.TxtDueño);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Condominio la 8 vencidad";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TxtDueño;
        private TextBox TxtInquilino;
        private TextBox TxtAdultos;
        private TextBox TxtNiños;
        private Button BtnCalcular;
        private Label LblTotal;
        private Label LblTotalPagar2;
        private ComboBox CbxNumApt;
    }
}