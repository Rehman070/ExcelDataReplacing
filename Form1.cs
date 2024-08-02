using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public string firstSourcePath, secondSourcePath, tezzDeliveryPath;
        public string txtBarcodeColumn, txtPriceColumn, txtMartBColumn;
        public List<ReplaceData> dataToReplaceList = new List<ReplaceData>();
        private ExcelPackage tezzDeliveryPackage;
        private ExcelWorksheet tezzDeliveryWorksheet;

        public Form1()
        {
            InitializeComponent();
            progressBar1.Visible = false;
        }

        private void btnFirstSource_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                firstSourcePath = openFileDialog1.FileName;
                lblFirstSource.Text = firstSourcePath;
            }
        }

        private void btnSecondSource_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                secondSourcePath = openFileDialog2.FileName;
                lblSecondSource.Text = secondSourcePath;
            }
        }

        private void btnTezzDelivery_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                tezzDeliveryPath = openFileDialog3.FileName;
                lblTezzDelivery.Text = tezzDeliveryPath;
            }
        }

        private async void btnReplace_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstSourcePath))
            {
                MessageBox.Show("Please Select a Source File", "File Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtBarcodeColumn = txtBarcodeColumnName.Text;
            txtPriceColumn = txtPriceColumnName.Text;
            txtMartBColumn = txtMartBColumnName.Text;

            if (string.IsNullOrEmpty(txtBarcodeColumn))
            {
                MessageBox.Show("Please Enter Matching Column Names", "Column Name Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else if (string.IsNullOrEmpty(txtPriceColumn))
            {
                MessageBox.Show("Please Enter Replacing Column Names", "Column Name Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else if (string.IsNullOrEmpty(txtMartBColumn))
            {
                MessageBox.Show("Please Enter Comparison Column Names", "Column Name Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Marquee;

            // Add EPPlus Package License
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            await Task.Run(() =>
            {
                // Read the First File Data
                using (ExcelPackage package1 = new ExcelPackage(new FileInfo(firstSourcePath)))
                {
                    try
                    {
                        ExcelWorkbook workbook = package1.Workbook;

                        if (workbook.Worksheets.Count == 0)
                        {
                            MessageBox.Show("Workbook is Empty", "Workbook", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        ExcelWorksheet excelWorksheet1 = workbook.Worksheets[0];

                        if (excelWorksheet1.Dimension == null)
                        {
                            MessageBox.Show("Worksheet is Empty", "Worksheet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        int rows = excelWorksheet1.Dimension.Rows;
                        int columns = excelWorksheet1.Dimension.Columns;

                        // Get the column indexes based on column names
                        int barcodeColumnIndex = -1;
                        int priceColumnIndex = -1;

                        for (int col = 1; col <= columns; col++)
                        {
                            string header = excelWorksheet1.Cells[1, col].Text.Trim();
                            if (header.Equals(txtBarcodeColumn, StringComparison.OrdinalIgnoreCase))
                            {
                                barcodeColumnIndex = col;
                            }
                            else if (header.Equals(txtPriceColumn, StringComparison.OrdinalIgnoreCase))
                            {
                                priceColumnIndex = col;
                            }

                        }

                        if (barcodeColumnIndex == -1 || priceColumnIndex == -1)
                        {
                            MessageBox.Show("Column names not found for Source File.\nPlease check the names and try again.", "Column Name Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Read data from the specified columns
                        for (int row = 2; row <= rows; row++)
                        {
                            var barcode = excelWorksheet1.Cells[row, barcodeColumnIndex].Text;
                            var price = excelWorksheet1.Cells[row, priceColumnIndex].Text;
                            dataToReplaceList.Add(new ReplaceData { BarCode = barcode, Price = price });
                        }

                        // Read data from the matching file
                        ReadMatchingFile();

                        // Read and update Tezz Delivery file
                        UpdateTezzDeliveryFile();
                        // Hide the progress bar immediately after the task is done
                        progressBar1.Visible = false;

                        // Show the completion message
                        MessageBox.Show("Replacement process completed successfully!\nYou can download a file.", "Process Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            });
               
                progressBar1.Visible = false;

            }

            
        }

        private void ReadMatchingFile()
        {
            if (string.IsNullOrEmpty(secondSourcePath))
            {
                MessageBox.Show("Please Select a Matching File", "File Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (ExcelPackage package2 = new ExcelPackage(new FileInfo(secondSourcePath)))
            {
                try
                {
                    ExcelWorkbook workbook = package2.Workbook;

                    if (workbook.Worksheets.Count == 0)
                    {
                        MessageBox.Show("Matching Workbook is Empty", "Workbook", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ExcelWorksheet excelWorksheet2 = workbook.Worksheets[0];

                    if (excelWorksheet2.Dimension == null)
                    {
                        MessageBox.Show("Matching Worksheet is Empty", "Worksheet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int rows = excelWorksheet2.Dimension.Rows;
                    int columns = excelWorksheet2.Dimension.Columns;

                    // Get the column indexes based on column names
                    int productCodeColumnIndex = -1;
                    int tdIdColumnIndex = -1;

                    for (int col = 1; col <= columns; col++)
                    {
                        string header = excelWorksheet2.Cells[1, col].Text.Trim();
                        if (header.Equals(txtMartBColumn, StringComparison.OrdinalIgnoreCase))
                        {
                            productCodeColumnIndex = col;
                        }
                        else if (header.Equals("TDID", StringComparison.OrdinalIgnoreCase))
                        {
                            tdIdColumnIndex = col;
                        }

                    }

                    if (productCodeColumnIndex == -1 || tdIdColumnIndex == -1)
                    {
                        MessageBox.Show("Column names not found Matching File.\nPlease check the names and try again.", "Column Name Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Read data and update the ReplaceData list
                    foreach (var replaceData in dataToReplaceList)
                    {
                        for (int row = 2; row <= rows; row++)
                        {
                            var productCode = excelWorksheet2.Cells[row, productCodeColumnIndex].Text;
                            if (replaceData.BarCode == productCode)
                            {
                                var tdId = excelWorksheet2.Cells[row, tdIdColumnIndex].Text;
                                replaceData.TDID = tdId;
                                break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateTezzDeliveryFile()
        {
            if (string.IsNullOrEmpty(tezzDeliveryPath))
            {
                MessageBox.Show("Please Select a Tezz Delivery File", "File Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Initialize the ExcelPackage without disposing it
                tezzDeliveryPackage = new ExcelPackage(new FileInfo(tezzDeliveryPath));
                ExcelWorkbook workbook = tezzDeliveryPackage.Workbook;

                if (workbook.Worksheets.Count == 0)
                {
                    MessageBox.Show("Tezz Delivery Workbook is Empty", "Workbook", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                tezzDeliveryWorksheet = workbook.Worksheets[0];

                if (tezzDeliveryWorksheet.Dimension == null)
                {
                    MessageBox.Show("Tezz Delivery Worksheet is Empty", "Worksheet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int rows = tezzDeliveryWorksheet.Dimension.Rows;
                int columns = tezzDeliveryWorksheet.Dimension.Columns;

                // Get the column indexes based on column names
                int tdIdColumnIndex = -1;
                int priceColumnIndex = -1;

                for (int col = 1; col <= columns; col++)
                {
                    string header = tezzDeliveryWorksheet.Cells[1, col].Text.Trim();
                    if (header.Equals("TDID", StringComparison.OrdinalIgnoreCase))
                    {
                        tdIdColumnIndex = col;
                    }
                    else if (header.Equals("Price", StringComparison.OrdinalIgnoreCase))
                    {
                        priceColumnIndex = col;
                    }

                }

                if (tdIdColumnIndex == -1 || priceColumnIndex == -1)
                {
                    MessageBox.Show("Column names not found Replacing File.\nPlease check the names and try again.", "Column Name Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update prices in the Tezz Delivery file
                for (int row = 2; row <= rows; row++)
                {
                    var tdId = tezzDeliveryWorksheet.Cells[row, tdIdColumnIndex].Text;
                    var replaceData = dataToReplaceList.FirstOrDefault(d => d.TDID == tdId);
                    if (replaceData != null)
                    {
                        tezzDeliveryWorksheet.Cells[row, priceColumnIndex].Value = replaceData.Price;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (tezzDeliveryPackage != null && tezzDeliveryWorksheet != null)
            {
                saveFileDialog1.FileName = "Updated_TezzDelivery.xlsx";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                        {
                            tezzDeliveryPackage.SaveAs(fs);
                        }
                        MessageBox.Show("File downloaded successfully!", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No updated file to download. Please update the data first.", "Download Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblFirstSource.Text = "No file selected";
            lblSecondSource.Text = "No file selected";
            lblTezzDelivery.Text = "No file selected";
            txtBarcodeColumnName.Clear();
            txtPriceColumnName.Clear();
            txtMartBColumnName.Clear();
            firstSourcePath = null;
            secondSourcePath = null;
            tezzDeliveryPath = null;
            dataToReplaceList.Clear();
            saveFileDialog1.FileName = null;
            tezzDeliveryPackage = null;
            tezzDeliveryWorksheet = null;
        }
    }
}
