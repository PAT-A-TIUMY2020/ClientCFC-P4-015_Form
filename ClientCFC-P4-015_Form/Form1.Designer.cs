namespace ClientCFC_P4_015_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tTambah = new System.Windows.Forms.TextBox();
            this.tKurang = new System.Windows.Forms.TextBox();
            this.tKali = new System.Windows.Forms.TextBox();
            this.tBagi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tambah";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kurang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kali";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bagi";
            // 
            // tTambah
            // 
            this.tTambah.Location = new System.Drawing.Point(202, 71);
            this.tTambah.Name = "tTambah";
            this.tTambah.Size = new System.Drawing.Size(203, 22);
            this.tTambah.TabIndex = 4;
            this.tTambah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tKurang
            // 
            this.tKurang.Location = new System.Drawing.Point(202, 113);
            this.tKurang.Name = "tKurang";
            this.tKurang.Size = new System.Drawing.Size(203, 22);
            this.tKurang.TabIndex = 5;
            this.tKurang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tKali
            // 
            this.tKali.Location = new System.Drawing.Point(202, 160);
            this.tKali.Name = "tKali";
            this.tKali.Size = new System.Drawing.Size(203, 22);
            this.tKali.TabIndex = 6;
            this.tKali.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBagi
            // 
            this.tBagi.Location = new System.Drawing.Point(202, 205);
            this.tBagi.Name = "tBagi";
            this.tBagi.Size = new System.Drawing.Size(203, 22);
            this.tBagi.TabIndex = 7;
            this.tBagi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tBagi);
            this.Controls.Add(this.tKali);
            this.Controls.Add(this.tKurang);
            this.Controls.Add(this.tTambah);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client CFC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tTambah;
        private System.Windows.Forms.TextBox tKurang;
        private System.Windows.Forms.TextBox tKali;
        private System.Windows.Forms.TextBox tBagi;
    }
}

