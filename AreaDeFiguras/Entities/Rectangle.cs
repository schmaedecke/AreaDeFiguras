using AreaDeFiguras.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AreaDeFiguras.Entities {
    internal class Rectangle : Shape {

        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Enums.Color color) : base(color) {
            Width = width;
            Height = height;
        }

        public override double Area() {
            return Width * Height;
        }
    }
}
