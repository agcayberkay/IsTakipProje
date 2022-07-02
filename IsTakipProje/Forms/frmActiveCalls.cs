using IsTakipProje.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakipProje.Forms
{
    public partial class frmActiveCalls : DevExpress.XtraEditors.XtraForm
    {
        public frmActiveCalls()
        {
            InitializeComponent();
            gridView1.OptionsBehavior.Editable = false;
        }

        IsTakipEntities1 db = new IsTakipEntities1();
        private void frmActiveCalls_Load(object sender, EventArgs e)
        {
            activeCalls();
        }

        public void activeCalls()
        {
            var degerler = (from x in db.InCall
                            select new
                            {
                                x.ID,
                                x.Company.Name,
                                x.Company.Phone,
                                x.Descriptions,
                                x.Subjects,
                                x.Durum
                            }
                            ).Where(y=> y.Durum==true).ToList();
            gridControl1.DataSource = degerler;
        }
    }
}
