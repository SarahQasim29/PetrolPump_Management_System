namespace PetrolPumpManagementSystem.Forms
{
    partial class FuelReceiptForm
    {
        private System.ComponentModel.IContainer components = null;

        // Header
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        // Main Panel
        private System.Windows.Forms.Panel pnlMain;

        // Receipt Fields
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.ComboBox cmbFuelType;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblReceiptDate;
        private System.Windows.Forms.DateTimePicker dtpReceiptDate;

        // Buttons
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;

        // Search
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;

        // Grid
        private System.Windows.Forms.DataGridView dgvReceipts;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.cmbFuelType = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblReceiptDate = new System.Windows.Forms.Label();
            this.dtpReceiptDate = new System.Windows.Forms.DateTimePicker();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvReceipts = new System.Windows.Forms.DataGridView();

            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipts)).BeginInit();
            this.SuspendLayout();

            // ============================================================
            // pnlHeader
            // ============================================================
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 85;
            this.pnlHeader.Name = "pnlHeader";

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(30, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "FUEL RECEIPTS";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitle.Location = new System.Drawing.Point(32, 52);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Record fuel purchases from suppliers";

            // ============================================================
            // pnlMain
            // ============================================================
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.lblSupplier);
            this.pnlMain.Controls.Add(this.cmbSupplier);
            this.pnlMain.Controls.Add(this.lblFuelType);
            this.pnlMain.Controls.Add(this.cmbFuelType);
            this.pnlMain.Controls.Add(this.lblQuantity);
            this.pnlMain.Controls.Add(this.txtQuantity);
            this.pnlMain.Controls.Add(this.lblPurchasePrice);
            this.pnlMain.Controls.Add(this.txtPurchasePrice);
            this.pnlMain.Controls.Add(this.lblTotalAmount);
            this.pnlMain.Controls.Add(this.txtTotalAmount);
            this.pnlMain.Controls.Add(this.lblReceiptDate);
            this.pnlMain.Controls.Add(this.dtpReceiptDate);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Height = 220;
            this.pnlMain.Name = "pnlMain";

            // Supplier
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSupplier.Location = new System.Drawing.Point(30, 20);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Text = "Supplier:";

            this.cmbSupplier.Location = new System.Drawing.Point(150, 16);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(300, 33);
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Fuel Type
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFuelType.Location = new System.Drawing.Point(500, 20);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Text = "Fuel Type:";

            this.cmbFuelType.Location = new System.Drawing.Point(620, 16);
            this.cmbFuelType.Name = "cmbFuelType";
            this.cmbFuelType.Size = new System.Drawing.Size(200, 33);
            this.cmbFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Quantity
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQuantity.Location = new System.Drawing.Point(30, 70);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Text = "Quantity (L):";

            this.txtQuantity.Location = new System.Drawing.Point(150, 66);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 31);
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);

            // Purchase Price
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPurchasePrice.Location = new System.Drawing.Point(500, 70);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Text = "Price (Rs/L):";

            this.txtPurchasePrice.Location = new System.Drawing.Point(620, 66);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(200, 31);
            this.txtPurchasePrice.TextChanged += new System.EventHandler(this.txtPurchasePrice_TextChanged);

            // Total Amount
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.Location = new System.Drawing.Point(30, 120);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Text = "Total Amount (Rs):";

            this.txtTotalAmount.Location = new System.Drawing.Point(150, 116);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(300, 31);
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            // Receipt Date
            this.lblReceiptDate.AutoSize = true;
            this.lblReceiptDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReceiptDate.Location = new System.Drawing.Point(500, 120);
            this.lblReceiptDate.Name = "lblReceiptDate";
            this.lblReceiptDate.Text = "Receipt Date:";

            this.dtpReceiptDate.Location = new System.Drawing.Point(620, 116);
            this.dtpReceiptDate.Name = "dtpReceiptDate";
            this.dtpReceiptDate.Size = new System.Drawing.Size(200, 31);
            this.dtpReceiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // ============================================================
            // pnlActions
            // ============================================================
            this.pnlActions.BackColor = System.Drawing.Color.White;
            this.pnlActions.Controls.Add(this.btnSave);
            this.pnlActions.Controls.Add(this.btnUpdate);
            this.pnlActions.Controls.Add(this.btnDelete);
            this.pnlActions.Controls.Add(this.btnClear);
            this.pnlActions.Controls.Add(this.btnRefresh);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActions.Height = 55;
            this.pnlActions.Name = "pnlActions";

            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(30, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(140, 10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Enabled = false;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(250, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Enabled = false;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClear.Location = new System.Drawing.Point(360, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRefresh.Location = new System.Drawing.Point(470, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 35);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // ============================================================
            // pnlSearch
            // ============================================================
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Height = 55;
            this.pnlSearch.Name = "pnlSearch";

            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(30, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Text = "Search Receipts:";

            this.txtSearch.Location = new System.Drawing.Point(180, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(400, 31);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            // ============================================================
            // dgvReceipts
            // ============================================================
            this.dgvReceipts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReceipts.Location = new System.Drawing.Point(0, 415);
            this.dgvReceipts.Name = "dgvReceipts";
            this.dgvReceipts.Size = new System.Drawing.Size(1000, 230);
            this.dgvReceipts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceipts_CellClick);

            // ============================================================
            // FuelReceiptForm
            // ============================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1000, 645);
            this.Controls.Add(this.dgvReceipts);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1000, 645);
            this.Name = "FuelReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fuel Receipts";

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipts)).EndInit();
            this.ResumeLayout(false);
        }
    }
}