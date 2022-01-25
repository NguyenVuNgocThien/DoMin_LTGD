using SoXo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoXo.BUS
{
    class BUS_SaveScore
    {
        DAO_SaveScore dSave;
        public BUS_SaveScore()
        {
            dSave = new DAO_SaveScore();
        }
        public void GetListScore(DataGridView dg)
        {
            dg.DataSource = dSave.GetListScore();
        }
        public int SaveScore(SaveScore ss)
        {
            int kq = 0;
            try
            {
                dSave.SaveScore(ss);
                kq = 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return kq;
        }
    }
}
