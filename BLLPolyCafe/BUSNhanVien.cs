using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PolyCafe;
using DTO_PolyCafe;

namespace BLL_PolyCafe
{
    public class BUSNhanVien
    {
        DALNhanVien dAlNhanVien = new DALNhanVien();

        public NhanVien DangNhap(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return null;
            }

            return dAlNhanVien.getNhanVien1(username, password);
        }

        public bool ResetMatKhau(string email, string mk)
        {
            try
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(mk))
                {
                    return false;
                }
                dAlNhanVien.reset(mk, email);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<NhanVien> GetNhanVienList()
        {
            return dAlNhanVien.selectAll();
        }


        public string InsertNhanVien(NhanVien nv)
        {
            try
            {
                nv.MaNhanVien = dAlNhanVien.generateMaNhanVien();
                if (string.IsNullOrEmpty(nv.MaNhanVien))
                {
                    return "Mã nhân viên không hợp lệ.";
                }
                if (dAlNhanVien.checkEmailExists(nv.Email))
                {
                    return "Email đã tồn tại.";
                }
                dAlNhanVien.insert(nv);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Thêm mới không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string UpdateNhanVien(NhanVien nv)
        {
            try
            {
                if (string.IsNullOrEmpty(nv.MaNhanVien))
                {
                    return "Mã nhân viên không hợp lệ.";
                }

                dAlNhanVien.update(nv);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Cập nhật không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string DeleteNhanVien(string maNV)
        {
            try
            {
                if (string.IsNullOrEmpty(maNV))
                {
                    return "Mã nhân viên không hợp lệ.";
                }

                dAlNhanVien.delete(maNV);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Xóa không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }
    }
}
    
