using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3DMaths
{
    public partial class Main : Form
    {
        int MouseX = 0;
        int MouseY = 0;
        Panel XLine = new Panel();
        Panel YLine = new Panel();
        Panel MouseDot = new Panel();
        Graphics DrawingArea;
        Vector2 Point1 = new Vector2();
        Vector2 Point2 = new Vector2();
        Panel Point1Dot = new Panel();
        Panel Point2Dot = new Panel();

        public Main()
        {
            InitializeComponent();

            #region Render properties
            XLine.BackColor = Color.Red; // Set XLine color
            YLine.BackColor = Color.Green; // Set YLine color
            MouseDot.Size = new Size(12, 12); // Set dot Size
            MouseDot.BackColor = Color.Blue; // Set dot color
            Point1Dot.Size = new Size(4, 4); // Sets the dot size to 4x4 pixels big
            Point1Dot.BackColor = Color.Cyan; // Sets the dot color to Cyan
            Point2Dot.Size = new Size(4, 4); // Sets the dot size to 4x4 pixels big
            Point2Dot.BackColor = Color.Cyan; // Sets the dot color to Cyan

            this.Controls.Add(XLine); // Add the line to the form
            this.Controls.Add(YLine); // Add the line to the form
            this.Controls.Add(MouseDot); // Add the dot to the form
            this.Controls.Add(Point1Dot); // Add the dot to the form
            this.Controls.Add(Point2Dot); // Add the dot to the form
            XLine.BringToFront(); // Put the line infront of the panel
            YLine.BringToFront(); // Put the line infront of the panel
            MouseDot.BringToFront(); // Put the dot infront of the panel
            Point1Dot.BringToFront(); // Put the dot infront of the panel
            Point2Dot.BringToFront(); // Put the dot infront of the panel
            #endregion

            this.DoubleBuffered = true; // Double buffered to increase performance and stop flickering
        }

        private void MouseRecorder_Tick(object sender, EventArgs e)
        {
            Point MousePos = MouseArea.PointToClient(Cursor.Position); // Get mouse position and compare it to the panel's size
            MouseX = MousePos.X; // Save the X position for this current tick
            MouseY = MousePos.Y;// Save the Y position for this current tick

            #region Calculate Mouse Position Inside Panel
            if (MouseX <= 0) // if X Position is in negative numbers (its outside the panel) then set it to 0
                MouseX = 0;
            if (MouseY <= 0) // if Y Position is in negative numbers (its outside the panel) then set it to 0
                MouseY = 0;

            if (MouseX >= MouseArea.Size.Width) // if X position is greater than the panel's width, then set it to 0
                MouseX = 0;
            if (MouseY >= MouseArea.Size.Height) // if Y position is greater than the panel's height, then set it to 0
                MouseY = 0;

            if (MouseX == 0) // if X position is 0 (most likely been reset because it was outside the panel) then set the Y position to 0 aswell
                MouseY = 0;

            if (MouseY == 0) // if Y position is 0 (most likely been reset because it was outside the panel) then set the X position to 0 aswell
                MouseX = 0;
            #endregion

            #region Update Line Lengths
            XLine.Size = new Size(MouseArea.Width, 4); // set XLine Size
            YLine.Size = new Size(4, MouseArea.Height); // set YLine Size
            #endregion

            #region Render X Y Lines
            if (MouseX != 0 && MouseY != 0 && cbMousePosition.Checked) // Only render lines if both values are NOT 0 (aka mouse is inside the panel)
            {
                XLine.Visible = true;
                YLine.Visible = true;
                XLine.BackColor = Color.Red; // Make the lines normal coloured again
                YLine.BackColor = Color.Green; // Make the lines normal coloured again
                XLine.Location = new Point(MouseArea.Location.X, MouseY + 7); // Set the lines position to where ever the mouse position is (7, because of alignment failures)
                YLine.Location = new Point(MouseX + 7, MouseArea.Location.Y); // Set the lines position to where ever the mouse position is (7, because of alignment failures)
            }
            else
            {
                XLine.Visible = false;
                YLine.Visible = false;
                XLine.BackColor = Color.DarkRed; // Darken the dot's color
                YLine.BackColor = Color.DarkGreen; // Darken the dot's color
            }
            #endregion

            #region Render Dot
            if (MouseX != 0 && MouseY != 0 && cbMousePosition.Checked) // Only render dot if both values are NOT 0 (aka mouse is inside the panel)
            {
                MouseDot.Visible = true;
                MouseDot.BackColor = Color.Blue; // Make the lines normal coloured again
                MouseDot.Location = new Point(MouseX + 3, MouseY + 3); // Set the dot's position to where ever the mouse position is (7, because of alignment failures)
            }
            else
            {
                MouseDot.Visible = false;
                MouseDot.BackColor = Color.DarkBlue; // Darken the dot's color
            }
            #endregion

            lblX1.Text      = "X: "     + Point1.X.ToString(); 
            lblY1.Text      = "Y: "     + Point1.Y.ToString();
            lblAngle1.Text  = "Angle: " + Point1.GetAngle(Point2).Angle.ToString();
            lblDistance1.Text  = "Distance: " + Point1.Distance(Point2).ToString();

            lblX2.Text      = "X: "     + Point2.X.ToString(); 
            lblY2.Text      = "Y: "     + Point2.Y.ToString();
            lblAngle2.Text  = "Angle: " + Point2.GetAngle(Point1).Angle.ToString();
            lblDistance2.Text  = "Distance: " + Point2.Distance(Point1).ToString();

            DrawingArea = MouseArea.CreateGraphics(); // Update drawing area (if size change)
        }

        private void Drawer_Tick(object sender, EventArgs e)
        {
            if ((Control.MouseButtons & MouseButtons.Left) != 0 && MouseX != 0 && MouseY != 0) // Check if left mouse button is held down and if mouse is not outside the drawing area.
            {
                #region Add dot
                Point1 = new Vector2(MouseX + 7, MouseY + 7);
                Point1Dot.Location = Point1.ToPoint(); // Sets the dot's position
                MouseArea.Refresh();
                #endregion
            }
            else if ((Control.MouseButtons & MouseButtons.Right) != 0 && MouseX != 0 && MouseY != 0) // Check if left mouse button is held down and if mouse is not outside the drawing area.
            {
                #region Add dot
                Point2 = new Vector2(MouseX + 7, MouseY + 7);
                Point2Dot.Location = Point2.ToPoint(); // Sets the dot's position
                MouseArea.Refresh();
                #endregion
            }

            #region Connect to previous dot
            try
            {
                if (Point1.X != 0 && Point1.Y != 0 && Point2.X != 0 && Point2.Y != 0)
                {
                    this.Invalidate(); // Redraws all the previous added connected lines
                    DrawingArea.DrawLine(new Pen(Color.Black, 1), Point1.Add(-9, -9).ToPoint(), Point2.Add(-9, -9).ToPoint()); // Draw a line connecting the current and previous dot
                }
            }
            catch { }
            #endregion
        }
    }
}