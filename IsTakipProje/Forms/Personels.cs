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
    public partial class PersonelsList : Form
    {
        public PersonelsList()
        {
            InitializeComponent();
            gridView1.OptionsBehavior.Editable= false;
        }

        #region DATABASE LOGİC LAYER 

        IsTakipEntities db = new IsTakipEntities();

        Personels P1 = new Personels();


        // Personel Listeleme işlemleri
        public void ShowPersonels()
        {
            var istenilenDegerler = (from x in db.Personels

                                     select new
                                     {
                                         x.Id,
                                         x.Name,
                                         x.Surname,
                                         x.Mail,
                                         x.Phone,
                                         x.Gorsel,
                                         Department=x.Departments.Name,
                                         x.Durum
                                     }

                                   ).ToList();

            grdPersonels.DataSource = istenilenDegerler.Where(x=> x.Durum==true).ToList();
        }
        //

       
        //

        // Personel silme/kaldırma işlemi
        public void RemovePersonel()
        {
            int x = int.Parse(txtPID.Text);
            var arananID = db.Personels.Find(x);
            if (arananID!=null)
            {
                arananID.Durum = false;
                db.SaveChanges();
                XtraMessageBox.Show("Silme işlemi başarılı bir şekilde gerçekleştirildi", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowPersonels();
            }
            else
            {
              XtraMessageBox.Show("Aranan değer bulunamadı ! Lütfen tekrar deneyin.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //


        // Personel güncelleme işlemi
        public void UpdatePersonel()
        {
            int x = int.Parse(txtPID.Text);
            var deger = db.Personels.Find(x);
            if (deger != null)
            {
                deger.Name = txtPName.Text;
                deger.Surname = txtPSurname.Text;
                deger.Mail = txtPMail.Text;
                deger.Phone = txtPPhone.Text;
                deger.Gorsel = txtPGorsel.Text;
                deger.Department = int.Parse(lookUpEdit1.EditValue.ToString());
                db.SaveChanges();
                XtraMessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleştirildi", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ShowPersonels();
            }
            else
            {
                XtraMessageBox.Show("Aranan değer bulunamadı ! Lütfen tekrar deneyin.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
       

        #endregion

        private void btnShowList_Click(object sender, EventArgs e)
        {
            ShowPersonels();

            var departments = (from x in db.Departments
                               select new
                               {
                                   x.ID,
                                   x.Name
                               }

                               ).ToList();

            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "Name";
            lookUpEdit1.Properties.DataSource = departments;  

        }


        private void btnPDelete_Click(object sender, EventArgs e)
        {
            RemovePersonel();
        }

        private void btnPUpdate_Click(object sender, EventArgs e)
        {
            UpdatePersonel();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtPID.Text = gridView1.GetFocusedRowCellValue("Id").ToString();
            txtPName.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
            txtPSurname.Text = gridView1.GetFocusedRowCellValue("Surname").ToString();
            txtPMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            txtPPhone.Text = gridView1.GetFocusedRowCellValue("Phone").ToString();
            txtPGorsel.Text = gridView1.GetFocusedRowCellValue("Gorsel").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("Department").ToString();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
