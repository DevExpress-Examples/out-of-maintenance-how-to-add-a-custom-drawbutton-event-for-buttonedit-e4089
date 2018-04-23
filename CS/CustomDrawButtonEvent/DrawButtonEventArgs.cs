using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;
using DevExpress.Utils.Drawing;
using System.Drawing;
using DevExpress.Utils;

namespace CustomDrawButtonEvent {

    public class DrawButtonEventArgs {
        public DrawButtonEventArgs(EditorButtonObjectInfoArgs info) {
            this.info = info;
            handled = false;
        }

        private EditorButtonObjectInfoArgs info;
        private bool handled;


        public bool Handled { 
            get {
                return handled;
            }
            set {
                if (handled != value)
                    handled = value;
            }
        }
        public ObjectState State { 
            get {
                return info.State;
            }
            set {
                if (info.State != value) {
                    info.State = value;
                }
            }
        }

        public AppearanceObject Appearance { get { return info.Appearance; } }
        public int Index { get { return info.Button.Index; } }
        public string Caption { get { return info.Button.Caption; } }
        public Graphics Graphics { get { return info.Graphics; } }
        public GraphicsCache Cache { get { return info.Cache; } }
        public Rectangle Bounds { get { return info.Bounds; } }
        public Image Image { get { return info.Button.Image; } }
        public ButtonPredefines Kind { get { return info.Button.Kind; } }
        public ImageLocation ImageLocation { get { return info.Button.ImageLocation; } }
    }

}
