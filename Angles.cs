using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace _3DMaths
{
    public class Angle2
    {
        public float Angle { get; set; }
        public Angle2() { }
        public Angle2(float angle)
        {
            Angle = angle;
        }
    }

    public class Angle3
    {
        public float Pitch { get; set; }
        public float Yaw { get; set; }
        public float Roll { get; set; }
        public Angle3() { }
        public Angle3(float pitch, float yaw, float roll)
        {
            Pitch = pitch;
            Yaw = yaw;
            Roll = roll;
        }
    }

    public static partial class Extensions
    {
        // Angle2
        public static void Reset(this Angle2 MyAng)
        {
            MyAng.Angle = 0;
        }




        // Angle3
        public static void Reset(this Angle3 MyAng)
        {
            MyAng.Pitch = 0;
            MyAng.Yaw = 0;
            MyAng.Roll = 0;
        }

        // NEED to calculate angels for Angle3
    }
}
