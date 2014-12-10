using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Wampi
{
    public class SetupFormBase : Form
    {
        public const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

        public SetupFormBase()
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = MinimizeBox = ShowInTaskbar = false;
            KeyPreview = true;
            KeyDown += delegate(object sender, KeyEventArgs args) { if (args.KeyCode == Keys.Escape) Close(); };
        }

        protected void ToggleControls(Control.ControlCollection container, bool enable)
        {
            foreach (Control control in container)
            {
                control.Enabled = enable;
            }
        }
    }
}