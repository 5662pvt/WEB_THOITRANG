using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WEB_THOITRANG.Models
{
    public class Product
    {
        MyDataDataContext db = new MyDataDataContext();
        public Product()
        {

        }
        public IEnumerable<SanPham> ListAll(int page, int pageSize)
        {
            return db.SanPhams.OrderByDescending(sp => sp.MaSP).ToPagedList(page, pageSize);
        }
    }
}