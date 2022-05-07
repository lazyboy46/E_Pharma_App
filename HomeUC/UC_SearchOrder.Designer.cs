namespace E_Pharma_App.HomeUC
{
    partial class UC_SearchOrder
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.txtmedid = new System.Windows.Forms.TextBox();
            this.txtmedname = new System.Windows.Forms.TextBox();
            this.txtdia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtperunit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.membercombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.browse = new System.Windows.Forms.Button();
            this.txttotprice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PresReq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartbtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.totlabel = new System.Windows.Forms.Label();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnplaceorder = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.usernameid = new System.Windows.Forms.Label();
            this.totprilabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search and Place Order";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Calibri", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 27;
            this.listBox1.Location = new System.Drawing.Point(21, 203);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(241, 490);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Calibri", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(21, 141);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(241, 34);
            this.txtsearch.TabIndex = 2;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // txtmedid
            // 
            this.txtmedid.Location = new System.Drawing.Point(315, 143);
            this.txtmedid.Name = "txtmedid";
            this.txtmedid.Size = new System.Drawing.Size(100, 26);
            this.txtmedid.TabIndex = 3;
            // 
            // txtmedname
            // 
            this.txtmedname.Location = new System.Drawing.Point(445, 143);
            this.txtmedname.Name = "txtmedname";
            this.txtmedname.Size = new System.Drawing.Size(170, 26);
            this.txtmedname.TabIndex = 4;
            // 
            // txtdia
            // 
            this.txtdia.Location = new System.Drawing.Point(651, 141);
            this.txtdia.Name = "txtdia";
            this.txtdia.Size = new System.Drawing.Size(203, 26);
            this.txtdia.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Medic ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Medicine Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(646, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Diagnosis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "PricePerUnit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(492, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantity";
            // 
            // txtperunit
            // 
            this.txtperunit.Location = new System.Drawing.Point(315, 233);
            this.txtperunit.Name = "txtperunit";
            this.txtperunit.Size = new System.Drawing.Size(151, 26);
            this.txtperunit.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(704, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "Member";
            // 
            // membercombo
            // 
            this.membercombo.FormattingEnabled = true;
            this.membercombo.Items.AddRange(new object[] {
            "Father",
            "Mother",
            "Brother",
            "Sister",
            "Myself",
            "Grandpa",
            "Grandma\t"});
            this.membercombo.Location = new System.Drawing.Point(709, 231);
            this.membercombo.Name = "membercombo";
            this.membercombo.Size = new System.Drawing.Size(121, 28);
            this.membercombo.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(310, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 27);
            this.label8.TabIndex = 14;
            this.label8.Text = "Prescription";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(497, 233);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(175, 26);
            this.txtquantity.TabIndex = 15;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.Color.IndianRed;
            this.browse.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse.Location = new System.Drawing.Point(316, 331);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(150, 43);
            this.browse.TabIndex = 16;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttotprice
            // 
            this.txttotprice.Location = new System.Drawing.Point(691, 340);
            this.txttotprice.Name = "txttotprice";
            this.txttotprice.Size = new System.Drawing.Size(159, 26);
            this.txttotprice.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(686, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 27);
            this.label10.TabIndex = 20;
            this.label10.Text = "Total Price";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedID,
            this.MedName,
            this.Diagosis,
            this.Member,
            this.Column1,
            this.Column2,
            this.PresReq});
            this.dataGridView1.Location = new System.Drawing.Point(283, 437);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(598, 150);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MedID
            // 
            this.MedID.HeaderText = "MedID";
            this.MedID.MinimumWidth = 8;
            this.MedID.Name = "MedID";
            this.MedID.Width = 150;
            // 
            // MedName
            // 
            this.MedName.HeaderText = "MedName";
            this.MedName.MinimumWidth = 8;
            this.MedName.Name = "MedName";
            this.MedName.Width = 150;
            // 
            // Diagosis
            // 
            this.Diagosis.HeaderText = "Diagosis";
            this.Diagosis.MinimumWidth = 8;
            this.Diagosis.Name = "Diagosis";
            this.Diagosis.Width = 150;
            // 
            // Member
            // 
            this.Member.HeaderText = "Member";
            this.Member.MinimumWidth = 8;
            this.Member.Name = "Member";
            this.Member.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Quantity";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Total Price";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // PresReq
            // 
            this.PresReq.HeaderText = "PresReq";
            this.PresReq.MinimumWidth = 8;
            this.PresReq.Name = "PresReq";
            this.PresReq.Width = 150;
            // 
            // cartbtn
            // 
            this.cartbtn.BackColor = System.Drawing.Color.IndianRed;
            this.cartbtn.Font = new System.Drawing.Font("Calibri", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartbtn.Location = new System.Drawing.Point(691, 383);
            this.cartbtn.Name = "cartbtn";
            this.cartbtn.Size = new System.Drawing.Size(159, 48);
            this.cartbtn.TabIndex = 22;
            this.cartbtn.Text = "Add To Cart";
            this.cartbtn.UseVisualStyleBackColor = false;
            this.cartbtn.Click += new System.EventHandler(this.cartbtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 27);
            this.label11.TabIndex = 23;
            this.label11.Text = "Search";
            // 
            // totlabel
            // 
            this.totlabel.AutoSize = true;
            this.totlabel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totlabel.Location = new System.Drawing.Point(734, 614);
            this.totlabel.Name = "totlabel";
            this.totlabel.Size = new System.Drawing.Size(0, 27);
            this.totlabel.TabIndex = 24;
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.IndianRed;
            this.btnremove.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(336, 594);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(150, 47);
            this.btnremove.TabIndex = 25;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnplaceorder
            // 
            this.btnplaceorder.BackColor = System.Drawing.Color.IndianRed;
            this.btnplaceorder.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplaceorder.Location = new System.Drawing.Point(709, 593);
            this.btnplaceorder.Name = "btnplaceorder";
            this.btnplaceorder.Size = new System.Drawing.Size(156, 48);
            this.btnplaceorder.TabIndex = 26;
            this.btnplaceorder.Text = "Place Order";
            this.btnplaceorder.UseVisualStyleBackColor = false;
            this.btnplaceorder.Click += new System.EventHandler(this.btnplaceorder_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(480, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 27);
            this.label9.TabIndex = 28;
            this.label9.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(485, 338);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 5, 6, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 5, 6, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.Value = new System.DateTime(2022, 5, 6, 0, 0, 0, 0);
            // 
            // usernameid
            // 
            this.usernameid.AutoSize = true;
            this.usernameid.Location = new System.Drawing.Point(546, 48);
            this.usernameid.Name = "usernameid";
            this.usernameid.Size = new System.Drawing.Size(80, 20);
            this.usernameid.TabIndex = 29;
            this.usernameid.Text = "username";
            // 
            // totprilabel
            // 
            this.totprilabel.AutoSize = true;
            this.totprilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totprilabel.Location = new System.Drawing.Point(541, 604);
            this.totprilabel.Name = "totprilabel";
            this.totprilabel.Size = new System.Drawing.Size(44, 25);
            this.totprilabel.TabIndex = 30;
            this.totprilabel.Text = "Rs:";
            // 
            // UC_SearchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.totprilabel);
            this.Controls.Add(this.usernameid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnplaceorder);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.totlabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cartbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txttotprice);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.membercombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtperunit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdia);
            this.Controls.Add(this.txtmedname);
            this.Controls.Add(this.txtmedid);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "UC_SearchOrder";
            this.Size = new System.Drawing.Size(997, 752);
            this.Load += new System.EventHandler(this.UC_SearchOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TextBox txtmedid;
        private System.Windows.Forms.TextBox txtmedname;
        private System.Windows.Forms.TextBox txtdia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtperunit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox membercombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.TextBox txttotprice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cartbtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label totlabel;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnplaceorder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label usernameid;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PresReq;
        private System.Windows.Forms.Label totprilabel;
    }
}
