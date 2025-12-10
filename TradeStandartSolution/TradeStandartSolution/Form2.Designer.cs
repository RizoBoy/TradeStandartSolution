namespace TradeStandartSolution
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainFilePathButton = new Button();
            MainFilePath = new TextBox();
            BlancFilePath = new TextBox();
            BlancFilePathButton = new Button();
            SaveFolderPath = new TextBox();
            SaveFolderPathButton = new Button();
            label1 = new Label();
            NextForm = new Button();
            StartButton = new Button();
            SuspendLayout();
            // 
            // MainFilePathButton
            // 
            MainFilePathButton.Location = new Point(27, 35);
            MainFilePathButton.Name = "MainFilePathButton";
            MainFilePathButton.Size = new Size(164, 27);
            MainFilePathButton.TabIndex = 0;
            MainFilePathButton.Text = "Импорт файла";
            MainFilePathButton.UseVisualStyleBackColor = true;
            MainFilePathButton.Click += MainFilePathButton_Click;
            // 
            // MainFilePath
            // 
            MainFilePath.Location = new Point(212, 35);
            MainFilePath.Name = "MainFilePath";
            MainFilePath.Size = new Size(451, 27);
            MainFilePath.TabIndex = 1;
            // 
            // BlancFilePath
            // 
            BlancFilePath.Location = new Point(212, 68);
            BlancFilePath.Name = "BlancFilePath";
            BlancFilePath.Size = new Size(451, 27);
            BlancFilePath.TabIndex = 3;
            // 
            // BlancFilePathButton
            // 
            BlancFilePathButton.Location = new Point(27, 68);
            BlancFilePathButton.Name = "BlancFilePathButton";
            BlancFilePathButton.Size = new Size(164, 27);
            BlancFilePathButton.TabIndex = 2;
            BlancFilePathButton.Text = "Импорт шаблона";
            BlancFilePathButton.UseVisualStyleBackColor = true;
            BlancFilePathButton.Click += BlancFilePathButton_Click;
            // 
            // SaveFolderPath
            // 
            SaveFolderPath.Location = new Point(212, 101);
            SaveFolderPath.Name = "SaveFolderPath";
            SaveFolderPath.Size = new Size(451, 27);
            SaveFolderPath.TabIndex = 5;
            SaveFolderPath.Text = "/Saved";
            SaveFolderPath.TextChanged += SaveFolderPath_TextChanged;
            // 
            // SaveFolderPathButton
            // 
            SaveFolderPathButton.Location = new Point(27, 101);
            SaveFolderPathButton.Name = "SaveFolderPathButton";
            SaveFolderPathButton.Size = new Size(164, 27);
            SaveFolderPathButton.TabIndex = 4;
            SaveFolderPathButton.Text = "Папка сохранении";
            SaveFolderPathButton.UseVisualStyleBackColor = true;
            SaveFolderPathButton.Click += SaveFolderPathButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 131);
            label1.Name = "label1";
            label1.Size = new Size(264, 20);
            label1.TabIndex = 6;
            label1.Text = "Рекомендуется указать пустую папку";
            label1.Click += label1_Click;
            // 
            // NextForm
            // 
            NextForm.Location = new Point(612, 396);
            NextForm.Name = "NextForm";
            NextForm.Size = new Size(158, 27);
            NextForm.TabIndex = 14;
            NextForm.Text = "Следующая форма";
            NextForm.UseVisualStyleBackColor = true;
            NextForm.Click += NextForm_Click;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(448, 396);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(158, 27);
            StartButton.TabIndex = 15;
            StartButton.Text = "Запустить";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StartButton);
            Controls.Add(NextForm);
            Controls.Add(label1);
            Controls.Add(SaveFolderPath);
            Controls.Add(SaveFolderPathButton);
            Controls.Add(BlancFilePath);
            Controls.Add(BlancFilePathButton);
            Controls.Add(MainFilePath);
            Controls.Add(MainFilePathButton);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MainFilePathButton;
        private TextBox MainFilePath;
        private TextBox BlancFilePath;
        private Button BlancFilePathButton;
        private TextBox SaveFolderPath;
        private Button SaveFolderPathButton;
        private Label label1;
        private Button NextForm;
        private Button StartButton;
    }
}