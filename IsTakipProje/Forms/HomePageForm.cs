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
            gridView2.OptionsBehavior.Editable = false;
            gridView3.OptionsBehavior.Editable = false;
            gridView4.OptionsBehavior.Editable = false;

        }

        IsTakipEntities1 db = new IsTakipEntities1();
        #region GridControle çekilecek işlemler


        private void ActiveTaskList()
        {
            var istenilenDegler = (from x in db.Tasks
                                   select new
                                   {
                                       x.Descriptions,
                                       Personel = x.Personels1.Name + " " + x.Personels1.Surname,
                                       x.Situation
                                   }).Where(y => y.Situation == true).ToList();

            grdDevamEdenGorevler.DataSource = istenilenDegler;
            gridView1.Columns["Situation"].Visible = false;
        }


        private void TaskDateToday()
        {
            DateTime todays = DateTime.Parse(DateTime.Today.ToShortDateString());
            var istenilenDegerler = (from x in db.MissionDetails
                                     select new
                                     {

                                         Gorev = x.Tasks.Descriptions,
                                         x.Descriptions,
                                         x.Dates
                                     }
                                   ).Where(x => x.Dates == todays).ToList();
            grdTodaysTasks.DataSource = istenilenDegerler;

        }


        private void InCall()
        {
            var istenilenDegerler = (from x in db.InCall
                                     select new
                                     {
                                         x.Company.Name,
                                         x.Subjects,
                                         x.Durum,
                                         x.Dates
                                     }).Where(y => y.Durum == true).ToList();
            grdInCall.DataSource = istenilenDegerler;
            gridView3.Columns["Durum"].Visible = false;


        }


        private void CompanyList()
        {
            var istenilenDegerler = (from x in db.Company
                                     select new
                                     {
                                         x.Name,
                                         x.Phone,
                                         x.Mail
                                     }
                                    ).ToList();
            grdCompany.DataSource = istenilenDegerler;
        }

        #endregion

        #region Active Inaktif Call

        private void IncallControl()
        {
            int activeCall = db.InCall.Where(x => x.Durum == true).Count();
            int inactiveCall = db.InCall.Where(x => x.Durum == false).Count();

            chartControl1.Series["In Call Graphic"].Points.AddPoint("Aktif Görevler", activeCall);
            chartControl1.Series["In Call Graphic"].Points.AddPoint("İnaktif Görevler", inactiveCall);
        }




        #endregion

        private void HomePageForm_Load(object sender, EventArgs e)
        {
            ActiveTaskList();
            TaskDateToday();
            InCall();
            CompanyList();

            IncallControl();
        }



        private void grdInCall_Click(object sender, EventArgs e)
        {

        }
    }
}
