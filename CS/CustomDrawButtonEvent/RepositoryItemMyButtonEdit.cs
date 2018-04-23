using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Registrator;
using System.ComponentModel;
using DevExpress.XtraEditors.ViewInfo;

namespace CustomDrawButtonEvent {
    public class RepositoryItemMyButtonEdit : RepositoryItemButtonEdit {

        static RepositoryItemMyButtonEdit() {
            Register();
        }

        public RepositoryItemMyButtonEdit() {
        }

        internal const string EditorName = "MyButtonEdit";

        public static void Register() {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(EditorName, typeof(MyButtonEdit),
                typeof(RepositoryItemMyButtonEdit), typeof(ButtonEditViewInfo),
                new CustomButtonEditPainter(), true, null, typeof(DevExpress.Accessibility.ButtonEditAccessible)));

        }

        public override string EditorTypeName {
            get { return EditorName; }

        }

        private static readonly object drawButton = new object();

        [Description("Occurs when custom editor buttons are being drawn."), Category(CategoryName.Events)]
        public event DrawButtonEventHandler DrawButton {
            add { this.Events.AddHandler(drawButton, value); }
            remove { this.Events.RemoveHandler(drawButton, value); }
        }


        protected internal virtual void RaiseDrawButtonEvent(DrawButtonEventArgs e) {
            DrawButtonEventHandler handler = (DrawButtonEventHandler)this.Events[drawButton];
            if (handler != null) handler(GetEventSender(), e);

        }

        public override void Assign(RepositoryItem item) {
            RepositoryItemMyButtonEdit source = item as RepositoryItemMyButtonEdit;
            BeginUpdate();
            try {
                base.Assign(item);
                if (source == null) return;
            }
            finally {
                EndUpdate();
            }
            Events.AddHandler(drawButton, source.Events[drawButton]);
        }

    }
}
