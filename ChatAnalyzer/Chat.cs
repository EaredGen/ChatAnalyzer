using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAnalyzer
{
    class Chat
    {
        public DateTime dateOfChat;
        public string loginOfEmployee;
        public string nameOfEmployee;
        public string numberOfCustomer;
        public string historyOfChat;

        public Chat(DateTime dateOfChat, string loginOfEmployee, 
            string nameOfEmployee, string numberOfCustomer, string historyOfChat)
        {
            this.dateOfChat = dateOfChat;
            this.loginOfEmployee = loginOfEmployee;
            this.nameOfEmployee = nameOfEmployee;
            this.numberOfCustomer = numberOfCustomer;
            this.historyOfChat = historyOfChat;
        }

    }
}
