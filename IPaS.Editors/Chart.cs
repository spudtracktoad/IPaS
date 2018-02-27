using IPaS.Shared;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPaS.Editors
{
    class Chart : UserControl
    {
        #region Private fields
        Rectangle _ClientWindow;
        
        #endregion

        #region Public Properties
        public ChartHeaderInfo HeaderInfo { get; set; }

        private String _chartX;
        private String _charTY;


        #endregion

        #region Private Properties
        private Rectangle ClientWindow
        {
            get
            {
                return _ClientWindow;
            }
            set
            {
                _ClientWindow = value;
                HeaderInfo.ViewWindow = value;
            }
        }
        #endregion

        #region Constructor
        public Chart()
        {
            HeaderInfo = new ChartHeaderInfo();
            this.AutoScroll = true;
            this.Controls.Add(new SirBarControl());
        }
        #endregion


        #region Events
        protected override void OnLoad(EventArgs e)
        {
            HeaderInfo.CurrentDateTime = DateTime.Now;
            ClientWindow = ClientRectangle;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            HeaderInfo.DrawHeader(e, Font);
            // Draws the x point for mouse move.  
            e.Graphics.DrawString(_chartX, Font,
                                new SolidBrush(Color.Black), 100, 100);
            // Draws the y point from mouse move.  
            e.Graphics.DrawString(_charTY, Font,
                                new SolidBrush(Color.Black), 150, 100);
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ClientWindow = ClientRectangle;
            this.Invalidate(ClientRectangle);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if(e.Button == MouseButtons.Left)
            {
                var tmp = "mouse moving";
                _chartX = e.X.ToString();
                _charTY = e.Y.ToString();
                this.Invalidate();
            }

        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseDown(e);
        }
        #endregion

        #region Private Methods

        #endregion
    }
}
