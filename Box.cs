using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SimpleAE
{
    public class Box
    {
        private const char
           upperLeftCorner = '╔',
           upperRightCorner = '╗',
           lowerLeftCorner = '╚',
           lowerRightCorner = '╝',
           verticalPipe = '║',
           horizontalPipe = '═',
           leftVerticalConnectingPipe = '╣',
           rightVerticalConnectingPipe = '╠',
           bottomHorizontalConnectingPipe = '╩',
           topHorizontalConnectingPipe = '╦',
           allWayConnectingPipe = '╬';
        internal readonly Rectangle size;
        private static readonly List<Box> boxes = new List<Box>();

        public Box(int x, int y, int width, int height)
        {
            size = new Rectangle(x, y, width, height);
            boxes.Add(this);
            CheckIntersects();
        }
        private void CheckIntersects()
        {
            if (!boxes.Any() || boxes.Count < 2) return;

            for (var i = 1; i < boxes.Count; i++)
            {
                if (boxes.Any(box => box.size.IntersectsWith(boxes[i].size))) { Console.WriteLine($"Overlapped!"); }
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < size.Height; i++)
            {
                if (i == 0)                      // first line
                    output.AppendLine(upperLeftCorner + new string('═', size.Width - 2) + upperRightCorner);
                else if (i == size.Height - 1)   // last line
                    output.AppendLine(lowerLeftCorner + new string('═', size.Width - 2) + lowerRightCorner);
                else                            // middle
                    output.AppendLine(verticalPipe + new string(' ', size.Width - 2) + verticalPipe);
            }
            return output.ToString();
        }
    }
}
