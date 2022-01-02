using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<ShippingByWeightByTotalRecord> sheetList = null;
        List<ShippingByWeight> sheetList2 = null;
        bool isSuccessful = false;
        string dbConn = null;
        SqlConnection con;

        public Form1()
        {
            InitializeComponent();
        }


        DataTableCollection dataTableCollection;

        private void Browse_Btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Worksheets|*.xlsx" })
            {

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.DataSource = null;

                    textBox_fileName.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            var tables = result.Tables.Cast<DataTable>();
                            dataTableCollection = result.Tables;


                            foreach (DataTable table in tables)
                            {
                                dataGridView1.DataSource = table;
                            }


                            //Data Binding
                            DataTable dt = dataTableCollection[dataGridView1.DataSource.ToString()];
                            if (dt != null)
                            {
                                sheetList = new List<ShippingByWeightByTotalRecord>();
                                sheetList2 = new List<ShippingByWeight>();

                                foreach (DataRow dRow in dt.Rows)
                                {
                                    if (dRow.Table.Columns.Contains("ZoneId")) //ShippingByWeight Exceli gelme durumu
                                    {
                                        ShippingByWeight entity2 = new ShippingByWeight();
                                        entity2.ZoneId = int.Parse(dRow["ZoneId"].ToString());
                                        entity2.From = decimal.Parse(dRow["From"].ToString());
                                        entity2.To = decimal.Parse(dRow["To"].ToString());
                                        entity2.AdditionalFixedCost = decimal.Parse(dRow["AdditionalFixedCost"].ToString());

                                        sheetList2.Add(entity2);
                                        shippingByWeightByTotalRecordBindingSource.DataSource = sheetList2;

                                    }
                                    else //ShippingByWeightByTotalRecord Exceli gelme durumu
                                    {

                                        ShippingByWeightByTotalRecord entity = new ShippingByWeightByTotalRecord();                                   
                                        entity.CountryId = int.Parse(dRow["CountryId"].ToString());
                                        entity.WeightFrom = decimal.Parse(dRow["WeightFrom"].ToString());
                                        entity.WeightTo = decimal.Parse(dRow["WeightTo"].ToString());
                                        entity.AdditionalFixedCost = decimal.Parse(dRow["AdditionalFixedCost"].ToString());
                                        entity.StoreId = int.Parse(dRow["StoreId"].ToString());

                                        sheetList.Add(entity);
                                        shippingByWeightByTotalRecordBindingSource.DataSource = sheetList;
                                    }

                                }
                                dataGridView1.DataSource = dt;

                            }
                        }
                    }

                }

            }
        }

        //Try to connect specified database
        private bool tryConnectDB(string conString)
        {
            try
            {
                using (con = new SqlConnection(conString))
                {
                    con.ConnectionString = conString;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void Import_Btn_Click(object sender, EventArgs e)
        {

            dbConn = textBox_Con.Text != null ? textBox_Con.Text : "Connection String Required";


            //try to connect DB
            bool isLoginSuccess = tryConnectDB(dbConn);

            if (isLoginSuccess)
            {
                //ShippingByWeightByTotalRecord exceli gelme durumu
                if (sheetList != null && sheetList.Count > 0)
                {

                    foreach (var item in sheetList)
                    {
                        var StoreId = item.StoreId;
                        var WarehouseId = item.WarehouseId;
                        var StateProvinceId = item.StateProvinceId;
                        var CountryId = item.CountryId;
                        var Zip = item.Zip;
                        var ShippingMethodId = 5;
                        var OrderSubtotalFrom = item.OrderSubtotalFrom;
                        var OrderSubtotalTo = item.OrderSubtotalTo;
                        var PercentageRateOfSubtotal = item.PercentageRateOfSubtotal;
                        var WeightFrom = item.WeightFrom;
                        var WeightTo = item.WeightTo;
                        var RatePerWeightUnit = item.RatePerWeightUnit;
                        var LowerWeightLimit = item.LowerWeightLimit;
                        var AdditionalFixedCost = item.AdditionalFixedCost;

                        string sp = "ShippingByWeightInsert";

                        using (var con = new SqlConnection(dbConn))
                        {
                            con.ConnectionString = dbConn;
                            con.Execute(sp, new
                            {
                                StoreId,
                                WarehouseId,
                                StateProvinceId,
                                CountryId,
                                Zip,
                                ShippingMethodId,
                                OrderSubtotalFrom,
                                OrderSubtotalTo,
                                PercentageRateOfSubtotal,
                                WeightFrom,
                                WeightTo,
                                RatePerWeightUnit,
                                LowerWeightLimit,
                                AdditionalFixedCost
                            }, commandType: CommandType.StoredProcedure);

                            //Progress Bar
                            progressBar.Maximum = sheetList.Count;
                            progressBar.PerformStep();
                            isSuccessful = true;

                        }
                    }
                }
                //ShippingByWeight exceli gelme durumu
                else if (sheetList2 != null || sheetList2.Count > 0)
                {
                    foreach (var item in sheetList2)
                    {
                        var ZoneId = item.ZoneId;
                        var Zip = item.Zip;
                        var ShippingMethodId = item.ShippingMethodId;
                        var From = item.From;
                        var To = item.To;
                        var AdditionalFixedCost = item.AdditionalFixedCost;
                        var PercentageRateOfSubtotal = item.PercentageRateOfSubtotal;
                        var RatePerWeightUnit = item.RatePerWeightUnit;
                        var LowerWeightLimit = item.LowerWeightLimit;
                        var StoreId = item.StoreId;

                        string sp = "ShippingByWeightInsert";

                        using (var con = new SqlConnection(dbConn))
                        {
                            con.ConnectionString = dbConn;
                            con.Execute(sp, new
                            {
                                ZoneId,
                                Zip,
                                ShippingMethodId,
                                From,
                                To,
                                AdditionalFixedCost,
                                PercentageRateOfSubtotal,
                                RatePerWeightUnit,
                                LowerWeightLimit,
                                StoreId

                            }, commandType: CommandType.StoredProcedure);

                            //Progress Bar
                            progressBar.Maximum = sheetList.Count;
                            progressBar.PerformStep();
                            isSuccessful = true;
                        }
                    }
                }

                if (isSuccessful)
                {
                    MessageBox.Show("Successful");
                    textBox_fileName.Clear();
                    textBox_Con.Clear();

                }
            }
        }

    }
}
