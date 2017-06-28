using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetXMLForBike18Upload
{
    public partial class Form1 : Form
    {
        string fileUrlsAllProducts;
        string fileUrlsNewProducts;
        Thread forms;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenAllProducts_Click(object sender, EventArgs e)
        {
            fileUrlsAllProducts = "";
            ofdAllProducts.ShowDialog();
        }

        private void btnLoadNewProduct_Click(object sender, EventArgs e)
        {
            fileUrlsNewProducts = "";
            ofdNewProduct.ShowDialog();
        }

        private void btnUpdateSLUG_Click(object sender, EventArgs e)
        {
            if (ofdAllProducts.FileName == "openFileDialog1" || ofdAllProducts.FileName == "" || ofdNewProduct.FileName == "openFileDialog1" || ofdNewProduct.FileName == "")
            {
                MessageBox.Show("Ошибка при выборе файла", "Ошибка файла");
                return;
            }
            fileUrlsAllProducts = ofdAllProducts.FileName.ToString();
            fileUrlsNewProducts = ofdNewProduct.FileName.ToString();

            Thread tabl = new Thread(() => UpdateSLUG());
            forms = tabl;
            forms.IsBackground = true;
            forms.Start();
        }

        private void UpdateSLUG()
        {
            ControlsFormEnabledFalse();

            tbHistory.Invoke(new Action(() => tbHistory.AppendText("Идет открытие выгрузки с сайта\n")));

            FileInfo file = new FileInfo(fileUrlsAllProducts);
            ExcelPackage p = new ExcelPackage(file);
            ExcelWorksheet w = p.Workbook.Worksheets[1];
            int q = w.Dimension.Rows;

            tbHistory.Invoke(new Action(() => tbHistory.AppendText("Количество строк в файле = " + q + "\n")));

            tbHistory.Invoke(new Action(() => tbHistory.AppendText("Идет открытие файла для загрузки\n")));

            string[] newTovars = File.ReadAllLines(fileUrlsNewProducts, Encoding.GetEncoding(1251));

            tbHistory.Invoke(new Action(() => tbHistory.AppendText("Количество строк в файле = " + newTovars.Length + "\n")));

            ActualSLUG(w, newTovars);

            ControlsFormEnabledTrue();
        }

        private void ActualSLUG(ExcelWorksheet w, string[] newTovars)
        {
            int countAllT = w.Dimension.Rows;

            for (int i = 1; newTovars.Length > i; i++)
            {
                string[] newTovarStr = newTovars[i].ToString().Split(';');
                string slugNewT = newTovarStr[newTovarStr.Length - 5];

                for(int n = 1; countAllT > n; n++)
                {
                    string chpuAllT = (string)w.Cells[i, 3].Value;
                }

            }
        }

        private void ControlsFormEnabledTrue()
        {
            btnLoadNewProduct.Invoke(new Action(() => btnLoadNewProduct.Enabled = true));
            btnOpenAllProducts.Invoke(new Action(() => btnOpenAllProducts.Enabled = true));
            btnUpdateSLUG.Invoke(new Action(() => btnUpdateSLUG.Enabled = true));
        }

        private void ControlsFormEnabledFalse()
        {
            btnLoadNewProduct.Invoke(new Action(() => btnLoadNewProduct.Enabled = false));
            btnOpenAllProducts.Invoke(new Action(() => btnOpenAllProducts.Enabled = false));
            btnUpdateSLUG.Invoke(new Action(() => btnUpdateSLUG.Enabled = false));
        }
    }
}
