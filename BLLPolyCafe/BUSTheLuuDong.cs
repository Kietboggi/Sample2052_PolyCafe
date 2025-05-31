using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PolyCafe;
using DTO_PolyCafe;


namespace BLLPolyCafe
{
    public class BUSTheLuuDong
    {
        DALTheLuuDong dALTheLuuDong = new DALTheLuuDong();

        public List<TheLuuDong> GetTheLuuDongList()
        {
            return dALTheLuuDong.selectAll();
        }


        public string InsertTheLuuDong(TheLuuDong the)
        {
            try
            {
                the.MaThe = dALTheLuuDong.generateTheLuuDong();
                if (string.IsNullOrEmpty(the.MaThe))
                {
                    return "Mã thẻ lưu động không hợp lệ.";
                }

                dALTheLuuDong.insertTheLuuDong(the);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Thêm mới không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string UpdateTheLuuDong(TheLuuDong nv)
        {
            try
            {
                if (string.IsNullOrEmpty(nv.MaThe))
                {
                    return "Mã thẻ lưu động không hợp lệ.";
                }

                dALTheLuuDong.updateTheLuuDong(nv);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Cập nhật không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string DeleteTheLuuDong(string maThe)
        {
            try
            {
                if (string.IsNullOrEmpty(maThe))
                {
                    return "Mã thẻ lưu động không hợp lệ.";
                }

                dALTheLuuDong.deleteTheLuuDong(maThe);
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
