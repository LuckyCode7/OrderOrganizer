namespace OrderOrganizer
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LoadDatabaseBT = new System.Windows.Forms.Button();
            this.OrdersGridView = new System.Windows.Forms.DataGridView();
            this.Client_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Request_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportNameTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GenerateReportPB = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.SelectedClientTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MultipleDataGB = new System.Windows.Forms.GroupBox();
            this.ToTXT = new System.Windows.Forms.TextBox();
            this.FromTXT = new System.Windows.Forms.TextBox();
            this.ToL = new System.Windows.Forms.Label();
            this.FromL = new System.Windows.Forms.Label();
            this.OrdersInPriceRangeCB = new System.Windows.Forms.CheckBox();
            this.ListOfAllOrdersCB = new System.Windows.Forms.CheckBox();
            this.SortingBoxGB = new System.Windows.Forms.GroupBox();
            this.PriceOptionGB = new System.Windows.Forms.CheckBox();
            this.QuantityOptionCB = new System.Windows.Forms.CheckBox();
            this.NameOptionCB = new System.Windows.Forms.CheckBox();
            this.RequestIdOptionCB = new System.Windows.Forms.CheckBox();
            this.ClienIdOptioCB = new System.Windows.Forms.CheckBox();
            this.SingleDataGB = new System.Windows.Forms.GroupBox();
            this.QuantityOfAllOrdersCB = new System.Windows.Forms.CheckBox();
            this.TotalAmountOfOrdersCB = new System.Windows.Forms.CheckBox();
            this.NumberOfOrdersGroupedByNameCB = new System.Windows.Forms.CheckBox();
            this.AverageValueOfOrderCB = new System.Windows.Forms.CheckBox();
            this.SelectFileBT = new System.Windows.Forms.Button();
            this.pathTXT = new System.Windows.Forms.TextBox();
            this.ClearDatabaseBT = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.LoadFilesTabPage = new System.Windows.Forms.TabPage();
            this.InvalidOrdersGridView = new System.Windows.Forms.DataGridView();
            this.InvalidOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.VisualisationTabPage = new System.Windows.Forms.TabPage();
            this.ReportTabPage = new System.Windows.Forms.TabPage();
            this.ReportsElementsGB = new System.Windows.Forms.GroupBox();
            this.GeneratePB = new System.Windows.Forms.PictureBox();
            this.ReportPB = new System.Windows.Forms.PictureBox();
            this.VisualPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerateReportPB)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.MultipleDataGB.SuspendLayout();
            this.SortingBoxGB.SuspendLayout();
            this.SingleDataGB.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.LoadFilesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvalidOrdersGridView)).BeginInit();
            this.VisualisationTabPage.SuspendLayout();
            this.ReportTabPage.SuspendLayout();
            this.ReportsElementsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeneratePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisualPB)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadDatabaseBT
            // 
            this.LoadDatabaseBT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoadDatabaseBT.FlatAppearance.BorderSize = 0;
            this.LoadDatabaseBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadDatabaseBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoadDatabaseBT.ForeColor = System.Drawing.Color.White;
            this.LoadDatabaseBT.Location = new System.Drawing.Point(14, 235);
            this.LoadDatabaseBT.Name = "LoadDatabaseBT";
            this.LoadDatabaseBT.Size = new System.Drawing.Size(258, 27);
            this.LoadDatabaseBT.TabIndex = 0;
            this.LoadDatabaseBT.Text = "Load database";
            this.LoadDatabaseBT.UseVisualStyleBackColor = false;
            this.LoadDatabaseBT.Click += new System.EventHandler(this.LoadDatabaseBT_Click);
            // 
            // OrdersGridView
            // 
            this.OrdersGridView.AllowUserToAddRows = false;
            this.OrdersGridView.AllowUserToDeleteRows = false;
            this.OrdersGridView.AllowUserToResizeColumns = false;
            this.OrdersGridView.AllowUserToResizeRows = false;
            this.OrdersGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.OrdersGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrdersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.OrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client_ID,
            this.Request_ID,
            this.Name_,
            this.Quantity,
            this.Price});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrdersGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.OrdersGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrdersGridView.Location = new System.Drawing.Point(6, 6);
            this.OrdersGridView.Name = "OrdersGridView";
            this.OrdersGridView.ReadOnly = true;
            this.OrdersGridView.RowHeadersWidth = 27;
            this.OrdersGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OrdersGridView.Size = new System.Drawing.Size(827, 293);
            this.OrdersGridView.TabIndex = 2;
            // 
            // Client_ID
            // 
            this.Client_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Client_ID.HeaderText = "Client ID";
            this.Client_ID.Name = "Client_ID";
            this.Client_ID.ReadOnly = true;
            this.Client_ID.Width = 160;
            // 
            // Request_ID
            // 
            this.Request_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Request_ID.HeaderText = "Request ID";
            this.Request_ID.Name = "Request_ID";
            this.Request_ID.ReadOnly = true;
            this.Request_ID.Width = 160;
            // 
            // Name_
            // 
            this.Name_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Name_.HeaderText = "Name";
            this.Name_.Name = "Name_";
            this.Name_.ReadOnly = true;
            this.Name_.Width = 160;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 160;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 160;
            // 
            // ReportNameTXT
            // 
            this.ReportNameTXT.Location = new System.Drawing.Point(633, 118);
            this.ReportNameTXT.Name = "ReportNameTXT";
            this.ReportNameTXT.Size = new System.Drawing.Size(173, 21);
            this.ReportNameTXT.TabIndex = 9;
            this.ReportNameTXT.Text = "ExampleName";
            this.ReportNameTXT.Click += new System.EventHandler(this.ReportNameTXT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(534, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Report name: ";
            // 
            // GenerateReportPB
            // 
            this.GenerateReportPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GenerateReportPB.Image = ((System.Drawing.Image)(resources.GetObject("GenerateReportPB.Image")));
            this.GenerateReportPB.Location = new System.Drawing.Point(531, 160);
            this.GenerateReportPB.Name = "GenerateReportPB";
            this.GenerateReportPB.Size = new System.Drawing.Size(281, 49);
            this.GenerateReportPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GenerateReportPB.TabIndex = 7;
            this.GenerateReportPB.TabStop = false;
            this.GenerateReportPB.Click += new System.EventHandler(this.GenerateReportPB_Click);
            this.GenerateReportPB.MouseEnter += new System.EventHandler(this.GenerateReportPB_MouseEnter);
            this.GenerateReportPB.MouseLeave += new System.EventHandler(this.GenerateReportPB_MouseLeave);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.SelectedClientTXT);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(528, 33);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(284, 62);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Individual client data (optional)";
            // 
            // SelectedClientTXT
            // 
            this.SelectedClientTXT.Location = new System.Drawing.Point(105, 24);
            this.SelectedClientTXT.Name = "SelectedClientTXT";
            this.SelectedClientTXT.Size = new System.Drawing.Size(173, 21);
            this.SelectedClientTXT.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select client ID: ";
            // 
            // MultipleDataGB
            // 
            this.MultipleDataGB.Controls.Add(this.ToTXT);
            this.MultipleDataGB.Controls.Add(this.FromTXT);
            this.MultipleDataGB.Controls.Add(this.ToL);
            this.MultipleDataGB.Controls.Add(this.FromL);
            this.MultipleDataGB.Controls.Add(this.OrdersInPriceRangeCB);
            this.MultipleDataGB.Controls.Add(this.ListOfAllOrdersCB);
            this.MultipleDataGB.Location = new System.Drawing.Point(271, 33);
            this.MultipleDataGB.Name = "MultipleDataGB";
            this.MultipleDataGB.Size = new System.Drawing.Size(251, 113);
            this.MultipleDataGB.TabIndex = 6;
            this.MultipleDataGB.TabStop = false;
            this.MultipleDataGB.Text = "Multiple data";
            // 
            // ToTXT
            // 
            this.ToTXT.Location = new System.Drawing.Point(49, 88);
            this.ToTXT.Name = "ToTXT";
            this.ToTXT.Size = new System.Drawing.Size(112, 21);
            this.ToTXT.TabIndex = 9;
            this.ToTXT.Text = "100.00";
            this.ToTXT.Visible = false;
            // 
            // FromTXT
            // 
            this.FromTXT.Location = new System.Drawing.Point(49, 65);
            this.FromTXT.Name = "FromTXT";
            this.FromTXT.Size = new System.Drawing.Size(112, 21);
            this.FromTXT.TabIndex = 7;
            this.FromTXT.Text = "0.00";
            this.FromTXT.Visible = false;
            // 
            // ToL
            // 
            this.ToL.AutoSize = true;
            this.ToL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ToL.Location = new System.Drawing.Point(3, 89);
            this.ToL.Name = "ToL";
            this.ToL.Size = new System.Drawing.Size(31, 16);
            this.ToL.TabIndex = 8;
            this.ToL.Text = "To: ";
            this.ToL.Visible = false;
            // 
            // FromL
            // 
            this.FromL.AutoSize = true;
            this.FromL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FromL.Location = new System.Drawing.Point(3, 66);
            this.FromL.Name = "FromL";
            this.FromL.Size = new System.Drawing.Size(45, 16);
            this.FromL.TabIndex = 7;
            this.FromL.Text = "From: ";
            this.FromL.Visible = false;
            // 
            // OrdersInPriceRangeCB
            // 
            this.OrdersInPriceRangeCB.AutoSize = true;
            this.OrdersInPriceRangeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OrdersInPriceRangeCB.Location = new System.Drawing.Point(6, 42);
            this.OrdersInPriceRangeCB.Name = "OrdersInPriceRangeCB";
            this.OrdersInPriceRangeCB.Size = new System.Drawing.Size(152, 20);
            this.OrdersInPriceRangeCB.TabIndex = 5;
            this.OrdersInPriceRangeCB.Text = "Orders in price range";
            this.OrdersInPriceRangeCB.UseVisualStyleBackColor = true;
            this.OrdersInPriceRangeCB.CheckedChanged += new System.EventHandler(this.OrdersInPriceRangeCB_CheckedChanged);
            // 
            // ListOfAllOrdersCB
            // 
            this.ListOfAllOrdersCB.AutoSize = true;
            this.ListOfAllOrdersCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListOfAllOrdersCB.Location = new System.Drawing.Point(6, 19);
            this.ListOfAllOrdersCB.Name = "ListOfAllOrdersCB";
            this.ListOfAllOrdersCB.Size = new System.Drawing.Size(120, 20);
            this.ListOfAllOrdersCB.TabIndex = 2;
            this.ListOfAllOrdersCB.Text = "List of all orders";
            this.ListOfAllOrdersCB.UseVisualStyleBackColor = true;
            this.ListOfAllOrdersCB.CheckedChanged += new System.EventHandler(this.ListOfAllOrdersCB_CheckedChanged);
            // 
            // SortingBoxGB
            // 
            this.SortingBoxGB.Controls.Add(this.PriceOptionGB);
            this.SortingBoxGB.Controls.Add(this.QuantityOptionCB);
            this.SortingBoxGB.Controls.Add(this.NameOptionCB);
            this.SortingBoxGB.Controls.Add(this.RequestIdOptionCB);
            this.SortingBoxGB.Controls.Add(this.ClienIdOptioCB);
            this.SortingBoxGB.Location = new System.Drawing.Point(14, 152);
            this.SortingBoxGB.Name = "SortingBoxGB";
            this.SortingBoxGB.Size = new System.Drawing.Size(508, 57);
            this.SortingBoxGB.TabIndex = 5;
            this.SortingBoxGB.TabStop = false;
            this.SortingBoxGB.Text = "Group orders by";
            // 
            // PriceOptionGB
            // 
            this.PriceOptionGB.AutoSize = true;
            this.PriceOptionGB.Enabled = false;
            this.PriceOptionGB.Location = new System.Drawing.Point(412, 23);
            this.PriceOptionGB.Name = "PriceOptionGB";
            this.PriceOptionGB.Size = new System.Drawing.Size(54, 19);
            this.PriceOptionGB.TabIndex = 5;
            this.PriceOptionGB.Text = "Price";
            this.PriceOptionGB.UseVisualStyleBackColor = true;
            this.PriceOptionGB.CheckedChanged += new System.EventHandler(this.PriceOptionGB_CheckedChanged);
            // 
            // QuantityOptionCB
            // 
            this.QuantityOptionCB.AutoSize = true;
            this.QuantityOptionCB.Enabled = false;
            this.QuantityOptionCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuantityOptionCB.Location = new System.Drawing.Point(306, 23);
            this.QuantityOptionCB.Name = "QuantityOptionCB";
            this.QuantityOptionCB.Size = new System.Drawing.Size(75, 20);
            this.QuantityOptionCB.TabIndex = 4;
            this.QuantityOptionCB.Text = "Quantity";
            this.QuantityOptionCB.UseVisualStyleBackColor = true;
            this.QuantityOptionCB.CheckedChanged += new System.EventHandler(this.QuantityOptionCB_CheckedChanged);
            // 
            // NameOptionCB
            // 
            this.NameOptionCB.AutoSize = true;
            this.NameOptionCB.Enabled = false;
            this.NameOptionCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameOptionCB.Location = new System.Drawing.Point(222, 23);
            this.NameOptionCB.Name = "NameOptionCB";
            this.NameOptionCB.Size = new System.Drawing.Size(64, 20);
            this.NameOptionCB.TabIndex = 3;
            this.NameOptionCB.Text = "Name";
            this.NameOptionCB.UseVisualStyleBackColor = true;
            this.NameOptionCB.CheckedChanged += new System.EventHandler(this.NameOptionCB_CheckedChanged);
            // 
            // RequestIdOptionCB
            // 
            this.RequestIdOptionCB.AutoSize = true;
            this.RequestIdOptionCB.Enabled = false;
            this.RequestIdOptionCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RequestIdOptionCB.Location = new System.Drawing.Point(97, 23);
            this.RequestIdOptionCB.Name = "RequestIdOptionCB";
            this.RequestIdOptionCB.Size = new System.Drawing.Size(94, 20);
            this.RequestIdOptionCB.TabIndex = 2;
            this.RequestIdOptionCB.Text = "Request ID";
            this.RequestIdOptionCB.UseVisualStyleBackColor = true;
            this.RequestIdOptionCB.CheckedChanged += new System.EventHandler(this.RequestIdOptionCB_CheckedChanged);
            // 
            // ClienIdOptioCB
            // 
            this.ClienIdOptioCB.AutoSize = true;
            this.ClienIdOptioCB.Enabled = false;
            this.ClienIdOptioCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClienIdOptioCB.Location = new System.Drawing.Point(6, 23);
            this.ClienIdOptioCB.Name = "ClienIdOptioCB";
            this.ClienIdOptioCB.Size = new System.Drawing.Size(76, 20);
            this.ClienIdOptioCB.TabIndex = 1;
            this.ClienIdOptioCB.Text = "Client ID";
            this.ClienIdOptioCB.UseVisualStyleBackColor = true;
            this.ClienIdOptioCB.CheckedChanged += new System.EventHandler(this.ClienIdOptioCB_CheckedChanged);
            // 
            // SingleDataGB
            // 
            this.SingleDataGB.Controls.Add(this.QuantityOfAllOrdersCB);
            this.SingleDataGB.Controls.Add(this.TotalAmountOfOrdersCB);
            this.SingleDataGB.Controls.Add(this.NumberOfOrdersGroupedByNameCB);
            this.SingleDataGB.Controls.Add(this.AverageValueOfOrderCB);
            this.SingleDataGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SingleDataGB.Location = new System.Drawing.Point(14, 33);
            this.SingleDataGB.Name = "SingleDataGB";
            this.SingleDataGB.Size = new System.Drawing.Size(251, 113);
            this.SingleDataGB.TabIndex = 6;
            this.SingleDataGB.TabStop = false;
            this.SingleDataGB.Text = "Single data";
            // 
            // QuantityOfAllOrdersCB
            // 
            this.QuantityOfAllOrdersCB.AutoSize = true;
            this.QuantityOfAllOrdersCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuantityOfAllOrdersCB.Location = new System.Drawing.Point(6, 19);
            this.QuantityOfAllOrdersCB.Name = "QuantityOfAllOrdersCB";
            this.QuantityOfAllOrdersCB.Size = new System.Drawing.Size(148, 20);
            this.QuantityOfAllOrdersCB.TabIndex = 0;
            this.QuantityOfAllOrdersCB.Text = "Quantity of all orders";
            this.QuantityOfAllOrdersCB.UseVisualStyleBackColor = true;
            // 
            // TotalAmountOfOrdersCB
            // 
            this.TotalAmountOfOrdersCB.AutoSize = true;
            this.TotalAmountOfOrdersCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TotalAmountOfOrdersCB.Location = new System.Drawing.Point(6, 42);
            this.TotalAmountOfOrdersCB.Name = "TotalAmountOfOrdersCB";
            this.TotalAmountOfOrdersCB.Size = new System.Drawing.Size(161, 20);
            this.TotalAmountOfOrdersCB.TabIndex = 1;
            this.TotalAmountOfOrdersCB.Text = "Total amount of orders";
            this.TotalAmountOfOrdersCB.UseVisualStyleBackColor = true;
            // 
            // NumberOfOrdersGroupedByNameCB
            // 
            this.NumberOfOrdersGroupedByNameCB.AutoSize = true;
            this.NumberOfOrdersGroupedByNameCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumberOfOrdersGroupedByNameCB.Location = new System.Drawing.Point(6, 88);
            this.NumberOfOrdersGroupedByNameCB.Name = "NumberOfOrdersGroupedByNameCB";
            this.NumberOfOrdersGroupedByNameCB.Size = new System.Drawing.Size(240, 20);
            this.NumberOfOrdersGroupedByNameCB.TabIndex = 4;
            this.NumberOfOrdersGroupedByNameCB.Text = "Number of orders grouped by name";
            this.NumberOfOrdersGroupedByNameCB.UseVisualStyleBackColor = true;
            // 
            // AverageValueOfOrderCB
            // 
            this.AverageValueOfOrderCB.AutoSize = true;
            this.AverageValueOfOrderCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AverageValueOfOrderCB.Location = new System.Drawing.Point(6, 65);
            this.AverageValueOfOrderCB.Name = "AverageValueOfOrderCB";
            this.AverageValueOfOrderCB.Size = new System.Drawing.Size(164, 20);
            this.AverageValueOfOrderCB.TabIndex = 3;
            this.AverageValueOfOrderCB.Text = "Average value of order";
            this.AverageValueOfOrderCB.UseVisualStyleBackColor = true;
            // 
            // SelectFileBT
            // 
            this.SelectFileBT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SelectFileBT.FlatAppearance.BorderSize = 0;
            this.SelectFileBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectFileBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SelectFileBT.ForeColor = System.Drawing.Color.White;
            this.SelectFileBT.Location = new System.Drawing.Point(14, 14);
            this.SelectFileBT.Name = "SelectFileBT";
            this.SelectFileBT.Size = new System.Drawing.Size(258, 27);
            this.SelectFileBT.TabIndex = 7;
            this.SelectFileBT.Text = "Select File";
            this.SelectFileBT.UseVisualStyleBackColor = false;
            this.SelectFileBT.Click += new System.EventHandler(this.SelectFileBT_Click);
            // 
            // pathTXT
            // 
            this.pathTXT.BackColor = System.Drawing.SystemColors.Control;
            this.pathTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pathTXT.Location = new System.Drawing.Point(14, 47);
            this.pathTXT.Multiline = true;
            this.pathTXT.Name = "pathTXT";
            this.pathTXT.ReadOnly = true;
            this.pathTXT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.pathTXT.Size = new System.Drawing.Size(258, 182);
            this.pathTXT.TabIndex = 8;
            this.pathTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClearDatabaseBT
            // 
            this.ClearDatabaseBT.BackColor = System.Drawing.Color.IndianRed;
            this.ClearDatabaseBT.FlatAppearance.BorderSize = 0;
            this.ClearDatabaseBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearDatabaseBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClearDatabaseBT.ForeColor = System.Drawing.Color.White;
            this.ClearDatabaseBT.Location = new System.Drawing.Point(14, 268);
            this.ClearDatabaseBT.Name = "ClearDatabaseBT";
            this.ClearDatabaseBT.Size = new System.Drawing.Size(258, 27);
            this.ClearDatabaseBT.TabIndex = 9;
            this.ClearDatabaseBT.Text = "Clear Database";
            this.ClearDatabaseBT.UseVisualStyleBackColor = false;
            this.ClearDatabaseBT.Click += new System.EventHandler(this.ClearDatabaseBT_Click);
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.AllowDrop = true;
            this.tabControl.Controls.Add(this.LoadFilesTabPage);
            this.tabControl.Controls.Add(this.VisualisationTabPage);
            this.tabControl.Controls.Add(this.ReportTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 77);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(847, 331);
            this.tabControl.TabIndex = 13;
            // 
            // LoadFilesTabPage
            // 
            this.LoadFilesTabPage.AllowDrop = true;
            this.LoadFilesTabPage.Controls.Add(this.InvalidOrdersGridView);
            this.LoadFilesTabPage.Controls.Add(this.label2);
            this.LoadFilesTabPage.Controls.Add(this.SelectFileBT);
            this.LoadFilesTabPage.Controls.Add(this.pathTXT);
            this.LoadFilesTabPage.Controls.Add(this.LoadDatabaseBT);
            this.LoadFilesTabPage.Controls.Add(this.ClearDatabaseBT);
            this.LoadFilesTabPage.Location = new System.Drawing.Point(4, 4);
            this.LoadFilesTabPage.Name = "LoadFilesTabPage";
            this.LoadFilesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.LoadFilesTabPage.Size = new System.Drawing.Size(839, 305);
            this.LoadFilesTabPage.TabIndex = 0;
            this.LoadFilesTabPage.Text = "Load external files";
            this.LoadFilesTabPage.UseVisualStyleBackColor = true;
            // 
            // InvalidOrdersGridView
            // 
            this.InvalidOrdersGridView.AllowUserToAddRows = false;
            this.InvalidOrdersGridView.AllowUserToDeleteRows = false;
            this.InvalidOrdersGridView.AllowUserToResizeColumns = false;
            this.InvalidOrdersGridView.AllowUserToResizeRows = false;
            this.InvalidOrdersGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.InvalidOrdersGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InvalidOrdersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.InvalidOrdersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvalidOrdersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvalidOrder});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InvalidOrdersGridView.DefaultCellStyle = dataGridViewCellStyle17;
            this.InvalidOrdersGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InvalidOrdersGridView.Location = new System.Drawing.Point(288, 47);
            this.InvalidOrdersGridView.Name = "InvalidOrdersGridView";
            this.InvalidOrdersGridView.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InvalidOrdersGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.InvalidOrdersGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.InvalidOrdersGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InvalidOrdersGridView.Size = new System.Drawing.Size(534, 182);
            this.InvalidOrdersGridView.TabIndex = 12;
            // 
            // InvalidOrder
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InvalidOrder.DefaultCellStyle = dataGridViewCellStyle16;
            this.InvalidOrder.HeaderText = "Source File: Invalid Order";
            this.InvalidOrder.Name = "InvalidOrder";
            this.InvalidOrder.ReadOnly = true;
            this.InvalidOrder.Width = 534;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(285, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Invalid Orders:";
            // 
            // VisualisationTabPage
            // 
            this.VisualisationTabPage.Controls.Add(this.OrdersGridView);
            this.VisualisationTabPage.Location = new System.Drawing.Point(4, 4);
            this.VisualisationTabPage.Name = "VisualisationTabPage";
            this.VisualisationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.VisualisationTabPage.Size = new System.Drawing.Size(839, 305);
            this.VisualisationTabPage.TabIndex = 2;
            this.VisualisationTabPage.Text = "Visualisation";
            this.VisualisationTabPage.UseVisualStyleBackColor = true;
            // 
            // ReportTabPage
            // 
            this.ReportTabPage.Controls.Add(this.ReportsElementsGB);
            this.ReportTabPage.Location = new System.Drawing.Point(4, 4);
            this.ReportTabPage.Name = "ReportTabPage";
            this.ReportTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ReportTabPage.Size = new System.Drawing.Size(839, 305);
            this.ReportTabPage.TabIndex = 1;
            this.ReportTabPage.Text = "Generate Report";
            this.ReportTabPage.UseVisualStyleBackColor = true;
            // 
            // ReportsElementsGB
            // 
            this.ReportsElementsGB.Controls.Add(this.ReportNameTXT);
            this.ReportsElementsGB.Controls.Add(this.SingleDataGB);
            this.ReportsElementsGB.Controls.Add(this.GenerateReportPB);
            this.ReportsElementsGB.Controls.Add(this.groupBox6);
            this.ReportsElementsGB.Controls.Add(this.SortingBoxGB);
            this.ReportsElementsGB.Controls.Add(this.MultipleDataGB);
            this.ReportsElementsGB.Controls.Add(this.label3);
            this.ReportsElementsGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReportsElementsGB.Location = new System.Drawing.Point(6, 6);
            this.ReportsElementsGB.Name = "ReportsElementsGB";
            this.ReportsElementsGB.Size = new System.Drawing.Size(827, 293);
            this.ReportsElementsGB.TabIndex = 0;
            this.ReportsElementsGB.TabStop = false;
            this.ReportsElementsGB.Text = "Report\'s elements";
            // 
            // GeneratePB
            // 
            this.GeneratePB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GeneratePB.Image = ((System.Drawing.Image)(resources.GetObject("GeneratePB.Image")));
            this.GeneratePB.Location = new System.Drawing.Point(12, 3);
            this.GeneratePB.Name = "GeneratePB";
            this.GeneratePB.Size = new System.Drawing.Size(275, 70);
            this.GeneratePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GeneratePB.TabIndex = 10;
            this.GeneratePB.TabStop = false;
            this.GeneratePB.Click += new System.EventHandler(this.GeneratePB_Click);
            this.GeneratePB.MouseEnter += new System.EventHandler(this.GeneratePB_MouseEnter);
            this.GeneratePB.MouseLeave += new System.EventHandler(this.GeneratePB_MouseLeave);
            // 
            // ReportPB
            // 
            this.ReportPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportPB.Image = ((System.Drawing.Image)(resources.GetObject("ReportPB.Image")));
            this.ReportPB.Location = new System.Drawing.Point(580, 3);
            this.ReportPB.Name = "ReportPB";
            this.ReportPB.Size = new System.Drawing.Size(275, 70);
            this.ReportPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ReportPB.TabIndex = 11;
            this.ReportPB.TabStop = false;
            this.ReportPB.Click += new System.EventHandler(this.ReportPB_Click);
            this.ReportPB.MouseEnter += new System.EventHandler(this.ReportPB_MouseEnter);
            this.ReportPB.MouseLeave += new System.EventHandler(this.ReportPB_MouseLeave);
            // 
            // VisualPB
            // 
            this.VisualPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VisualPB.Image = ((System.Drawing.Image)(resources.GetObject("VisualPB.Image")));
            this.VisualPB.Location = new System.Drawing.Point(293, 3);
            this.VisualPB.Name = "VisualPB";
            this.VisualPB.Size = new System.Drawing.Size(281, 70);
            this.VisualPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VisualPB.TabIndex = 12;
            this.VisualPB.TabStop = false;
            this.VisualPB.Click += new System.EventHandler(this.VisualPB_Click);
            this.VisualPB.MouseEnter += new System.EventHandler(this.VisualPB_MouseEnter);
            this.VisualPB.MouseLeave += new System.EventHandler(this.VisualPB_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 410);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.VisualPB);
            this.Controls.Add(this.ReportPB);
            this.Controls.Add(this.GeneratePB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders Organizer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerateReportPB)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.MultipleDataGB.ResumeLayout(false);
            this.MultipleDataGB.PerformLayout();
            this.SortingBoxGB.ResumeLayout(false);
            this.SortingBoxGB.PerformLayout();
            this.SingleDataGB.ResumeLayout(false);
            this.SingleDataGB.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.LoadFilesTabPage.ResumeLayout(false);
            this.LoadFilesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvalidOrdersGridView)).EndInit();
            this.VisualisationTabPage.ResumeLayout(false);
            this.ReportTabPage.ResumeLayout(false);
            this.ReportsElementsGB.ResumeLayout(false);
            this.ReportsElementsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeneratePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisualPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadDatabaseBT;
        private System.Windows.Forms.DataGridView OrdersGridView;
        private System.Windows.Forms.CheckBox OrdersInPriceRangeCB;
        private System.Windows.Forms.CheckBox NumberOfOrdersGroupedByNameCB;
        private System.Windows.Forms.CheckBox AverageValueOfOrderCB;
        private System.Windows.Forms.CheckBox ListOfAllOrdersCB;
        private System.Windows.Forms.CheckBox TotalAmountOfOrdersCB;
        private System.Windows.Forms.CheckBox QuantityOfAllOrdersCB;
        private System.Windows.Forms.GroupBox MultipleDataGB;
        private System.Windows.Forms.GroupBox SingleDataGB;
        private System.Windows.Forms.GroupBox SortingBoxGB;
        private System.Windows.Forms.CheckBox PriceOptionGB;
        private System.Windows.Forms.CheckBox QuantityOptionCB;
        private System.Windows.Forms.CheckBox NameOptionCB;
        private System.Windows.Forms.CheckBox RequestIdOptionCB;
        private System.Windows.Forms.CheckBox ClienIdOptioCB;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox SelectedClientTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectFileBT;
        private System.Windows.Forms.TextBox pathTXT;
        private System.Windows.Forms.Button ClearDatabaseBT;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage LoadFilesTabPage;
        private System.Windows.Forms.TabPage ReportTabPage;
        private System.Windows.Forms.TabPage VisualisationTabPage;
        private System.Windows.Forms.PictureBox GeneratePB;
        private System.Windows.Forms.PictureBox ReportPB;
        private System.Windows.Forms.PictureBox VisualPB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView InvalidOrdersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvalidOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Request_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.PictureBox GenerateReportPB;
        private System.Windows.Forms.TextBox ReportNameTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ToTXT;
        private System.Windows.Forms.TextBox FromTXT;
        private System.Windows.Forms.Label ToL;
        private System.Windows.Forms.Label FromL;
        private System.Windows.Forms.GroupBox ReportsElementsGB;
    }
}

