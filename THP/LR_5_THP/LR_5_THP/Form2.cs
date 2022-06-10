using Library_Gems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ТХИ_3;

namespace LR_5_THP
{
    public partial class Form2 : Form
    {
        ProductCalculator calc = new ProductCalculator();
        List<TextBox> listText = new List<TextBox>();
        Brilliant drill = new Brilliant();
        public Form2()
        {
            InitializeComponent();
            comboBox1.Items.Add("MidSizeCar");
            comboBox1.Items.Add("LuxuryCar");
            if (ProductCalculator.indJews != -1)
            {
                comboBox1.SelectedIndex = 0;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "MidSizeCar":
                    {
                        string[] labels = new string[] { "Name", "Price", "Capacity", "MaxSpeed" };
                        for (int i = 0; i < 4; i++)
                        {
                            CreateLabel(labels[i], i * 40 + 68);
                            CreateTextBox(i * 40 + 64);
                        }
                        if (ProductCalculator.indJews != -1)
                        {
                            drill = calc.GetJew();
                            listText[0].Text = drill.Name;
                            listText[1].Text = drill.Carats.ToString();
                            listText[2].Text = drill.Capacity.ToString();
                            listText[3].Text = drill.Price.ToString();
                        }
                        break;
                    }
                case "LuxuryCar":
                    {
                        break;
                    }
            }
        }
        private void CreateLabel(string text, int placeY)
        {
            Label label = new Label();
            label.Text = text;
            label.Location = new System.Drawing.Point(30, placeY);
            label.Size = new System.Drawing.Size(70, 30);
            this.Controls.Add(label);
        }
        private void CreateTextBox(int placeY)
        {
            TextBox textBox = new TextBox();
            textBox.Text = "";
            textBox.Location = new System.Drawing.Point(100, placeY);
            textBox.Size = new System.Drawing.Size(121, 23);
            this.Controls.Add(textBox);
            listText.Add(textBox);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductCalculator.indJews != -1)
                {
                    calc.EditJew(
                        listText[0].Text,
                        Convert.ToInt32(listText[1].Text),
                        Convert.ToDouble(listText[2].Text),
                        Convert.ToInt32(listText[3].Text));
                    ProductCalculator.indJews = -1;
                }
                else
                {
                    calc.AddingJew(
                        listText[0].Text,
                        Convert.ToInt32(listText[1].Text),
                        Convert.ToDouble(listText[2].Text),
                        Convert.ToInt32(listText[3].Text));
                }
                this.Hide();
                Form1 form = new Form1();
                form.ShowDialog();

                this.Dispose();
            }
            catch (System.FormatException)
            {
                CreateLabel("Enter correctly", 360);
                button1.BackColor = System.Drawing.Color.FromName("Coral");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            this.Close();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
