using System;
using System.Collections.Generic;
using System.IO;

using Newtonsoft.Json;
using Renamer.Common;

namespace Renamer.Models
{
    public class Profile
    {
        public string Name;
        public string FileName;
        public List<Filter> Filters;

        public Profile(string file)
        {
            Name = Path.GetFileNameWithoutExtension(file);
            FileName = file;

            //Read filters from profile file
            string json = File.ReadAllText(FileName);
            Filters = JsonConvert.DeserializeObject<List<Filter>>(json);

            //Because each filter only has filterType, firstArgument and secondArgument as public attributes
            //We need to recreate the filter
            for (int i = 0; i < Filters.Count; i++)
            {
                Filters[i] = new Filter(Filters[i].filterType, Filters[i].FirstArgument, Filters[i].SecondArgument);
            }
        }

        public Profile(string name, List<Filter> list)
        {
            Name = name.Clean();

            string appDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            FileName = appDirectory + "\\Profiles\\" + Name + ".json";

            Filters = new List<Filter>(list);
        }

        public bool Save(bool overwrite, out string message)
        {
            if (!overwrite && File.Exists(FileName))
            {
                message = "Profile name already in use, please choose another name.";
                return false;
            }

            if (Name == "")
            {
                message = "Name can not be empty.";
                return false;
            }

            Delete(out message);

            try
            {
                //MessageBox.Show(FileName);

                var writer = new StreamWriter(FileName);
                writer.Write(GetJson());
                writer.Close();

                message = "";
                return true;
            }
            catch (Exception exception)
            {
                //Console.WriteLine(exception.Message);
                message = exception.Message;
                return false;
            }
        }

        //public bool SaveAs(string newName, out string message)
        //{
        //    FileName = newName;
        //    return Save(false, out message);
        //}

        public bool Rename(string newName, out string message)
        {
            try
            {
                File.Move(FileName, newName);
                FileName = newName;
                message = "";
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                message = exception.Message;
                return false;
            }
        }

        public bool Delete(out string message)
        {
            try
            {
                File.Delete(FileName);
                message = "";
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                message = exception.Message;
                return false;
            }
        }

        private string GetJson()
        {
            return JsonConvert.SerializeObject(Filters);
        }

        




}
}
