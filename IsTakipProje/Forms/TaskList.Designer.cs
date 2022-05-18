
namespace IsTakipProje.Forms
{
    partial class TaskList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskList));
            DevExpress.XtraCharts.Legend legend1 = new DevExpress.XtraCharts.Legend();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            this.grdTaskList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlSol = new DevExpress.XtraEditors.PanelControl();
            this.pnl1 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblToplamD = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pnl2 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblInaktif = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.pnl3 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblAktif = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pnlSagAlt = new DevExpress.XtraEditors.PanelControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.pnlOrtaUst = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grdTaskList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSol)).BeginInit();
            this.pnlSol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl1)).BeginInit();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl2)).BeginInit();
            this.pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl3)).BeginInit();
            this.pnl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSagAlt)).BeginInit();
            this.pnlSagAlt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOrtaUst)).BeginInit();
            this.pnlOrtaUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdTaskList
            // 
            this.grdTaskList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTaskList.Location = new System.Drawing.Point(2, 2);
            this.grdTaskList.MainView = this.gridView1;
            this.grdTaskList.Name = "grdTaskList";
            this.grdTaskList.Size = new System.Drawing.Size(413, 449);
            this.grdTaskList.TabIndex = 0;
            this.grdTaskList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdTaskList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // pnlSol
            // 
            this.pnlSol.Controls.Add(this.grdTaskList);
            this.pnlSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSol.Location = new System.Drawing.Point(0, 0);
            this.pnlSol.Name = "pnlSol";
            this.pnlSol.Size = new System.Drawing.Size(417, 453);
            this.pnlSol.TabIndex = 1;
            // 
            // pnl1
            // 
            this.pnl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(185)))), ((int)(((byte)(59)))));
            this.pnl1.Appearance.Options.UseBackColor = true;
            this.pnl1.Controls.Add(this.pictureBox1);
            this.pnl1.Controls.Add(this.lblToplamD);
            this.pnl1.Controls.Add(this.labelControl1);
            this.pnl1.Location = new System.Drawing.Point(15, 7);
            this.pnl1.LookAndFeel.SkinName = "DevExpress Style";
            this.pnl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(165, 139);
            this.pnl1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblToplamD
            // 
            this.lblToplamD.Appearance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamD.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblToplamD.Appearance.Options.UseFont = true;
            this.lblToplamD.Appearance.Options.UseForeColor = true;
            this.lblToplamD.Location = new System.Drawing.Point(70, 94);
            this.lblToplamD.Name = "lblToplamD";
            this.lblToplamD.Size = new System.Drawing.Size(15, 33);
            this.lblToplamD.TabIndex = 0;
            this.lblToplamD.Text = "0";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(20, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(127, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Toplam Departman";
            // 
            // pnl2
            // 
            this.pnl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.pnl2.Appearance.Options.UseBackColor = true;
            this.pnl2.Controls.Add(this.pictureBox3);
            this.pnl2.Controls.Add(this.lblInaktif);
            this.pnl2.Controls.Add(this.labelControl4);
            this.pnl2.Location = new System.Drawing.Point(407, 7);
            this.pnl2.LookAndFeel.SkinName = "DevExpress Style";
            this.pnl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(165, 139);
            this.pnl2.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(57, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // lblInaktif
            // 
            this.lblInaktif.Appearance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInaktif.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblInaktif.Appearance.Options.UseFont = true;
            this.lblInaktif.Appearance.Options.UseForeColor = true;
            this.lblInaktif.Location = new System.Drawing.Point(78, 94);
            this.lblInaktif.Name = "lblInaktif";
            this.lblInaktif.Size = new System.Drawing.Size(15, 33);
            this.lblInaktif.TabIndex = 0;
            this.lblInaktif.Text = "0";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(27, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(119, 17);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "İnaktif Görev Sayısı";
            // 
            // pnl3
            // 
            this.pnl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(181)))), ((int)(((byte)(204)))));
            this.pnl3.Appearance.Options.UseBackColor = true;
            this.pnl3.Controls.Add(this.pictureBox2);
            this.pnl3.Controls.Add(this.lblAktif);
            this.pnl3.Controls.Add(this.labelControl3);
            this.pnl3.Location = new System.Drawing.Point(211, 7);
            this.pnl3.LookAndFeel.SkinName = "DevExpress Style";
            this.pnl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.pnl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(165, 139);
            this.pnl3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(57, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblAktif
            // 
            this.lblAktif.Appearance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAktif.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblAktif.Appearance.Options.UseFont = true;
            this.lblAktif.Appearance.Options.UseForeColor = true;
            this.lblAktif.Location = new System.Drawing.Point(78, 94);
            this.lblAktif.Name = "lblAktif";
            this.lblAktif.Size = new System.Drawing.Size(15, 33);
            this.lblAktif.TabIndex = 0;
            this.lblAktif.Text = "0";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(29, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(108, 17);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Aktif Görev Sayısı";
            // 
            // pnlSagAlt
            // 
            this.pnlSagAlt.Controls.Add(this.chartControl1);
            this.pnlSagAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSagAlt.Location = new System.Drawing.Point(417, 157);
            this.pnlSagAlt.Name = "pnlSagAlt";
            this.pnlSagAlt.Size = new System.Drawing.Size(585, 296);
            this.pnlSagAlt.TabIndex = 3;
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            legend1.Name = "Legend 1";
            legend1.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.Legends.AddRange(new DevExpress.XtraCharts.Legend[] {
            legend1});
            this.chartControl1.Location = new System.Drawing.Point(2, 2);
            this.chartControl1.Name = "chartControl1";
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Name = "Departments";
            series1.View = pieSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(581, 292);
            this.chartControl1.TabIndex = 0;
            // 
            // pnlOrtaUst
            // 
            this.pnlOrtaUst.Controls.Add(this.pnl3);
            this.pnlOrtaUst.Controls.Add(this.pnl1);
            this.pnlOrtaUst.Controls.Add(this.pnl2);
            this.pnlOrtaUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOrtaUst.Location = new System.Drawing.Point(417, 0);
            this.pnlOrtaUst.Name = "pnlOrtaUst";
            this.pnlOrtaUst.Size = new System.Drawing.Size(585, 151);
            this.pnlOrtaUst.TabIndex = 4;
            this.pnlOrtaUst.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOrtaUst_Paint);
            // 
            // TaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 453);
            this.Controls.Add(this.pnlOrtaUst);
            this.Controls.Add(this.pnlSagAlt);
            this.Controls.Add(this.pnlSol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskList";
            this.Text = "Task List";
            this.Load += new System.EventHandler(this.TaskList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTaskList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSol)).EndInit();
            this.pnlSol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnl1)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl2)).EndInit();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl3)).EndInit();
            this.pnl3.ResumeLayout(false);
            this.pnl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSagAlt)).EndInit();
            this.pnlSagAlt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOrtaUst)).EndInit();
            this.pnlOrtaUst.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdTaskList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl pnlSol;
        private DevExpress.XtraEditors.PanelControl pnl1;
        private DevExpress.XtraEditors.PanelControl pnl2;
        private DevExpress.XtraEditors.PanelControl pnl3;
        private DevExpress.XtraEditors.PanelControl pnlSagAlt;
        private DevExpress.XtraEditors.PanelControl pnlOrtaUst;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl lblToplamD;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private DevExpress.XtraEditors.LabelControl lblInaktif;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.LabelControl lblAktif;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}