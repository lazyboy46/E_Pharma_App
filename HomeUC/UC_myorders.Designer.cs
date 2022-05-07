namespace E_Pharma_App.HomeUC
{
    partial class UC_myorders
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btncancel = new System.Windows.Forms.Button();
            this.usernameid = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.txttotpri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Myorders";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.IndianRed;
            this.dataGridView1.Location = new System.Drawing.Point(30, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(869, 428);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.IndianRed;
            this.btncancel.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.Black;
            this.btncancel.Location = new System.Drawing.Point(728, 590);
            this.btncancel.Margin = new System.Windows.Forms.Padding(0);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(171, 52);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Print Order";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // usernameid
            // 
            this.usernameid.AutoSize = true;
            this.usernameid.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameid.Location = new System.Drawing.Point(233, 28);
            this.usernameid.Name = "usernameid";
            this.usernameid.Size = new System.Drawing.Size(112, 29);
            this.usernameid.TabIndex = 3;
            this.usernameid.Text = "username";
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.IndianRed;
            this.btnrefresh.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Location = new System.Drawing.Point(56, 100);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(183, 53);
            this.btnrefresh.TabIndex = 4;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // txttotpri
            // 
            this.txttotpri.AutoSize = true;
            this.txttotpri.Location = new System.Drawing.Point(377, 621);
            this.txttotpri.Name = "txttotpri";
            this.txttotpri.Size = new System.Drawing.Size(0, 20);
            this.txttotpri.TabIndex = 5;
            // 
            // UC_myorders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txttotpri);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.usernameid);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "UC_myorders";
            this.Size = new System.Drawing.Size(1016, 692);
            this.Load += new System.EventHandler(this.UC_myorders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label usernameid;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Label txttotpri;
    }
}
