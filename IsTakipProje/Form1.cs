using IsTakipProje.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakipProje
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }


        HomePageForm home;
        Departmentt departmentt;
        PersonelsList pr;
        PersonelsGraphic pg;
        TaskList taskL;
        NewTask ntask;
        AddPersonel adp;
        TaskDetails tskd;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (departmentt == null || departmentt.IsDisposed)
            {
                departmentt = new Departmentt();
                departmentt.MdiParent = this;
                departmentt.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Açılan sayfanın bir daha açılmaması için gerekli kod bloğu
            if (pr == null || pr.IsDisposed)
            {
                pr = new PersonelsList();
                pr.MdiParent = this;
                pr.Show();
            }

        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (pg == null || pg.IsDisposed)
            {
                pg = new PersonelsGraphic();
                pg.MdiParent = this;
                pg.Show();
            }

        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (taskL == null || taskL.IsDisposed)
            {
                taskL = new TaskList();
                taskL.MdiParent = this;
                taskL.Show();
            }

        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ntask == null || ntask.IsDisposed)
            {
                ntask = new NewTask();
                ntask.Show();
            }

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (adp == null || adp.IsDisposed)
            {
                adp = new AddPersonel();
                adp.Show();
            }

        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tskd == null || tskd.IsDisposed)
            {
                tskd = new TaskDetails();
                tskd.MdiParent = this;
                tskd.Show();
            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (home == null || home.IsDisposed)
            {
                home = new HomePageForm();
                home.MdiParent = this;
                home.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            home = new HomePageForm();
            home.MdiParent = this;
            home.Show();
        }
    }
}
