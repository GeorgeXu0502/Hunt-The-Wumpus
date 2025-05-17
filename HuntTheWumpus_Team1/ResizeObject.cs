using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntTheWumpus_Team1
{
    public class ResizeObject
    {
        public Rectangle RectangleToUse { get; set; }

        public Control ControlToChange { get; set; }

        public ResizeObject(Rectangle rectangleToUse, Control controlToChange)
        {
            RectangleToUse = rectangleToUse;
            ControlToChange = controlToChange;
        }
    }
}
