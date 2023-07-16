using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenegationRegular;
using ConnectedGraph;

namespace RegularGraphs
{
    public partial class Form1 : Form
    {
        Generator genGraphs;
        ConnectedGraphs conGraphs;
        public Form1()
        {
            InitializeComponent();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((int)numericNodeCount.Value <= (int)numericConnectivity.Value)
            {
                MessageBox.Show("Связность вершин должна быть меньше их количества", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                genGraphs = new Generator((int)numericNodeCount.Value, (int)numericConnectivity.Value);
                genGraphs.GrathGenerate();
                richTextBoxResult.Text = genGraphs.PrintResult(genGraphs.Grapth);
            }
    }


        private void удалитьНесвязныеГрафыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (genGraphs != null)
            {
                conGraphs = new ConnectedGraphs(genGraphs.Grapth, genGraphs.NodeCount);
                conGraphs.deleteNotConnected();
                richTextBoxResult.Text = genGraphs.PrintResult(conGraphs.Graphs);
            }
            else
            {
                MessageBox.Show("Сначала сгенерируйте регулярные графы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void рассчитатьДиаметрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (genGraphs != null)
            {
                    conGraphs = new ConnectedGraphs(genGraphs.Grapth, genGraphs.NodeCount);
                    conGraphs.deleteNotConnected();
                    conGraphs.CalculateDiameters();
                    richTextBoxResult.Text = conGraphs.PrintResult();
                
            }
            else
            {
                MessageBox.Show("Сначала сгенерируйте регулярные графы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ололоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inqury inq = new Inqury();
            inq.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
