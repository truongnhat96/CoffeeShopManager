namespace GUI
{
    partial class fStockManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStockManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNotifyadm = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnHistoryImport = new System.Windows.Forms.Button();
            this.btnRemoveproduct = new System.Windows.Forms.Button();
            this.btnEditproduct = new System.Windows.Forms.Button();
            this.dtgvProducts = new System.Windows.Forms.DataGridView();
            this.txtProductname = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.txtSuppliername = new System.Windows.Forms.TextBox();
            this.lblSupplierView = new System.Windows.Forms.LinkLabel();
            this.lblProductname = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDateimport = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDateimport = new System.Windows.Forms.DateTimePicker();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "close (1).png");
            this.imageList1.Images.SetKeyName(1, "close-button.png");
            this.imageList1.Images.SetKeyName(2, "bin.png");
            this.imageList1.Images.SetKeyName(3, "edit.png");
            this.imageList1.Images.SetKeyName(4, "document.png");
            this.imageList1.Images.SetKeyName(5, "delivery-man.png");
            this.imageList1.Images.SetKeyName(6, "error-7-24.ico");
            this.imageList1.Images.SetKeyName(7, "warning-sign.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblNotifyadm);
            this.panel1.Controls.Add(this.lblAdmin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSuppliers);
            this.panel1.Controls.Add(this.btnHistoryImport);
            this.panel1.Controls.Add(this.btnRemoveproduct);
            this.panel1.Controls.Add(this.btnEditproduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 675);
            this.panel1.TabIndex = 1;
            // 
            // lblNotifyadm
            // 
            this.lblNotifyadm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotifyadm.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblNotifyadm.ImageIndex = 7;
            this.lblNotifyadm.ImageList = this.imageList1;
            this.lblNotifyadm.Location = new System.Drawing.Point(3, 575);
            this.lblNotifyadm.Name = "lblNotifyadm";
            this.lblNotifyadm.Size = new System.Drawing.Size(303, 100);
            this.lblNotifyadm.TabIndex = 3;
            this.lblNotifyadm.Text = "Vui lòng điền thông tin mặt hàng cẩn thận trước khi thực hiện Sửa/Xóa mặt hàng";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAdmin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.Red;
            this.lblAdmin.Location = new System.Drawing.Point(0, 652);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(277, 23);
            this.lblAdmin.TabIndex = 2;
            this.lblAdmin.Text = "Chức Năng Chỉ Dành Cho Admin!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.Transparent;
            this.btnSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnSuppliers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppliers.ImageIndex = 5;
            this.btnSuppliers.ImageList = this.imageList1;
            this.btnSuppliers.Location = new System.Drawing.Point(3, 477);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(303, 54);
            this.btnSuppliers.TabIndex = 0;
            this.btnSuppliers.Text = "Nhà Cung Cấp";
            this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnHistoryImport
            // 
            this.btnHistoryImport.BackColor = System.Drawing.Color.Transparent;
            this.btnHistoryImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistoryImport.FlatAppearance.BorderSize = 0;
            this.btnHistoryImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnHistoryImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btnHistoryImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoryImport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoryImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistoryImport.ImageIndex = 4;
            this.btnHistoryImport.ImageList = this.imageList1;
            this.btnHistoryImport.Location = new System.Drawing.Point(0, 373);
            this.btnHistoryImport.Name = "btnHistoryImport";
            this.btnHistoryImport.Size = new System.Drawing.Size(306, 54);
            this.btnHistoryImport.TabIndex = 0;
            this.btnHistoryImport.Text = "Lịch Sử Nhập Hàng";
            this.btnHistoryImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistoryImport.UseVisualStyleBackColor = false;
            this.btnHistoryImport.Click += new System.EventHandler(this.btnHistoryImport_Click);
            // 
            // btnRemoveproduct
            // 
            this.btnRemoveproduct.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveproduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveproduct.FlatAppearance.BorderSize = 0;
            this.btnRemoveproduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnRemoveproduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btnRemoveproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveproduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveproduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveproduct.ImageIndex = 2;
            this.btnRemoveproduct.ImageList = this.imageList1;
            this.btnRemoveproduct.Location = new System.Drawing.Point(3, 270);
            this.btnRemoveproduct.Name = "btnRemoveproduct";
            this.btnRemoveproduct.Size = new System.Drawing.Size(303, 54);
            this.btnRemoveproduct.TabIndex = 0;
            this.btnRemoveproduct.Text = "Xóa Mặt Hàng";
            this.btnRemoveproduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveproduct.UseVisualStyleBackColor = false;
            this.btnRemoveproduct.Click += new System.EventHandler(this.btnRemoveproduct_Click);
            // 
            // btnEditproduct
            // 
            this.btnEditproduct.BackColor = System.Drawing.Color.Transparent;
            this.btnEditproduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditproduct.FlatAppearance.BorderSize = 0;
            this.btnEditproduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.NavajoWhite;
            this.btnEditproduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.NavajoWhite;
            this.btnEditproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditproduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditproduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditproduct.ImageIndex = 3;
            this.btnEditproduct.ImageList = this.imageList1;
            this.btnEditproduct.Location = new System.Drawing.Point(3, 166);
            this.btnEditproduct.Name = "btnEditproduct";
            this.btnEditproduct.Size = new System.Drawing.Size(303, 54);
            this.btnEditproduct.TabIndex = 0;
            this.btnEditproduct.Text = "Sửa Thông Tin SP";
            this.btnEditproduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditproduct.UseVisualStyleBackColor = false;
            this.btnEditproduct.Click += new System.EventHandler(this.btnEditproduct_Click);
            // 
            // dtgvProducts
            // 
            this.dtgvProducts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvProducts.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgvProducts.Location = new System.Drawing.Point(315, 138);
            this.dtgvProducts.Name = "dtgvProducts";
            this.dtgvProducts.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvProducts.RowHeadersWidth = 51;
            this.dtgvProducts.RowTemplate.Height = 24;
            this.dtgvProducts.Size = new System.Drawing.Size(712, 364);
            this.dtgvProducts.TabIndex = 2;
            this.dtgvProducts.SelectionChanged += new System.EventHandler(this.dtgvProducts_SelectionChanged);
            // 
            // txtProductname
            // 
            this.txtProductname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductname.Location = new System.Drawing.Point(1218, 138);
            this.txtProductname.Name = "txtProductname";
            this.txtProductname.Size = new System.Drawing.Size(223, 30);
            this.txtProductname.TabIndex = 3;
            // 
            // txtUnit
            // 
            this.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.Location = new System.Drawing.Point(1218, 266);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(223, 30);
            this.txtUnit.TabIndex = 3;
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(470, 525);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(388, 61);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Nhập Hàng";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtSuppliername
            // 
            this.txtSuppliername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSuppliername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuppliername.Location = new System.Drawing.Point(1218, 405);
            this.txtSuppliername.Name = "txtSuppliername";
            this.txtSuppliername.Size = new System.Drawing.Size(223, 30);
            this.txtSuppliername.TabIndex = 3;
            // 
            // lblSupplierView
            // 
            this.lblSupplierView.AutoSize = true;
            this.lblSupplierView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierView.Location = new System.Drawing.Point(652, 641);
            this.lblSupplierView.Name = "lblSupplierView";
            this.lblSupplierView.Size = new System.Drawing.Size(368, 25);
            this.lblSupplierView.TabIndex = 5;
            this.lblSupplierView.TabStop = true;
            this.lblSupplierView.Text = "Xem danh sách nhà cung cấp có sẵn";
            this.lblSupplierView.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSupplierView_LinkClicked);
            // 
            // lblProductname
            // 
            this.lblProductname.AutoSize = true;
            this.lblProductname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductname.Location = new System.Drawing.Point(1047, 140);
            this.lblProductname.Name = "lblProductname";
            this.lblProductname.Size = new System.Drawing.Size(129, 28);
            this.lblProductname.TabIndex = 6;
            this.lblProductname.Text = "Tên mặt hàng";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(1047, 201);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(92, 28);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "Số lượng";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(1047, 268);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(108, 28);
            this.lblUnit.TabIndex = 6;
            this.lblUnit.Text = "Đơn vị tính";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(1047, 331);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(79, 28);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Giá tiền";
            // 
            // lblDateimport
            // 
            this.lblDateimport.AutoSize = true;
            this.lblDateimport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateimport.Location = new System.Drawing.Point(1042, 470);
            this.lblDateimport.Name = "lblDateimport";
            this.lblDateimport.Size = new System.Drawing.Size(113, 28);
            this.lblDateimport.TabIndex = 6;
            this.lblDateimport.Text = "Ngày nhập ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1033, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên nhà cung cấp";
            // 
            // dtpDateimport
            // 
            this.dtpDateimport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateimport.Location = new System.Drawing.Point(1173, 470);
            this.dtpDateimport.Name = "dtpDateimport";
            this.dtpDateimport.Size = new System.Drawing.Size(268, 34);
            this.dtpDateimport.TabIndex = 7;
            // 
            // numCount
            // 
            this.numCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCount.Location = new System.Drawing.Point(1218, 201);
            this.numCount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(219, 34);
            this.numCount.TabIndex = 8;
            // 
            // numPrice
            // 
            this.numPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPrice.Location = new System.Drawing.Point(1218, 325);
            this.numPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(219, 34);
            this.numPrice.TabIndex = 8;
            this.numPrice.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(525, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Danh Sách Mặt Hàng ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1100, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Thông Tin Mặt Hàng";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ImageIndex = 1;
            this.btnExit.ImageList = this.imageList1;
            this.btnExit.Location = new System.Drawing.Point(1387, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 64);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Crimson;
            this.txtTotal.Location = new System.Drawing.Point(1129, 607);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(207, 38);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1142, 555);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tổng tiền hàng";
            // 
            // fStockManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 675);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.numCount);
            this.Controls.Add(this.dtpDateimport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDateimport);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblProductname);
            this.Controls.Add(this.lblSupplierView);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtSuppliername);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtProductname);
            this.Controls.Add(this.dtgvProducts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fStockManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockManager";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fStockManager_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fStockManager_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fStockManager_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnHistoryImport;
        private System.Windows.Forms.Button btnRemoveproduct;
        private System.Windows.Forms.Button btnEditproduct;
        private System.Windows.Forms.DataGridView dtgvProducts;
        private System.Windows.Forms.TextBox txtProductname;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox txtSuppliername;
        private System.Windows.Forms.LinkLabel lblSupplierView;
        private System.Windows.Forms.Label lblProductname;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDateimport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDateimport;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblNotifyadm;
    }
}