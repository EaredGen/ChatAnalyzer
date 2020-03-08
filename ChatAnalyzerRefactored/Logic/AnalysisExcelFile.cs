using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAnalyzer.Logic
{
    class AnalysisExcelFile
    {
        OpenedExcel openedExcel;

        private Chat chat = new Chat();

        private TimeSpan control = new TimeSpan(0, 0, 5, 0);

        private Queue<Chat> longWaitChat;
        private List<Message> listOfMessagesInsideOfChat;
        private char[] array;

        public AnalysisExcelFile(OpenedExcel openedExcel)
        {
            this.openedExcel = openedExcel;
            longWaitChat = new Queue<Chat>();
            listOfMessagesInsideOfChat = new List<Message>();
        }

        public void Reading()
        {
            try
            {
                for (int counter = 2; counter < openedExcel.lastCell.Row; counter++)
                {
                    try
                    {
                        if (!DefineCorrectness(openedExcel.ws.Cells[counter, 12].Text.ToString()))
                        {
                            chat.dateOfChat = Convert.ToDateTime(openedExcel.ws.Cells[counter, 2].Text.ToString());
                            chat.loginOfEmployee = openedExcel.ws.Cells[counter, 9].Text.ToString();
                            chat.nameOfEmployee = openedExcel.ws.Cells[counter, 10].Text.ToString();
                            chat.numberOfCustomer = openedExcel.ws.Cells[counter, 11].Text.ToString();
                            chat.historyOfChat = openedExcel.ws.Cells[counter, 12].Text.ToString();

                            if (chat.loginOfEmployee != "")
                                longWaitChat.Enqueue(new Chat(chat.dateOfChat, chat.loginOfEmployee,
                                    chat.nameOfEmployee, chat.numberOfCustomer, chat.historyOfChat));
                        }
                    }
                    catch (IndexOutOfRangeException exc)
                    {
                        continue;
                    }
                }
            }
            catch (Exception ex)
            {
                openedExcel.excel.Quit();
                
            }
            finally
            {
                openedExcel.excel.Quit();
            }
        }

        private bool DefineCorrectness(string chat)
        {
            char owner;
            TimeSpan time;
            listOfMessagesInsideOfChat = new List<Message>();
            Message first = null, second = null;

            array = chat.ToCharArray();
            for (int counter = 0; counter < array.Length; counter++)
            {
                if ((array[counter] == '\n') &&
                    (array[counter + 3] == '(') &&
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

        public Queue<Chat> ReturnResult()
        {
            return longWaitChat;
        }
        private TimeSpan CreateTimeSpanFromChars(char firstSecond, char secondSecond,
                                                    char firstMinute, char secondMinute)
        {
            int seconds = int.Parse(firstSecond.ToString() + secondSecond.ToString());
            int minutes = int.Parse(firstMinute.ToString() + secondMinute.ToString());
            TimeSpan result = new TimeSpan(0, 0, minutes, seconds);
            return result;
        }

        private bool IsHold(Message first, Message second)
        {
            if (((first.owner == 'О' && second.owner == 'О') && (second.time - first.time > control)) ||
                ((first.owner == 'K' && second.owner == 'О') && (second.time - first.time > control)) ||
                (first.owner == 'О' && second.owner == 'K') && ((second.time - first.time > control)))
                return true;
            return false;

        }
    }
}
