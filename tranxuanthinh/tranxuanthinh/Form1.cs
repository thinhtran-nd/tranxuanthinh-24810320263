using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tranxuanthinh
{
    public partial class Form1 : Form
    {
        private List<Product> masterProducts = new List<Product>();
        private BindingList<Product> viewList;
        private BindingSource bindingSource = new BindingSource();
        private string selectedImagePath = null;

        public Form1()
        {
            InitializeComponent();
            InitializeGridColumns();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // setup initial binding
            viewList = new BindingList<Product>(masterProducts);
            bindingSource.DataSource = viewList;
            dgvProducts.DataSource = bindingSource;

            // initial categories already added in designer
            UpdateStatusCount();
        }

        private void InitializeGridColumns()
        {
            dgvProducts.Columns.Clear();

            var colId = new DataGridViewTextBoxColumn { DataPropertyName = "ProductId", HeaderText = "Mã SP" };
            var colName = new DataGridViewTextBoxColumn { DataPropertyName = "ProductName", HeaderText = "Tên SP" };
            var colCat = new DataGridViewTextBoxColumn { DataPropertyName = "Category", HeaderText = "Danh mục" };
            var colPrice = new DataGridViewTextBoxColumn { DataPropertyName = "UnitPrice", HeaderText = "Đơn giá" };
            var colQty = new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "Số lượng" };

            colPrice.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colCat, colPrice, colQty });
        }

        private void tableLayoutMain_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                try
                {
                    picAvatar.Image?.Dispose();
                    picAvatar.Image = System.Drawing.Image.FromFile(selectedImagePath);
                }
                catch
                {
                    MessageBox.Show("Không thể nạp ảnh.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    selectedImagePath = null;
                }
            }
        }

        private bool ValidateInputs()
        {
            bool ok = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                errorProvider.SetError(txtProductName, "Tên SP không được để trống.");
                ok = false;
            }

            if (!decimal.TryParse(txtUnitPrice.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal price) || price <= 0)
            {
                errorProvider.SetError(txtUnitPrice, "Đơn giá phải là số lớn hơn 0.");
                ok = false;
            }

            if (!int.TryParse(txtQuantity.Text, out int qty) || qty < 0)
            {
                errorProvider.SetError(txtQuantity, "Số lượng phải là số nguyên >= 0.");
                ok = false;
            }

            return ok;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var product = new Product
            {
                ProductId = txtProductId.Text.Trim(),
                ProductName = txtProductName.Text.Trim(),
                Category = cboCategory.Text,
                UnitPrice = decimal.Parse(txtUnitPrice.Text, NumberStyles.Number),
                Quantity = int.Parse(txtQuantity.Text),
                ImagePath = selectedImagePath
            };

            masterProducts.Add(product);
            ApplyFilter();
            ClearInputs();
            UpdateStatusCount();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;
            if (!ValidateInputs()) return;

            var current = dgvProducts.CurrentRow.DataBoundItem as Product;
            if (current == null) return;

            current.ProductId = txtProductId.Text.Trim();
            current.ProductName = txtProductName.Text.Trim();
            current.Category = cboCategory.Text;
            current.UnitPrice = decimal.Parse(txtUnitPrice.Text, NumberStyles.Number);
            current.Quantity = int.Parse(txtQuantity.Text);
            current.ImagePath = selectedImagePath;

            // refresh grid
            dgvProducts.Refresh();
            UpdateStatusCount();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            var current = dgvProducts.CurrentRow.DataBoundItem as Product;
            if (current == null) return;

            var dr = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                masterProducts.Remove(current);
                ApplyFilter();
                ClearInputs();
                UpdateStatusCount();
            }
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                ClearInputs();
                return;
            }

            var current = dgvProducts.CurrentRow.DataBoundItem as Product;
            if (current == null) return;

            txtProductId.Text = current.ProductId;
            txtProductName.Text = current.ProductName;
            cboCategory.Text = current.Category;
            txtUnitPrice.Text = current.UnitPrice.ToString("N0");
            txtQuantity.Text = current.Quantity.ToString();
            selectedImagePath = current.ImagePath;
            try
            {
                picAvatar.Image?.Dispose();
                picAvatar.Image = string.IsNullOrEmpty(selectedImagePath) || !File.Exists(selectedImagePath)
                    ? null
                    : System.Drawing.Image.FromFile(selectedImagePath);
            }
            catch { }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string q = txtSearch.Text?.Trim().ToLowerInvariant();
            IEnumerable<Product> filtered = masterProducts;
            if (!string.IsNullOrEmpty(q)) filtered = masterProducts.Where(p => (p.ProductName ?? "").ToLowerInvariant().Contains(q));

            viewList = new BindingList<Product>(filtered.ToList());
            bindingSource.DataSource = viewList;
            dgvProducts.DataSource = bindingSource;
            UpdateStatusCount();
        }

        private void UpdateStatusCount()
        {
            toolStripStatusLabelCount.Text = $"Tổng số sản phẩm: {masterProducts.Count}";
        }

        private void ClearInputs()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            cboCategory.SelectedIndex = -1;
            picAvatar.Image?.Dispose();
            picAvatar.Image = null;
            selectedImagePath = null;
            errorProvider.Clear();
        }

        private void exportCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (masterProducts.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm để xuất.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                using (var sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                {
                    sw.WriteLine("ProductId,ProductName,Category,UnitPrice,Quantity,ImagePath");
                    foreach (var p in masterProducts)
                    {
                        var line = $"\"{p.ProductId}\",\"{p.ProductName}\",\"{p.Category}\",{p.UnitPrice},{p.Quantity},\"{p.ImagePath}\"";
                        sw.WriteLine(line);
                    }
                }
                MessageBox.Show("Xuất CSV thành công.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi ghi file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvProducts.Columns[e.ColumnIndex].DataPropertyName == "UnitPrice" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal v))
                {
                    e.Value = v.ToString("N0") + " VNĐ";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
