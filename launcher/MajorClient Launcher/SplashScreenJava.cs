using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MajorClient_Launcher
{
	public partial class SplashScreenJava : Form
	{
		public SplashScreenJava()
		{
			InitializeComponent();
			Optimization.ApplyOptimizations(this);
		}

		private void SplashScreenJava_Load(object sender, EventArgs e)
		{
			IsOracleAvailable();
			OracleConnection();
			RPC();
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

		public static bool IsOracleAvailable()
		{
			try
			{
				using (Ping ping = new Ping())
				{
					PingReply reply = ping.Send("www.oracle.com", 3000); // Google'ın IP'sini ping atarak kontrol edebilirsiniz.
					return (reply != null && reply.Status == IPStatus.Success);
				}
			}
			catch
			{
				return false;
			}
		}

		private static void OracleConnection()
		{
			if (IsOracleAvailable())
			{
				IsOracleAvailable();
				Console.WriteLine(" ");
			}
			else
			{
				MessageBox.Show("Error" + "Oracle Bağlantısı Bulunamadı. Eğer Bir Sorun Yoksa Yeniden Deneyin.");
				Application.Exit();
			}
		}

		private void folderPather()
		{
			if (Directory.Exists(LatestUpdates.javaFolder))
			{
				/*
                  Console.WriteLine("Cihazda Kurulmuş Bir Java Bulundu.");
                  consoleTexter = true;
                */
			}
			else
			{
				MessageBox.Show("Cihazınız da Kurulmuş Bir Java Bulunamadı.");
				MessageBox.Show("Kurulum Yolunu (C: -> Program Files -> Java) Olarak Güncelleyiniz!");
				Application.Exit();
			}
		}

		private void filePather()
		{
			if (File.Exists (LatestUpdates.javaFile))
			{
				/*
                  Console.WriteLine("Cihazda Kurulmuş Bir Java Bulundu.");
                  consoleTexter = true;
                */
			}
			else
			{
				MessageBox.Show("Cihazınız da Kurulmuş Bir Java Bulunamadı.");
				MessageBox.Show("Kurulum Yolunu (C: -> Program Files -> Java) Olarak Güncelleyiniz!");
				Application.Exit();
			}
		}

		private void controllerText_Click(object sender, EventArgs e)
		{

		}

		private void javaLoader_Tick(object sender, EventArgs e)
		{
			guna2Panel1.Width += 3;
			if (guna2Panel1.Width >= 0)
			{
			 // OracleConnection();
				controllerJava.Text = "Oracle Bağlantısı Kuruluyor...";
			}
			if (guna2Panel1.Width >= 233)
			{
				folderPather();
				controllerJava.Text = "Java Klasörü Kontrol Ediliyor...";
			}
			if (guna2Panel1.Width >= 466)
			{
				filePather();
				controllerJava.Text = "Java.exe Programı Kontrol Ediliyor...";
			}
			
			if (guna2Panel1.Width >= 699)
			{
				controllerJava.Text = "Launcher Başlatılıyor...";
				javaLoader.Stop();
				LoginScreen ls = new LoginScreen();
				ls.Show();
				this.Hide();
			}
		}
	}
}
