using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Scheduler_Simulator
{
    public partial class AddMLFQForm : Form
    {
        public enum schedulerTypes
        {
            RoundRobbin,
            FirstComeFirstServe
        }

        Random random = new Random();
        public MultiLevelableScheduler[] queues = new MultiLevelableScheduler[3];
        public AddMLFQForm()
        {
            InitializeComponent();
            Location = Cursor.Position;
        }
        Color randomColor()
        {
            return Color.FromArgb(random.Next(0, 168), random.Next(0, 168), random.Next(0, 168));
        }

        private void onSelect(ComboBox combobox, int i)
        {
            if (combobox.SelectedIndex == (int)schedulerTypes.RoundRobbin)
            {
                EnterValueForm pop = new EnterValueForm("Enter quantum for Round Robbin:", EnterValueForm.PopUpType.Input);
                if (pop.ShowDialog() == DialogResult.OK)
                {
                    queues[i] = new RoundRobinScheduler("RR:" + pop.value, pop.value, null);
                }
                else
                {
                    combobox.SelectedItem = null;
                }
            }
            else if (combobox.SelectedIndex == (int)schedulerTypes.FirstComeFirstServe)
            {
                queues[i] = new FirstComeFirstServeScheduler("FCFS", null);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            onSelect(comboBox1, 0);
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            onSelect(comboBox2, 1);
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            onSelect(comboBox3, 2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null
                || comboBox2.SelectedItem == null
                || comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Please select all three queues!");
                return;
            }
            DialogResult = DialogResult.OK;
        }


    }
}
