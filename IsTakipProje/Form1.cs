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


        

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Departmentt departmentt = new Departmentt();
            departmentt.MdiParent = this;
            departmentt.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelsList pr = new PersonelsList();
            pr.MdiParent = this;
            pr.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelsGraphic pg = new PersonelsGraphic();
            pg.MdiParent = this;
            pg.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TaskList taskL = new TaskList();
            taskL.MdiParent = this;
            taskL.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NewTask ntask = new NewTask();
            ntask.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddPersonel adp = new AddPersonel();
            adp.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TaskDetails tskd = new TaskDetails();
            tskd.MdiParent = this;
            tskd.Show();
        }
    }
}
