namespace Assignment_3._4
{
    public partial class MainForm : Form
    {
        private BindingSource bindingSource = new BindingSource();

        public MainForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = Data.Coffees;
            dataCoffeeList.DataSource = bindingSource;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderForm addForm = new OrderForm();
            addForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to remove this order?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bindingSource.RemoveCurrent();
            }
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(1, 51);
            MessageBox.Show($"Your order has been sent to the front. Your order number is {num}");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            bindingSource.ResetBindings(false);
        }
    }
}
