using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Solid.CSharp.ConsoleApp
{
    internal class Valid
    {
        private string _firstname;
        private string _lastname;
        private int email;

        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                if (Regex.IsMatch())
                {
                    _firstname = value;
                }
            }
        }
    }
}