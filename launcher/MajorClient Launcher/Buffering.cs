using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MajorClient_Launcher
{
	internal class Buffering
	{
		public static void EnableDoubleBuffering(Control control)
		{
			// Çift tamponlamayı etkinleştirmek için SetStyle metodunu kullanma
			typeof(Control).GetMethod("SetStyle", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
			?.Invoke(control, new object[] { ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer, true });
		}
	}
}
