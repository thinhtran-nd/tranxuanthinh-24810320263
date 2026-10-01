namespace tranxuanthinh
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
            components = new System.ComponentModel.Container();
            menuStripMain = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exportCsvToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutMain = new TableLayoutPanel();
            pnlInput = new Panel();
            lblCategory = new Label();
            lblQuantity = new Label();
            lblUnitPrice = new Label();
            lblProductName = new Label();
            cboCategory = new ComboBox();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            txtProductName = new TextBox();
            txtProductId = new TextBox();
            lblProductId = new Label();
            lblTitle = new Label();
            picAvatar = new PictureBox();
            btnChooseImage = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            pnlGrid = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            dgvProducts = new DataGridView();
            statusStripMain = new StatusStrip();
            toolStripStatusLabelCount = new ToolStripStatusLabel();
            errorProvider = new ErrorProvider(components);
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            menuStripMain.SuspendLayout();
            tableLayoutMain.SuspendLayout();
            pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            statusStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.ImageScalingSize = new Size(20, 20);
            menuStripMain.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(982, 28);
            menuStripMain.TabIndex = 0;
            menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportCsvToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // exportCsvToolStripMenuItem
            // 
            exportCsvToolStripMenuItem.Name = "exportCsvToolStripMenuItem";
            exportCsvToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            exportCsvToolStripMenuItem.Size = new Size(215, 26);
            exportCsvToolStripMenuItem.Text = "Export CSV";
            exportCsvToolStripMenuItem.Click += exportCsvToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            exitToolStripMenuItem.Size = new Size(215, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 2;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutMain.Controls.Add(pnlInput, 0, 0);
            tableLayoutMain.Controls.Add(pnlGrid, 1, 0);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 28);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 1;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.Size = new Size(982, 525);
            tableLayoutMain.TabIndex = 0;
            tableLayoutMain.Paint += tableLayoutMain_Paint;
            // 
            // pnlInput
            // 
            pnlInput.Controls.Add(lblCategory);
            pnlInput.Controls.Add(lblQuantity);
            pnlInput.Controls.Add(lblUnitPrice);
            pnlInput.Controls.Add(lblProductName);
            pnlInput.Controls.Add(cboCategory);
            pnlInput.Controls.Add(txtQuantity);
            pnlInput.Controls.Add(txtUnitPrice);
            pnlInput.Controls.Add(txtProductName);
            pnlInput.Controls.Add(txtProductId);
            pnlInput.Controls.Add(lblProductId);
            pnlInput.Controls.Add(lblTitle);
            pnlInput.Controls.Add(picAvatar);
            pnlInput.Controls.Add(btnChooseImage);
            pnlInput.Controls.Add(btnAdd);
            pnlInput.Controls.Add(btnUpdate);
            pnlInput.Controls.Add(btnDelete);
            pnlInput.Dock = DockStyle.Fill;
            pnlInput.Location = new Point(3, 3);
            pnlInput.Name = "pnlInput";
            pnlInput.Padding = new Padding(10, 0, 0, 0);
            pnlInput.Size = new Size(337, 519);
            pnlInput.TabIndex = 0;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(10, 155);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(79, 20);
            lblCategory.TabIndex = 11;
            lblCategory.Text = "Danh mục:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(10, 122);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(72, 20);
            lblQuantity.TabIndex = 10;
            lblQuantity.Text = "Số lượng:";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(10, 89);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(65, 20);
            lblUnitPrice.TabIndex = 9;
            lblUnitPrice.Text = "Đơn giá:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(10, 56);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(52, 20);
            lblProductName.TabIndex = 8;
            lblProductName.Text = "Tên SP";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Điện thoại", "Laptop", "Phụ kiện" });
            cboCategory.Location = new Point(80, 152);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(221, 28);
            cboCategory.TabIndex = 7;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(80, 119);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(221, 27);
            txtQuantity.TabIndex = 5;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(80, 86);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(221, 27);
            txtUnitPrice.TabIndex = 4;
            txtUnitPrice.TextChanged += textBox2_TextChanged;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(80, 53);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(238, 27);
            txtProductName.TabIndex = 3;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(80, 23);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(238, 27);
            txtProductId.TabIndex = 2;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(10, 26);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(53, 20);
            lblProductId.TabIndex = 1;
            lblProductId.Text = "Mã SP:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Location = new Point(10, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(166, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Location = new Point(14, 190);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(120, 120);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 12;
            picAvatar.TabStop = false;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Location = new Point(150, 220);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(120, 30);
            btnChooseImage.TabIndex = 12;
            btnChooseImage.Text = "Chọn Ảnh";
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(14, 330);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 30);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Thêm mới";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(110, 330);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(80, 30);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(206, 330);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(80, 30);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // pnlGrid
            // 
            pnlGrid.Controls.Add(lblSearch);
            pnlGrid.Controls.Add(txtSearch);
            pnlGrid.Controls.Add(dgvProducts);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(346, 3);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(10);
            pnlGrid.Size = new Size(633, 519);
            pnlGrid.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(12, 8);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(62, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm tên:";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(90, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(307, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeight = 29;
            dgvProducts.Location = new Point(12, 40);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(607, 392);
            dgvProducts.TabIndex = 2;
            dgvProducts.CellFormatting += dgvProducts_CellFormatting;
            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
            // 
            // statusStripMain
            // 
            statusStripMain.ImageScalingSize = new Size(20, 20);
            statusStripMain.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelCount });
            statusStripMain.Location = new Point(0, 527);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Size = new Size(982, 26);
            statusStripMain.TabIndex = 2;
            // 
            // toolStripStatusLabelCount
            // 
            toolStripStatusLabelCount.Name = "toolStripStatusLabelCount";
            toolStripStatusLabelCount.Size = new Size(145, 20);
            toolStripStatusLabelCount.Text = "Tổng số sản phẩm: 0";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All files|*.*";
            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files|*.*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(statusStripMain);
            Controls.Add(tableLayoutMain);
            Controls.Add(menuStripMain);
            MinimumSize = new Size(1000, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechMart Product Manager";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            tableLayoutMain.ResumeLayout(false);
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            pnlGrid.ResumeLayout(false);
            pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exportCsvToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TableLayoutPanel tableLayoutMain;
        private Panel pnlInput;
        private Label lblTitle;
        private Label lblProductName;
        private ComboBox cboCategory;
        private TextBox txtQuantity;
        private TextBox txtUnitPrice;
        private TextBox txtProductName;
        private TextBox txtProductId;
        private Label lblProductId;
        private Label lblUnitPrice;
        private Label lblQuantity;
        private Label lblCategory;
        private PictureBox picAvatar;
        private Button btnChooseImage;
        private Panel pnlGrid;
        private DataGridView dgvProducts;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private StatusStrip statusStripMain;
        private ToolStripStatusLabel toolStripStatusLabelCount;
        private ErrorProvider errorProvider;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}
