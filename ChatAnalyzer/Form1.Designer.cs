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
            this.choiceButtonRead = new System.Windows.Forms.Button();
            this.readingFileDirectory = new System.Windows.Forms.TextBox();
            this.beginReading = new System.Windows.Forms.Button();
            this.choiceButtonWrite = new System.Windows.Forms.Button();
            this.writingFileDirectory = new System.Windows.Forms.TextBox();
            this.beginWriting = new System.Windows.Forms.Button();
            this.readingInformLabel = new System.Windows.Forms.Label();
            this.writingInformLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.waitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // choiceButtonRead
            // 
            this.choiceButtonRead.Location = new System.Drawing.Point(28, 55);
            this.choiceButtonRead.Name = "choiceButtonRead";
            this.choiceButtonRead.Size = new System.Drawing.Size(97, 33);
            this.choiceButtonRead.TabIndex = 0;
            this.choiceButtonRead.Text = "Выбрать";
            this.choiceButtonRead.UseVisualStyleBackColor = true;
            this.choiceButtonRead.Click += new System.EventHandler(this.ButtonChoise);
            // 
            // readingFileDirectory
            // 
            this.readingFileDirectory.Location = new System.Drawing.Point(143, 61);
            this.readingFileDirectory.Name = "readingFileDirectory";
            this.readingFileDirectory.ReadOnly = true;
            this.readingFileDirectory.Size = new System.Drawing.Size(287, 22);
            this.readingFileDirectory.TabIndex = 1;
            // 
            // beginReading
            // 
            this.beginReading.Enabled = false;
            this.beginReading.Location = new System.Drawing.Point(28, 118);
            this.beginReading.Name = "beginReading";
            this.beginReading.Size = new System.Drawing.Size(97, 33);
            this.beginReading.TabIndex = 2;
            this.beginReading.Text = "Выгрузить";
            this.beginReading.UseVisualStyleBackColor = true;
            this.beginReading.Click += new System.EventHandler(this.ButtonReading);
            // 
            // choiceButtonWrite
            // 
            this.choiceButtonWrite.Enabled = false;
            this.choiceButtonWrite.Location = new System.Drawing.Point(28, 255);
            this.choiceButtonWrite.Name = "choiceButtonWrite";
            this.choiceButtonWrite.Size = new System.Drawing.Size(97, 33);
            this.choiceButtonWrite.TabIndex = 3;
            this.choiceButtonWrite.Text = "Выбрать";
            this.choiceButtonWrite.UseVisualStyleBackColor = true;
            this.choiceButtonWrite.Click += new System.EventHandler(this.ButtonChoise);
            // 
            // writingFileDirectory
            // 
            this.writingFileDirectory.Enabled = false;
            this.writingFileDirectory.Location = new System.Drawing.Point(143, 261);
            this.writingFileDirectory.Name = "writingFileDirectory";
            this.writingFileDirectory.ReadOnly = true;
            this.writingFileDirectory.Size = new System.Drawing.Size(287, 22);
            this.writingFileDirectory.TabIndex = 4;
            // 
            // beginWriting
            // 
            this.beginWriting.Enabled = false;
            this.beginWriting.Location = new System.Drawing.Point(28, 318);
            this.beginWriting.Name = "beginWriting";
            this.beginWriting.Size = new System.Drawing.Size(97, 33);
            this.beginWriting.TabIndex = 5;
            this.beginWriting.Text = "Запись";
            this.beginWriting.UseVisualStyleBackColor = true;
            this.beginWriting.Click += new System.EventHandler(this.ButtonWriting);
            // 
            // readingInformLabel
            // 
            this.readingInformLabel.AutoSize = true;
            this.readingInformLabel.Location = new System.Drawing.Point(28, 21);
            this.readingInformLabel.Name = "readingInformLabel";
            this.readingInformLabel.Size = new System.Drawing.Size(192, 17);
            this.readingInformLabel.TabIndex = 9;
            this.readingInformLabel.Text = "Выберите файл для чтения";
            // 
            // writingInformLabel
            // 
            this.writingInformLabel.AutoSize = true;
            this.writingInformLabel.Location = new System.Drawing.Point(28, 202);
            this.writingInformLabel.Name = "writingInformLabel";
            this.writingInformLabel.Size = new System.Drawing.Size(191, 17);
            this.writingInformLabel.TabIndex = 10;
            this.writingInformLabel.Text = "Выберите файл для записи";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(28, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Для записи используйте пустой Excel файл";
            // 
            // waitLabel
            // 
            this.waitLabel.AutoSize = true;
            this.waitLabel.ForeColor = System.Drawing.Color.Red;
            this.waitLabel.Location = new System.Drawing.Point(28, 162);
            this.waitLabel.Name = "waitLabel";
            this.waitLabel.Size = new System.Drawing.Size(213, 17);
            this.waitLabel.TabIndex = 12;
            this.waitLabel.Text = "Ожидайте окончания выгрузки";
            this.waitLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 413);
            this.Controls.Add(this.waitLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.writingInformLabel);
            this.Controls.Add(this.readingInformLabel);
            this.Controls.Add(this.beginWriting);
            this.Controls.Add(this.writingFileDirectory);
            this.Controls.Add(this.choiceButtonWrite);
            this.Controls.Add(this.beginReading);
            this.Controls.Add(this.readingFileDirectory);
            this.Controls.Add(this.choiceButtonRead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Chat Analyzer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button choiceButtonRead;
        private System.Windows.Forms.TextBox readingFileDirectory;
        private System.Windows.Forms.Button beginReading;
        private System.Windows.Forms.Button choiceButtonWrite;
        private System.Windows.Forms.TextBox writingFileDirectory;
        private System.Windows.Forms.Button beginWriting;
        private System.Windows.Forms.Label readingInformLabel;
        private System.Windows.Forms.Label writingInformLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label waitLabel;
    }
}

