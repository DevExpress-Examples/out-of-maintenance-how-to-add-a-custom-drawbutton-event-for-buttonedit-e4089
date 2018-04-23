using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.Utils.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using DevExpress.XtraEditors.Controls;

namespace CustomDrawButtonEvent {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            CreateDataSource();
            item = new RepositoryItemMyButtonEdit();
            ConfigureRepositoryItemButtonEdit(item);
        }

          RepositoryItemMyButtonEdit item;
        private void ConfigureRepositoryItemButtonEdit(RepositoryItemMyButtonEdit item) {
            item.Buttons[0].Kind = ButtonPredefines.OK;
            item.Buttons.Add(new EditorButton());
            item.DrawButton += new DrawButtonEventHandler(myButtonEdit2_DrawButton);
            gridControl1.RepositoryItems.Add(item);
            gridView1.Columns["Age"].ColumnEdit = item;
            gridView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
        }



        private void CreateDataSource() {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Age", typeof(int));
            dataTable.Rows.Add(new object[] { "John Smith", 32 });
            dataTable.Rows.Add(new object[] { "Ivanov", 23 });
            dataTable.Rows.Add(new object[] { "Petrov", 31 });
            dataTable.Rows.Add(new object[] { "John Smith", 32 });
            dataTable.Rows.Add(new object[] { "Ivanov", 2 });
            dataTable.Rows.Add(new object[] { "Petrov", 23 });
            dataTable.Rows.Add(new object[] { "John Smith", 42 });
            dataTable.Rows.Add(new object[] { "Ivanov", 25 });
            dataTable.Rows.Add(new object[] { "Petrov", 62 });
            dataTable.Rows.Add(new object[] { "John Smith", 12 });
            gridControl1.DataSource = dataTable;
        }

        private  void DrawCustomButton(DrawButtonEventArgs e, int textOffset) {
            using (LinearGradientBrush brush = new LinearGradientBrush(e.Bounds, Color.DarkBlue, Color.LightSkyBlue, 30)) {
                e.Graphics.FillRectangle(brush, e.Bounds);
               
            }

            e.Graphics.DrawLine(Pens.Black, new Point(e.Bounds.X + 1, e.Bounds.Y + 1), new Point(e.Bounds.Right, e.Bounds.Y + 1));
            e.Graphics.DrawLine(Pens.Black, new Point(e.Bounds.X + 1, e.Bounds.Y + 1), new Point(e.Bounds.X + 1, e.Bounds.Bottom - 2));
            e.Graphics.DrawLine(Pens.LightGray, new Point(e.Bounds.Right + 2, e.Bounds.Y + 2), new Point(e.Bounds.Right - 2, e.Bounds.Bottom - 2));
            e.Graphics.DrawLine(Pens.LightGray, new Point(e.Bounds.X + 2, e.Bounds.Bottom - 2), new Point(e.Bounds.Right - 2, e.Bounds.Bottom - 2));

            using (SolidBrush whiteBrush = new SolidBrush(Color.White)) {
                e.Graphics.DrawString(e.Caption, e.Appearance.GetFont(), whiteBrush, new Point(e.Bounds.X + textOffset, e.Bounds.Y + textOffset));
            }

            using ( SolidBrush yellowBrush = new SolidBrush(Color.Yellow)) {
                SizeF size = e.Cache.CalcTextSize(e.Caption, e.Appearance.GetFont(), new StringFormat(), e.Bounds.Size.Width);
                e.Graphics.DrawString("...", e.Appearance.GetFont(), yellowBrush, new Point(e.Bounds.X + textOffset + 2 + (int)size.Width, e.Bounds.Y + 1));
            }
        }

        void myButtonEdit1_DrawButton(object sender, DrawButtonEventArgs e) {
            switch (e.Index) {
                case 0:
                    e.Handled = true;
                    int textOffset = 4;
                    DrawCustomButton(e, textOffset);
                    break;
                case 1:
                    if (e.State == ObjectState.Hot || e.State == ObjectState.Pressed || e.State == ObjectState.Selected)
                        e.Appearance.BackColor = Color.LightSkyBlue;
                    break;
            }

            labelControl1.Text = "CustomEditButton1 " + "index = " + " " + e.Index.ToString() + " button State = " + e.State.ToString();
        }

        private void myButtonEdit2_DrawButton(object sender, DrawButtonEventArgs e) {
            switch (e.Index) {
                case 0:
                    e.State = ObjectState.Hot;
                    break;
                case 1:
                    e.Handled = true;
                    int textOffset = 0;
                    DrawCustomButton(e, textOffset);
                    break;
            }

            labelControl2.Text = "CustomEditButton2 " + "index = " + " " + e.Index.ToString() + " button State = " + e.State.ToString();
        }




        private void Form1_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e) {
            item.DrawButton -= new DrawButtonEventHandler(myButtonEdit2_DrawButton);
        }
    }
}
