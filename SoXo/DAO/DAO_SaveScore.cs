using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoXo.DAO
{
    class DAO_SaveScore
    {
        DoMinEntities db;
        public DAO_SaveScore()
        {
            db = new DoMinEntities();
        }
        public dynamic GetListScore()
        {
            var ds = db.SaveScores.Select(s => s).ToList();
            return ds;
        }
        public void SaveScore(SaveScore ss)
        {
            SaveScore a = db.SaveScores.FirstOrDefault(s => s.TenNguoiChoi == ss.TenNguoiChoi);
            if (a != null)
            {
                db.SaveScores.Remove(a);
            }
            db.SaveScores.Add(ss);
            db.SaveChanges();
        }
    }
}
