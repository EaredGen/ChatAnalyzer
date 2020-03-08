using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ChatAnalyzer.Logic
{
    class Writer
    {
        private Queue<Chat> longWaitChat;
        private OpenedExcel openedExcel;

        public Writer(Queue<Chat> longWaitChat, OpenedExcel openedExcel)
        {
            this.longWaitChat = longWaitChat;
            this.openedExcel = openedExcel;
        }

        public void StartWritting()
        {
            try
            {
                Chat chat;
                int counter = 2;

                while (longWaitChat.Count != 0)
                {
                    try
                    {
                        chat = longWaitChat.Dequeue();
                        if (!(chat.loginOfEmployee == "serebryakovakp"))
                        {
                            openedExcel.ws.Cells[counter, 2] = String.Format(chat.dateOfChat.ToString());
                            openedExcel.ws.Cells[counter, 3] = String.Format(chat.loginOfEmployee);
                            openedExcel.ws.Cells[counter, 4] = String.Format(chat.nameOfEmployee);
                            openedExcel.ws.Cells[counter, 5] = String.Format(chat.numberOfCustomer);
                            openedExcel.ws.Cells[counter, 6] = String.Format(chat.historyOfChat);
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
                openedExcel.excel.Quit();
            }
            finally
            {
                openedExcel.excel.Quit();
            }
        }
    }
}
