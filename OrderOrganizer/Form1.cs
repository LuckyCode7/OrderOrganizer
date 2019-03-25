using OrderOrganizer.cs;
using OrderOrganizer.cs.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace OrderOrganizer
{
    public partial class Form1 : Form
    {
        private OrdersDatabase dataBase;
        private List<string> pathsToFiles;
        private string WorkingDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        private ReportGenerator rp;
        private SoundPlayer player;

        public Form1()
        {
            dataBase = new OrdersDatabase();
            pathsToFiles = new List<string>();
            player = new SoundPlayer(WorkingDirectory + "/Sounds/click.wav");
            InitializeComponent();
        }

        #region Load database 

        private bool IsPathsListEmpty() => pathsToFiles.Count == 0;

        private void LoadDataBaseFromPathsList()
        {
            foreach (var path in pathsToFiles)
            {
                switch (Path.GetExtension(path).ToLower())
                {
                    case ".csv":
                        dataBase.AddOrdersFromExternalFile(new CSVParser(path));
                        break;
                    case ".json":
                        dataBase.AddOrdersFromExternalFile(new JSONParser(path));
                        break;
                    case ".xml":
                        dataBase.AddOrdersFromExternalFile(new XMLParser(path));
                        break;
                }
            }
        }

        private void FillInOrdersDataGridView()
        {
            ClearDataGridView(OrdersGridView);
            foreach (var o in dataBase)
            {
                string[] row = {
                              o.ClientId,
                              o.RequestId.ToString(),
                              o.Name,
                              o.Quantity.ToString(),
                              o.Price.ToString("0.00") };
                OrdersGridView.Rows.Add(row);
            }
        }

        private OpenFileDialog createOpenFileDialog()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Choose your files";
            dlg.Filter = "Files (*.csv; *.json; *.xml)|*.csv; *.json; *.xml";
            dlg.InitialDirectory = WorkingDirectory + "/Orders/";
            return dlg;
        }

        private void AddPathsToExternalDatabaseFiles(string FileName)
        {
            bool pathFlag = true;
            foreach (var path in pathsToFiles)
            {
                if (path == FileName)
                {
                    pathFlag = false;
                    MessageBox.Show("This file was already selected", "Invalid input",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
            if (pathFlag)
            {
                pathsToFiles.Add(FileName);
                ShowLastFile();
            }
        }

        private void LoadDatabaseBT_Click(object sender, EventArgs e)
        {
            if (!IsPathsListEmpty())
            {
                dataBase.Clear();
                LoadDataBaseFromPathsList();
                FillInOrdersDataGridView();
                ShowInvalidOrders();
            }
            else MessageBox.Show("First select any file", "No files selected",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SelectFileBT_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = createOpenFileDialog();
            dlg.ShowDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                AddPathsToExternalDatabaseFiles(dlg.FileName);
        }
        #endregion

        #region Show Database
        private void ShowInvalidOrders()
        {
            ClearDataGridView(InvalidOrdersGridView);
            foreach (var order in dataBase.InvalidOrders)
            {
                InvalidOrdersGridView.Rows.Add(order);
            }
        }

        private void ClearDataGridView(DataGridView datagridView)
        {
            datagridView.Rows.Clear();
            datagridView.Refresh();
        }

        private void ShowLastFile()
        {
            var lastFile = pathsToFiles[pathsToFiles.Count - 1];
            pathTXT.Text += lastFile.Substring(lastFile.LastIndexOf('\\') + 1) + "\r\n";
        }

        private void ClearDatabaseBT_Click(object sender, EventArgs e)
        {
            if (IsPathsListEmpty())
            {
                MessageBox.Show("Your database is empty yet", "Empty database",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (MessageBox.Show("Are you sure you want clear database ? ", "Clear database",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataBase.Clear();
                ClearDataGridView(OrdersGridView);
                ClearDataGridView(InvalidOrdersGridView);
                pathsToFiles.Clear();
                pathTXT.Clear();
            }
        }
        #endregion

        #region Visual methods
        private void GeneratePB_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = LoadFilesTabPage;
            player.Play();
        }

        private void VisualPB_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = VisualisationTabPage;
            player.Play();
        }

        private void ReportPB_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = ReportTabPage;
            player.Play();
        }

        private void GeneratePB_MouseEnter(object sender, EventArgs e)
        {
            GeneratePB.BackColor = System.Drawing.Color.FromArgb(195, 195, 195);
        }

        private void VisualPB_MouseEnter(object sender, EventArgs e)
        {
            VisualPB.BackColor = System.Drawing.Color.FromArgb(195, 195, 195);
        }

        private void ReportPB_MouseEnter(object sender, EventArgs e)
        {
            ReportPB.BackColor = System.Drawing.Color.FromArgb(195, 195, 195);
        }

        private void GeneratePB_MouseLeave(object sender, EventArgs e)
        {
            GeneratePB.BackColor = System.Drawing.Color.FromKnownColor(KnownColor.Control);
        }

        private void VisualPB_MouseLeave(object sender, EventArgs e)
        {
            VisualPB.BackColor = System.Drawing.Color.FromKnownColor(KnownColor.Control);
        }

        private void ReportPB_MouseLeave(object sender, EventArgs e)
        {
            ReportPB.BackColor = System.Drawing.Color.FromKnownColor(KnownColor.Control);
        }

        private void GenerateReportPB_MouseEnter(object sender, EventArgs e)
        {
            GenerateReportPB.BackColor = System.Drawing.Color.FromArgb(195, 195, 195);
        }

        private void GenerateReportPB_MouseLeave(object sender, EventArgs e)
        {
            GenerateReportPB.BackColor = System.Drawing.Color.FromKnownColor(KnownColor.Control);
        }

        private void ReportNameTXT_Click(object sender, EventArgs e)
        {
            ReportNameTXT.Clear();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        #endregion

        #region Generate report
        private void GenerateReportPB_Click(object sender, EventArgs e)
        {
            if (dataBase.IsEmpty())
            {
                MessageBox.Show("First load external files to database", "Empty database",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else AddInformationsToReport();
        }

        private bool CheckIfReportsNameIsNotEmpty()
        {
            if (ReportNameTXT.Text == "")
            {
                MessageBox.Show("First set your report's name", "Report's name",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void AddInformationsToReport()
        {
            if (CheckIfReportsNameIsNotEmpty())
            {
                player.Play();
                rp = new ReportGenerator(ReportNameTXT.Text);
                IterateThroughGroupBox();
                SaveReport();
            }
        }

        private void IterateThroughGroupBox()
        {
            if (CheckSelectedClientID())
            {
                IterateThroughGroupBoxWithCheckBoxes(SingleDataGB, SetSingleDataWhenClienIsSelected,
                                                     SetSingleDataWhenClienIsNotSelected);
                IterateThroughGroupBoxWithCheckBoxes(MultipleDataGB, SetMultipleDataWhenClienIsSelected,
                                                     SetMultipleDataWhenClienIsNotSelected);
            }
        }

        private bool CheckSelectedClientID()
        {
            if ((checkIfCheckBoxesAreChecked(SingleDataGB) || checkIfCheckBoxesAreChecked(MultipleDataGB))
                  && SelectedClientTXT.Text != "" && !dataBase.CheckClientByClientId(SelectedClientTXT.Text))
            {
                MessageBox.Show("There is no ClientID [" + SelectedClientTXT.Text + "] in database",
                    "CliendID error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        private void SaveReport()
        {
            if ((dataBase.CheckClientByClientId(SelectedClientTXT.Text) || (SelectedClientTXT.Text == "")) && CheckPriceFields(0, 0))
            {
                rp.Generate();
                MessageBox.Show("Report has been saved to OrderOrganizer/Reports/"
                                + ReportNameTXT.Text + ".csv", "Report",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool CheckPriceFields(double From, double To)
        {
            return OrderValidator.TrySetPrice(FromTXT.Text, out From) && (OrderValidator.TrySetPrice(ToTXT.Text, out To));
        }

        private void SetSortedLisOfAllOrdersWHenClientIdIsNotSelected()
        {
            rp.Add("List of all orders:");
            if (ClienIdOptioCB.Checked)
                rp.Add(dataBase.GetDatabaseSortedByClientID());
            else if (RequestIdOptionCB.Checked)
                rp.Add(dataBase.GetDatabaseSortedByRequestID());
            else if (NameOptionCB.Checked)
                rp.Add(dataBase.GetDatabaseSortedByName());
            else if (QuantityOptionCB.Checked)
                rp.Add(dataBase.GetDatabaseSortedByQuantity());
            else if (PriceOptionGB.Checked)
                rp.Add(dataBase.GetDatabaseSortedByPrice());
            else rp.Add(dataBase);
        }

        private void SetSortedListOfOrdersInPriceRangeWHenClientIdIsNotSelected(double from, double to)
        {
            rp.Add("List of all orders in price range from " + FromTXT.Text + " to " + ToTXT.Text);
            if (ClienIdOptioCB.Checked)
                rp.Add(dataBase.GetDatabaseFromPriceRange(from, to).GetDatabaseSortedByClientID());
            else if (RequestIdOptionCB.Checked)
                rp.Add(dataBase.GetDatabaseFromPriceRange(from, to).GetDatabaseSortedByRequestID());
            else if (NameOptionCB.Checked)
                rp.Add(dataBase.GetDatabaseFromPriceRange(from, to).GetDatabaseSortedByName());
            else if (QuantityOptionCB.Checked)
                rp.Add(dataBase.GetDatabaseFromPriceRange(from, to).GetDatabaseSortedByQuantity());
            else if (PriceOptionGB.Checked)
                rp.Add(dataBase.GetDatabaseFromPriceRange(from, to).GetDatabaseSortedByPrice());
            else rp.Add(dataBase.GetDatabaseFromPriceRange(from, to));
        }

        private void SetMultipleDataWhenClienIsNotSelected(string checkBoxName)
        {
            switch (checkBoxName)
            {
                case "ListOfAllOrdersCB":
                    SetSortedLisOfAllOrdersWHenClientIdIsNotSelected();
                    break;
                case "OrdersInPriceRangeCB":
                    double From = 0.00;
                    double To = 0.00;
                    if (OrderValidator.TrySetPrice(FromTXT.Text, out From) && (OrderValidator.TrySetPrice(ToTXT.Text, out To)))
                        SetSortedListOfOrdersInPriceRangeWHenClientIdIsNotSelected(From, To);
                    else MessageBox.Show("Set correct price range", "Invalid price range",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void SetSortedLisOfAllOrdersWHenClientIdIsSelected()
        {
            rp.Add("List of all [ClientID: " + SelectedClientTXT.Text + "] orders:");
            if (ClienIdOptioCB.Checked)
                rp.Add(dataBase.GetDatabaseSortedByClientID(SelectedClientTXT.Text));
            else if (RequestIdOptionCB.Checked)
                rp.Add(dataBase.GetDatabaseSortedByRequestID(SelectedClientTXT.Text));
            else if (NameOptionCB.Checked)
                rp.Add(dataBase.GetDatabaseSortedByName(SelectedClientTXT.Text));
            else if (QuantityOptionCB.Checked)
                rp.Add(dataBase.GetDatabaseSortedByQuantity(SelectedClientTXT.Text));
            else if (PriceOptionGB.Checked)
                rp.Add(dataBase.GetDatabaseSortedByPrice(SelectedClientTXT.Text));
            else rp.Add(dataBase.Where(x => x.ClientId == SelectedClientTXT.Text));
        }

        private void SetSortedListOfOrdersInPriceRangeWHenClientIdIsSelected(double from, double to)
        {
            rp.Add("List of all [ClientID:" + SelectedClientTXT.Text + "] orders in price range from " + FromTXT.Text + " to " + ToTXT.Text);
            if (ClienIdOptioCB.Checked)
                rp.Add(dataBase.GetDatabaseFromPriceRange(SelectedClientTXT.Text, from, to).GetDatabaseSortedByClientID());
            else if (RequestIdOptionCB.Checked)
                rp.Add(dataBase.GetDatabaseFromPriceRange(SelectedClientTXT.Text, from, to).GetDatabaseSortedByRequestID());
            else if (NameOptionCB.Checked)
                rp.Add(dataBase.GetDatabaseFromPriceRange(SelectedClientTXT.Text, from, to).GetDatabaseSortedByName());
            else if (QuantityOptionCB.Checked)
                rp.Add(dataBase.GetDatabaseFromPriceRange(SelectedClientTXT.Text, from, to).GetDatabaseSortedByQuantity());
            else if (PriceOptionGB.Checked)
                rp.Add(dataBase.GetDatabaseFromPriceRange(SelectedClientTXT.Text, from, to).GetDatabaseSortedByPrice());
            else rp.Add(dataBase.GetDatabaseFromPriceRange(SelectedClientTXT.Text, from, to));
        }

        private void SetMultipleDataWhenClienIsSelected(string checkBoxName)
        {
            switch (checkBoxName)
            {
                case "ListOfAllOrdersCB":
                    SetSortedLisOfAllOrdersWHenClientIdIsSelected();
                    break;
                case "OrdersInPriceRangeCB":
                    double From = 0.00;
                    double To = 0.00;
                    if (OrderValidator.TrySetPrice(FromTXT.Text, out From) && (OrderValidator.TrySetPrice(ToTXT.Text, out To)))
                        SetSortedListOfOrdersInPriceRangeWHenClientIdIsSelected(From, To);
                    else MessageBox.Show("Set correct price range", "Invalid price range",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        void IterateThroughGroupBoxWithCheckBoxes(GroupBox groupBox, Action<string> AddDataWhenClientIsSelected, Action<string> AddDataWhenClientIsNotSelected)
        {
            foreach (Control element in groupBox.Controls.OfType<CheckBox>())
            {
                var checkBox = (CheckBox)element;
                if (checkBox.Checked)
                {
                    if (SelectedClientTXT.Text != "")
                    {
                        if (dataBase.CheckClientByClientId(SelectedClientTXT.Text))
                            AddDataWhenClientIsSelected(checkBox.Name);
                        else break;
                    }
                    else AddDataWhenClientIsNotSelected(checkBox.Name);
                }
            }
        }

        private void SetSingleDataWhenClienIsSelected(string checkBoxName)
        {
            switch (checkBoxName)
            {
                case "QuantityOfAllOrdersCB":
                    rp.Add("Quantity Of All [ClientID: " + SelectedClientTXT.Text + "] Orders: "
                        + dataBase.GetNumberOfOrders(SelectedClientTXT.Text).ToString());
                    break;
                case "TotalAmountOfOrdersCB":
                    rp.Add("Total Amount Of [ClientID: " + SelectedClientTXT.Text + "] Orders: "
                        + dataBase.GetTotalAmountOfOrders(SelectedClientTXT.Text).ToString());
                    break;
                case "AverageValueOfOrderCB":
                    rp.Add("Average Value Of [ClientID: " + SelectedClientTXT.Text + "] Order: "
                        + dataBase.GetAverageAmountOfOrders(SelectedClientTXT.Text).ToString("0.00"));
                    break;
                case "NumberOfOrdersGroupedByNameCB":
                    rp.Add("Number Of [ClientID:  " + SelectedClientTXT.Text + "] Orders Grouped By Name: "
                        + dataBase.GetNumberOfOrdersGroupedByName(SelectedClientTXT.Text).ToString());
                    break;
            }
        }

        private void SetSingleDataWhenClienIsNotSelected(string checkBoxName)
        {
            switch (checkBoxName)
            {
                case "QuantityOfAllOrdersCB":
                    rp.Add("Quantity Of All Orders: " + dataBase.GetNumberOfOrders().ToString());
                    break;
                case "TotalAmountOfOrdersCB":
                    rp.Add("Total Amount Of Orders: " + dataBase.GetTotalAmountOfOrders().ToString());
                    break;
                case "AverageValueOfOrderCB":
                    rp.Add("Average Value Of Order: " + dataBase.GetAverageAmountOfOrders().ToString("0.00"));
                    break;
                case "NumberOfOrdersGroupedByNameCB":
                    rp.Add("Number Of Orders Grouped By Name: " + dataBase.GetNumberOfOrdersGroupedByName().ToString());
                    break;
            }
        }

        private void SetCheckBoxesCheckStatus(GroupBox groupBox, bool status)
        {
            foreach (Control element in SortingBoxGB.Controls)
            {
                var checkBox = (CheckBox)element;
                checkBox.Checked = status;
            }
        }

        private void SetCheckBoxesEnableStatus(GroupBox groupBox, CheckBox skipIt)
        {
            foreach (Control element in SortingBoxGB.Controls)
            {
                var checkBox = (CheckBox)element;
                if (checkBox == skipIt) continue;
                checkBox.Enabled = false;
            }
        }

        private void SetCheckBoxesEnableStatus(GroupBox groupBox, bool status)
        {
            foreach (Control element in groupBox.Controls)
            {
                var checkBox = (CheckBox)element;
                checkBox.Enabled = status;
            }
        }

        private void SetCheckBoxesEnableStatus(object sender)
        {
            if (((CheckBox)sender).Checked)
                SetCheckBoxesEnableStatus(SortingBoxGB, sender as CheckBox);
            else
                SetCheckBoxesEnableStatus(SortingBoxGB, true);
        }

        private void SetCheckBoxesEnableStatus()
        {
            if (!ListOfAllOrdersCB.Checked && !OrdersInPriceRangeCB.Checked)
            {
                SetCheckBoxesCheckStatus(SortingBoxGB, false);
                SetCheckBoxesEnableStatus(SortingBoxGB, false);
            }
            else if (!checkIfCheckBoxesAreChecked(SortingBoxGB))
                SetCheckBoxesEnableStatus(SortingBoxGB, true);
        }

        private bool checkIfCheckBoxesAreChecked(GroupBox groupBox)
        {
            foreach (Control element in groupBox.Controls)
            {
                if (element is CheckBox)
                {
                    var checkBox = (CheckBox)element;
                    if (checkBox.Checked == true)
                        return true;
                }
            }
            return false;
        }

        private void SetInitialPriceFields()
        {
            FromTXT.Text = "0.00";
            ToTXT.Text = "100.00";
        }

        private void OrdersInPriceRangeCB_CheckedChanged(object sender, EventArgs e)
        {
            SetCheckBoxesEnableStatus();
            if (OrdersInPriceRangeCB.Checked)
                SetPriceRangeVisibility(true);
            else
            {
                SetInitialPriceFields();
                SetPriceRangeVisibility(false);
            }
        }

        private void SetPriceRangeVisibility(bool status)
        {
            FromL.Visible = status;
            FromTXT.Visible = status;
            ToL.Visible = status;
            ToTXT.Visible = status;
        }

        private void ListOfAllOrdersCB_CheckedChanged(object sender, EventArgs e) => SetCheckBoxesEnableStatus();

        private void ClienIdOptioCB_CheckedChanged(object sender, EventArgs e) => SetCheckBoxesEnableStatus(sender);

        private void RequestIdOptionCB_CheckedChanged(object sender, EventArgs e) => SetCheckBoxesEnableStatus(sender);

        private void NameOptionCB_CheckedChanged(object sender, EventArgs e) => SetCheckBoxesEnableStatus(sender);

        private void QuantityOptionCB_CheckedChanged(object sender, EventArgs e) => SetCheckBoxesEnableStatus(sender);

        private void PriceOptionGB_CheckedChanged(object sender, EventArgs e) => SetCheckBoxesEnableStatus(sender);
        #endregion
    }
}