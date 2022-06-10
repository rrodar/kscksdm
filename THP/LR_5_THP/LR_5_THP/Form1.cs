using рух_3;

namespace LR_5_THP
{
    public partial class Form1 : Form
    {
        ProductCalculator calculator = new ProductCalculator();
        public Form1()
        {
            InitializeComponent();
            calculator.InitCalculator();
            InsertInListBox();
            EnterConsumption();
        }
        private void InsertInListBox()
        {
            listBox1.Items.Clear();
            string[] list = calculator.GetJews();
            listBox1.Items.AddRange(list);
        }
        private void EnterConsumption()
        {
            label1.Text = String.Format("Total Weight: {0}", calculator.CalculatingWeight().ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 newForm = new Form2();
            newForm.ShowDialog();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductCalculator.indJews = listBox1.SelectedIndex;
            Form2 newForm = new Form2();
            newForm.ShowDialog();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            calculator.DeleteJew(listBox1.SelectedIndex);
            InsertInListBox();
            EnterConsumption();
        }
    }

}