namespace PetrolPumpManagementSystem.Forms
{
    partial class StockForm
    {
        private System.ComponentModel.IContainer components = null;

        // Header
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        // Summary
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblTotalStockSummary;
        private System.Windows.Forms.Label lblFuelTypes;
        private System.Windows.Forms.Label lblLowStock;

        // Main Panel
        private System.Windows.Forms.Panel pnlMain;

        // Fuel Selection
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.ComboBox cmbFuel;

        // Opening Stock (Editable - with Save button)
        private System.Windows.Forms.Label lblOpeningStock;
        private System.Windows.Forms.TextBox txtOpeningStock;
        private System.Windows.Forms.Button btnSaveOpening;

        // Received Stock (READONLY - auto-loads from FuelReceipts)
        private System.Windows.Forms.Label lblReceivedStock;
        private System.Windows.Forms.TextBox txtReceivedStock;

        // Total Stock (READONLY)
        private System.Windows.Forms.Label lblTotalStock;
        private System.Windows.Forms.TextBox txtTotalStock;

        // Today's Sales (READONLY - from DipEntries)
        private System.Windows.Forms.Label lblTodaySales;
        private System.Windows.Forms.TextBox txtTodaySales;

        // Closing Stock (READONLY)
        private System.Windows.Forms.Label lblClosingStock;
        private System.Windows.Forms.TextBox txtClosingStock;

        // Physical Dip (READONLY - from DipEntries)
        private System.Windows.Forms.Label lblPhysicalDip;
        private System.Windows.Forms.TextBox txtPhysicalDip;

        // Difference (READONLY)
        private System.Windows.Forms.Label lblDifference;
        private System.Windows.Forms.TextBox txtDifference;

        // Buttons
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;

        // Grid
        private System.Windows.Forms.DataGridView dgvStock;

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
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblTotalStockSummary = new System.Windows.Forms.Label();
            this.lblFuelTypes = new System.Windows.Forms.Label();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblFuel = new System.Windows.Forms.Label();
            this.cmbFuel = new System.Windows.Forms.ComboBox();
            this.lblOpeningStock = new System.Windows.Forms.Label();
            this.txtOpeningStock = new System.Windows.Forms.TextBox();
            this.btnSaveOpening = new System.Windows.Forms.Button();
            this.lblReceivedStock = new System.Windows.Forms.Label();
            this.txtReceivedStock = new System.Windows.Forms.TextBox();
            this.lblTotalStock = new System.Windows.Forms.Label();
            this.txtTotalStock = new System.Windows.Forms.TextBox();
            this.lblTodaySales = new System.Windows.Forms.Label();
            this.txtTodaySales = new System.Windows.Forms.TextBox();
            this.lblClosingStock = new System.Windows.Forms.Label();
            this.txtClosingStock = new System.Windows.Forms.TextBox();
            this.lblPhysicalDip = new System.Windows.Forms.Label();
            this.txtPhysicalDip = new System.Windows.Forms.TextBox();
            this.lblDifference = new System.Windows.Forms.Label();
            this.txtDifference = new System.Windows.Forms.TextBox();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvStock = new System.Windows.Forms.DataGridView();

            this.pnlHeader.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
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
            this.lblTitle.Text = "STOCK MANAGEMENT";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitle.Location = new System.Drawing.Point(32, 52);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "View stock levels and manage opening stock";

            // ============================================================
            // pnlSummary
            // ============================================================
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.pnlSummary.Controls.Add(this.lblTotalStockSummary);
            this.pnlSummary.Controls.Add(this.lblFuelTypes);
            this.pnlSummary.Controls.Add(this.lblLowStock);
            this.pnlSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSummary.Height = 55;
            this.pnlSummary.Name = "pnlSummary";

            this.lblTotalStockSummary.AutoSize = true;
            this.lblTotalStockSummary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalStockSummary.Location = new System.Drawing.Point(30, 15);
            this.lblTotalStockSummary.Name = "lblTotalStockSummary";
            this.lblTotalStockSummary.Text = "Total Stock: 0 L";

            this.lblFuelTypes.AutoSize = true;
            this.lblFuelTypes.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblFuelTypes.Location = new System.Drawing.Point(250, 15);
            this.lblFuelTypes.Name = "lblFuelTypes";
            this.lblFuelTypes.Text = "Fuel Types: 0";

            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLowStock.Location = new System.Drawing.Point(470, 15);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Text = "⚠️ Low Stock Items: 0";

            // ============================================================
            // pnlMain
            // ============================================================
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.lblFuel);
            this.pnlMain.Controls.Add(this.cmbFuel);
            this.pnlMain.Controls.Add(this.lblOpeningStock);
            this.pnlMain.Controls.Add(this.txtOpeningStock);
            this.pnlMain.Controls.Add(this.btnSaveOpening);
            this.pnlMain.Controls.Add(this.lblReceivedStock);
            this.pnlMain.Controls.Add(this.txtReceivedStock);
            this.pnlMain.Controls.Add(this.lblTotalStock);
            this.pnlMain.Controls.Add(this.txtTotalStock);
            this.pnlMain.Controls.Add(this.lblTodaySales);
            this.pnlMain.Controls.Add(this.txtTodaySales);
            this.pnlMain.Controls.Add(this.lblClosingStock);
            this.pnlMain.Controls.Add(this.txtClosingStock);
            this.pnlMain.Controls.Add(this.lblPhysicalDip);
            this.pnlMain.Controls.Add(this.txtPhysicalDip);
            this.pnlMain.Controls.Add(this.lblDifference);
            this.pnlMain.Controls.Add(this.txtDifference);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Height = 260;
            this.pnlMain.Name = "pnlMain";

            // Fuel
            this.lblFuel.AutoSize = true;
            this.lblFuel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFuel.Location = new System.Drawing.Point(30, 20);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Text = "Fuel Type:";

            this.cmbFuel.Location = new System.Drawing.Point(150, 16);
            this.cmbFuel.Name = "cmbFuel";
            this.cmbFuel.Size = new System.Drawing.Size(200, 33);
            this.cmbFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuel.SelectedIndexChanged += new System.EventHandler(this.cmbFuel_SelectedIndexChanged);

            // OPENING STOCK - EDITABLE (Initial Setup Only)
            this.lblOpeningStock.AutoSize = true;
            this.lblOpeningStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOpeningStock.Location = new System.Drawing.Point(30, 70);
            this.lblOpeningStock.Name = "lblOpeningStock";
            this.lblOpeningStock.Text = "Opening Stock (L):";

            this.txtOpeningStock.Location = new System.Drawing.Point(200, 66);
            this.txtOpeningStock.Name = "txtOpeningStock";
            this.txtOpeningStock.Size = new System.Drawing.Size(200, 31);
            this.txtOpeningStock.BackColor = System.Drawing.Color.White;
            this.txtOpeningStock.TextChanged += new System.EventHandler(this.txtOpeningStock_TextChanged);

            this.btnSaveOpening.Location = new System.Drawing.Point(410, 64);
            this.btnSaveOpening.Name = "btnSaveOpening";
            this.btnSaveOpening.Size = new System.Drawing.Size(100, 35);
            this.btnSaveOpening.Text = "Save";
            this.btnSaveOpening.UseVisualStyleBackColor = true;
            this.btnSaveOpening.Click += new System.EventHandler(this.btnSaveOpening_Click);

            // RECEIVED STOCK - READONLY (Auto-loads from FuelReceipts)
            this.lblReceivedStock.AutoSize = true;
            this.lblReceivedStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReceivedStock.Location = new System.Drawing.Point(30, 115);
            this.lblReceivedStock.Name = "lblReceivedStock";
            this.lblReceivedStock.Text = "Received Stock (L):";

            this.txtReceivedStock.Location = new System.Drawing.Point(200, 111);
            this.txtReceivedStock.Name = "txtReceivedStock";
            this.txtReceivedStock.Size = new System.Drawing.Size(200, 31);
            this.txtReceivedStock.ReadOnly = true;
            this.txtReceivedStock.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            // TOTAL STOCK - READONLY
            this.lblTotalStock.AutoSize = true;
            this.lblTotalStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalStock.Location = new System.Drawing.Point(30, 160);
            this.lblTotalStock.Name = "lblTotalStock";
            this.lblTotalStock.Text = "Total Stock (L):";

            this.txtTotalStock.Location = new System.Drawing.Point(200, 156);
            this.txtTotalStock.Name = "txtTotalStock";
            this.txtTotalStock.Size = new System.Drawing.Size(200, 31);
            this.txtTotalStock.ReadOnly = true;
            this.txtTotalStock.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            // TODAY'S SALES - READONLY (From DipEntries)
            this.lblTodaySales.AutoSize = true;
            this.lblTodaySales.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTodaySales.Location = new System.Drawing.Point(500, 70);
            this.lblTodaySales.Name = "lblTodaySales";
            this.lblTodaySales.Text = "Today's Sales (L):";

            this.txtTodaySales.Location = new System.Drawing.Point(660, 66);
            this.txtTodaySales.Name = "txtTodaySales";
            this.txtTodaySales.Size = new System.Drawing.Size(200, 31);
            this.txtTodaySales.ReadOnly = true;
            this.txtTodaySales.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            // CLOSING STOCK - READONLY
            this.lblClosingStock.AutoSize = true;
            this.lblClosingStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblClosingStock.Location = new System.Drawing.Point(500, 115);
            this.lblClosingStock.Name = "lblClosingStock";
            this.lblClosingStock.Text = "Closing Stock (L):";

            this.txtClosingStock.Location = new System.Drawing.Point(660, 111);
            this.txtClosingStock.Name = "txtClosingStock";
            this.txtClosingStock.Size = new System.Drawing.Size(200, 31);
            this.txtClosingStock.ReadOnly = true;
            this.txtClosingStock.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            // PHYSICAL DIP - READONLY (From DipEntries)
            this.lblPhysicalDip.AutoSize = true;
            this.lblPhysicalDip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhysicalDip.Location = new System.Drawing.Point(500, 160);
            this.lblPhysicalDip.Name = "lblPhysicalDip";
            this.lblPhysicalDip.Text = "Physical Dip (L):";

            this.txtPhysicalDip.Location = new System.Drawing.Point(660, 156);
            this.txtPhysicalDip.Name = "txtPhysicalDip";
            this.txtPhysicalDip.Size = new System.Drawing.Size(200, 31);
            this.txtPhysicalDip.ReadOnly = true;
            this.txtPhysicalDip.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            // DIFFERENCE - READONLY
            this.lblDifference.AutoSize = true;
            this.lblDifference.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDifference.Location = new System.Drawing.Point(500, 205);
            this.lblDifference.Name = "lblDifference";
            this.lblDifference.Text = "Difference (L):";

            this.txtDifference.Location = new System.Drawing.Point(660, 201);
            this.txtDifference.Name = "txtDifference";
            this.txtDifference.Size = new System.Drawing.Size(200, 31);
            this.txtDifference.ReadOnly = true;
            this.txtDifference.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);

            // ============================================================
            // pnlActions
            // ============================================================
            this.pnlActions.BackColor = System.Drawing.Color.White;
            this.pnlActions.Controls.Add(this.btnCalculate);
            this.pnlActions.Controls.Add(this.btnRefresh);
            this.pnlActions.Controls.Add(this.btnClear);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActions.Height = 55;
            this.pnlActions.Name = "pnlActions";

            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.Location = new System.Drawing.Point(30, 10);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 35);
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(170, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 35);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClear.Location = new System.Drawing.Point(310, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // ============================================================
            // dgvStock
            // ============================================================
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStock.ColumnHeadersHeight = 40;
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.EnableHeadersVisualStyles = false;
            this.dgvStock.Location = new System.Drawing.Point(0, 455);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(1000, 190);
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellClick);

            // ============================================================
            // StockForm
            // ============================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1000, 645);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1000, 645);
            this.Name = "StockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stock Management";

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
        }
    }
}