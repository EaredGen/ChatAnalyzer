namespace ChatAnalyzer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelFirstStep = new System.Windows.Forms.Label();
            this.ButtonChoiseFileReading = new System.Windows.Forms.Button();
            this.TextBoxFIleDirectotyReading = new System.Windows.Forms.TextBox();
            this.ButtonStartReading = new System.Windows.Forms.Button();
            this.LabelSecondStep = new System.Windows.Forms.Label();
            this.ButtonChoiseFileWritting = new System.Windows.Forms.Button();
            this.TextBoxFIleDirectotyWritting = new System.Windows.Forms.TextBox();
            this.ButtonStartWriting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelFirstStep
            // 
            this.LabelFirstStep.AutoSize = true;
            this.LabelFirstStep.Location = new System.Drawing.Point(13, 13);
            this.LabelFirstStep.Name = "LabelFirstStep";
            this.LabelFirstStep.Size = new System.Drawing.Size(327, 17);
            this.LabelFirstStep.TabIndex = 0;
            this.LabelFirstStep.Text = "Шаг 1. Выберите файл Excel для выгрузки чатов";
            // 
            // ButtonChoiseFileReading
            // 
            this.ButtonChoiseFileReading.Location = new System.Drawing.Point(16, 46);
            this.ButtonChoiseFileReading.Name = "ButtonChoiseFileReading";
            this.ButtonChoiseFileReading.Size = new System.Drawing.Size(95, 25);
            this.ButtonChoiseFileReading.TabIndex = 1;
            this.ButtonChoiseFileReading.Text = "Выбрать";
            this.ButtonChoiseFileReading.UseVisualStyleBackColor = true;
            this.ButtonChoiseFileReading.Click += new System.EventHandler(this.ButtonChoiseFile);
            // 
            // TextBoxFIleDirectotyReading
            // 
            this.TextBoxFIleDirectotyReading.Location = new System.Drawing.Point(131, 47);
            this.TextBoxFIleDirectotyReading.Name = "TextBoxFIleDirectotyReading";
            this.TextBoxFIleDirectotyReading.ReadOnly = true;
            this.TextBoxFIleDirectotyReading.Size = new System.Drawing.Size(272, 22);
            this.TextBoxFIleDirectotyReading.TabIndex = 2;
            // 
            // ButtonStartReading
            // 
            this.ButtonStartReading.Enabled = false;
            this.ButtonStartReading.Location = new System.Drawing.Point(16, 99);
            this.ButtonStartReading.Name = "ButtonStartReading";
            this.ButtonStartReading.Size = new System.Drawing.Size(95, 25);
            this.ButtonStartReading.TabIndex = 3;
            this.ButtonStartReading.Text = "Выгрузить";
            this.ButtonStartReading.UseVisualStyleBackColor = true;
            this.ButtonStartReading.Click += new System.EventHandler(this.ButtonStartReading_Click);
            // 
            // LabelSecondStep
            // 
            this.LabelSecondStep.AutoSize = true;
            this.LabelSecondStep.Location = new System.Drawing.Point(16, 166);
            this.LabelSecondStep.Name = "LabelSecondStep";
            this.LabelSecondStep.Size = new System.Drawing.Size(400, 17);
            this.LabelSecondStep.TabIndex = 4;
            this.LabelSecondStep.Text = "Шаг 2. Выберите пустой файл Excel для записи результата";
            // 
            // ButtonChoiseFileWritting
            // 
            this.ButtonChoiseFileWritting.Enabled = false;
            this.ButtonChoiseFileWritting.Location = new System.Drawing.Point(16, 213);
            this.ButtonChoiseFileWritting.Name = "ButtonChoiseFileWritting";
            this.ButtonChoiseFileWritting.Size = new System.Drawing.Size(95, 25);
            this.ButtonChoiseFileWritting.TabIndex = 5;
            this.ButtonChoiseFileWritting.Text = "Выбрать";
            this.ButtonChoiseFileWritting.UseVisualStyleBackColor = true;
            this.ButtonChoiseFileWritting.Click += new System.EventHandler(this.ButtonChoiseFile);
            // 
            // TextBoxFIleDirectotyWritting
            // 
            this.TextBoxFIleDirectotyWritting.Location = new System.Drawing.Point(131, 216);
            this.TextBoxFIleDirectotyWritting.Name = "TextBoxFIleDirectotyWritting";
            this.TextBoxFIleDirectotyWritting.ReadOnly = true;
            this.TextBoxFIleDirectotyWritting.Size = new System.Drawing.Size(272, 22);
            this.TextBoxFIleDirectotyWritting.TabIndex = 6;
            // 
            // ButtonStartWriting
            // 
            this.ButtonStartWriting.Enabled = false;
            this.ButtonStartWriting.Location = new System.Drawing.Point(16, 267);
            this.ButtonStartWriting.Name = "ButtonStartWriting";
            this.ButtonStartWriting.Size = new System.Drawing.Size(95, 25);
            this.ButtonStartWriting.TabIndex = 7;
            this.ButtonStartWriting.Text = "Записать";
            this.ButtonStartWriting.UseVisualStyleBackColor = true;
            this.ButtonStartWriting.Click += new System.EventHandler(this.ButtonStartWritting_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 347);
            this.Controls.Add(this.ButtonStartWriting);
            this.Controls.Add(this.TextBoxFIleDirectotyWritting);
            this.Controls.Add(this.ButtonChoiseFileWritting);
            this.Controls.Add(this.LabelSecondStep);
            this.Controls.Add(this.ButtonStartReading);
            this.Controls.Add(this.TextBoxFIleDirectotyReading);
            this.Controls.Add(this.ButtonChoiseFileReading);
            this.Controls.Add(this.LabelFirstStep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Analyzer 2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelFirstStep;
        private System.Windows.Forms.Button ButtonChoiseFileReading;
        public System.Windows.Forms.TextBox TextBoxFIleDirectotyReading;
        private System.Windows.Forms.Button ButtonStartReading;
        private System.Windows.Forms.Label LabelSecondStep;
        private System.Windows.Forms.Button ButtonChoiseFileWritting;
        private System.Windows.Forms.TextBox TextBoxFIleDirectotyWritting;
        private System.Windows.Forms.Button ButtonStartWriting;
    }
}

