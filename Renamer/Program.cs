using System;
using System.Reflection;
using System.Windows.Forms;

namespace Renamer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Enable multicore jit if available
            //http://blog.getpaint.net/2012/09/08/using-multi-core-jit-from-net-4-0-if-net-4-5-is-installed/

            var profileOptimizationType = Type.GetType("System.Runtime.ProfileOptimization", false);
            if (profileOptimizationType != null)
            {
                var setProfileRootMethod = profileOptimizationType.GetMethod("SetProfileRoot", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(string) }, null);
                var startProfileMethod = profileOptimizationType.GetMethod("StartProfile", BindingFlags.Static | BindingFlags.Public, null, new Type[] { typeof(string) }, null);

                if (setProfileRootMethod != null && startProfileMethod != null)
                {
                    try
                    {
                        setProfileRootMethod.Invoke(null, new object[] { Models.Settings.ApplicationDataPath });
                        startProfileMethod.Invoke(null, new object[] { "Startup.Profile" });
                    }
                    catch { }
                }
            }            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length == 1) Application.Run(new Main(args[0]));
            else Application.Run(new Main());
        }
    }
}
