using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeStandartSolution
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ImportMainPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveFolderPathButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Выберите папку";
                fbd.ShowNewFolderButton = true;

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    SaveFolderPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void BlancFilePathButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel files (*.xlsx;*.xls;*.xlsm;*.xlsb)|*.xlsx;*.xls;*.xlsm;*.xlsb|All files (*.*)|*.*";
                ofd.Title = "Выберите файл";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    BlancFilePath.Text = ofd.FileName;
                }
            }
        }

        private void SaveFolderPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NextForm_Click(object sender, EventArgs e)
        {
            AutoRenamingForm newForm = new AutoRenamingForm();
            newForm.Show();
            Hide();
        }

        private void MainFilePathButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel files (*.xlsx;*.xls;*.xlsm;*.xlsb)|*.xlsx;*.xls;*.xlsm;*.xlsb|All files (*.*)|*.*";
                ofd.Title = "Выберите файл";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    MainFilePath.Text = ofd.FileName;
                }
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

        }
    }
}
