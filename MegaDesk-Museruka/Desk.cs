using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Museruka
{
    public class Desk
    {
        // validatator values
        public const int MinWidth = 24;
        public const int MaxWidth = 96;
        public const int MinDepth = 12;
        public const int MaxDepth = 48;

        //width, depth, number of drawers, and the surface material.
        public double Width { get; set; }
        public double Depth { get; set; }
        public double NumberOfDrawers { get; set; }
        public Material SurfaceMaterial { get; set; }


        public enum Material
        {
            Laminate = 1,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }

    }
}
