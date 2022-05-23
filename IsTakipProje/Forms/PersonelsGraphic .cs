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
    public partial class PersonelsGraphic : Form
    {
        public PersonelsGraphic()
        {
            InitializeComponent();
        }

        IsTakipEntities1 db = new IsTakipEntities1();
        private void PersonelsGraphic_Load(object sender, EventArgs e)
        {
            lblToplamDepartman.Text = db.Departments.Count().ToString();
            lblToplamPersonel.Text = db.Personels.Count().ToString();
            lblFirmaSayisi.Text = db.Company.Count().ToString();
            lblAktifİsSayisi.Text = db.Tasks.Count(x => x.Situation == true).ToString();
            lblInAkitfİsSayisi.Text = db.Tasks.Count(x => x.Situation == false).ToString();
            lblSonGörev.Text = db.Tasks.OrderByDescending(x => x.ID).Select(x => x.Descriptions).FirstOrDefault();
            lblSGT.Text = db.Tasks.OrderByDescending(x => x.ID).Select(x => x.DateT).FirstOrDefault().ToString();
            lblIsYapilanSehir.Text = db.Company.Select(x => x.Province).Distinct().Count().ToString();
            lblSektorSayisi.Text = db.Company.Select(x => x.Sector).Distinct().Count().ToString();
            DateTime bugun = DateTime.Today;
            lblBugunGorev.Text = db.Tasks.Count(x => x.DateT == bugun).ToString();
            var ayınPersoneli = db.Tasks.GroupBy(x => x.Worker).OrderByDescending(Z => Z.Count()).Select(y => y.Key).FirstOrDefault();
            lblAyinPersoneli.Text = db.Personels.Where(x => x.Id == ayınPersoneli).Select(y => y.Name +" "+ y.Surname).FirstOrDefault().ToString();
            lblAyınDepartmanı.Text = db.Departments.Where(x => x.ID == db.Personels.Where(y => y.Id == ayınPersoneli).Select
            (z => z.Department).FirstOrDefault()).Select(a => a.Name).FirstOrDefault().ToString();

        }
    }
}
