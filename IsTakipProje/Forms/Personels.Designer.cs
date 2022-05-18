
namespace IsTakipProje.Forms
{
    partial class PersonelsList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelsList));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.tx = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPGorsel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtPMail = new DevExpress.XtraEditors.TextEdit();
            this.txtPSurname = new DevExpress.XtraEditors.TextEdit();
            this.txtPName = new DevExpress.XtraEditors.TextEdit();
            this.txtPID = new DevExpress.XtraEditors.TextEdit();
            this.btnPUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnPDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnPShowList = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.grdPersonels = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPGorsel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPersonels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.tx);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtPGorsel);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtPPhone);
            this.groupControl1.Controls.Add(this.txtPMail);
            this.groupControl1.Controls.Add(this.txtPSurname);
            this.groupControl1.Controls.Add(this.txtPName);
            this.groupControl1.Controls.Add(this.txtPID);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(698, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(304, 453);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(69, 373);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.NullText = "Yazılım";
            this.lookUpEdit1.Size = new System.Drawing.Size(174, 20);
            this.lookUpEdit1.TabIndex = 6;
            // 
            // tx
            // 
            this.tx.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx.Appearance.Options.UseFont = true;
            this.tx.Location = new System.Drawing.Point(102, 352);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(116, 16);
            this.tx.TabIndex = 2;
            this.tx.Text = "Personel Department:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(117, 302);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(83, 16);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Personel Gorsel:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(123, 202);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 16);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Personel Mail:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(119, 102);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(83, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Personel Name:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(117, 252);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(85, 16);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Personel Phone:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(111, 152);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(98, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Personel Surname:";
            // 
            // txtPGorsel
            // 
            this.txtPGorsel.Location = new System.Drawing.Point(69, 323);
            this.txtPGorsel.Name = "txtPGorsel";
            this.txtPGorsel.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPGorsel.Properties.Appearance.Options.UseFont = true;
            this.txtPGorsel.Size = new System.Drawing.Size(174, 24);
            this.txtPGorsel.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(127, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Personel ID:";
            // 
            // txtPPhone
            // 
            this.txtPPhone.Location = new System.Drawing.Point(69, 273);
            this.txtPPhone.Name = "txtPPhone";
            this.txtPPhone.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPPhone.Properties.Appearance.Options.UseFont = true;
            this.txtPPhone.Size = new System.Drawing.Size(174, 24);
            this.txtPPhone.TabIndex = 4;
            // 
            // txtPMail
            // 
            this.txtPMail.Location = new System.Drawing.Point(69, 223);
            this.txtPMail.Name = "txtPMail";
            this.txtPMail.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPMail.Properties.Appearance.Options.UseFont = true;
            this.txtPMail.Size = new System.Drawing.Size(174, 24);
            this.txtPMail.TabIndex = 3;
            // 
            // txtPSurname
            // 
            this.txtPSurname.Location = new System.Drawing.Point(69, 173);
            this.txtPSurname.Name = "txtPSurname";
            this.txtPSurname.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPSurname.Properties.Appearance.Options.UseFont = true;
            this.txtPSurname.Size = new System.Drawing.Size(174, 24);
            this.txtPSurname.TabIndex = 2;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(69, 123);
            this.txtPName.Name = "txtPName";
            this.txtPName.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPName.Properties.Appearance.Options.UseFont = true;
            this.txtPName.Size = new System.Drawing.Size(174, 24);
            this.txtPName.TabIndex = 1;
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(69, 73);
            this.txtPID.Name = "txtPID";
            this.txtPID.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPID.Properties.Appearance.Options.UseFont = true;
            this.txtPID.Size = new System.Drawing.Size(174, 24);
            this.txtPID.TabIndex = 0;
            // 
            // btnPUpdate
            // 
            this.btnPUpdate.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPUpdate.Appearance.Options.UseFont = true;
            this.btnPUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPUpdate.ImageOptions.SvgImage")));
            this.btnPUpdate.Location = new System.Drawing.Point(353, 9);
            this.btnPUpdate.Name = "btnPUpdate";
            this.btnPUpdate.Size = new System.Drawing.Size(143, 35);
            this.btnPUpdate.TabIndex = 3;
            this.btnPUpdate.Text = "Update Personel";
            this.btnPUpdate.Click += new System.EventHandler(this.btnPUpdate_Click);
            // 
            // btnPDelete
            // 
            this.btnPDelete.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPDelete.Appearance.Options.UseFont = true;
            this.btnPDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPDelete.ImageOptions.SvgImage")));
            this.btnPDelete.Location = new System.Drawing.Point(179, 9);
            this.btnPDelete.Name = "btnPDelete";
            this.btnPDelete.Size = new System.Drawing.Size(143, 35);
            this.btnPDelete.TabIndex = 2;
            this.btnPDelete.Text = "Delete Personel";
            this.btnPDelete.Click += new System.EventHandler(this.btnPDelete_Click);
            // 
            // btnPShowList
            // 
            this.btnPShowList.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPShowList.Appearance.Options.UseFont = true;
            this.btnPShowList.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnPShowList.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPShowList.ImageOptions.SvgImage")));
            this.btnPShowList.Location = new System.Drawing.Point(5, 9);
            this.btnPShowList.Name = "btnPShowList";
            this.btnPShowList.Size = new System.Drawing.Size(143, 35);
            this.btnPShowList.TabIndex = 0;
            this.btnPShowList.Text = "Show Personel List";
            this.btnPShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPShowList);
            this.panelControl1.Controls.Add(this.btnPUpdate);
            this.panelControl1.Controls.Add(this.btnPDelete);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 404);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(698, 49);
            this.panelControl1.TabIndex = 2;
            // 
            // grdPersonels
            // 
            this.grdPersonels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPersonels.Location = new System.Drawing.Point(0, 0);
            this.grdPersonels.MainView = this.gridView1;
            this.grdPersonels.Name = "grdPersonels";
            this.grdPersonels.Size = new System.Drawing.Size(698, 404);
            this.grdPersonels.TabIndex = 0;
            this.grdPersonels.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdPersonels;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // PersonelsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 453);
            this.Controls.Add(this.grdPersonels);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelsList";
            this.Text = "Employees List";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPGorsel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPersonels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPUpdate;
        private DevExpress.XtraEditors.SimpleButton btnPDelete;
        private DevExpress.XtraEditors.SimpleButton btnPShowList;
        public DevExpress.XtraEditors.TextEdit txtPName;
        public DevExpress.XtraEditors.TextEdit txtPID;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl grdPersonels;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.TextEdit txtPGorsel;
        public DevExpress.XtraEditors.TextEdit txtPPhone;
        public DevExpress.XtraEditors.TextEdit txtPMail;
        public DevExpress.XtraEditors.TextEdit txtPSurname;
        private DevExpress.XtraEditors.LabelControl tx;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
    }
}