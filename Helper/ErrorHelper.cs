using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoHinh_MVC.Helper
{
    enum ErrorType //enum: kiểu dữ liệu liệt kê
    {
        ThanhCong,
        TrungMa,
        KhongCoMa,
        DanhSachTrong
    }
    class ErrorHelper
    {
        public static void Log(ErrorType et) //Ghi lỗi ra
        {
            switch(et)
            {
                case ErrorType.ThanhCong:
                    Console.WriteLine("Thuc hien thao tac thanh cong");
                    break;
                case ErrorType.TrungMa:
                    Console.WriteLine("Ma da bi trung");
                    break;
                case ErrorType.KhongCoMa:
                    Console.WriteLine("Khong tin thay ma nay");
                    break;
                case ErrorType.DanhSachTrong:
                    Console.WriteLine("Khong có ban ghi nao trong danh sach");
                    break;

            }    
        }
    }
}
