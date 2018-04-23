namespace CustomDrawButtonEvent {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.myButtonEdit2 = new CustomDrawButtonEvent.MyButtonEdit();
            this.myButtonEdit1 = new CustomDrawButtonEvent.MyButtonEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "labelControl1";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(12, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "labelControl1";
            // 
            // myButtonEdit2
            // 
            this.myButtonEdit2.Location = new System.Drawing.Point(12, 91);
            this.myButtonEdit2.Name = "myButtonEdit2";
            this.myButtonEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "test", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleLeft, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.myButtonEdit2.Size = new System.Drawing.Size(100, 20);
            this.myButtonEdit2.TabIndex = 4;
            this.myButtonEdit2.DrawButton += new CustomDrawButtonEvent.DrawButtonEventHandler(this.myButtonEdit2_DrawButton);
            // 
            // myButtonEdit1
            // 
            this.myButtonEdit1.Location = new System.Drawing.Point(12, 31);
            this.myButtonEdit1.Name = "myButtonEdit1";
            this.myButtonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "test", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleRight, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.myButtonEdit1.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.myButtonEdit1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.myButtonEdit1.Size = new System.Drawing.Size(100, 22);
            this.myButtonEdit1.TabIndex = 3;
            this.myButtonEdit1.DrawButton += new CustomDrawButtonEvent.DrawButtonEventHandler(this.myButtonEdit1_DrawButton);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridControl1.Location = new System.Drawing.Point(345, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(379, 262);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 262);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.myButtonEdit2);
            this.Controls.Add(this.myButtonEdit1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.Name = "Form1";
            this.Text = "Custom DrawButton event";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private MyButtonEdit myButtonEdit1;
        private MyButtonEdit myButtonEdit2;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}

