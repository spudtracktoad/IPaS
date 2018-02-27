using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPaS.Shared
{
    public class ChartHeaderInfo
    {
        const int dateLineHeight = 15;
        const int hrGridWidth = 35;

        #region Private Fields
        private Rectangle _viewWindow;
        private DateTime _currentDateTime;
        private DateTime _viewDateTime;
        private int _viewWindowMiddle;
        private int _viewWindowMaxHrs = 0;
        private List<DateTime> _dateTimeList;
        #endregion

        #region Constructor
        public ChartHeaderInfo()
        {
            _dateTimeList = new List<DateTime>(20);
        }
        #endregion
        #region Public Properties

        public DateTime CurrentDateTime
        {
            get { return _currentDateTime; }
            set
            {
                _currentDateTime = value;
                SetHrStringListValues();
            }
        }


        public DateTime ViewDateTime { get; set; }

        public Rectangle ViewWindow
        {
            get
            {
                return _viewWindow;
            }
            set
            {
                _viewWindow = value;
                _viewWindowMaxHrs = _viewWindow.Width / 35;
                _viewWindowMiddle = _viewWindowMaxHrs / 2;
                if (_currentDateTime.Year != 1)
                    SetHrStringListValues();
            }
        }

        #endregion

        #region Public Helpers
        public void DrawHeader(PaintEventArgs e, Font font)
        {
            DrawHeaderHours(e, font);
        }
        #endregion

        #region Private Methods

        private void DrawHeaderDates(PaintEventArgs e, Font font, DateTime dateTime, Point startPoint)
        {
            // Draws the date.  
            e.Graphics.DrawString(dateTime.ToShortDateString(), font,
                                new SolidBrush(Color.Black), startPoint.X, startPoint.Y);
            //  Draw the Line under the date
            e.Graphics.DrawLine(new Pen(Color.Black), new Point(0, dateLineHeight),
                                new Point(ViewWindow.Width, dateLineHeight));
        }

        private void DrawHeaderHours(PaintEventArgs e, Font font)
        {
            _viewDateTime = _dateTimeList[0];
            DrawHeaderDates(e, font, _viewDateTime, new Point(0,0));
            int i = 0; 
            while ((0 + i * hrGridWidth) < ViewWindow.Width)
            {
                // Draw Visable hour increments 
                e.Graphics.DrawString(_dateTimeList[i].ToString("HH:00"), font,
                                    new SolidBrush(Color.Black), (float)(0 + i * hrGridWidth), (float)20.0);
                //  Draw the Line under the date
                e.Graphics.DrawLine(new Pen(Color.Black), new Point((0 + i * hrGridWidth), dateLineHeight),
                                    new Point((0 + i * hrGridWidth), ViewWindow.Height));

                if(_viewDateTime.Day != _dateTimeList[i].Day)
                {
                    var startPoint = new Point((0 + i * hrGridWidth), 0);
                    // Draw date seperator
                    e.Graphics.DrawLine(new Pen(Color.Black, 2), startPoint, new Point(startPoint.X, ViewWindow.Height));
                    //Draw the change day header
                    DrawHeaderDates(e, font, _dateTimeList[i], startPoint);
                    _viewDateTime = _dateTimeList[i];
                }
                i++;
            }
        }


        private void SetHrStringListValues()
        {
            _dateTimeList.Clear();
            for (int i = 0; i < _viewWindowMaxHrs + 1; i++)
            {
                _dateTimeList.Add(CurrentDateTime.AddHours(-(_viewWindowMiddle - (1 * i))));
            }
        }
        #endregion
    }
}
