using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Renamer.Models
{
    public class FileName
    {
        private string Directory;

        public string Original;
        public string Modified;

        private FileInfo Info;

        //public FileName(string fullPath)
        //{
        //}

        //directory name should not end with \
        
        public FileName(string directory, string original, string modified)
        {
            Directory = directory.TrimEnd('\\'); 

            Original = original;
            Modified = modified;
        }

        public FileName(FileName name, bool swap = false)
        {
            Directory = name.Directory.TrimEnd('\\');

            Original = name.Original;
            Modified = name.Modified;

            if (swap) Swap();
        }

        public void Reset()
        {
            Modified = Original;
        }

        public bool IsValidName()
        {
            if (Modified == "") return false;
            return (Modified.IndexOfAny(Path.GetInvalidFileNameChars()) == -1);
        }

        public void Swap()
        {
            var temp = Original;
            Original = Modified;
            Modified = temp;
        }

        public string GetExtension()
        {
            return Path.GetExtension(this.Original);
        }

        public string GetModifiedNameWithoutExtension()
        {
            return Path.GetFileNameWithoutExtension(Modified);
        }

        public string ParentDirectory()
        {
            var parts = this.Directory.Split('\\');
            return parts[parts.Length - 1];
            //var parts = this.Directory.Split('\\');
            //var parent = parts[parts.Length - 1];

            //if (parent == "") return parts[0];          //if this.Directory is C:\ (only a drive), parent will be "", so return the drive
            //return parent;                              //else return the directory name
        }

        public string FullPath()
        {
            return this.Directory + "\\" + this.Original;
        }

        public string FullPathModified(string newDirectory = null)
        {
            if (newDirectory != null) return newDirectory + "\\" + this.Modified;
            return this.Directory + "\\" + this.Modified;
        }

        public System.Drawing.Bitmap GetIcon()
        {
            return Common.ShellIcon.GetBitmapIcon(this.FullPath());
        }

        public System.Drawing.Bitmap GetIconModified()
        {
            return Common.ShellIcon.GetBitmapIcon(this.FullPathModified());
        }

        private void LoadFileInfo()
        {
            if (Info == null)
                Info = new FileInfo(this.FullPath());
        }

        public string CreationDate()
        {
            LoadFileInfo();

            return Info.CreationTime.ToShortDateString() + " " + Info.CreationTime.ToShortTimeString();
        }

        public string LastWriteDate()
        {
            LoadFileInfo();

            return Info.LastWriteTime.ToShortDateString() + " " + Info.LastWriteTime.ToShortTimeString();
        }
                
        //trim file length to fit a unit
        private double TrimSize(double length, int n = 0)
        {
            for (int i = 0; i < n; i++) length /= 1024.0;         //divide n times by 1024            
            return Math.Round(Convert.ToDouble(length), 2);     //convert to double and round to 2 decimal places
        }

        public string ReadableFileSize()
        {
            LoadFileInfo();

            long length = Info.Length;

            if (length < Math.Pow(1024, 1)) return length + " B";               //lower than 1kb
            if (length < Math.Pow(1024, 2)) return TrimSize(length, 1) + " KB"; //lower than 1mb
            if (length < Math.Pow(1024, 3)) return TrimSize(length, 2) + " MB"; //lower than 1gb
            if (length < Math.Pow(1024, 4)) return TrimSize(length, 3) + " GB"; //lower than 1tb
            
            return length + " TB";                                              //return size in tb    
        }




    }
}
