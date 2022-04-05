using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Utilies.Exceptions
{
    class NotFoundException:Exception
    {
        public NotFoundException(string message):base(message)
        {

        }
    }
}
