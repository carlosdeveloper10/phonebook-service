/*
* Copyright (c) Carlos Mario.
* Please, read the document https://github.com/carlosprogrammer/phonebook-service/blob/master/LICENSE
* of this code
*
*
*
*
*
*
*
*
* 
* 
* <carlos_programmer10@hotmail.com>
*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmsoft.CloudDBConnection
{
    /// <summary>
    /// It throws when occurs some exception with the connection
    /// 
    /// Autor: Carlos Mario <carlos_programmer@hotmail.com>
    /// </summary>
    public class ConnectionException : Exception
    {

        public ConnectionException()
        {
        }


        public ConnectionException(string message)
            : base(message)
        {
        }

        public ConnectionException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
