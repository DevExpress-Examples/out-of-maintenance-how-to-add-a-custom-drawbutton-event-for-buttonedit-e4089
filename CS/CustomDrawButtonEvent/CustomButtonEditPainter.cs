using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;

namespace CustomDrawButtonEvent {
    public class CustomButtonEditPainter : ButtonEditPainter {
        public CustomButtonEditPainter() { }

        protected override void DrawButton(ButtonEditViewInfo viewInfo, EditorButtonObjectInfoArgs info) {
            DrawButtonEventArgs e = new DrawButtonEventArgs( info);
            (viewInfo.Item as RepositoryItemMyButtonEdit).RaiseDrawButtonEvent(e);
            if (!e.Handled) {
                base.DrawButton(viewInfo, info); 
            }
        }

    }
}
