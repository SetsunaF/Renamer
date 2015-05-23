using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Renamer.Common
{
    public static class ShellIcon
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public IntPtr iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        class Win32
        {
            public const uint SHGFI_ICON = 0x100;
            public const uint SHGFI_LARGEICON = 0x0; // Large icon
            public const uint SHGFI_SMALLICON = 0x1; // Small icon
            public const uint USEFILEATTRIBUTES = 0x000000010; // when the full path isn't available
            [DllImport("shell32.dll")]
            public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);
            [DllImport("User32.dll")]
            public static extern int DestroyIcon(IntPtr hIcon);
        }
                
        private static Icon GetIcon(string fileName)
        {
            IntPtr hImgSmall; //the handle to the system image list
            SHFILEINFO shinfo = new SHFILEINFO();
            hImgSmall = Win32.SHGetFileInfo(fileName, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), Win32.SHGFI_ICON | Win32.SHGFI_SMALLICON | Win32.USEFILEATTRIBUTES);
            //The icon is returned in the hIcon member of the shinfo struct
            Icon icon = (Icon)Icon.FromHandle(shinfo.hIcon).Clone();
            Win32.DestroyIcon(shinfo.hIcon);

            return icon;
        }

        private static List<ExtIcon> cache = new List<ExtIcon>();

        private static int FindIconIndex(string extension)
        {
            if (extension == ".exe") return -1;

            for (int i = 0; i < cache.Count; i++)
            {
                if (cache[i].Equals(extension))
                {
                    return i;
                }
            }

            return -1;
        }

        public static Bitmap GetBitmapIcon(string fileName)
        {
            var parts = fileName.Split('.');
            string extension = ".";
            if (parts.Length > 1) extension += parts[parts.Length - 1];

            int index = FindIconIndex(extension);

            if (index == -1)
            {
                var icon = GetIcon(fileName).ToBitmap();
                if (extension != ".exe") cache.Add(new ExtIcon(extension, icon));
                return icon;
            }

            return cache[index].icon;
        }
    }

    public class ExtIcon
    {
        private string extension;
        public Bitmap icon;

        public ExtIcon(string extension, Bitmap icon)
        {
            this.extension = extension;
            this.icon = icon;
        }

        public bool Equals(string extension)
        {
            return this.extension == extension;
        }
    }
}
