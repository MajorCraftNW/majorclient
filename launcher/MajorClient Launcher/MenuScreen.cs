using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

using CmlLib.Utils;
using CmlLib.Core;
using CmlLib.Core.Auth;
using Guna.UI2.WinForms;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace MajorClient_Launcher
{
	public partial class MenuScreen : Form
	{
		public MenuScreen()
		{
			InitializeComponent();
			CheckForIllegalCrossThreadCalls = false;
			Optimization.ApplyOptimizations(this);
		}

		private DiscordRPC.EventHandlers handlers;
		private DiscordRPC.RichPresence presence;
		void RPC()
		{
			this.handlers = default(DiscordRPC.EventHandlers);
			DiscordRPC.Initialize("1179841204226105355", ref this.handlers, true, null);
			this.presence.details = "MajorClient Launcher";
			this.presence.state = "Ana Sayfa";
			this.presence.largeImageKey = "majorclient";
			this.presence.largeImageText = "Made by ImJumperr";
			this.presence.startTimestamp = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
			DiscordRPC.UpdatePresence(ref this.presence);
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

		private void MenuScreen_Load(object sender, EventArgs e)
		{
			InternetConnection();
			IsInternetAvailable();
			usernametexter.Text += LoginScreen.minecraftusername;
			RPC();
			path();

			try
			{
				string minecraftusername = LoginScreen.minecraftusername;
				string skinURL = "https://minotar.net/helm/" + minecraftusername + "/100.png";
				using (WebClient client = new WebClient())
				{
					using (Stream stream = client.OpenRead(skinURL))
					{
						Image skin = Image.FromStream(stream);
						skinImage.Image = skin;
					}
				}
			}
			catch (Exception)
			{
				string errorSkinURL = "https://minotar.net/helm/mhf_steve/100.png";
				using (WebClient client = new WebClient())
				{
					using (Stream stream = client.OpenRead(errorSkinURL))
					{
						Image skin = Image.FromStream(stream);
						skinImage.Image = skin;
					}
				}
			}
		}

		private void guna2ControlBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void guna2PictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void path()
		{
			MinecraftPath path = new MinecraftPath(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".majorclient"));
			var launcher = new CMLauncher(path);
		}

		private void launch()
		{
			MinecraftPath path = new MinecraftPath(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".majorclient"));
			var launcher = new CMLauncher(path);

			var launchOption = new MLaunchOption
			{
				MaximumRamMb = 2048,
				Session = MSession.GetOfflineSession(LoginScreen.minecraftusername),
			//  ServerIp = "phoenixcraft.tk",
			//  ServerPort = 25565,
			};

			var process = launcher.CreateProcess("1.8.8", launchOption);
			process.Start();
			this.Hide();

			while (true)
			{
				Process[] pname = Process.GetProcessesByName("javaw");
				if (pname.Length > 0)
				{

				}
				else
				{
					this.Show();
					guna2PictureBox1.Enabled = true;
					break;
				}

			}
		}

		private void guna2PictureBox5_Click(object sender, EventArgs e)
		{
			LoginScreen ls = new LoginScreen();
			ls.Show();
			this.Hide();
		}

		private void guna2PictureBox4_Click(object sender, EventArgs e)
		{
			guna2Panel1.Enabled = true;
			guna2Panel1.Visible = true;
		}

		private void guna2PictureBox6_Click(object sender, EventArgs e)
		{
			guna2Panel1.Enabled = false;
			guna2Panel1.Visible = false;
		}
	}
}
