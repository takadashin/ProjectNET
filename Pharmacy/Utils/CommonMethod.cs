using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Utils
{
    class CommonMethod
    {
        public static bool checkEmptyString(string text,string errorMsg,string caption)
        {
            if (text.Trim() == "")
            {
                if (errorMsg != null)
                    MessageBox.Show(errorMsg, caption);
                return true;
            }
            return false;
        }

        
        public static bool checkNotInt(string text, string errorMsg, string caption)
        {
            int number;
            if (text.Trim() != "" && !Int32.TryParse(text.Trim(), out number))
            {
                if (errorMsg != null)
                    MessageBox.Show(errorMsg, caption);
                return true;
            }
            return false;
        }

        public static bool checkNotDateTime(string text, string errorMsg, string caption)
        {
            DateTime date;
            if (text.Trim() != "" && !DateTime.TryParse(text.Trim(), out date))
            {
                if (errorMsg != null)
                    MessageBox.Show(errorMsg, caption);
                return true;
            }
            return false;
        }
        public static int getComboboxIndex(string[] source,string text)
        {
            for (int i = 0; i < source.Length; i++)
            {
                if(text.Trim() == source[i])
                    return i;
            }
            return 0;
        }
    }
}
