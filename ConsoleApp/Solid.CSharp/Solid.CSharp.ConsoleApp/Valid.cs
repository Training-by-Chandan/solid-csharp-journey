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
        private string _email;

        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                Regex re = new Regex("[A-Z][a-z]{2,}");
                if (re.IsMatch(value))
                {
                    _firstname = value;
                }
                else
                {
                    throw new Exception($"Staring alphabet should be captial followed by small alphabets and Minimun lenght of 3");
                }
            }
        }

        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                Regex re = new Regex("[A-Z][a-z]{2,}");
                if (re.IsMatch(value))
                {
                    _lastname = value;
                }
                else
                {
                    throw new Exception($"Staring alphabet of last name should be captial followed by small alphabets and Minimun lenght of 3");
                }
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                Regex re = new Regex("");
                if (re.IsMatch(value))
                {
                    _email = value;
                }
                else
                {
                    throw new Exception($"Email should start with alphabet and must contain symbols like @ .");
                }
            }
        }
    }
}