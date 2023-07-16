using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegularGraphs
{
    public partial class Inqury : Form
    {
        string str;
        public Inqury()
        {
            str = "";
            str += "Программа предназначена для исследования диаметров\n";
            str += "связных регулярных графов\n\n";
            str += "Для решения поставленной задачи программа генерирует\n";
            str += "все возможные регулярные графы с заданными количеством\n";
            str += "и степенью вершин. \n\n";
            str += "Диаметр возможно найти только у связных графов, \n";
            str += "поэтому при нажатии на кнопку \"Расчитать диаметры\" \n";
            str += "все несвязные графы автоматически удаляются.\n\n";
            str += "Так как алгоритм генерации очень трудоёмкий,\n";
            str += "количество задаваемых вершин ограничено 7.";
            InitializeComponent();
            richTextBox1.Text = str;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
