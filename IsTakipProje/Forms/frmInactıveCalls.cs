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
    public partial class frmInactıveCalls : DevExpress.XtraEditors.XtraForm
    {
        public frmInactıveCalls()
        {
            InitializeComponent();
            gridView1.OptionsBehavior.Editable = false;
        }

        IsTakipEntities1 db = new IsTakipEntities1();

        public void ınactiveCalls()
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
                            }).Where(x=> x.Durum==false).ToList();
            gridControl1.DataSource = degerler;
        }

        private void frmInactıveCalls_Load(object sender, EventArgs e)
        {
            ınactiveCalls();
        }
    }
}
