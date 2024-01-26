using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using System.Drawing.Text;
using System.ComponentModel.Design.Serialization;
using System.Net.NetworkInformation;

using CmlLib.Utils;
using CmlLib.Core;
using CmlLib.Core.Auth;

namespace MajorClient_Launcher
{
	public partial class SplashScreen : Form
	{
		public SplashScreen()
		{
			InitializeComponent();
			Optimization.ApplyOptimizations(this);
		}

		private DiscordRPC.EventHandlers handlers;
		private DiscordRPC.RichPresence presence;
		void RPC()
		{
			this.handlers = default(DiscordRPC.EventHandlers);
			DiscordRPC.Initialize("1179841204226105355", ref this.handlers, true, null);
			this.presence.details = "MajorClient Launcher";
			this.presence.state = "Launcher Baslatiliyor...";
			this.presence.largeImageKey = "majorclient";
			this.presence.largeImageText = "Made by ImJumperr";
			this.presence.startTimestamp = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
			DiscordRPC.UpdatePresence(ref this.presence);
		}

		private void SplashScreen_Load(object sender, EventArgs e)
		{
			IsInternetAvailable();
			InternetConnection();
		    RPC();
			loader.Start();
		}

		private void loader_Tick(object sender, EventArgs e)
		{
			guna2Panel1.Width += 3;
			if (guna2Panel1.Width >= 0)
			{
				IsInternetAvailable();
				InternetConnection();
				controllerText.Text = "İnternet Bağlantısı Kontrol Ediliyor...";
			}
			if (guna2Panel1.Width >= 275)
			{
				CheckVersion();
				controllerText.Text = "Güncellemeler Kontrol Ediliyor...";
			}
			if (guna2Panel1.Width >= 475)
			{
				controllerText.Text = "Program Verileri Yükleniyor...";
			}
			if (guna2Panel1.Width >= 675)
			{
				controllerText.Text = "Launcher Başlatılıyor...";
				loader.Stop();
				SplashScreenJava ssj = new SplashScreenJava();
				ssj.Show();
				this.Hide();
			}
		}

		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void CheckVersion()
		{
			try
			{
				using (WebClient client = new WebClient())
				{
					string remoteVersion = client.DownloadString(LatestUpdates.latestVersion).Trim();

					if (remoteVersion != LatestUpdates.launcherversion)
					{
						loader.Stop();
						MessageBox.Show("Yeni Güncelleme Mevcut !");
						Process.Start(LatestUpdates.webURL);
						Application.Exit();
					}
				}
			}
			catch (Exception)
			{
				loader.Stop();
				MessageBox.Show("Hata!" + "Internet Bağlantısı Bulunamadı. Bağlantınızı Kontrol Edin ve Yeniden Deneyin.");
				Application.Exit();
			}
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
				IsInternetAvailable();
			}
			else
			{
				MessageBox.Show("Hata!" + "Internet Bağlantısı Bulunamadı. Bağlantınızı Kontrol Edin ve Yeniden Deneyin.");
				Application.Exit();
			}
		}
	}
}
