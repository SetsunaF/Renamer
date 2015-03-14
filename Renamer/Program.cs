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
        static void Main()
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
                        setProfileRootMethod.Invoke(null, new object[] { Application.StartupPath });
                        startProfileMethod.Invoke(null, new object[] { "Startup.Profile" });
                    }
                    catch { }
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
