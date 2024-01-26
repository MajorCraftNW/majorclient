using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CmlLib.Utils;
using CmlLib.Core;
using CmlLib.Core.Auth;
using System.Net.NetworkInformation;

namespace MajorClient_Launcher
{
	public partial class LoginScreen : Form
	{
		public LoginScreen()
		{
			InitializeComponent();
			Optimization.ApplyOptimizations(this);
		}

		public static string minecraftusername;

		private DiscordRPC.EventHandlers handlers;
		private DiscordRPC.RichPresence presence;
		void RPC()
		{
			this.handlers = default(DiscordRPC.EventHandlers);
			DiscordRPC.Initialize("1179841204226105355", ref this.handlers, true, null);
			this.presence.details = "MajorClient Launcher";
			this.presence.state = "Hesaba Giris Menusu";
			this.presence.largeImageKey = "majorclient";
			this.presence.largeImageText = "Made by ImJumperr";
			this.presence.startTimestamp = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
			DiscordRPC.UpdatePresence(ref this.presence);
		}

		public static bool IsInternetAvailable()
		{
			try
			{
				using (Ping ping = new Ping())
				{
					PingReply reply = ping.Send("www.google.com", 3000); // Google'ın IP'sini ping atarak kontrol edebilirsiniz.
					return (reply != null && reply.Status == IPStatus.Success);
				}
			}
			catch
			{
				return false;
			}
		}

		private static void InternetConnection()
		{
			if (IsInternetAvailable())
			{

			}
			else
			{
				MessageBox.Show("Error" + "Internet Bağlantısı Bulunamadı. Bağlantınızı Kontrol Edin ve Yeniden Deneyin.");
				Application.Exit();
			}
		}

		private void LoginScreen_Load(object sender, EventArgs e)
		{
			InternetConnection();
			IsInternetAvailable();
			RPC();
		}

		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://majorclient.github.io/");
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			minecraftusername = mcUserText.Text;
			MenuScreen ms = new MenuScreen();
			ms.Show();
			this.Hide();
		}
	}
}
