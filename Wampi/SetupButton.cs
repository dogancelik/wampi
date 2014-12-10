using System.Drawing;
using System.Windows.Forms;

namespace Wampi
{
    public partial class SetupButton : Button
    {
        public SetupButton(string setupId, string buttonName, Bitmap buttonImage)
        {
            InitializeComponent();

            Name = "buttonSetup_" + setupId;
            Image = buttonImage;
            ImageAlign = ContentAlignment.MiddleCenter;
            TextImageRelation = TextImageRelation.ImageBeforeText;
            TextAlign = ContentAlignment.MiddleRight;
            Text = buttonName;
            Size = new Size { Height = 42, Width = 200 };
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}