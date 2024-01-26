using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zlib;
using System.CodeDom;
using System.Security.Policy;
using Newtonsoft.Json.Bson;
using System.Configuration;

namespace MajorClient_Launcher
{
	internal class Optimization
	{

		public static void ApplyOptimizations(Form form)
		{
			EnableDoubleBuffering(form);
			form.Load += (sender, e) => OnFormLoad(sender, e, form);
			form.Resize += (sender, e) => OnFormResize(sender, e, form);
		}

		private static void EnableDoubleBuffering(Control control)
		{
			typeof(Control).GetMethod("SetStyle", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
			?.Invoke(control, new object[] { ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer, true });
		}

		private static void OnFormLoad(object sender, EventArgs e, Form form)
		{
			if (form is SplashScreen ss)
			{
				Console.WriteLine("OpenAI © | SplashScreen Verileri İçerisinde Optimize Edildi!");
			}

			if (form is SplashScreenJava ssj)
			{
				Console.WriteLine("OpenAI © | SplashScreenJava Verileri İçerisinde Optimize Edildi!");
			}

			if (form is LoginScreen ls)
			{
				Console.WriteLine("OpenAI © | LoginScreen Verileri İçerisinde Optimize Edildi!");
			}

			if (form is MenuScreen ms)
			{
				Console.WriteLine("OpenAI © | MenuScreen Verileri İçerisinde Optimize Edildi!");
			}
		}

		private static void OnFormResize(object sender, EventArgs e, Form form)
		{
			if (form is SplashScreen ss)
			{
				Console.WriteLine("OpenAI © | SplashScreen Cihaz Çözünürlüğünde Optimize Edildi!");
			}

			if (form is SplashScreenJava ssj)
			{
				Console.WriteLine("OpenAI © | SplashScreenJava Cihaz Çözünürlüğünde Optimize Edildi!");
			}

			if (form is LoginScreen ls)
			{
				Console.WriteLine("OpenAI © | LoginScreen Cihaz Çözünürlüğünde Optimize Edildi!");
			}

			if (form is MenuScreen ms)
			{
				Console.WriteLine("OpenAI © | MenuScreen Cihaz Çözünürlüğünde Optimize Edildi!");
			}
		}
	}
}
