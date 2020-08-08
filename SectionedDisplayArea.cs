using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SimpleAE
{


    public sealed class SectionedDisplayArea
    {
        public Box Box { get; set; }

        /// <summery>
        /// Creates a new <see cref="SectionedDisplayArea" />.
        /// <param name="x">The X position of the box</param>
        /// <param name="y">The Y position of the box</param>
        /// <param name="width">The width of the box</param>
        /// <param name="height">The height of the box</param>
        /// </summery>
        public SectionedDisplayArea(int x, int y, int width, int height) 
        {
            Box = new Box(x, y, width, height);
        }

        /// <summery>
        /// Creates a new <see cref="SectionedDisplayArea" /> using a <see cref="Rectangle" />.
        /// <param name="size">The <see cref="Rectangle" /> containing the size and position of the box</param>
        /// </summery>
        public SectionedDisplayArea(Rectangle Size)
        {
            Box = new Box(Size.X, Size.Y, Size.Width, Size.Height);
        }

    }
}
