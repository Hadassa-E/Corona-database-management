using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Functions
{
    public class ChecksBLL
    {
        #region Input integrity checks
        public bool IsValidIsraeliId(string id)
        {
            if (id.Length != 9)
                return false;

            foreach (char c in id)
            {
                if (!char.IsDigit(c))
                    return false;
            }

            // בדיקת ספרת הביקורת
            int[] idDigits = id.Select(c => c - '0').ToArray();
            int sum = 0;
            for (int i = 0; i < idDigits.Length - 1; i++)
            {
                int digit = idDigits[i];
                if (i % 2 == 0)
                {
                    digit *= 1;
                }
                else
                {
                    digit *= 2;
                    if (digit > 9)
                    {
                        digit = digit / 10 + digit % 10;
                    }
                }
                sum += digit;
            }

            return (sum + idDigits[idDigits.Length - 1]) % 10 == 0;
        }


        public static bool IsValidHebrewText(string name)
        {
            for (int i = 0; i < name.Length; i++)
                if ((name[i] < 'א' || name[i] > 'ת') && name[i] != ' ')
                    return false;
            return true;
        }


        public static bool IsValidEnglishText(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                    return false;
            }

            return true;
        }

        public static bool IsValidPhone(string phone)
        {
            if (phone.Length != 10)
                return false;
            if (phone[0] != '0' || phone[1] != '5')
                return false;
            for (int i = 2; i < phone.Length; i++)
                if (phone[i] < '0' || phone[i] > '9')
                    return false;
            return true;
        }


        public static bool IsValidTelephone(string phone)
        {
            if (phone.Length != 10 && phone.Length != 9)
                return false;
            if (phone[0] != '0')
                return false;
            for (int i = 1; i < phone.Length; i++)
                if (phone[i] < '0' || phone[i] > '9')
                    return false;
            return true;
        }

        #endregion
    }
}
