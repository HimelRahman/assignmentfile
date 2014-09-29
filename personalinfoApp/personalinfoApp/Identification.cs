using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personalinfoApp
{
    class Identification
    {
        public string firstname;
        public string lastname;
        public string fathername;
        public string mothername;
        public string address;

        public string Firstname 
        {
            set
            {
                if(value.Length>=3)
                firstname = value;
            }
            get
            {
                return firstname;
            }
        }

        public string Lastname
        {
            set
            {
                if (value.Length >= 3)
                    lastname = value;
            }
            get
            {
                return lastname;
            }
        }

        public string Fathername
        {
            set
            {
                if (value.Length >= 3)
                    fathername = value;
            }
            get
            {
                return fathername;
            }
        }

        public string Mothername
        {
            set
            {
                if (value.Length >= 3)
                    mothername = value;
            }
            get
            {
                return mothername;
            }
        }

        public string Address
        {
            set
            {
                if (value.Length >= 3)
                    address = value;
            }
            get
            {
                return address;
            }
        }

        public string Getfullname()
        {
            return firstname + " " + lastname;
        }
    }
}
