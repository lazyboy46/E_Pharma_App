namespace E_Pharma_App
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.userlabel = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnmembers = new System.Windows.Forms.Button();
            this.btnmyorders = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnmyprofile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.uC_MyProfile1 = new E_Pharma_App.HomeUC.UC_MyProfile();
            this.uC_Members1 = new E_Pharma_App.HomeUC.UC_Members();
            this.uC_myorders1 = new E_Pharma_App.HomeUC.UC_myorders();
            this.uC_SearchOrder1 = new E_Pharma_App.HomeUC.UC_SearchOrder();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.userlabel);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnmembers);
            this.panel1.Controls.Add(this.btnmyorders);
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.btnmyprofile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 771);
            this.panel1.TabIndex = 0;
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlabel.ForeColor = System.Drawing.Color.White;
            this.userlabel.Location = new System.Drawing.Point(150, 212);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(46, 24);
            this.userlabel.TabIndex = 7;
            this.userlabel.Text = "user";
            // 
            // btnlogout
            // 
            this.btnlogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnlogout.BackColor = System.Drawing.Color.MistyRose;
            this.btnlogout.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.LightCoral;
            this.btnlogout.Location = new System.Drawing.Point(75, 628);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(6);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Padding = new System.Windows.Forms.Padding(5);
            this.btnlogout.Size = new System.Drawing.Size(238, 58);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnmembers
            // 
            this.btnmembers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnmembers.BackColor = System.Drawing.Color.MistyRose;
            this.btnmembers.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmembers.ForeColor = System.Drawing.Color.LightCoral;
            this.btnmembers.Location = new System.Drawing.Point(75, 553);
            this.btnmembers.Margin = new System.Windows.Forms.Padding(6);
            this.btnmembers.Name = "btnmembers";
            this.btnmembers.Padding = new System.Windows.Forms.Padding(5);
            this.btnmembers.Size = new System.Drawing.Size(238, 58);
            this.btnmembers.TabIndex = 5;
            this.btnmembers.Text = "Members";
            this.btnmembers.UseVisualStyleBackColor = false;
            this.btnmembers.Click += new System.EventHandler(this.btnmembers_Click);
            // 
            // btnmyorders
            // 
            this.btnmyorders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnmyorders.BackColor = System.Drawing.Color.MistyRose;
            this.btnmyorders.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmyorders.ForeColor = System.Drawing.Color.LightCoral;
            this.btnmyorders.Location = new System.Drawing.Point(75, 476);
            this.btnmyorders.Margin = new System.Windows.Forms.Padding(6);
            this.btnmyorders.Name = "btnmyorders";
            this.btnmyorders.Padding = new System.Windows.Forms.Padding(5);
            this.btnmyorders.Size = new System.Drawing.Size(238, 58);
            this.btnmyorders.TabIndex = 4;
            this.btnmyorders.Text = "My Orders";
            this.btnmyorders.UseVisualStyleBackColor = false;
            this.btnmyorders.Click += new System.EventHandler(this.btnmyorders_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsearch.BackColor = System.Drawing.Color.MistyRose;
            this.btnsearch.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.LightCoral;
            this.btnsearch.Location = new System.Drawing.Point(75, 402);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Padding = new System.Windows.Forms.Padding(5);
            this.btnsearch.Size = new System.Drawing.Size(238, 58);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Search/Place Order";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnmyprofile
            // 
            this.btnmyprofile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmyprofile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnmyprofile.BackColor = System.Drawing.Color.MistyRose;
            this.btnmyprofile.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmyprofile.ForeColor = System.Drawing.Color.LightCoral;
            this.btnmyprofile.Location = new System.Drawing.Point(75, 330);
            this.btnmyprofile.Margin = new System.Windows.Forms.Padding(6);
            this.btnmyprofile.Name = "btnmyprofile";
            this.btnmyprofile.Padding = new System.Windows.Forms.Padding(5);
            this.btnmyprofile.Size = new System.Drawing.Size(238, 58);
            this.btnmyprofile.TabIndex = 2;
            this.btnmyprofile.Text = "My Profile";
            this.btnmyprofile.UseVisualStyleBackColor = false;
            this.btnmyprofile.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-Pharma";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_MyProfile1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.uC_Members1);
            this.panel2.Controls.Add(this.uC_myorders1);
            this.panel2.Controls.Add(this.uC_SearchOrder1);
            this.panel2.Location = new System.Drawing.Point(365, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 759);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "WLC to home page";
            // 
            // uC_MyProfile1
            // 
            this.uC_MyProfile1.BackColor = System.Drawing.Color.White;
            this.uC_MyProfile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_MyProfile1.Location = new System.Drawing.Point(0, 0);
            this.uC_MyProfile1.Name = "uC_MyProfile1";
            this.uC_MyProfile1.Size = new System.Drawing.Size(1000, 759);
            this.uC_MyProfile1.TabIndex = 6;
            this.uC_MyProfile1.Load += new System.EventHandler(this.uC_MyProfile1_Load_2);
            // 
            // uC_Members1
            // 
            this.uC_Members1.BackColor = System.Drawing.Color.White;
            this.uC_Members1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Members1.Location = new System.Drawing.Point(0, 0);
            this.uC_Members1.Name = "uC_Members1";
            this.uC_Members1.Size = new System.Drawing.Size(1000, 759);
            this.uC_Members1.TabIndex = 5;
            // 
            // uC_myorders1
            // 
            this.uC_myorders1.BackColor = System.Drawing.Color.White;
            this.uC_myorders1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_myorders1.Location = new System.Drawing.Point(0, 0);
            this.uC_myorders1.Name = "uC_myorders1";
            this.uC_myorders1.Size = new System.Drawing.Size(1000, 759);
            this.uC_myorders1.TabIndex = 4;
            // 
            // uC_SearchOrder1
            // 
            this.uC_SearchOrder1.BackColor = System.Drawing.Color.White;
            this.uC_SearchOrder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_SearchOrder1.Location = new System.Drawing.Point(0, 0);
            this.uC_SearchOrder1.Name = "uC_SearchOrder1";
            this.uC_SearchOrder1.Size = new System.Drawing.Size(1000, 759);
            this.uC_SearchOrder1.TabIndex = 3;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnmembers;
        private System.Windows.Forms.Button btnmyorders;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnmyprofile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.Label label2;
        private HomeUC.UC_SearchOrder uC_SearchOrder1;
        private HomeUC.UC_myorders uC_myorders1;
        private HomeUC.UC_Members uC_Members1;
        private HomeUC.UC_MyProfile uC_MyProfile1;
    }
}