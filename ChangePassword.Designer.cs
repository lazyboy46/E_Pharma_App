namespace E_Pharma_App
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.txtrenewpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnpwdreset = new System.Windows.Forms.Button();
            this.pictureBoxtick1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxtick2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxtick1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxtick2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 773);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 438);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-Pharma";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(770, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 147);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Location = new System.Drawing.Point(464, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 698);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(739, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "Change Password";
            // 
            // txtnewpass
            // 
            this.txtnewpass.Location = new System.Drawing.Point(687, 410);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(275, 26);
            this.txtnewpass.TabIndex = 9;
            this.txtnewpass.TextChanged += new System.EventHandler(this.txtoldpass_TextChanged);
            // 
            // txtrenewpass
            // 
            this.txtrenewpass.Location = new System.Drawing.Point(687, 530);
            this.txtrenewpass.Name = "txtrenewpass";
            this.txtrenewpass.Size = new System.Drawing.Size(275, 26);
            this.txtrenewpass.TabIndex = 10;
            this.txtrenewpass.TextChanged += new System.EventHandler(this.txtnewpass_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(682, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter New password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(691, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Re-enter New Password";
            // 
            // btnpwdreset
            // 
            this.btnpwdreset.BackColor = System.Drawing.Color.IndianRed;
            this.btnpwdreset.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpwdreset.Location = new System.Drawing.Point(745, 586);
            this.btnpwdreset.Name = "btnpwdreset";
            this.btnpwdreset.Size = new System.Drawing.Size(182, 55);
            this.btnpwdreset.TabIndex = 13;
            this.btnpwdreset.Text = "Update";
            this.btnpwdreset.UseVisualStyleBackColor = false;
            this.btnpwdreset.Click += new System.EventHandler(this.btnpwreset_Click);
            // 
            // pictureBoxtick1
            // 
            this.pictureBoxtick1.Location = new System.Drawing.Point(969, 410);
            this.pictureBoxtick1.Name = "pictureBoxtick1";
            this.pictureBoxtick1.Size = new System.Drawing.Size(31, 26);
            this.pictureBoxtick1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxtick1.TabIndex = 14;
            this.pictureBoxtick1.TabStop = false;
            // 
            // pictureBoxtick2
            // 
            this.pictureBoxtick2.Location = new System.Drawing.Point(969, 530);
            this.pictureBoxtick2.Name = "pictureBoxtick2";
            this.pictureBoxtick2.Size = new System.Drawing.Size(31, 26);
            this.pictureBoxtick2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxtick2.TabIndex = 15;
            this.pictureBoxtick2.TabStop = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 768);
            this.Controls.Add(this.pictureBoxtick2);
            this.Controls.Add(this.pictureBoxtick1);
            this.Controls.Add(this.btnpwdreset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtrenewpass);
            this.Controls.Add(this.txtnewpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ic";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxtick1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxtick2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.TextBox txtrenewpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnpwdreset;
        private System.Windows.Forms.PictureBox pictureBoxtick1;
        private System.Windows.Forms.PictureBox pictureBoxtick2;
    }
}