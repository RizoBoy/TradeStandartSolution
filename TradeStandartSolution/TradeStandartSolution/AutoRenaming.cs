using OfficeOpenXml;

namespace TradeStandartSolution
{
    public class AutoRenaming
    {
        public static string MainFilePath { get; set; } = string.Empty;

        public static string SecondFilePath { get; set; } = string.Empty;

        public static int MainTrainColumn { get; set; } = 5;

        public static int MainNameColumn { get; set; } = 6;

        public static int SecondTrainColumn { get; set; } = 5;

        public static int SecondNameColumn { get; set; } = 6;

        private static Dictionary<object, object> trainList = new();

        public static void Start()
        {
            if (!File.Exists(MainFilePath) || !File.Exists(SecondFilePath))
            {
                MessageBox.Show("Укажите путь к файлу.", "Файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            trainList = new();

            using (ExcelPackage package = new ExcelPackage(new FileInfo(MainFilePath)))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                for (int i = 2; worksheet.Cells[i, MainTrainColumn].Text != string.Empty; i++)
                    trainList.Add(worksheet.Cells[i, MainTrainColumn].Value, worksheet.Cells[i, MainNameColumn].Value);
            }

            using (ExcelPackage package = new ExcelPackage(new FileInfo(SecondFilePath)))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                if (worksheet.Cells[1, SecondNameColumn].Text == string.Empty)
                {
                    MessageBox.Show($"Названия уже перенесены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                worksheet.InsertColumn(SecondNameColumn, 1);

                int successCounter = 0;
                for (int i = 2; worksheet.Cells[i, SecondTrainColumn].Text != string.Empty; i++)
                {
                    if (trainList.TryGetValue(worksheet.Cells[i, SecondTrainColumn].Value, out object? value) && worksheet.Cells[i, SecondNameColumn].Value != value)
                    {
                        worksheet.Cells[i, SecondNameColumn].Value = value;
                        successCounter++;
                    }
                }

                try
                {
                    package.Save();
                }
                catch
                {
                    MessageBox.Show("Закройте второй файл.", "Конфликт сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show($"Успешно перенесено {successCounter} из {trainList.Count} строк.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
