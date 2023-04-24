using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEntrada
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new Login());
             //Application.Run(new Usuarios());
            //  Application.Run(new Menu());
            //Application.Run(new Personas());
        }
    }
    public class AppData
    {
        public const int MaxFingers = 10;
        //shared data
        public int EnrrolledFingerMask = 0;
        public int MaxEnrollFingerCount = MaxFingers;
        public bool IsEventHandlerSucceeds = true;
        public bool IsFeatureSetMatched = false;
        public int FalseAcceptRate = 0;
        public DPFP.Template[] Templates = new DPFP.Template[MaxFingers];

    }
}
