using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Utilies.Exceptions
{
    class NotAvailableException:Exception
    {
        public NotAvailableException(string message) :base(message)
        {

        }
    }
}
