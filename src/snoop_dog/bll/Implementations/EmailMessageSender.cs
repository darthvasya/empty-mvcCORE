using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using snoop_dog.bll.Contracts;

namespace snoop_dog.bll.Implementations
{
    public class EmailMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Send by Email";
        }
    }
}
