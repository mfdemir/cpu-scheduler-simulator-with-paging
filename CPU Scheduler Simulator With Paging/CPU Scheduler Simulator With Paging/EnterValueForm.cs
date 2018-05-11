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
    public partial class EnterValueForm : Form
    {
        public enum PopUpType
        {
            Input,
            Checkbox,
            Text
        }
        public int value;
        public EnterValueForm(string title,PopUpType popUpType)
        {
            InitializeComponent();
            Location = Cursor.Position;
            if (popUpType == PopUpType.Input)
            {
                label1.Visible = true;
                textBox1.Visible = true;
                label1.Text = title;
                this.Size = new Size(label1.Size.Width + textBox1.Size.Width + 50, 110);
            }
            else if(popUpType == PopUpType.Checkbox)
            {
                checkBox1.Visible = true;
                checkBox1.Text = title;
            }
            else if(popUpType == PopUpType.Text)
            {
                label1.Visible = true;
                label1.Text = title;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(textBox1.Text,out value))
            {
                MessageBox.Show("Please enter a number...");
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
