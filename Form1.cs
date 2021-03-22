using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karimova_pr7_IT
{
  public partial class Form1 : Form
  {
    // 4.Найти в каждой строке матрицы минимальный элемент. Выделить максимальное из полученных значений.
    public Form1()
    {
      InitializeComponent();
    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    private void button1_Click(object sender, EventArgs e)
    {
      textBox1.Text = "";
      dataGridView1.RowCount = 5;
      dataGridView1.ColumnCount = 5;
      int[,] a = new int[15, 15];
      int i, j;
      Random rand = new Random();
      for (i = 0; i < 5; i++)
      {
        for (j = 0; j < 5; j++)
        {
          a[i, j] = rand.Next(-100, 100);
        }
      }

      for (i = 0; i < 5; i++)
      {
        for (j = 0; j < 5; j++)
        {
          dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
        }
      }
      int max=-100000000, min;
      int[] mas_min_el = new int[5];
        for(int b = 0; b<5; b++)
        {
          min = a[b, 0];
          for (int c = 0; c < 5; c++)
          {
          if (a[b, c] < min) { min = a[b, c];}
        }
        textBox1.Text += "Минимальный в " + (b + 1) + " строке: " + min + Environment.NewLine;
        if (min > max) { max = min; }
      }
      textBox1.Text += "Максимальный из минимальных: " + max;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
