namespace Oefening3
{
    partial class formCurrencyConvertor
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
            this.lblFrank = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblRupees = new System.Windows.Forms.Label();
            this.lblYen = new System.Windows.Forms.Label();
            this.lblPound = new System.Windows.Forms.Label();
            this.lblUSD = new System.Windows.Forms.Label();
            this.tbFrank = new System.Windows.Forms.TextBox();
            this.tbRupees = new System.Windows.Forms.TextBox();
            this.tbYen = new System.Windows.Forms.TextBox();
            this.tbEuro = new System.Windows.Forms.TextBox();
            this.tbPound = new System.Windows.Forms.TextBox();
            this.tbUSD = new System.Windows.Forms.TextBox();
            this.btnConverteer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFrank
            // 
            this.lblFrank.AutoSize = true;
            this.lblFrank.Location = new System.Drawing.Point(499, 187);
            this.lblFrank.Name = "lblFrank";
            this.lblFrank.Size = new System.Drawing.Size(116, 16);
            this.lblFrank.TabIndex = 25;
            this.lblFrank.Text = "Zwitserse Franken";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(431, 81);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(35, 16);
            this.lblEuro.TabIndex = 24;
            this.lblEuro.Text = "Euro";
            // 
            // lblRupees
            // 
            this.lblRupees.AutoSize = true;
            this.lblRupees.Location = new System.Drawing.Point(331, 187);
            this.lblRupees.Name = "lblRupees";
            this.lblRupees.Size = new System.Drawing.Size(110, 16);
            this.lblRupees.TabIndex = 23;
            this.lblRupees.Text = "Indiaase Rupees";
            // 
            // lblYen
            // 
            this.lblYen.AutoSize = true;
            this.lblYen.Location = new System.Drawing.Point(171, 187);
            this.lblYen.Name = "lblYen";
            this.lblYen.Size = new System.Drawing.Size(95, 16);
            this.lblYen.TabIndex = 22;
            this.lblYen.Text = "Japanese Yen";
            // 
            // lblPound
            // 
            this.lblPound.AutoSize = true;
            this.lblPound.Location = new System.Drawing.Point(242, 81);
            this.lblPound.Name = "lblPound";
            this.lblPound.Size = new System.Drawing.Size(92, 16);
            this.lblPound.TabIndex = 21;
            this.lblPound.Text = "British Pounds";
            // 
            // lblUSD
            // 
            this.lblUSD.AutoSize = true;
            this.lblUSD.Location = new System.Drawing.Point(347, 366);
            this.lblUSD.Name = "lblUSD";
            this.lblUSD.Size = new System.Drawing.Size(65, 16);
            this.lblUSD.TabIndex = 20;
            this.lblUSD.Text = "US Dollar";
            // 
            // tbFrank
            // 
            this.tbFrank.Location = new System.Drawing.Point(502, 206);
            this.tbFrank.Name = "tbFrank";
            this.tbFrank.Size = new System.Drawing.Size(100, 22);
            this.tbFrank.TabIndex = 19;
            // 
            // tbRupees
            // 
            this.tbRupees.Location = new System.Drawing.Point(334, 206);
            this.tbRupees.Name = "tbRupees";
            this.tbRupees.Size = new System.Drawing.Size(100, 22);
            this.tbRupees.TabIndex = 18;
            // 
            // tbYen
            // 
            this.tbYen.Location = new System.Drawing.Point(174, 206);
            this.tbYen.Name = "tbYen";
            this.tbYen.Size = new System.Drawing.Size(100, 22);
            this.tbYen.TabIndex = 17;
            // 
            // tbEuro
            // 
            this.tbEuro.Location = new System.Drawing.Point(434, 100);
            this.tbEuro.Name = "tbEuro";
            this.tbEuro.Size = new System.Drawing.Size(100, 22);
            this.tbEuro.TabIndex = 16;
            // 
            // tbPound
            // 
            this.tbPound.Location = new System.Drawing.Point(245, 100);
            this.tbPound.Name = "tbPound";
            this.tbPound.Size = new System.Drawing.Size(100, 22);
            this.tbPound.TabIndex = 15;
            // 
            // tbUSD
            // 
            this.tbUSD.Location = new System.Drawing.Point(334, 385);
            this.tbUSD.Name = "tbUSD";
            this.tbUSD.Size = new System.Drawing.Size(100, 22);
            this.tbUSD.TabIndex = 14;
            // 
            // btnConverteer
            // 
            this.btnConverteer.Location = new System.Drawing.Point(314, 283);
            this.btnConverteer.Name = "btnConverteer";
            this.btnConverteer.Size = new System.Drawing.Size(142, 57);
            this.btnConverteer.TabIndex = 26;
            this.btnConverteer.Text = "Converteer";
            this.btnConverteer.UseVisualStyleBackColor = true;
            this.btnConverteer.Click += new System.EventHandler(this.btnConverteer_Click);
            // 
            // formCurrencyConvertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConverteer);
            this.Controls.Add(this.lblFrank);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblRupees);
            this.Controls.Add(this.lblYen);
            this.Controls.Add(this.lblPound);
            this.Controls.Add(this.lblUSD);
            this.Controls.Add(this.tbFrank);
            this.Controls.Add(this.tbRupees);
            this.Controls.Add(this.tbYen);
            this.Controls.Add(this.tbEuro);
            this.Controls.Add(this.tbPound);
            this.Controls.Add(this.tbUSD);
            this.Name = "formCurrencyConvertor";
            this.Text = "CurrencyConvertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrank;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblRupees;
        private System.Windows.Forms.Label lblYen;
        private System.Windows.Forms.Label lblPound;
        private System.Windows.Forms.Label lblUSD;
        private System.Windows.Forms.TextBox tbFrank;
        private System.Windows.Forms.TextBox tbRupees;
        private System.Windows.Forms.TextBox tbYen;
        private System.Windows.Forms.TextBox tbEuro;
        private System.Windows.Forms.TextBox tbPound;
        private System.Windows.Forms.TextBox tbUSD;
        private System.Windows.Forms.Button btnConverteer;
    }
}

