using DevExpress.XtraEditors;
using IsTakipProje.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsTakipProje.Forms
{
    public partial class TaskDetails : DevExpress.XtraEditors.XtraForm
    {
        public TaskDetails()
        {
            InitializeComponent();
            gridView1.OptionsBehavior.Editable = false;
            
        }

        IsTakipEntities1 db = new IsTakipEntities1();

        private void TaskDetails_Load(object sender, EventArgs e)
        {

            ShowTaskDetailsList();

            txtTDClock.Text = DateTime.Now.ToShortTimeString();
        }

        private void ShowTaskDetailsList()
        {
            db.MissionDetails.Load();
            bindingSource1.DataSource = db.MissionDetails.Local;
            
        }

        private void btnTDUpdate_Click(object sender, EventArgs e)
        {
            // Güncelleme İşlemi
            int x = int.Parse(txtTDEmployeer.Text);
            var deger = db.MissionDetails.Find(x);
            if (deger != null)
            {
                deger.Descriptions = txtTDDescription.Text;
                deger.Dates = DateTime.Parse(dtTTDaskDate.Text);
                deger.Clock = txtTDClock.Text;
                db.SaveChanges();
                ShowTaskDetailsList();
                XtraMessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleştirildi", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                XtraMessageBox.Show("Aranan değer bulunamadı ! Lütfen tekrar deneyin.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtTDEmployeer.Text = gridView1.GetFocusedRowCellValue("Task").ToString();
            txtTDDescription.Text = gridView1.GetFocusedRowCellValue("Descriptions").ToString();
            dtTTDaskDate.Text = gridView1.GetFocusedRowCellValue("Dates").ToString();
            txtTDClock.Text = gridView1.GetFocusedRowCellValue("Clock").ToString();
        }
    }
}
