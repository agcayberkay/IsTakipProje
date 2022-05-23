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
    public partial class AddPersonel : DevExpress.XtraEditors.XtraForm
    {
        public AddPersonel()
        {
            InitializeComponent();
        }

        IsTakipEntities1 db = new IsTakipEntities1();

        Personels P1 = new Personels();


        private void btnPersonelAdd_Click(object sender, EventArgs e)
        {
            // Personel ekleme işlemi

            P1.Id = int.Parse(txtPAID.Text);
            var arananDeger = db.Personels.Find(P1.Id);
            if (arananDeger == null)
            {
                P1.Name = txtPAName.Text;
                P1.Surname = txtPASurname.Text;
                P1.Mail = txtPAMail.Text;
                P1.Phone = txtPAPhone.Text;
                P1.Gorsel = txtPAGorsel.Text;
                P1.Department = int.Parse(lookUpPADepartments.EditValue.ToString());
                P1.Durum = true;
                db.Personels.Add(P1);
                db.SaveChanges();
                XtraMessageBox.Show("Personel başarılı bir şekilde eklendi.", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Eklemeye çalıştığınıd ID'de farklı bir kayıt bulunmaktadır. Lütfen kontrol edip tekrar deneyiniz.", "ADD ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            //
        }

        private void AddPersonel_Load(object sender, EventArgs e)
        {
            // LookupEdite departman adlarını çekme
            var istenilenDegerler = (from x in db.Departments
                                     select new
                                     {
                                         x.ID,
                                         x.Name

                                     }).ToList();
            lookUpPADepartments.Properties.ValueMember = "ID";
            lookUpPADepartments.Properties.DisplayMember = "Name";
            lookUpPADepartments.Properties.DataSource = istenilenDegerler;
            
            //
        }
    }
}
