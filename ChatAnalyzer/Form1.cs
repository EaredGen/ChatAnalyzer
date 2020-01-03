using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace ChatAnalyzer
{
    public partial class MainForm : Form
    {
        private _Application excel;
        private OpenFileDialog ofd;
        private Workbook wb;
        private Worksheet ws;
        private Queue<Chat> queue;
        private char[] array;
        private List<Message> listOfMessagesInsideOfChat;

        private DateTime dateOfChat;
        private string loginOfEmployee;
        private string nameOfEmployee;
        private string numberOfCustomer;
        private string historyOfChat;
        private TimeSpan control = new TimeSpan(0, 0, 5, 0);


        public MainForm()
        {
            InitializeComponent();
            ofd = new OpenFileDialog(); ;
            excel = new _Excel.Application();
            queue = new Queue<Chat>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        // используем для выбора файла
        private void ButtonChoise(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (sender == choiceButtonRead)
                {
                    readingFileDirectory.Text = ofd.FileName;
                    if (readingFileDirectory.Text != "")
                        beginReading.Enabled = true;
                }
                else
                {
                    writingFileDirectory.Text = ofd.FileName;
                    if (writingFileDirectory.Text != "")
                        beginWriting.Enabled = true;
                }
            }
        }

        // Загрузка Excel, начало анализа всего файла
        private void ButtonReading(object sender, EventArgs e)
        {
            try
            {
                beginReading.Enabled = false;
                waitLabel.Visible = true;
                wb = excel.Workbooks.Open(readingFileDirectory.Text);
                ws = wb.Worksheets[1];
                var lastCell = excel.Cells.SpecialCells(_Excel.XlCellType.xlCellTypeLastCell);
                string[,] list = new string[lastCell.Column, lastCell.Row];

                //идем по 2:12 -> n:12 lastCell.Row
                for (int counter = 2; counter < lastCell.Row; counter++)
                {
                    try
                    {
                        if (!DefineCorrectness(ws.Cells[counter, 12].Text.ToString()))
                        {
                            dateOfChat = Convert.ToDateTime(ws.Cells[counter, 2].Text.ToString());
                            loginOfEmployee = ws.Cells[counter, 9].Text.ToString();
                            nameOfEmployee = ws.Cells[counter, 10].Text.ToString();
                            numberOfCustomer = ws.Cells[counter, 11].Text.ToString();
                            historyOfChat = ws.Cells[counter, 12].Text.ToString();

                            if(loginOfEmployee != "")
                                queue.Enqueue(new Chat(dateOfChat, loginOfEmployee, nameOfEmployee, numberOfCustomer, historyOfChat));
                        }
                    }
                    catch (IndexOutOfRangeException exc)
                    {
                        continue;
                        //MessageBox.Show(counter.ToString());
                        //break;
                        //MessageBox.Show($"{exc.Message} + строка {counter.ToString()}");
                    }
                }

            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                excel.Quit();
            }
            choiceButtonWrite.Enabled = true;
            beginWriting.Enabled = true;
            writingFileDirectory.Enabled = true;
            waitLabel.Visible = false;
        }

        // Загрузка Excel, начало выгрузки результатов
        private void ButtonWriting(object sender, EventArgs e)
        {  
            try
            {
                beginWriting.Enabled = false;
                wb = excel.Workbooks.Open(writingFileDirectory.Text);
                ws = wb.Worksheets[1];
                var lastCell = excel.Cells.SpecialCells(_Excel.XlCellType.xlCellTypeLastCell);
                string[,] list = new string[lastCell.Column, lastCell.Row];
                Writing();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошло некоторое говно");
            }
            finally
            {
                excel.Quit();
                Dispose();
            }
        }

        // определение, является ли чат правильным или нет. Получат текст чата
        // false если чат не правильный
        public bool DefineCorrectness(string chat)
        {
            // возвращает true если чат правильный, false - чат с долгим hold
            char owner;
            TimeSpan time;
            listOfMessagesInsideOfChat = new List<Message>();
            Message first = null, second = null;

            array = chat.ToCharArray();
            for (int counter = 0; counter < array.Length; counter++)
            {
                if ((array[counter] == '\n') &&
                    (array[counter + 3] == '(')&&
                    (array[counter + 9] == ')'))
                {
                    owner = array[counter + 1];
                    time = CreateTimeSpanFromChars(array[counter + 7], array[counter + 8],
                                                   array[counter + 4], array[counter + 5]);
                    listOfMessagesInsideOfChat.Add(new Message(owner, time));
                }
            }

            if (listOfMessagesInsideOfChat.Count != 0)
                first = listOfMessagesInsideOfChat[0];

            for (int counter = 1; counter < listOfMessagesInsideOfChat.Count; counter++)
            {
                if (listOfMessagesInsideOfChat.Count != 0)
                {
                    second = listOfMessagesInsideOfChat[counter];
                    if (IsHold(first, second))
                    {
                        return false;
                    }
                    first = second;
                }
            }
            return true;
        }

        private void Writing()
        {
            try
            {
                Chat chat;
                int counter = 2;

                while (queue.Count != 0)
                {
                    try
                    {
                        chat = queue.Dequeue();
                        if (!(chat.loginOfEmployee == "serebryakovakp"))
                        {
                            ws.Cells[counter, 2] = String.Format(chat.dateOfChat.ToString());
                            ws.Cells[counter, 3] = String.Format(chat.loginOfEmployee);
                            ws.Cells[counter, 4] = String.Format(chat.nameOfEmployee);
                            ws.Cells[counter, 5] = String.Format(chat.numberOfCustomer);
                            ws.Cells[counter, 6] = String.Format(chat.historyOfChat);
                            counter++;
                        }
                    }
                    catch (Exception exc)
                    {
                        continue;
                    }

                }
            }
            catch (Exception exc)
            {
                
            }
            
        }

        
        private TimeSpan CreateTimeSpanFromChars(char firstSecond, char secondSecond, 
                                                    char firstMinute, char secondMinute)
        {
            int seconds = int.Parse(firstSecond.ToString() + secondSecond.ToString());
            int minutes = int.Parse(firstMinute.ToString() + secondMinute.ToString());
            TimeSpan result = new TimeSpan(0,0,minutes,seconds);
            return result;
        }


        //возвращает true если время ответа превышено
        private bool IsHold(Message first, Message second)
        {
            //возращает true если время ожидания превышено. 
            if (((first.owner == 'О' && second.owner == 'О') && (second.time - first.time > control)) ||
                ((first.owner == 'K' && second.owner == 'О') && (second.time - first.time > control)) ||
                (first.owner == 'О' && second.owner == 'K') && ((second.time - first.time > control)))
                return true;
            return false;

        }

    }
}
