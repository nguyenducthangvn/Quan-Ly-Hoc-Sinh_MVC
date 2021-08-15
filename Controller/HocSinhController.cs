using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoHinh_MVC.Model;
using MoHinh_MVC.Helper;

namespace MoHinh_MVC.Controller
{
    class HocSinhController
    {
        List<HocSinh> lst = new List<HocSinh>();

        //Xử lý nghiệp vụ ở trong Model (crud): hiển thị, thêm, sửa, xoá (Create, update, delete)
        public ErrorType Them(HocSinh hs)
        {
            if (lst.Count == 0)
            {
                lst.Add(hs);
                return ErrorType.ThanhCong;
            }
            else
            {
                int pos = lst.FindIndex(x => x.HocSinhID == hs.HocSinhID);
                if (pos == -1)
                {
                    lst.Add(hs);
                    return ErrorType.ThanhCong;
                }
                return ErrorType.TrungMa;
            }
        }

        public ErrorType Sua(HocSinh hs)
        {
            if (lst.Count == 0)
                return ErrorType.DanhSachTrong;
            else
            {
                int pos = lst.FindIndex(x => x.HocSinhID == hs.HocSinhID);
                if (pos == -1)
                    return ErrorType.KhongCoMa;
                lst[pos] = hs;
                return ErrorType.ThanhCong;
            }
        }

        public ErrorType Xoa(HocSinh hs)
        {
            if (lst.Count == 0)
                return ErrorType.DanhSachTrong;
            else
            {
                int pos = lst.FindIndex(x => x.HocSinhID == hs.HocSinhID);
                if (pos == -1)
                    return ErrorType.KhongCoMa;
                lst.RemoveAt(pos);
                return ErrorType.ThanhCong;
            }
        }

        public ErrorType Hien()
        {
            if (lst.Count == 0)
                return ErrorType.DanhSachTrong;
            else
            {
                lst.ForEach(x => x.Hien());
                return ErrorType.ThanhCong;
            }
        }
    }
}
