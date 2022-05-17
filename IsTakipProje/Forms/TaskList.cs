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

            // Grafik verilerini oluşturma

            chart1.Series["Departments"].Points.AddXY("İnsan Kaynakları", 15);
            chart1.Series["Departments"].Points.AddXY("Yazılım", 60);
            chart1.Series["Departments"].Points.AddXY("Muhasebe Departmanı", 4);
            chart1.Series["Departments"].Points.AddXY("Bilgi İşlem", 23);
            chart1.Series["Departments"].Points.AddXY("Yönetim", 4);
            chart1.Series["Departments"].Points.AddXY("Kütüphane", 13);
            chart1.Series["Departments"].Points.AddXY("Donanım", 19);
            chart1.Series["Departments"].Points.AddXY("Mutfak", 15);
            chart1.Series["Departments"].Points.AddXY("Bahçe İşleri", 30);

            //

            // Panel verileni çeken kod bloğu


            lblAktif.Text = db.Tasks.Where(x => x.Situation == true).Count().ToString();
            lblInaktif.Text = db.Tasks.Where(x => x.Situation == false).Count().ToString();
            lblToplamD.Text = db.Departments.Count().ToString();


            //
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
