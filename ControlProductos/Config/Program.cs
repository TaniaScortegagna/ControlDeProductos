using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlProductos
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD:ControlProductos/Config/Program.cs
            Application.Run(new Login());
=======
            Application.Run(new AdministrarProducto());
>>>>>>> origin/master:ControlProductos/Program.cs
        }
    }
}
