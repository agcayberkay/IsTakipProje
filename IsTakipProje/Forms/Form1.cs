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
    public partial class Departmentt : Form
    {
        public Departmentt()
        {
            InitializeComponent();
            gridView1.OptionsBehavior.Editable = false;
        }


        #region   DATABASE LOGİC LAYER 

        IsTakipEntities1 db = new IsTakipEntities1();

        Departments t = new Departments();

        // Listeleme işlemi
        public void ShowList()
        {


            // İstenilen sütunları gösteren kod bloğu
            var istenilenDegerler = (from x in db.Departments
                                     select new
                                     {
                                         x.ID,
                                         x.Name
                                     }
                                     ).ToList();

            grdDeparmetns.DataSource = istenilenDegerler;

            //
        }
        //

        // Departman ekleme işlemi
        public void AddList()
        {

            t.Name = txtName.Text;
            t.ID = int.Parse(txtID.Text);
            db.Departments.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Departman başarılı bir şekilde sisteme kayıt edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowList();
        }
        //

        // Departman silme/kaldırma işlemi
        public void RemoveList()
        {
            int x = int.Parse(txtID.Text);
            var deger = db.Departments.Find(x);
            if (deger != null)
            {
                db.Departments.Remove(deger);
                db.SaveChanges();
                XtraMessageBox.Show("Silme işlemi başarılı bir şekilde gerçekleştirildi", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowList();
            }
            else
            {
                XtraMessageBox.Show("Aranan değer bulunamadı ! Lütfen tekrar deneyin.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //

        // Departman güncelleme İşlemi
        public void UpdateList()
        {
            int x = int.Parse(txtID.Text);
            var deger = db.Departments.Find(x);
            if (deger != null)
            {
                deger.Name = txtName.Text;
                db.SaveChanges();
                XtraMessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleştirildi", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ShowList();
            }
            else
            {
                XtraMessageBox.Show("Aranan değer bulunamadı ! Lütfen tekrar deneyin.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //


        #endregion



        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            ShowList();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            AddList();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            RemoveList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtName.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void Departmentt_Load(object sender, EventArgs e)
        {

        }
    }
}
