namespace PhoneBook
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			DevExpress.XtraEditors.Controls.CheckedListBoxItem checkedListBoxItem1 = new DevExpress.XtraEditors.Controls.CheckedListBoxItem();
			DevExpress.XtraEditors.Controls.CheckedListBoxItem checkedListBoxItem2 = new DevExpress.XtraEditors.Controls.CheckedListBoxItem();
			DevExpress.XtraEditors.Controls.CheckedListBoxItem checkedListBoxItem3 = new DevExpress.XtraEditors.Controls.CheckedListBoxItem();
			this.grdObject = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gbAra = new DevExpress.XtraEditors.GroupControl();
			this.txtAra = new DevExpress.XtraEditors.TextEdit();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.getAllCustomer = new System.Windows.Forms.ToolStripMenuItem();
			this.telefonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.getAllPhone = new System.Windows.Forms.ToolStripMenuItem();
			this.GetAllPhoneCustomer = new System.Windows.Forms.ToolStripMenuItem();
			this.txtAd = new DevExpress.XtraEditors.TextEdit();
			this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
			this.AddCustomer = new DevExpress.XtraEditors.SimpleButton();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUpdated = new DevExpress.XtraEditors.TextEdit();
			this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
			this.txtUpdateSurname = new DevExpress.XtraEditors.TextEdit();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
			this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
			this.label9 = new System.Windows.Forms.Label();
			this.ChImportantPhone = new DevExpress.XtraEditors.CheckedComboBoxEdit();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPhoneTag = new DevExpress.XtraEditors.TextEdit();
			this.txtKisiId = new DevExpress.XtraEditors.TextEdit();
			this.txtPhoneNumber = new DevExpress.XtraEditors.TextEdit();
			this.BtnSavePhone = new DevExpress.XtraEditors.SimpleButton();
			this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
			this.BtnNext = new DevExpress.XtraEditors.SimpleButton();
			this.label10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.grdObject)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gbAra)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAra.Properties)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUpdated.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUpdateSurname.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ChImportantPhone.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPhoneTag.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKisiId.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// grdObject
			// 
			this.grdObject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grdObject.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.grdObject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.grdObject.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.grdObject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdObject.ContextMenuStrip = this.contextMenuStrip1;
			this.grdObject.Cursor = System.Windows.Forms.Cursors.Cross;
			this.grdObject.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.grdObject.Location = new System.Drawing.Point(12, 44);
			this.grdObject.MultiSelect = false;
			this.grdObject.Name = "grdObject";
			this.grdObject.RowHeadersVisible = false;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grdObject.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.grdObject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdObject.Size = new System.Drawing.Size(551, 209);
			this.grdObject.TabIndex = 0;
			this.grdObject.Visible = false;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
			this.contextMenuStrip1.Text = "Düzenle";
			// 
			// düzenleToolStripMenuItem
			// 
			this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
			this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.düzenleToolStripMenuItem.Text = "Düzenle";
			this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.DuzenleToolStripMenuItem_Click);
			// 
			// silToolStripMenuItem
			// 
			this.silToolStripMenuItem.Name = "silToolStripMenuItem";
			this.silToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
			this.silToolStripMenuItem.Text = "Sil";
			this.silToolStripMenuItem.Click += new System.EventHandler(this.SilToolStripMenuItem_Click);
			// 
			// gbAra
			// 
			this.gbAra.Controls.Add(this.txtAra);
			this.gbAra.Location = new System.Drawing.Point(581, 44);
			this.gbAra.Name = "gbAra";
			this.gbAra.Size = new System.Drawing.Size(203, 94);
			this.gbAra.TabIndex = 3;
			this.gbAra.Text = "Ara (Ad veya Soyada göre)";
			// 
			// txtAra
			// 
			this.txtAra.Location = new System.Drawing.Point(28, 46);
			this.txtAra.Name = "txtAra";
			this.txtAra.Size = new System.Drawing.Size(159, 20);
			this.txtAra.TabIndex = 0;
			this.txtAra.TextChanged += new System.EventHandler(this.TxtAra_TextChanged);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriToolStripMenuItem,
            this.telefonToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(847, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// müşteriToolStripMenuItem
			// 
			this.müşteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getAllCustomer});
			this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
			this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.müşteriToolStripMenuItem.Text = "Kişi";
			// 
			// getAllCustomer
			// 
			this.getAllCustomer.Name = "getAllCustomer";
			this.getAllCustomer.Size = new System.Drawing.Size(107, 22);
			this.getAllCustomer.Text = "Listele";
			this.getAllCustomer.Click += new System.EventHandler(this.GetAllCustomer_Click);
			// 
			// telefonToolStripMenuItem
			// 
			this.telefonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getAllPhone,
            this.GetAllPhoneCustomer});
			this.telefonToolStripMenuItem.Name = "telefonToolStripMenuItem";
			this.telefonToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.telefonToolStripMenuItem.Text = "Telefon";
			// 
			// getAllPhone
			// 
			this.getAllPhone.Name = "getAllPhone";
			this.getAllPhone.Size = new System.Drawing.Size(186, 22);
			this.getAllPhone.Text = "Listele";
			this.getAllPhone.Click += new System.EventHandler(this.GetAllPhone_Click);
			// 
			// GetAllPhoneCustomer
			// 
			this.GetAllPhoneCustomer.Name = "GetAllPhoneCustomer";
			this.GetAllPhoneCustomer.Size = new System.Drawing.Size(186, 22);
			this.GetAllPhoneCustomer.Text = "Müşteri Adıyla Listele";
			this.GetAllPhoneCustomer.Click += new System.EventHandler(this.GetAllPhoneCustomer_Click);
			// 
			// txtAd
			// 
			this.txtAd.Location = new System.Drawing.Point(90, 29);
			this.txtAd.Name = "txtAd";
			this.txtAd.TabIndex = 6;
			// 
			// txtSoyad
			// 
			this.txtSoyad.Location = new System.Drawing.Point(90, 58);
			this.txtSoyad.Name = "txtSoyad";
			this.txtSoyad.TabIndex = 7;
			// 
			// AddCustomer
			// 
			this.AddCustomer.Location = new System.Drawing.Point(167, 88);
			this.AddCustomer.Name = "AddCustomer";
			this.AddCustomer.Size = new System.Drawing.Size(78, 35);
			this.AddCustomer.TabIndex = 9;
			this.AddCustomer.Text = "Kaydet";
			this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
			// 
			// groupControl1
			// 
			this.groupControl1.Controls.Add(this.label3);
			this.groupControl1.Controls.Add(this.label4);
			this.groupControl1.Controls.Add(this.txtAd);
			this.groupControl1.Controls.Add(this.txtSoyad);
			this.groupControl1.Controls.Add(this.AddCustomer);
			this.groupControl1.Location = new System.Drawing.Point(12, 302);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(245, 123);
			this.groupControl1.TabIndex = 11;
			this.groupControl1.Text = "Kişi Kaydet";
			this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 17;
			this.label3.Text = "Kişi Adı";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 13);
			this.label4.TabIndex = 18;
			this.label4.Text = "Kişi Soyadı";
			// 
			// txtUpdated
			// 
			this.txtUpdated.Location = new System.Drawing.Point(81, 29);
			this.txtUpdated.Name = "txtUpdated";
			this.txtUpdated.TabIndex = 12;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(138, 87);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 37);
			this.btnUpdate.TabIndex = 13;
			this.btnUpdate.Text = "Düzenle";
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
			// 
			// txtUpdateSurname
			// 
			this.txtUpdateSurname.Location = new System.Drawing.Point(81, 58);
			this.txtUpdateSurname.Name = "txtUpdateSurname";
			this.txtUpdateSurname.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Kişi Adı";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Kişi Soyadı";
			// 
			// groupControl2
			// 
			this.groupControl2.Controls.Add(this.label1);
			this.groupControl2.Controls.Add(this.label2);
			this.groupControl2.Controls.Add(this.txtUpdated);
			this.groupControl2.Controls.Add(this.btnUpdate);
			this.groupControl2.Controls.Add(this.txtUpdateSurname);
			this.groupControl2.Location = new System.Drawing.Point(274, 302);
			this.groupControl2.Name = "groupControl2";
			this.groupControl2.Size = new System.Drawing.Size(213, 123);
			this.groupControl2.TabIndex = 17;
			this.groupControl2.Text = "Kişi Düzenle";
			// 
			// groupControl3
			// 
			this.groupControl3.Controls.Add(this.label9);
			this.groupControl3.Controls.Add(this.ChImportantPhone);
			this.groupControl3.Controls.Add(this.label8);
			this.groupControl3.Controls.Add(this.label7);
			this.groupControl3.Controls.Add(this.label6);
			this.groupControl3.Controls.Add(this.label5);
			this.groupControl3.Controls.Add(this.txtPhoneTag);
			this.groupControl3.Controls.Add(this.txtKisiId);
			this.groupControl3.Controls.Add(this.txtPhoneNumber);
			this.groupControl3.Controls.Add(this.BtnSavePhone);
			this.groupControl3.Location = new System.Drawing.Point(523, 302);
			this.groupControl3.Name = "groupControl3";
			this.groupControl3.Size = new System.Drawing.Size(271, 162);
			this.groupControl3.TabIndex = 12;
			this.groupControl3.Text = "Telefon Numarası Kaydet";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(79, 147);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(117, 13);
			this.label9.TabIndex = 21;
			this.label9.Text = "Burası çalışmıyor henüz";
			// 
			// ChImportantPhone
			// 
			this.ChImportantPhone.EditValue = "";
			this.ChImportantPhone.Location = new System.Drawing.Point(96, 110);
			this.ChImportantPhone.Name = "ChImportantPhone";
			// 
			// 
			// 
			this.ChImportantPhone.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ChImportantPhone.Properties.DropDownRows = 3;
			checkedListBoxItem1.Description = "Primay";
			checkedListBoxItem1.Tag = ((short)(1));
			checkedListBoxItem2.Description = "Second";
			checkedListBoxItem2.Tag = ((short)(2));
			checkedListBoxItem2.Value = ((short)(2));
			checkedListBoxItem3.Description = "Third";
			checkedListBoxItem3.Tag = ((short)(3));
			checkedListBoxItem3.Value = "1";
			this.ChImportantPhone.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            checkedListBoxItem1,
            checkedListBoxItem2,
            checkedListBoxItem3});
			this.ChImportantPhone.Properties.SelectAllItemVisible = false;
			this.ChImportantPhone.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.ChImportantPhone.TabIndex = 26;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(5, 113);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(85, 13);
			this.label8.TabIndex = 23;
			this.label8.Text = "Öncelik Derecesi";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(5, 85);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 13);
			this.label7.TabIndex = 22;
			this.label7.Text = "Telefon Tag";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(5, 59);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 13);
			this.label6.TabIndex = 21;
			this.label6.Text = "Telefon No";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(5, 30);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 20;
			this.label5.Text = "Kişi Id";
			// 
			// txtPhoneTag
			// 
			this.txtPhoneTag.Location = new System.Drawing.Point(96, 86);
			this.txtPhoneTag.Name = "txtPhoneTag";
			this.txtPhoneTag.TabIndex = 11;
			// 
			// txtKisiId
			// 
			this.txtKisiId.Location = new System.Drawing.Point(96, 27);
			this.txtKisiId.Name = "txtKisiId";
			this.txtKisiId.TabIndex = 6;
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Location = new System.Drawing.Point(96, 56);
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.TabIndex = 7;
			// 
			// BtnSavePhone
			// 
			this.BtnSavePhone.Location = new System.Drawing.Point(202, 101);
			this.BtnSavePhone.Name = "BtnSavePhone";
			this.BtnSavePhone.Size = new System.Drawing.Size(69, 39);
			this.BtnSavePhone.TabIndex = 9;
			this.BtnSavePhone.Text = "Kaydet";
			this.BtnSavePhone.Click += new System.EventHandler(this.BtnSavePhone_Click);
			// 
			// btnPrev
			// 
			this.btnPrev.Location = new System.Drawing.Point(207, 259);
			this.btnPrev.Name = "btnPrev";
			this.btnPrev.TabIndex = 19;
			this.btnPrev.Text = "Prev";
			// 
			// BtnNext
			// 
			this.BtnNext.Location = new System.Drawing.Point(288, 259);
			this.BtnNext.Name = "BtnNext";
			this.BtnNext.TabIndex = 20;
			this.BtnNext.Text = "Next";
			this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(352, 264);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(116, 13);
			this.label10.TabIndex = 22;
			this.label10.Text = "Burası çalışmıyor henüz";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(847, 525);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.BtnNext);
			this.Controls.Add(this.btnPrev);
			this.Controls.Add(this.groupControl3);
			this.Controls.Add(this.groupControl2);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.gbAra);
			this.Controls.Add(this.grdObject);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.grdObject)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gbAra)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAra.Properties)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUpdated.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUpdateSurname.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ChImportantPhone.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPhoneTag.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtKisiId.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPhoneNumber.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView grdObject;
		private DevExpress.XtraEditors.GroupControl gbAra;
		private DevExpress.XtraEditors.TextEdit txtAra;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem getAllCustomer;
		private System.Windows.Forms.ToolStripMenuItem telefonToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem getAllPhone;
		private System.Windows.Forms.ToolStripMenuItem GetAllPhoneCustomer;
		private DevExpress.XtraEditors.TextEdit txtAd;
		private DevExpress.XtraEditors.TextEdit txtSoyad;
		private DevExpress.XtraEditors.SimpleButton AddCustomer;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.TextEdit txtUpdated;
		private DevExpress.XtraEditors.SimpleButton btnUpdate;
		private DevExpress.XtraEditors.TextEdit txtUpdateSurname;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private DevExpress.XtraEditors.GroupControl groupControl2;
		private DevExpress.XtraEditors.GroupControl groupControl3;
		private DevExpress.XtraEditors.TextEdit txtKisiId;
		private DevExpress.XtraEditors.TextEdit txtPhoneNumber;
		private DevExpress.XtraEditors.SimpleButton BtnSavePhone;
		private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private DevExpress.XtraEditors.SimpleButton btnPrev;
		private DevExpress.XtraEditors.SimpleButton BtnNext;
		private DevExpress.XtraEditors.TextEdit txtPhoneTag;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private DevExpress.XtraEditors.CheckedComboBoxEdit ChImportantPhone;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
	}
}

