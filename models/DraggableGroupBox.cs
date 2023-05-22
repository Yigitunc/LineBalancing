using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeCalc.models
{
    public class DraggableGroupBox : GroupBox
    {
        private bool isDragging = false;
        private Point lastMousePosition;

        public DraggableGroupBox()
        {
            MouseDown += DraggableGroupBox_MouseDown;
            MouseMove += DraggableGroupBox_MouseMove;
            MouseUp += DraggableGroupBox_MouseUp;
        }

        private void DraggableGroupBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastMousePosition = e.Location;
        }

        private void DraggableGroupBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.X - lastMousePosition.X;
                int deltaY = e.Y - lastMousePosition.Y;

                Location = new Point(Location.X + deltaX, Location.Y + deltaY);
            }
        }

        private void DraggableGroupBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }

}
