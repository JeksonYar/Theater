using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace L6KalachihinFin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_play_finDataSet7.people". При необходимости она может быть перемещена или удалена.
            this.peopleTableAdapter.Fill(this.bd_play_finDataSet7.people);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            peopleTableAdapter.Update(bd_play_finDataSet7.people);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "При удалении этой строки, Вам необходимо будет удать данные о ней в других таблица.  Желаете продолжить? ";
            String caption = "Предупреждение";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
            {
                // удаляем выделенные строки из dataGridView1
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }
    }
}
