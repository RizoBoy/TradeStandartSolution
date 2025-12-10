namespace TradeStandartSolution
{
    public partial class AutoRenamingForm : Form
    {
        public AutoRenamingForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel files (*.xlsx;*.xls;*.xlsm;*.xlsb)|*.xlsx;*.xls;*.xlsm;*.xlsb|All files (*.*)|*.*";
                ofd.Title = "Выберите файл";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ImportMainPath.Text = ofd.FileName;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel files (*.xlsx;*.xls;*.xlsm;*.xlsb)|*.xlsx;*.xls;*.xlsm;*.xlsb|All files (*.*)|*.*";
                ofd.Title = "Выберите файл";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ImportSecondPath.Text = ofd.FileName;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AutoRenaming.Start();
            Console.WriteLine("pushed");
        }

        private void ImportMainPath_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                AutoRenaming.MainFilePath = textBox.Text;
            }
        }

        private void ImportSecondPath_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                AutoRenaming.SecondFilePath = textBox.Text;
            }
        }

        private void MainTrainColumn_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (int.TryParse(textBox.Text, out int column))
                {
                    AutoRenaming.MainTrainColumn = column;
                }
                else
                {
                    MessageBox.Show("Введите корректное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Text = AutoRenaming.MainTrainColumn.ToString();
                }
            }
        }

        private void MainNameColumn_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (int.TryParse(textBox.Text, out int column))
                {
                    AutoRenaming.MainNameColumn = column;
                }
                else
                {
                    MessageBox.Show("Введите корректное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Text = AutoRenaming.MainNameColumn.ToString();
                }
            }
        }

        private void SecondTrainColumn_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (int.TryParse(textBox.Text, out int column))
                {
                    AutoRenaming.SecondTrainColumn = column;
                }
                else
                {
                    MessageBox.Show("Введите корректное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Text = AutoRenaming.SecondTrainColumn.ToString();
                }
            }
        }

        private void SecondNameColumn_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (int.TryParse(textBox.Text, out int column))
                {
                    AutoRenaming.SecondNameColumn = column;
                }
                else
                {
                    MessageBox.Show("Введите корректное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Text = AutoRenaming.SecondNameColumn.ToString();
                }
            }
        }

        private void MainNameColumnText_Click(object sender, EventArgs e)
        {

        }

        private void SecondTrainColumnText_Click(object sender, EventArgs e)
        {

        }

        private void SecondNameColumnText_Click(object sender, EventArgs e)
        {

        }

        private void NextForm_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            Hide();
        }
    }
}
