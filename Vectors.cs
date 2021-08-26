using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3DMaths
{
    public class Vector2
    {
        public float X { get; set; }
        public float Y { get; set; }
        public Vector2() { }
        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
    
    public class Vector3
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public Vector3() { }
        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }

    public static partial class Extensions
    {
        // Vector2
        public static void Reset(this Vector2 MyVec)
        {
            MyVec.X = 0;
            MyVec.Y = 0;
        }
        public static Vector2 Normalize(this Vector2 MyVec)
        {
            float distance = (float)Math.Sqrt(MyVec.X * MyVec.X + MyVec.Y * MyVec.Y);
            return new Vector2(MyVec.X / distance, MyVec.Y / distance);
        }
        public static Vector2 MoveTowards(this Vector2 MyVec, Vector2 TargetVec, float MaxDeltaDistance)
        {
            float ToVec_X = TargetVec.X - MyVec.X;
            float ToVec_Y = TargetVec.Y - MyVec.Y;

            float SqDistance = ToVec_X * ToVec_X + ToVec_Y * ToVec_Y;

            if (SqDistance == 0 || (MaxDeltaDistance >= 0 && SqDistance <= MaxDeltaDistance * MaxDeltaDistance))
                return TargetVec;
            var Distance = (float)Math.Sqrt(SqDistance);

            return new Vector2(MyVec.X + ToVec_X / Distance * MaxDeltaDistance, MyVec.Y + ToVec_Y / Distance * MaxDeltaDistance);
        }
        public static float Distance(this Vector2 MyVec, Vector2 TargetVec)
        {
            float Difference_X = MyVec.X - TargetVec.X;
            float Difference_Y = MyVec.Y - TargetVec.Y;
            return (float)Math.Sqrt(Difference_X * Difference_X + Difference_Y * Difference_Y);
        }
        public static float Dot(this Vector2 MyVec, Vector2 TargetVec)
        {
            return MyVec.X * TargetVec.X + MyVec.Y * TargetVec.Y;
        }
        public static Vector2 Cross(this Vector2 MyVec, Vector2 TargetVec)
        {
            return new Vector2(
                MyVec.Y * TargetVec.X - MyVec.X * TargetVec.Y,
                MyVec.X * TargetVec.Y - MyVec.Y * TargetVec.X);
        }
        public static Angle2 GetAngle(this Vector2 MyVec, Vector2 TargetVec)
        {
            return new Angle2((float)(-Math.Atan2(TargetVec.X - MyVec.X, TargetVec.Y - MyVec.Y) / Math.PI * 180.0f + 180.0f));
        }
        public static Point ToPoint(this Vector2 MyVec)
        {
            return new Point((int)MyVec.X, (int)MyVec.Y);
        }
        public static PointF ToPointF(this Vector2 MyVec)
        {
            return new PointF(MyVec.X, MyVec.Y);
        }
        public static Vector2 Add(this Vector2 MyVec, float X, float Y)
        {
            return new Vector2(MyVec.X + X, MyVec.Y + Y);
        }




        // Vector3
        public static void Reset(this Vector3 MyVec)
        {
            MyVec.X = 0;
            MyVec.Y = 0;
            MyVec.Z = 0;
        }
        public static Vector3 Normalize(this Vector3 MyVec)
        {
            float distance = (float)Math.Sqrt(MyVec.X * MyVec.X + MyVec.Y * MyVec.Y + MyVec.Z * MyVec.Z);
            return new Vector3(MyVec.X / distance, MyVec.Y / distance, MyVec.Z / distance);
        }
        public static Vector3 MoveTowards(this Vector3 MyVec, Vector3 TargetVec, float MaxDeltaDistance)
        {
            float ToVec_X = TargetVec.X - MyVec.X;
            float ToVec_Y = TargetVec.Y - MyVec.Y;
            float ToVec_Z = TargetVec.Z - MyVec.Z;

            float SqDistance = ToVec_X * ToVec_X + ToVec_Y * ToVec_Y + ToVec_Z * ToVec_Z;

            if (SqDistance == 0 || (MaxDeltaDistance >= 0 && SqDistance <= MaxDeltaDistance * MaxDeltaDistance))
                return TargetVec;
            var Distance = (float)Math.Sqrt(SqDistance);

            return new Vector3(MyVec.X + ToVec_X / Distance * MaxDeltaDistance, MyVec.Y + ToVec_Y / Distance * MaxDeltaDistance, MyVec.Z + ToVec_Z / Distance * MaxDeltaDistance);
        }
        public static float Distance(this Vector3 MyVec, Vector3 TargetVec)
        {
            float Difference_X = MyVec.X - TargetVec.X;
            float Difference_Y = MyVec.Y - TargetVec.Y;
            float Difference_Z = MyVec.Z - TargetVec.Z;
            return (float)Math.Sqrt(Difference_X * Difference_X + Difference_Y * Difference_Y + Difference_Z * Difference_Z);
        }
        public static float Dot(this Vector3 MyVec, Vector3 TargetVec)
        {
            return MyVec.X * TargetVec.X + MyVec.Y * TargetVec.Y + MyVec.Z * TargetVec.Z;
        }
        public static Vector3 Cross(this Vector3 MyVec, Vector3 TargetVec)
        {
            return new Vector3(
                MyVec.Y * TargetVec.Z - MyVec.Z * TargetVec.Y,
                MyVec.Z * TargetVec.X - MyVec.X * TargetVec.Z,
                MyVec.X * TargetVec.Y - MyVec.Y * TargetVec.X);
        }

        public static Angle3 GetAngle(this Vector3 MyVec, Vector3 TargetVec)
        {
            Angle3 angle = new Angle3
            {
                Pitch = (float)(-Math.Atan2(TargetVec.X - MyVec.X, TargetVec.Y - MyVec.Y) / Math.PI * 180.0f + 180.0f),
                Yaw = (float)(Math.Asin((TargetVec.Z - MyVec.Z) / Distance(MyVec, TargetVec)) * 180.0f / Math.PI),
                Roll = 0.0f
            };
            return angle;
        }
        public static Vector3 Add(this Vector3 MyVec, float X, float Y, float Z)
        {
            return new Vector3(MyVec.X + X, MyVec.Y + Y, MyVec.Z + Z);
        }
        public static Point ToPoint(this Vector3 MyVec)
        {
            return new Point((int)MyVec.X, (int)MyVec.Y);
        }
        public static PointF ToPointF(this Vector3 MyVec)
        {
            return new PointF(MyVec.X, MyVec.Y);
        }
    }
}