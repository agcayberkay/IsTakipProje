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
    public partial class HomePageForm : DevExpress.XtraEditors.XtraForm
    {
        public HomePageForm()
        {
            InitializeComponent();
            gridView1.OptionsBehavior.Editable = false;
        }

        IsTakipEntities db = new IsTakipEntities();

        private void ActiveTaskList()
        {
            var istenilenDegler = (from x in db.Tasks
                                   select new
                                   {
                                       x.Descriptions,
                                       Personel = x.Personels1.Name+" "+x.Personels1.Surname,
                                       x.Situation
                                   }).Where(y=> y.Situation==true).ToList();
            grdDevamEdenGorevler.DataSource = istenilenDegler;
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {
            ActiveTaskList();
        }
    }
}
