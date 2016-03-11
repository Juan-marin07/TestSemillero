using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Reflection;

namespace RedesSociales
{
    class WebFactory
    {

        public IWeb CreateRequest(string DirrecionURl)
        {
            DirrecionURl = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(DirrecionURl.ToLower()); ;
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                var type = assembly.GetTypes().First(t => t.Name == DirrecionURl);
                //Console.WriteLine(network + " successfully generated");
                return (IWeb)Activator.CreateInstance(type);
            }
            catch (Exception e)
            {
                //Console.WriteLine(network + " does not exist.");
                // MessageBox.Show("The calculations are complete", "My Application");
                return null;
            }
        }
    }
}
