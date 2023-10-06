﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanDoAn
{
    class RoundButton
    {
        public static Rectangle ClientRectangle { get; private set; }
        public static Region Region { get; private set; }

        private void roundButton_Paint(object sender,
     System.Windows.Forms.PaintEventArgs e)
        {

            System.Drawing.Drawing2D.GraphicsPath buttonPath =
                new System.Drawing.Drawing2D.GraphicsPath();

            // Set a new rectangle to the same size as the button's 
            // ClientRectangle property.
            System.Drawing.Rectangle newRectangle = RoundButton.ClientRectangle;

            // Decrease the size of the rectangle.
            newRectangle.Inflate(-10, -10);

            // Draw the button's border.
            e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle);

            // Increase the size of the rectangle to include the border.
            newRectangle.Inflate(1, 1);

            // Create a circle within the new rectangle.
            buttonPath.AddEllipse(newRectangle);

            // Set the button's Region property to the newly created 
            // circle region.
            RoundButton.Region = new System.Drawing.Region(buttonPath);
        }
    }
}
