using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Registrator;
using System.ComponentModel;

namespace CustomDrawButtonEvent {
    public delegate void DrawButtonEventHandler(object sender, DrawButtonEventArgs e);

    [UserRepositoryItem("Register")]
    public class MyButtonEdit : ButtonEdit {

        static MyButtonEdit() {
            RepositoryItemMyButtonEdit.Register();
        }

        public MyButtonEdit() {
        }


        public override string EditorTypeName {
            get { return RepositoryItemMyButtonEdit.EditorName; }
        }


        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemMyButtonEdit Properties {
            get { return base.Properties as RepositoryItemMyButtonEdit; }
        }


        [Description("Occurs when custom editor buttons are being drawn."), Category(CategoryName.Events)]
        public event DrawButtonEventHandler DrawButton {
            add { Properties.DrawButton += value; }
            remove { Properties.DrawButton -= value; }
        }

        
    }
}
