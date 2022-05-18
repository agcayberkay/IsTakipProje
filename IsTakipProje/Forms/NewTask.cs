using DevExpress.XtraEditors;
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
    public partial class NewTask : DevExpress.XtraEditors.XtraForm
    {
        public NewTask()
        {
            InitializeComponent();
        }

        private void NewTask_Load(object sender, EventArgs e)
        {
            dtTaskDate.DateTime = DateTime.Now;

            var istenilenDegerler = (from x in db.Personels
                                     select new
                                     {
                                         x.Id,
                                         AdSoyad =x.Name+" "+x.Surname,
                                                                       
                                     }).ToList();
            txtWorker.Properties.ValueMember = "Id";
            txtWorker.Properties.DisplayMember = "AdSoyad";
            txtWorker.Properties.DataSource = istenilenDegerler;
        }

        IsTakipEntities db = new IsTakipEntities();

        private void btnTaskAdd_Click(object sender, EventArgs e)
        {
            Tasks t = new Tasks();
            t.Descriptions = txtDescription.Text;
            t.Situation = true;
            t.Worker = int.Parse(txtWorker.EditValue.ToString());
            t.DateT = DateTime.Parse(dtTaskDate.Text);
            t.Employer = int.Parse(txtEmployeer.Text);
            db.Tasks.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Görev başarılı bir şekilde eklendi.","Added",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnTaskCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
