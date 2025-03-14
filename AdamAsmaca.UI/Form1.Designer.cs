namespace AdamAsmaca.UI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnIp = new Button();
            btnBas = new Button();
            btnSolKol = new Button();
            btnSagKol = new Button();
            btnGovde = new Button();
            btnSolBacak = new Button();
            btnSagBacak = new Button();
            lblKelime = new Label();
            grpBoxHarfler = new GroupBox();
            btnYeniOyun = new Button();
            SuspendLayout();
            // 
            // btnIp
            // 
            btnIp.BackColor = Color.Brown;
            btnIp.FlatStyle = FlatStyle.Flat;
            btnIp.Location = new Point(430, 10);
            btnIp.Name = "btnIp";
            btnIp.Size = new Size(10, 50);
            btnIp.TabIndex = 0;
            btnIp.UseVisualStyleBackColor = false;
            // 
            // btnBas
            // 
            btnBas.BackColor = Color.SteelBlue;
            btnBas.FlatAppearance.BorderColor = Color.Black;
            btnBas.FlatStyle = FlatStyle.Flat;
            btnBas.Location = new Point(400, 54);
            btnBas.Name = "btnBas";
            btnBas.Size = new Size(60, 60);
            btnBas.TabIndex = 1;
            btnBas.UseVisualStyleBackColor = false;
            // 
            // btnSolKol
            // 
            btnSolKol.BackColor = Color.SteelBlue;
            btnSolKol.FlatAppearance.BorderColor = Color.Black;
            btnSolKol.FlatStyle = FlatStyle.Flat;
            btnSolKol.Location = new Point(375, 120);
            btnSolKol.Name = "btnSolKol";
            btnSolKol.Size = new Size(40, 70);
            btnSolKol.TabIndex = 3;
            btnSolKol.UseVisualStyleBackColor = false;
            // 
            // btnSagKol
            // 
            btnSagKol.BackColor = Color.SteelBlue;
            btnSagKol.FlatAppearance.BorderColor = Color.Black;
            btnSagKol.FlatStyle = FlatStyle.Flat;
            btnSagKol.Location = new Point(445, 120);
            btnSagKol.Name = "btnSagKol";
            btnSagKol.Size = new Size(40, 70);
            btnSagKol.TabIndex = 4;
            btnSagKol.UseVisualStyleBackColor = false;
            // 
            // btnGovde
            // 
            btnGovde.BackColor = Color.SteelBlue;
            btnGovde.FlatAppearance.BorderColor = Color.Black;
            btnGovde.FlatStyle = FlatStyle.Flat;
            btnGovde.Location = new Point(415, 110);
            btnGovde.Name = "btnGovde";
            btnGovde.Size = new Size(30, 90);
            btnGovde.TabIndex = 2;
            btnGovde.UseVisualStyleBackColor = false;
            // 
            // btnSolBacak
            // 
            btnSolBacak.BackColor = Color.SteelBlue;
            btnSolBacak.FlatAppearance.BorderColor = Color.Black;
            btnSolBacak.FlatStyle = FlatStyle.Flat;
            btnSolBacak.Location = new Point(400, 200);
            btnSolBacak.Name = "btnSolBacak";
            btnSolBacak.Size = new Size(30, 80);
            btnSolBacak.TabIndex = 5;
            btnSolBacak.UseVisualStyleBackColor = false;
            // 
            // btnSagBacak
            // 
            btnSagBacak.BackColor = Color.SteelBlue;
            btnSagBacak.FlatAppearance.BorderColor = Color.Black;
            btnSagBacak.FlatStyle = FlatStyle.Flat;
            btnSagBacak.Location = new Point(430, 200);
            btnSagBacak.Name = "btnSagBacak";
            btnSagBacak.Size = new Size(30, 80);
            btnSagBacak.TabIndex = 6;
            btnSagBacak.UseVisualStyleBackColor = false;
            // 
            // lblKelime
            // 
            lblKelime.Font = new Font("Arial", 14F, FontStyle.Bold);
            lblKelime.Location = new Point(300, 300);
            lblKelime.Name = "lblKelime";
            lblKelime.Size = new Size(300, 40);
            lblKelime.TabIndex = 7;
            lblKelime.Text = "Kelime: ___";
            lblKelime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpBoxHarfler
            // 
            grpBoxHarfler.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            grpBoxHarfler.Location = new Point(100, 350);
            grpBoxHarfler.Name = "grpBoxHarfler";
            grpBoxHarfler.Size = new Size(660, 122);
            grpBoxHarfler.TabIndex = 8;
            grpBoxHarfler.TabStop = false;
            grpBoxHarfler.Text = "Harf Seç";
            // 
            // btnYeniOyun
            // 
            btnYeniOyun.Location = new Point(10, 10);
            btnYeniOyun.Name = "btnYeniOyun";
            btnYeniOyun.Size = new Size(100, 30);
            btnYeniOyun.TabIndex = 9;
            btnYeniOyun.Text = "Yeni Oyun";
            btnYeniOyun.UseVisualStyleBackColor = true;
            btnYeniOyun.Click += btnYeniOyun_Click;
            // 
            // Form1
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(900, 550);
            Controls.Add(btnYeniOyun);
            Controls.Add(btnIp);
            Controls.Add(btnBas);
            Controls.Add(btnGovde);
            Controls.Add(btnSolKol);
            Controls.Add(btnSagKol);
            Controls.Add(btnSolBacak);
            Controls.Add(btnSagBacak);
            Controls.Add(lblKelime);
            Controls.Add(grpBoxHarfler);
            Name = "Form1";
            Text = "Adam Asmaca";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnIp;
        private System.Windows.Forms.Button btnBas;
        private System.Windows.Forms.Button btnSolKol;
        private System.Windows.Forms.Button btnSagKol;
        private System.Windows.Forms.Button btnGovde;
        private System.Windows.Forms.Button btnSolBacak;
        private System.Windows.Forms.Button btnSagBacak;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.GroupBox grpBoxHarfler;
        private Button btnYeniOyun;
    }
}