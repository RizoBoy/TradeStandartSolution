namespace TradeStandartSolution
{
    partial class AutoRenamingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ImportMainButton = new Button();
            ImportMainPath = new TextBox();
            ImportSecondPath = new TextBox();
            ImportSecondButton = new Button();
            MainTrainColumnText = new Label();
            MainTrainColumn = new TextBox();
            MainNameColumn = new TextBox();
            MainNameColumnText = new Label();
            SecondNameColumn = new TextBox();
            SecondNameColumnText = new Label();
            SecondTrainColumn = new TextBox();
            SecondTrainColumnText = new Label();
            StartButton = new Button();
            NextForm = new Button();
            SuspendLayout();
            // 
            // ImportMainButton
            // 
            ImportMainButton.Location = new Point(12, 83);
            ImportMainButton.Name = "ImportMainButton";
            ImportMainButton.Size = new Size(223, 27);
            ImportMainButton.TabIndex = 0;
            ImportMainButton.Text = "Импорт дислокации";
            ImportMainButton.UseVisualStyleBackColor = true;
            ImportMainButton.Click += button1_Click;
            // 
            // ImportMainPath
            // 
            ImportMainPath.Location = new Point(241, 83);
            ImportMainPath.Name = "ImportMainPath";
            ImportMainPath.Size = new Size(493, 27);
            ImportMainPath.TabIndex = 1;
            ImportMainPath.TextChanged += ImportMainPath_TextChanged;
            // 
            // ImportSecondPath
            // 
            ImportSecondPath.Location = new Point(241, 209);
            ImportSecondPath.Name = "ImportSecondPath";
            ImportSecondPath.Size = new Size(493, 27);
            ImportSecondPath.TabIndex = 3;
            ImportSecondPath.TextChanged += ImportSecondPath_TextChanged;
            // 
            // ImportSecondButton
            // 
            ImportSecondButton.Location = new Point(12, 209);
            ImportSecondButton.Name = "ImportSecondButton";
            ImportSecondButton.Size = new Size(223, 27);
            ImportSecondButton.TabIndex = 2;
            ImportSecondButton.Text = "Импорт новой дислокации";
            ImportSecondButton.UseVisualStyleBackColor = true;
            ImportSecondButton.Click += button2_Click;
            // 
            // MainTrainColumnText
            // 
            MainTrainColumnText.AutoSize = true;
            MainTrainColumnText.Location = new Point(19, 126);
            MainTrainColumnText.Name = "MainTrainColumnText";
            MainTrainColumnText.Size = new Size(181, 20);
            MainTrainColumnText.TabIndex = 4;
            MainTrainColumnText.Text = "Номер столбца вагонов:";
            MainTrainColumnText.Click += label1_Click;
            // 
            // MainTrainColumn
            // 
            MainTrainColumn.Location = new Point(212, 126);
            MainTrainColumn.Name = "MainTrainColumn";
            MainTrainColumn.Size = new Size(23, 27);
            MainTrainColumn.TabIndex = 5;
            MainTrainColumn.Text = "5";
            MainTrainColumn.TextChanged += MainTrainColumn_TextChanged;
            // 
            // MainNameColumn
            // 
            MainNameColumn.Location = new Point(212, 158);
            MainNameColumn.Name = "MainNameColumn";
            MainNameColumn.Size = new Size(23, 27);
            MainNameColumn.TabIndex = 7;
            MainNameColumn.Text = "6";
            MainNameColumn.TextChanged += MainNameColumn_TextChanged;
            // 
            // MainNameColumnText
            // 
            MainNameColumnText.AutoSize = true;
            MainNameColumnText.Location = new Point(19, 158);
            MainNameColumnText.Name = "MainNameColumnText";
            MainNameColumnText.Size = new Size(195, 20);
            MainNameColumnText.TabIndex = 6;
            MainNameColumnText.Text = "Номер столбца названии: ";
            MainNameColumnText.Click += MainNameColumnText_Click;
            // 
            // SecondNameColumn
            // 
            SecondNameColumn.Location = new Point(212, 285);
            SecondNameColumn.Name = "SecondNameColumn";
            SecondNameColumn.Size = new Size(23, 27);
            SecondNameColumn.TabIndex = 11;
            SecondNameColumn.Text = "6";
            SecondNameColumn.TextChanged += SecondNameColumn_TextChanged;
            // 
            // SecondNameColumnText
            // 
            SecondNameColumnText.AutoSize = true;
            SecondNameColumnText.Location = new Point(19, 288);
            SecondNameColumnText.Name = "SecondNameColumnText";
            SecondNameColumnText.Size = new Size(195, 20);
            SecondNameColumnText.TabIndex = 10;
            SecondNameColumnText.Text = "Номер столбца названии: ";
            SecondNameColumnText.Click += SecondNameColumnText_Click;
            // 
            // SecondTrainColumn
            // 
            SecondTrainColumn.Location = new Point(212, 253);
            SecondTrainColumn.Name = "SecondTrainColumn";
            SecondTrainColumn.Size = new Size(23, 27);
            SecondTrainColumn.TabIndex = 9;
            SecondTrainColumn.Text = "5";
            SecondTrainColumn.TextChanged += SecondTrainColumn_TextChanged;
            // 
            // SecondTrainColumnText
            // 
            SecondTrainColumnText.AutoSize = true;
            SecondTrainColumnText.Location = new Point(19, 256);
            SecondTrainColumnText.Name = "SecondTrainColumnText";
            SecondTrainColumnText.Size = new Size(181, 20);
            SecondTrainColumnText.TabIndex = 8;
            SecondTrainColumnText.Text = "Номер столбца вагонов:";
            SecondTrainColumnText.Click += SecondTrainColumnText_Click;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(430, 395);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(158, 27);
            StartButton.TabIndex = 12;
            StartButton.Text = "Перенести";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += button1_Click_1;
            // 
            // NextForm
            // 
            NextForm.Location = new Point(594, 395);
            NextForm.Name = "NextForm";
            NextForm.Size = new Size(158, 27);
            NextForm.TabIndex = 13;
            NextForm.Text = "Следующая форма";
            NextForm.UseVisualStyleBackColor = true;
            NextForm.Click += NextForm_Click;
            // 
            // AutoRenamingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NextForm);
            Controls.Add(StartButton);
            Controls.Add(SecondNameColumn);
            Controls.Add(SecondNameColumnText);
            Controls.Add(SecondTrainColumn);
            Controls.Add(SecondTrainColumnText);
            Controls.Add(MainNameColumn);
            Controls.Add(MainNameColumnText);
            Controls.Add(MainTrainColumn);
            Controls.Add(MainTrainColumnText);
            Controls.Add(ImportSecondPath);
            Controls.Add(ImportSecondButton);
            Controls.Add(ImportMainPath);
            Controls.Add(ImportMainButton);
            Name = "AutoRenamingForm";
            Text = "AutoRenamingForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ImportMainButton;
        private TextBox ImportMainPath;
        private TextBox ImportSecondPath;
        private Button ImportSecondButton;
        private Label MainTrainColumnText;
        private TextBox MainTrainColumn;
        private TextBox MainNameColumn;
        private Label MainNameColumnText;
        private TextBox SecondNameColumn;
        private Label SecondNameColumnText;
        private TextBox SecondTrainColumn;
        private Label SecondTrainColumnText;
        private Button StartButton;
        private Button NextForm;
    }
}
