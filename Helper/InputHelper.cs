using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoHinh_MVC.Helper
{
    enum InputType
    {
        Them,
        Sua,
        Xoa
    }
    class InputHelper
    {
        public static int InputINT(string msg, string err)
        {
            bool ok = true;
            int ret;
            do
            {
                Console.WriteLine(msg);
                ok = int.TryParse(Console.ReadLine(), out ret);
                if (!ok) Console.WriteLine(err);
            } while (!ok);
            return ret;
        }
        public static string InputSTR(string msg, string err, int minLength = 0, int maxLength = int.MaxValue)
        {
            bool ok = true;
            string ret;
            do
            {
                Console.WriteLine(msg);
                ret = Console.ReadLine();
                ok = ret.Length >= minLength && ret.Length <= maxLength;
                if (!ok) Console.WriteLine(err);
            } while (!ok);
            return ret;
        }
        public static DateTime InputDT(string msg, string err, DateTime min, DateTime max)
        {
            bool ok = true;
            DateTime ret;
            do
            {
                Console.WriteLine(msg);
                ok = DateTime.TryParse(Console.ReadLine(), out ret);
                ok = ok && ret >= min && ret <= max;
                if (!ok) Console.WriteLine(err);
            } while (!ok);
            return ret;
        }
    }
}
