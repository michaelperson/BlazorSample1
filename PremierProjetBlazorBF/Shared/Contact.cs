using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierProjetBlazorBF.Shared
{
    public class Contact
    {
        private string _nom, _email, _message;

        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
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
                _email = value;
            }
        }

        public string Message
        {
            get
            {
                return _message;
            }

            set
            {
                _message = value;
            }
        }
    }
}
