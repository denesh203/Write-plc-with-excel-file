using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ActUtlTypeLib;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ActUtlType plc = new ActUtlType();
        private void Openbtn_Click(object sender, EventArgs e)
        {

            if (dataGridView1.RowCount == 0)
            {
                string file = ""; //variable for the Excel File Location
                DataTable dt = new DataTable(); //container for our excel data
                DataRow row;
                DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK) // Check if Result == "OK".
                {
                    file = openFileDialog1.FileName; //get the filename with the location of the file
                    try
                    {
                        //Create Object for Microsoft.Office.Interop.Excel that will be use to read excel file

                        Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();

                        Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(file);

                        Microsoft.Office.Interop.Excel._Worksheet excelWorksheet = excelWorkbook.Sheets[1];

                        Microsoft.Office.Interop.Excel.Range excelRange = excelWorksheet.UsedRange;

                        int rowCount = excelRange.Rows.Count; //get row count of excel data

                        int colCount = excelRange.Columns.Count; // get column count of excel data

                        //Get the first Column of excel file which is the Column Name

                        for (int i = 1; i <= rowCount; i++)
                        {
                            for (int j = 1; j <= colCount; j++)
                            {
                                dt.Columns.Add(excelRange.Cells[i, j].Value2.ToString());
                            }
                            break;
                        }

                        //Get Row Data of Excel

                        int rowCounter; //This variable is used for row index number
                        for (int i = 2; i <= rowCount; i++) //Loop for available row of excel data
                        {
                            row = dt.NewRow(); //assign new row to DataTable
                            rowCounter = 0;
                            for (int j = 1; j <= colCount; j++) //Loop for available column of excel data
                            {
                                //check if cell is empty
                                if (excelRange.Cells[i, j] != null && excelRange.Cells[i, j].Value2 != null)
                                {
                                    row[rowCounter] = excelRange.Cells[i, j].Value2.ToString();
                                }
                                else
                                {
                                    row[i] = "";
                                }
                                rowCounter++;
                            }
                            dt.Rows.Add(row); //add row to DataTable
                        }

                        dataGridView1.DataSource = dt; //assign DataTable as Datasource for DataGridview

                        //close and clean excel process
                        //GC.Collect();
                        //GC.WaitForPendingFinalizers();
                        //Marshal.ReleaseComObject(excelRange);
                        //Marshal.ReleaseComObject(excelWorksheet);
                        ////quit apps
                        //excelWorkbook.Close();
                        //Marshal.ReleaseComObject(excelWorkbook);
                        //excelApp.Quit();
                        //Marshal.ReleaseComObject(excelApp);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                Cmtbox.Text = "最初に既存のデータを削除して下さい";
                Cmtbox.BackColor = Color.Yellow;
            }
        }

        private void Dbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                DialogResult dialogResult = MessageBox.Show("削除してよろしいですか Yes/No", "Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    dataGridView1.DataSource = null;
                    Cmtbox.Text = "データの削除に成功しました";
                    Cmtbox.BackColor = Color.Green;
                }
            }
            else
            {
                Cmtbox.Text = "削除するデータがありません";
                Cmtbox.BackColor = Color.Yellow;
            }
        }

        private void DDbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0 && Header.Text!="")
            {
                if (dataGridView1.Columns.Contains(Header.Text) == true)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                    dataGridView1.Columns.Remove(Header.Text);
                    // dataGridView1.Columns.Remove("型式");
                    // dataGridView1.Columns.Remove("IDENT");
                }
                else
                {
                    Cmtbox.Text = "列ヘッダーありません";
                    Cmtbox.BackColor = Color.Yellow;
                }
            }
            else
            {
                Cmtbox.Text = "削除するデータがありません";
                Cmtbox.BackColor = Color.Yellow;
            }
            Header.Text = "";
        }
        int conn;
        private void Connbtn_Click(object sender, EventArgs e)
        {
            plc.ActLogicalStationNumber = 5;
            conn = this.plc.Open();
            if (conn == 0)
            {
                Cmtbox.Text = "接続しました";
                Cmtbox.BackColor = Color.Green;
                //  Writebtn.BackColor = Color.Green;
                Lamp.BackColor = Color.Red;
                label11.Text = "PLC ON";
            }
            else
            {
                Cmtbox.Text = "接続を解除してください";
                Cmtbox.BackColor = Color.Yellow;
                // Writebtn.BackColor = Color.Yellow;
            }
        }

        private void Disbtn_Click(object sender, EventArgs e)
        {
            if (plc.ActLogicalStationNumber == 5)
            {
                plc.Close();
                Cmtbox.BackColor = Color.Yellow;
                Cmtbox.Text = "切断しました";
                plc.ActLogicalStationNumber = 0;
                //  Writebtn.BackColor = Color.Yellow;
                Lamp.BackColor = Color.Gray;
                label11.Text = "PLC OFF";



            }
            else
            {
                Cmtbox.Text = "エラー : 接続解除に失敗しました";
                Cmtbox.BackColor = Color.Yellow;



            }
        }

        private void Writebtn_Click(object sender, EventArgs e)
        {
            
            if (plc.ActLogicalStationNumber == 5)
            {
                if (dataGridView1.RowCount>0)
                {
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            plc.SetDevice(dataGridView1.Columns[j].HeaderText.ToString(), Convert.ToInt16(dataGridView1.Rows[i].Cells[j].Value.ToString()));
                            Thread.Sleep(200);
                        }
                    }
                }
                else
                {
                    Cmtbox.Text = "エラーデータありませんでした";
                    Cmtbox.BackColor = Color.Yellow;
                }
            }
            else
            {
                Cmtbox.Text = "エラー : 接続解除に失敗しました";
                Cmtbox.BackColor = Color.Yellow;

            }
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            if (Cmtbox.Text != "")
            {
                Cmtbox.Text = "";
                Cmtbox.BackColor = Color.Gray;
            }
            else
            {
                // MessageBox.Show("コメント無し");
                Cmtbox.Text = "コメント無し";
                Cmtbox.BackColor = Color.Yellow;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label65.Text = DateTime.Now.ToString(" yyyy年M月d日");
            Lamp.BackColor = Color.Gray;
        }
    }
}
