using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {

        }

        public Client (string name, string email, DateTime birthDate)
        {
            if (validaEmail(email))
            {
                Name = name;
                Email = email;
                BirthDate = birthDate;
            }
            else
            {
                Console.WriteLine("Email invalido");
            }
        }

        public Boolean validaEmail (string email)
        {
            if (email.Contains('@') && email.Contains('.'))
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" ("+BirthDate.ToShortDateString()+") - ");
            sb.Append(Email);
            return sb.ToString();
        }
    }
}
