using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CmlLib.Utils;
using CmlLib.Core;
using CmlLib.Core.Auth;

namespace MajorClient_Launcher
{
	internal class LatestUpdates
	{
		public static string java8JSON = "https://raw.githubusercontent.com/majorclient/majorclient.github.io/main/bootstrap.json";
		public static string java16JSON = "";
		public static string java17JSON = "";
		public static string java18JSON = "";

		public static string javaFolder = java8JSON;
		public static string javaFile = "C:\\Program Files\\Java\\bin\\java.exe";
		public static string javawFile = "C:\\Program Files\\Java\\bin\\javaw.exe";
		public static string githubURL = "https://github.com/majorclient/majorclient.github.io/";
		public static string webURL = "https://majorclient.github.io";
		public static string latestVersion = "https://raw.githubusercontent.com/majorclient/majorclient.github.io/main/version";
		public static string launcherversion = "(MajorLauncherVersion-1.0.0)(LauncherID-d7481ac)";
	}
}
