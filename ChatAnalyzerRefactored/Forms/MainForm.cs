using ChatAnalyzer.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAnalyzer
{
    
    public partial class MainForm : Form
    {
        private OpenFileDialog ofd;
        private OpeningExcelFile openingExcelFile;
        private Queue<Chat> longWaitChat;
        public MainForm()
        {
            InitializeComponent();
            ofd = new OpenFileDialog();
        }

        private void Form1_Load(object sender, EventArgs e){}
        
        private void ButtonChoiseFile(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                if (sender == ButtonChoiseFileReading)
                {
                    TextBoxFIleDirectotyReading.Text = ofd.FileName;
                    if (TextBoxFIleDirectotyReading.Text != "")
                        ButtonStartReading.Enabled = true;
                } 
                else
                {
                    TextBoxFIleDirectotyWritting.Text = ofd.FileName;
                    if (TextBoxFIleDirectotyWritting.Text != "")
                        ButtonStartWriting.Enabled = true;
                }
            }
        }


        private void ButtonStartReading_Click(object sender, EventArgs e)
        {
            openingExcelFile = new OpeningExcelFile(this.TextBoxFIleDirectotyReading);
            OpenedExcel excelForReading = openingExcelFile.OpenFile();
            if (excelForReading == null)
            {
                MessageBox.Show("Возникла ошибка. Вероятно, вы выбрали неверный файл." +
                    "Выберите, пожалуйста, Excel файл с выгрузкой.");
            }
            else
            {
                AnalysisExcelFile analysisExcel = new AnalysisExcelFile(excelForReading);
                analysisExcel.Reading();
                longWaitChat = analysisExcel.ReturnResult();
            }
            ButtonChoiseFileWritting.Enabled = true;
        }
        
        private void ButtonStartWritting_Click(object sender, EventArgs e)
        {
            openingExcelFile = new OpeningExcelFile(this.TextBoxFIleDirectotyWritting);
            OpenedExcel excelForWritting = openingExcelFile.OpenFile();
            Writer writer = new Writer(longWaitChat,excelForWritting);
            writer.StartWritting();
            Dispose();
        }
    }
}
