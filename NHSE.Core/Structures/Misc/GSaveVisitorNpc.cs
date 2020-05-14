﻿using System.ComponentModel;
using System.Runtime.InteropServices;

#pragma warning disable CS8618, CA1815, CA1819, IDE1006
namespace NHSE.Core
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public class GSaveVisitorNpc
    {
        public const int SIZE = 0x78;
        private const int Days = 7;

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = Days)]
        public int[] VisitorNPC { get; set; }

        public V3f CreatePos { get; set; }
        public V3f _61e631dc { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.I1, SizeConst = Days)]
        public bool[] IsNormalLive { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.I1, SizeConst = Days)]
        public bool[] IsBirthdayLive { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] gap_42;

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = Days)]
        public int[] InitSchedule { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.I1, SizeConst = Days * 2)]
        public bool[] _437619d8 { get; set; }

        [field: MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] gap_6e;

        public int _e2484556 {get; set; }
        public int _753479b1 { get; set; }
    }

    // same as Vector3; not importing package
    [TypeConverter(typeof(ValueTypeTypeConverter))]
    public struct V3f
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public override string ToString() => $"({X},{Y},{Z})";
    }
}
