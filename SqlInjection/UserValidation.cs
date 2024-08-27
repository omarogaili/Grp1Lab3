using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SqlInjection
{
    public class UserValidation
    {
        public bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";  // Kontrollerar e-posten
            return Regex.IsMatch(email, emailPattern);
        }

        public bool IsValidPhoneNumber(string phoneNumber)
        {
            string phonePattern = @"^\d{10,15}$";  // Kontrollerar att telefonnumret är 10-15 siffror långt
            return Regex.IsMatch(phoneNumber, phonePattern);
        }
    }
}
