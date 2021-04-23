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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bd_play_finDataSet2.play_in_theater". При необходимости она может быть перемещена или удалена.
            this.play_in_theaterTableAdapter.Fill(this.bd_play_finDataSet2.play_in_theater);

        }


        // кнопка удаления
        private void button2_Click(object sender, EventArgs e)
        {
           
                // удаляем выделенные строки из dataGridView1
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            play_in_theaterTableAdapter.Update(bd_play_finDataSet2.play_in_theater);
        }
    }
}
