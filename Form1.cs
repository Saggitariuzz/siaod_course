using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace app
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void rbPartOrd_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPartOrd.Checked)
            {
                nudPercent.Enabled = true;
            }
            else
            {
                nudPercent.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if(!rbArray.Checked && !rbList.Checked && !rbLinkedList.Checked)
            {
                MessageBox.Show("Выберите структуру данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!rbDisord.Checked && !rbOrd.Checked && !rbPartOrd.Checked && !rbBackOrd.Checked)
            {
                MessageBox.Show("Выберите тип упорядоченности", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int size = (int)nudSize.Value;
            if(size <= 0 )
            {
                MessageBox.Show("Размер структуры данных не может быть меньше или равен 0",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if(rbPartOrd.Checked && ((int)nudPercent.Value<=0 || (int)nudPercent.Value > 100))
            {
                MessageBox.Show("Процент упорядоченности должен быть меньше 100 и больше или равен 0",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            chartGrpah.Series[0].Points.Clear();
            chartGrpah.Series[0].Points.AddXY(0, 0);
            chartGrpah.Series[1].Points.Clear();
            chartGrpah.Series[1].Points.AddXY(0, 0);
            chartGrpah.Series[2].Points.Clear();
            chartGrpah.Series[2].Points.AddXY(0, 0);
            if (rbArray.Checked)
            {
                if (rbDisord.Checked)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        int bsort = ArrayConstructor.bubbleSort(ArrayConstructor.createNotOrdered(i * size / 10));
                        int ssort = ArrayConstructor.shakerSort(ArrayConstructor.createNotOrdered(i * size / 10));
                        int savesort = ArrayConstructor.savePositionBubbleSort(ArrayConstructor.createNotOrdered(i * size / 10));
                        resultTable.Rows[0].Cells[i].Value = bsort.ToString();
                        resultTable.Rows[1].Cells[i].Value = ssort.ToString();
                        resultTable.Rows[2].Cells[i].Value = savesort.ToString();
                        chartGrpah.Series[0].Points.AddXY(i * size / 10, bsort);
                        chartGrpah.Series[1].Points.AddXY(i * size / 10, ssort);
                        chartGrpah.Series[2].Points.AddXY(i * size / 10, savesort);
                    }
                }
                else if (rbOrd.Checked)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        int bsort = ArrayConstructor.bubbleSort(ArrayConstructor.createOrdered(i * size / 10));
                        int ssort = ArrayConstructor.shakerSort(ArrayConstructor.createOrdered(i * size / 10));
                        int savesort = ArrayConstructor.savePositionBubbleSort(ArrayConstructor.createOrdered(i * size / 10));
                        resultTable.Rows[0].Cells[i].Value = bsort.ToString();
                        resultTable.Rows[1].Cells[i].Value = ssort.ToString();
                        resultTable.Rows[2].Cells[i].Value = savesort.ToString();
                        chartGrpah.Series[0].Points.AddXY(i * size / 10, bsort);
                        chartGrpah.Series[1].Points.AddXY(i * size / 10, ssort);
                        chartGrpah.Series[2].Points.AddXY(i * size / 10, savesort);
                    }
                }
                else if (rbBackOrd.Checked)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        int bsort = ArrayConstructor.bubbleSort(ArrayConstructor.createReverseOrdered(i * size / 10));
                        int ssort = ArrayConstructor.shakerSort(ArrayConstructor.createReverseOrdered(i * size / 10));
                        int savesort = ArrayConstructor.savePositionBubbleSort(ArrayConstructor.createReverseOrdered(i * size / 10));
                        resultTable.Rows[0].Cells[i].Value = bsort.ToString();
                        resultTable.Rows[1].Cells[i].Value = ssort.ToString();
                        resultTable.Rows[2].Cells[i].Value = savesort.ToString();
                        chartGrpah.Series[0].Points.AddXY(i * size / 10, bsort);
                        chartGrpah.Series[1].Points.AddXY(i * size / 10, ssort);
                        chartGrpah.Series[2].Points.AddXY(i * size / 10, savesort);
                    }
                }
                else if (rbPartOrd.Checked)
                {
                    int percent = (int)nudPercent.Value;
                    for (int i = 1; i <= 10; i++)
                    {
                        int bsort = ArrayConstructor.bubbleSort(ArrayConstructor.createPartlyOrdered(i * size / 10, percent));
                        int ssort = ArrayConstructor.shakerSort(ArrayConstructor.createPartlyOrdered(i * size / 10, percent));
                        int savesort = ArrayConstructor.savePositionBubbleSort(ArrayConstructor.createPartlyOrdered(i * size / 10, percent));
                        resultTable.Rows[0].Cells[i].Value = bsort.ToString();
                        resultTable.Rows[1].Cells[i].Value = ssort.ToString();
                        resultTable.Rows[2].Cells[i].Value = savesort.ToString();
                        chartGrpah.Series[0].Points.AddXY(i * size / 10, bsort);
                        chartGrpah.Series[1].Points.AddXY(i * size / 10, ssort);
                        chartGrpah.Series[2].Points.AddXY(i * size / 10, savesort);
                    }
                }
            }
            else if (rbList.Checked)
            {
                if (rbDisord.Checked)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        int bsort = SinglyLinkedList.bubbleSort(SinglyLinkedList.createNotOrdered(i * size / 10));
                        int ssort = SinglyLinkedList.shakerSort(SinglyLinkedList.createNotOrdered(i * size / 10));
                        int savesort = SinglyLinkedList.savePositionBubbleSort(SinglyLinkedList.createNotOrdered(i * size / 10));
                        resultTable.Rows[0].Cells[i].Value = bsort.ToString();
                        resultTable.Rows[1].Cells[i].Value = ssort.ToString();
                        resultTable.Rows[2].Cells[i].Value = savesort.ToString();
                        chartGrpah.Series[0].Points.AddXY(i * size / 10, bsort);
                        chartGrpah.Series[1].Points.AddXY(i * size / 10, ssort);
                        chartGrpah.Series[2].Points.AddXY(i * size / 10, savesort);
                    }
                }
                else if (rbOrd.Checked)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        int bsort = SinglyLinkedList.bubbleSort(SinglyLinkedList.createOrdered(i * size / 10));
                        int ssort = SinglyLinkedList.shakerSort(SinglyLinkedList.createOrdered(i * size / 10));
                        int savesort = SinglyLinkedList.savePositionBubbleSort(SinglyLinkedList.createOrdered(i * size / 10));
                        resultTable.Rows[0].Cells[i].Value = bsort.ToString();
                        resultTable.Rows[1].Cells[i].Value = ssort.ToString();
                        resultTable.Rows[2].Cells[i].Value = savesort.ToString();
                        chartGrpah.Series[0].Points.AddXY(i * size / 10, bsort);
                        chartGrpah.Series[1].Points.AddXY(i * size / 10, ssort);
                        chartGrpah.Series[2].Points.AddXY(i * size / 10, savesort);
                    }
                }
                else if (rbBackOrd.Checked)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        int bsort = SinglyLinkedList.bubbleSort(SinglyLinkedList.createReverseOrdered(i * size / 10));
                        int ssort = SinglyLinkedList.shakerSort(SinglyLinkedList.createReverseOrdered(i * size / 10));
                        int savesort = SinglyLinkedList.savePositionBubbleSort(SinglyLinkedList.createReverseOrdered(i * size / 10));
                        resultTable.Rows[0].Cells[i].Value = bsort.ToString();
                        resultTable.Rows[1].Cells[i].Value = ssort.ToString();
                        resultTable.Rows[2].Cells[i].Value = savesort.ToString();
                        chartGrpah.Series[0].Points.AddXY(i * size / 10, bsort);
                        chartGrpah.Series[1].Points.AddXY(i * size / 10, ssort);
                        chartGrpah.Series[2].Points.AddXY(i * size / 10, savesort);
                    }
                }
                else if (rbPartOrd.Checked)
                {
                    int percent = (int)nudPercent.Value;
                    for (int i = 1; i <= 10; i++)
                    {
                        int bsort = SinglyLinkedList.bubbleSort(SinglyLinkedList.createPartlyOrdered(i * size / 10, percent));
                        int ssort = SinglyLinkedList.shakerSort(SinglyLinkedList.createPartlyOrdered(i * size / 10, percent));
                        int savesort = SinglyLinkedList.savePositionBubbleSort(SinglyLinkedList.createPartlyOrdered(i * size / 10, percent));
                        resultTable.Rows[0].Cells[i].Value = bsort.ToString();
                        resultTable.Rows[1].Cells[i].Value = ssort.ToString();
                        resultTable.Rows[2].Cells[i].Value = savesort.ToString();
                        chartGrpah.Series[0].Points.AddXY(i * size / 10, bsort);
                        chartGrpah.Series[1].Points.AddXY(i * size / 10, ssort);
                        chartGrpah.Series[2].Points.AddXY(i * size / 10, savesort);
                    }
                }
            }
            else if (rbLinkedList.Checked)
            {
                if (rbDisord.Checked)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        int bsort = LinkedListConstructor.bubbleSort(LinkedListConstructor.createNotOrdered(i * size / 10));
                        int ssort = LinkedListConstructor.shakerSort(LinkedListConstructor.createNotOrdered(i * size / 10));
                        int savesort = LinkedListConstructor.savePositionBubbleSort(LinkedListConstructor.createNotOrdered(i * size / 10));
                        resultTable.Rows[0].Cells[i].Value = bsort.ToString();
                        resultTable.Rows[1].Cells[i].Value = ssort.ToString();
                        resultTable.Rows[2].Cells[i].Value = savesort.ToString();
                        chartGrpah.Series[0].Points.AddXY(i * size / 10, bsort);
                        chartGrpah.Series[1].Points.AddXY(i * size / 10, ssort);
                        chartGrpah.Series[2].Points.AddXY(i * size / 10, savesort);
                    }
                }
                else if (rbOrd.Checked)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        int bsort = LinkedListConstructor.bubbleSort(LinkedListConstructor.createOrdered(i * size / 10));
                        int ssort = LinkedListConstructor.shakerSort(LinkedListConstructor.createOrdered(i * size / 10));
                        int savesort = LinkedListConstructor.savePositionBubbleSort(LinkedListConstructor.createOrdered(i * size / 10));
                        resultTable.Rows[0].Cells[i].Value = bsort.ToString();
                        resultTable.Rows[1].Cells[i].Value = ssort.ToString();
                        resultTable.Rows[2].Cells[i].Value = savesort.ToString();
                        chartGrpah.Series[0].Points.AddXY(i * size / 10, bsort);
                        chartGrpah.Series[1].Points.AddXY(i * size / 10, ssort);
                        chartGrpah.Series[2].Points.AddXY(i * size / 10, savesort);
                    }
                }
                else if (rbBackOrd.Checked)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        int bsort = LinkedListConstructor.bubbleSort(LinkedListConstructor.createReverseOrdered(i * size / 10));
                        int ssort = LinkedListConstructor.shakerSort(LinkedListConstructor.createReverseOrdered(i * size / 10));
                        int savesort = LinkedListConstructor.savePositionBubbleSort(LinkedListConstructor.createReverseOrdered(i * size / 10));
                        resultTable.Rows[0].Cells[i].Value = bsort.ToString();
                        resultTable.Rows[1].Cells[i].Value = ssort.ToString();
                        resultTable.Rows[2].Cells[i].Value = savesort.ToString();
                        chartGrpah.Series[0].Points.AddXY(i * size / 10, bsort);
                        chartGrpah.Series[1].Points.AddXY(i * size / 10, ssort);
                        chartGrpah.Series[2].Points.AddXY(i * size / 10, savesort);
                    }
                }
                else if (rbPartOrd.Checked)
                {
                    int percent = (int)nudPercent.Value;
                    for (int i = 1; i <= 10; i++)
                    {
                        int bsort = LinkedListConstructor.bubbleSort(LinkedListConstructor.createPartlyOrdered(i * size / 10, percent));
                        int ssort = LinkedListConstructor.shakerSort(LinkedListConstructor.createPartlyOrdered(i * size / 10, percent));
                        int savesort = LinkedListConstructor.savePositionBubbleSort(LinkedListConstructor.createPartlyOrdered(i * size / 10, percent));
                        resultTable.Rows[0].Cells[i].Value = bsort.ToString();
                        resultTable.Rows[1].Cells[i].Value = ssort.ToString();
                        resultTable.Rows[2].Cells[i].Value = savesort.ToString();
                        chartGrpah.Series[0].Points.AddXY(i * size / 10, bsort);
                        chartGrpah.Series[1].Points.AddXY(i * size / 10, ssort);
                        chartGrpah.Series[2].Points.AddXY(i * size / 10, savesort);
                    }
                }
            }
        }
    }
}
