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
    public partial class TaskList : Form
    {
        public TaskList()
        {
            InitializeComponent();
            gridView1.OptionsBehavior.Editable = false;
        }

        private void pnlOrtaUst_Paint(object sender, PaintEventArgs e)
        {

        }

        IsTakipEntities db = new IsTakipEntities();

        private void TaskList_Load(object sender, EventArgs e)
        {
            // Listeye verileri çekme
            var istenilenDegerler = (from x in db.Tasks
                                     select new
                                     {
                                         x.ID,
                                         x.Descriptions,
                                         x.Situation
                                     }).ToList() ;
            grdTaskList.DataSource = istenilenDegerler;
            //

       

            // Panel verileni çeken kod bloğu


            lblAktif.Text = db.Tasks.Where(x => x.Situation == true).Count().ToString();
            lblInaktif.Text = db.Tasks.Where(x => x.Situation == false).Count().ToString();
            lblToplamD.Text = db.Departments.Count().ToString();
            //


            // Grafik verilerini oluşturma

            chartControl1.Series["Departments"].Points.AddPoint("Aktif Görevler", int.Parse(lblAktif.Text));
            chartControl1.Series["Departments"].Points.AddPoint("İnaktif Görevler", int.Parse(lblInaktif.Text));
            


            //
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
