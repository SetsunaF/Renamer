using System.IO;
using System.Runtime.InteropServices;

namespace Renamer.Models
{
    public class FileName
    {
        private string Directory;

        public string Original;
        public string Modified;

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

        public string FullPathModified()
        {
            return this.Directory + "\\" + this.Modified;
        }

        public System.Drawing.Bitmap GetIcon()
        {
            return Common.ShellIcon.GetIcon(this.FullPath()).ToBitmap();
        }

        public System.Drawing.Bitmap GetIconModified()
        {
            return Common.ShellIcon.GetIcon(this.FullPathModified()).ToBitmap();
        }
    }
}
