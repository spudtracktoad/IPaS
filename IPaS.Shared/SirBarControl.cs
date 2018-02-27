using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPaS.Shared
{
    public class SirBarControl : Label
    {
        const int _Height = 15;
        int _width = 75;
        Point location = new Point(125, 125);

        public SirBarControl()
        {
            Height = _Height;
            Width = _width;
            Location = location;
            BackColor = Color.Blue;
            ForeColor = Color.Ivory;
            BorderStyle = BorderStyle.FixedSingle;
            Text = "I am a SIR";
            //Enabled = false;
            
        }
    }
}
