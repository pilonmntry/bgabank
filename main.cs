using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Net;

namespace bga.com
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            // this is not a malware
            string username = "hack";
            string password = "şifre";
            
            ADConnector conn = new ADConnections(username, password);
            
            // use the conn
        }
    }
}
