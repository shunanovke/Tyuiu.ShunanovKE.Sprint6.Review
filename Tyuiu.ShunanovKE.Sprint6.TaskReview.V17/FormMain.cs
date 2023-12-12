using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShunanovKE.Sprint6.TaskReview.V17.Lib;

namespace Tyuiu.ShunanovKE.Sprint6.TaskReview.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] array;
        private void buttonGetMatrix_SKE_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBoxN_SKE.Text);
                int m = Convert.ToInt32(textBoxM_SKE.Text);
                int n1 = Convert.ToInt32(textBoxN1_SKE.Text);
                int n2 = Convert.ToInt32(textBoxN2_SKE.Text);
                array = ds.GetRandMatrix(n, m, n1, n2);

                dataGridViewMatrix_SKE.Rows.Clear();
                dataGridViewMatrix_SKE.Columns.Clear();

                dataGridViewMatrix_SKE.RowCount = n;
                dataGridViewMatrix_SKE.ColumnCount = m;

                for(int i = 0; i < m; i++)
                {
                    dataGridViewMatrix_SKE.Columns[i].Width = 40;
                }
                for(int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        dataGridViewMatrix_SKE.Rows[i].Cells[j].Value = array[i, j];
                    }
                }
                buttonDone_SKE.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_SKE_Click(object sender, EventArgs e)
        {
            try
            {
                int k = Convert.ToInt32(textBoxK_SKE.Text);
                int l = Convert.ToInt32(textBoxL_SKE.Text);
                int r = Convert.ToInt32(textBoxR_SKE.Text);
                if (k < l)
                {
                    int res = ds.GetMatrix(array, k, l, r);
                    textBoxOutPut_SKE.Text = Convert.ToString(res);
                }
                else MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
