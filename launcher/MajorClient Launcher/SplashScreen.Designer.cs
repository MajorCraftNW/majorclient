namespace MajorClient_Launcher
{
	partial class SplashScreen
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.controllerText = new System.Windows.Forms.Label();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.loader = new System.Windows.Forms.Timer(this.components);
			this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.guna2Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 25;
			this.guna2Elipse1.TargetControl = this;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(255, 200);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(182, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "MajorClient Launcher";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// controllerText
			// 
			this.controllerText.AutoSize = true;
			this.controllerText.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.controllerText.ForeColor = System.Drawing.Color.White;
			this.controllerText.Location = new System.Drawing.Point(0, 325);
			this.controllerText.Name = "controllerText";
			this.controllerText.Size = new System.Drawing.Size(137, 22);
			this.controllerText.TabIndex = 2;
			this.controllerText.Text = "{controllerText}";
			this.controllerText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.controllerText.Click += new System.EventHandler(this.label2_Click);
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BackColor = System.Drawing.Color.Cyan;
			this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(25, 25);
			this.guna2Panel1.TabIndex = 3;
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.Controls.Add(this.guna2Panel1);
			this.guna2Panel2.Location = new System.Drawing.Point(0, 350);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new System.Drawing.Size(700, 25);
			this.guna2Panel2.TabIndex = 4;
			// 
			// loader
			// 
			this.loader.Enabled = true;
			this.loader.Interval = 15;
			this.loader.Tick += new System.EventHandler(this.loader_Tick);
			// 
			// guna2ControlBox1
			// 
			this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new System.Drawing.Point(665, 0);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new System.Drawing.Size(35, 35);
			this.guna2ControlBox1.TabIndex = 5;
			this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
			// 
			// guna2Elipse2
			// 
			this.guna2Elipse2.BorderRadius = 25;
			this.guna2Elipse2.TargetControl = this.guna2ControlBox1;
			// 
			// guna2BorderlessForm1
			// 
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.Image = global::MajorClient_Launcher.Properties.Resources._512p;
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(273, 50);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new System.Drawing.Size(150, 150);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2PictureBox1.TabIndex = 0;
			this.guna2PictureBox1.TabStop = false;
			// 
			// guna2DragControl1
			// 
			this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
			this.guna2DragControl1.TargetControl = this.guna2PictureBox1;
			this.guna2DragControl1.UseTransparentDrag = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(74, 256);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(568, 42);
			this.label2.TabIndex = 6;
			this.label2.Text = "Launcher, Yapay Zeka Destekli Optimizasyona Sahiptir.\r\nBir Sorunla Karşılaşırsanı" +
    "z Discord Üzerinden Ulaşabilirsiniz.";
			// 
			// SplashScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.ClientSize = new System.Drawing.Size(700, 375);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.guna2ControlBox1);
			this.Controls.Add(this.controllerText);
			this.Controls.Add(this.guna2Panel2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.guna2PictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SplashScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Açılıyor... | MajorClient Launcher";
			this.Load += new System.EventHandler(this.SplashScreen_Load);
			this.guna2Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label controllerText;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private System.Windows.Forms.Timer loader;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
		private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private System.Windows.Forms.Label label2;
	}
}

