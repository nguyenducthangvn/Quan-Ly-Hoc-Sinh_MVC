using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoHinh_MVC.Helper;

namespace MoHinh_MVC.Model
{
    class HocSinh
    {
        public int HocSinhID { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public HocSinh(InputType it)
        {
            if (it == InputType.Them || it == InputType.Sua)
            {
                HocSinhID = InputHelper.InputINT(res.InpMaHS, res.ErrMaHS);
                Ten = InputHelper.InputSTR(res.InpTen, res.ErrTen, 6, 20);
                NgaySinh = InputHelper.InputDT(res.InpNgaySinh, res.ErrNgaySinh,
                    new DateTime(2002, 1, 1), new DateTime(2013, 12, 31));
            }
            else if (it == InputType.Xoa)
            {
                HocSinhID = InputHelper.InputINT(res.InpMaHS, res.ErrMaHS);
            }
        }
        
        public void Hien()
            => Console.WriteLine($"{HocSinhID} ten la {Ten}, " +
                $"sinh ngay {NgaySinh.ToShortDateString()}");
    }
}
