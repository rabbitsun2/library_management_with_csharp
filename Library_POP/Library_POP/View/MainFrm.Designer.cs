namespace Library_POP.View
{
    partial class MainFrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCollectionID = new System.Windows.Forms.TextBox();
            this.txtCollectionBillingNumber = new System.Windows.Forms.TextBox();
            this.txtCollection = new System.Windows.Forms.TextBox();
            this.txtCollectionRegiNumber = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBookRemove = new System.Windows.Forms.Button();
            this.btnBookModify = new System.Windows.Forms.Button();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCollectionModify = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.cmbResBookCnt = new System.Windows.Forms.ComboBox();
            this.btnResReturn = new System.Windows.Forms.Button();
            this.btnResRegister = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.btnResDelete = new System.Windows.Forms.Button();
            this.statusFrm = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLblTitle = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.statusFrm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "도서관리 시스템";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1011, 221);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "소장정보";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(14, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(136, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "청구기호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(341, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "소장처";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(534, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "등록번호";
            // 
            // txtCollectionID
            // 
            this.txtCollectionID.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCollectionID.Location = new System.Drawing.Point(56, 49);
            this.txtCollectionID.Name = "txtCollectionID";
            this.txtCollectionID.ReadOnly = true;
            this.txtCollectionID.Size = new System.Drawing.Size(69, 21);
            this.txtCollectionID.TabIndex = 7;
            // 
            // txtCollectionBillingNumber
            // 
            this.txtCollectionBillingNumber.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCollectionBillingNumber.Location = new System.Drawing.Point(202, 50);
            this.txtCollectionBillingNumber.Name = "txtCollectionBillingNumber";
            this.txtCollectionBillingNumber.Size = new System.Drawing.Size(128, 21);
            this.txtCollectionBillingNumber.TabIndex = 8;
            // 
            // txtCollection
            // 
            this.txtCollection.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCollection.Location = new System.Drawing.Point(395, 50);
            this.txtCollection.Name = "txtCollection";
            this.txtCollection.Size = new System.Drawing.Size(128, 21);
            this.txtCollection.TabIndex = 9;
            // 
            // txtCollectionRegiNumber
            // 
            this.txtCollectionRegiNumber.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCollectionRegiNumber.Location = new System.Drawing.Point(600, 49);
            this.txtCollectionRegiNumber.Name = "txtCollectionRegiNumber";
            this.txtCollectionRegiNumber.Size = new System.Drawing.Size(128, 21);
            this.txtCollectionRegiNumber.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(286, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 29);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBookRemove);
            this.panel1.Controls.Add(this.btnBookModify);
            this.panel1.Controls.Add(this.btnBookAdd);
            this.panel1.Controls.Add(this.txtKeyword);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(21, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 45);
            this.panel1.TabIndex = 12;
            // 
            // btnBookRemove
            // 
            this.btnBookRemove.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBookRemove.Location = new System.Drawing.Point(637, 8);
            this.btnBookRemove.Name = "btnBookRemove";
            this.btnBookRemove.Size = new System.Drawing.Size(111, 29);
            this.btnBookRemove.TabIndex = 15;
            this.btnBookRemove.Text = "도서 삭제";
            this.btnBookRemove.UseVisualStyleBackColor = true;
            this.btnBookRemove.Click += new System.EventHandler(this.btnBookRemove_Click);
            // 
            // btnBookModify
            // 
            this.btnBookModify.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBookModify.Location = new System.Drawing.Point(520, 8);
            this.btnBookModify.Name = "btnBookModify";
            this.btnBookModify.Size = new System.Drawing.Size(111, 29);
            this.btnBookModify.TabIndex = 14;
            this.btnBookModify.Text = "도서 수정";
            this.btnBookModify.UseVisualStyleBackColor = true;
            this.btnBookModify.Click += new System.EventHandler(this.btnBookModify_Click);
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBookAdd.Location = new System.Drawing.Point(403, 8);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(111, 29);
            this.btnBookAdd.TabIndex = 13;
            this.btnBookAdd.Text = "도서 추가";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtKeyword.Location = new System.Drawing.Point(10, 11);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(261, 22);
            this.txtKeyword.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCollectionModify);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtCollectionRegiNumber);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtCollection);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtCollectionBillingNumber);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtCollectionID);
            this.panel2.Location = new System.Drawing.Point(22, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 86);
            this.panel2.TabIndex = 13;
            // 
            // btnCollectionModify
            // 
            this.btnCollectionModify.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCollectionModify.Location = new System.Drawing.Point(740, 44);
            this.btnCollectionModify.Name = "btnCollectionModify";
            this.btnCollectionModify.Size = new System.Drawing.Size(106, 29);
            this.btnCollectionModify.TabIndex = 11;
            this.btnCollectionModify.Text = "수정";
            this.btnCollectionModify.UseVisualStyleBackColor = true;
            this.btnCollectionModify.Click += new System.EventHandler(this.btnCollectionModify_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnResDelete);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.lblBookID);
            this.panel4.Controls.Add(this.cmbResBookCnt);
            this.panel4.Controls.Add(this.btnResReturn);
            this.panel4.Controls.Add(this.btnResRegister);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(22, 436);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1012, 144);
            this.panel4.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(133, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "식별번호";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBookID.Location = new System.Drawing.Point(199, 15);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(0, 15);
            this.lblBookID.TabIndex = 15;
            // 
            // cmbResBookCnt
            // 
            this.cmbResBookCnt.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbResBookCnt.FormattingEnabled = true;
            this.cmbResBookCnt.Location = new System.Drawing.Point(285, 13);
            this.cmbResBookCnt.Name = "cmbResBookCnt";
            this.cmbResBookCnt.Size = new System.Drawing.Size(64, 22);
            this.cmbResBookCnt.TabIndex = 14;
            // 
            // btnResReturn
            // 
            this.btnResReturn.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnResReturn.Location = new System.Drawing.Point(475, 9);
            this.btnResReturn.Name = "btnResReturn";
            this.btnResReturn.Size = new System.Drawing.Size(106, 29);
            this.btnResReturn.TabIndex = 13;
            this.btnResReturn.Text = "반납";
            this.btnResReturn.UseVisualStyleBackColor = true;
            this.btnResReturn.Click += new System.EventHandler(this.btnResReturn_Click);
            // 
            // btnResRegister
            // 
            this.btnResRegister.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnResRegister.Location = new System.Drawing.Point(363, 9);
            this.btnResRegister.Name = "btnResRegister";
            this.btnResRegister.Size = new System.Drawing.Size(106, 29);
            this.btnResRegister.TabIndex = 12;
            this.btnResRegister.Text = "예약";
            this.btnResRegister.UseVisualStyleBackColor = true;
            this.btnResRegister.Click += new System.EventHandler(this.btnResRegister_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(239, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "수량";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-2, 45);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1012, 95);
            this.dataGridView2.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(17, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "예약현황";
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAccountID.Location = new System.Drawing.Point(1030, 10);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(17, 12);
            this.lblAccountID.TabIndex = 14;
            this.lblAccountID.Text = "-1";
            // 
            // btnResDelete
            // 
            this.btnResDelete.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnResDelete.Location = new System.Drawing.Point(587, 9);
            this.btnResDelete.Name = "btnResDelete";
            this.btnResDelete.Size = new System.Drawing.Size(106, 29);
            this.btnResDelete.TabIndex = 17;
            this.btnResDelete.Text = "예약 취소";
            this.btnResDelete.UseVisualStyleBackColor = true;
            this.btnResDelete.Click += new System.EventHandler(this.btnResDelete_Click);
            // 
            // statusFrm
            // 
            this.statusFrm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLblTitle});
            this.statusFrm.Location = new System.Drawing.Point(0, 606);
            this.statusFrm.Name = "statusFrm";
            this.statusFrm.Size = new System.Drawing.Size(1051, 22);
            this.statusFrm.TabIndex = 15;
            this.statusFrm.Text = "statusStrip1";
            // 
            // toolStripStatusLblTitle
            // 
            this.toolStripStatusLblTitle.Name = "toolStripStatusLblTitle";
            this.toolStripStatusLblTitle.Size = new System.Drawing.Size(0, 17);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 628);
            this.Controls.Add(this.statusFrm);
            this.Controls.Add(this.lblAccountID);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "도서관리 시스템";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.statusFrm.ResumeLayout(false);
            this.statusFrm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCollectionID;
        private System.Windows.Forms.TextBox txtCollectionBillingNumber;
        private System.Windows.Forms.TextBox txtCollection;
        private System.Windows.Forms.TextBox txtCollectionRegiNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCollectionModify;
        private System.Windows.Forms.Button btnBookModify;
        private System.Windows.Forms.Button btnBookRemove;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnResRegister;
        private System.Windows.Forms.Button btnResReturn;
        private System.Windows.Forms.ComboBox cmbResBookCnt;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnResDelete;
        private System.Windows.Forms.StatusStrip statusFrm;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLblTitle;
    }
}