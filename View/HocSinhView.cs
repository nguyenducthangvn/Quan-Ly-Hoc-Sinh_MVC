using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoHinh_MVC.Controller;
using MoHinh_MVC.Model;
using MoHinh_MVC.Helper;

namespace MoHinh_MVC.View
{
    class HocSinhView
    {
        HocSinhController hc = new HocSinhController();

        public void Menu()
        {
            Clear();
            WriteLine("------------Quan Ly Hoc Sinh-----------");
            WriteLine("1. Hien thi danh sach hoc sinh");
            WriteLine("2. Them hoc sinh moi");
            WriteLine("3. Sua thong tin hoc sinh");
            WriteLine("4. Xoa hoc sinh");
            WriteLine("5. Thoat");
            Write("Chon:  ");
            char c = ReadKey().KeyChar;
            WriteLine();
            DoAction(c);
        }
        private void DoAction(char c)
        {
            switch(c)
            {
                case '1':
                    ErrorHelper.Log(hc.Hien());
                    break;
                case '2':
                    ErrorHelper.Log(hc.Them(new HocSinh(InputType.Them)));
                    break;
                case '3':
                    ErrorHelper.Log(hc.Sua(new HocSinh(InputType.Sua)));
                    break;
                case '4':
                    ErrorHelper.Log(hc.Xoa(new HocSinh(InputType.Xoa)));
                    break;
                case '5':
                    return;
            }    
            ReadKey();
            Menu();
        }

    }
}
