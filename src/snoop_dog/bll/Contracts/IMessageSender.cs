using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace snoop_dog.bll.Contracts
{
    public interface IMessageSender
    {
        string Send();
    }
}
