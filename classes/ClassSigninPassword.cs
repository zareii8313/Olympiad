using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad.classes
{
    class ClassSigninPassword
    {
        public static bool ValidPassword(string password)
        {
            if ((password.Length >= 8) &&
                Consecutive(password) == true &&
                Repetitive(password) == true)
            {
                return true;
            }
            else if (password.Length < 8)
            {
                System.Windows.Forms.MessageBox.Show("رمز عبور باید حداقل 8 کاراکتر باشد.",
                   "InvalidPassword", System.Windows.Forms.MessageBoxButtons.OK,
                   System.Windows.Forms.MessageBoxIcon.Warning);
                return false;
            }
            else if (!Consecutive(password))
            {
                System.Windows.Forms.MessageBox.Show("رمز عبور نباید شامل اعداد متوالی باشد.",
                    "InvalidPassword", System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning);
                return false;
            }
            else if (!Repetitive(password))
            {
                System.Windows.Forms.MessageBox.Show("رمز عبور نباید شامل الگوهای حداقل دو حرفی تکراری  باشد.",
                                  "InvalidPassword", System.Windows.Forms.MessageBoxButtons.OK,
                                  System.Windows.Forms.MessageBoxIcon.Warning);
                return false;
            }
            else
                return false;
        }

        //Not Be Consecutive
        private static bool Consecutive(string input)
        {
            //separate numbers
            string NumPart = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    NumPart += input[i];
                }
            }
            //Check Consecutives
            bool result = true;
            if (!string.IsNullOrEmpty(NumPart))
            {
                for (int i = 0; i < NumPart.Length; i++)
                {
                    int num = NumPart[i];
                    for (int j = 0; j < NumPart.Length; j++)
                    {
                        if ((num - 1 == NumPart[j]) || (num + 1 == NumPart[j]))
                        {
                            result = false;
                            break;
                        }
                    }
                }
            }
            if (result)
            {
                return true;
            }
            return false;
        }

        //Not Be Repetitive
        private static bool Repetitive(string input)
        {
            //Separate Letters
            string LetterPart = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    LetterPart += input[i];
                }
            }
            //Check Repetitive
            bool result = true;
            for (int i = 0; i < LetterPart.Count() - 2; i++)
            {
                for (int j = i + 1; j < LetterPart.Count() - 2; j++)
                {
                    if ((LetterPart[i] == LetterPart[j]) &&
                        (LetterPart[i + 1] == LetterPart[j + 1]) &&
                        (LetterPart[i + 2] == LetterPart[j + 2]))
                    {
                        result = false;
                        break;
                    }
                }
            }
            if (result)
            {
                return true;
            }
            return false;
        }
    }
}
