using Bloknot;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace File_manager
{
    public partial class File_manager : Form
    {
        Label info = new Label();
        Label info_f = new Label();
        int i = 0;
        public File_manager()
        {
            InitializeComponent();
            try
            {
                button2.Text = "💡";
                panel3.ForeColor = Color.White;
                panel2.ForeColor = Color.White;
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in drives)
                {
                    Button disk = new Button();
                    disk.Size = new Size(200, 40);
                    disk.Text = drive.VolumeLabel + " (" + drive.Name[0] + ":)";
                    disk.TextAlign = (ContentAlignment)HorizontalAlignment.Right;
                    disk.FlatStyle = FlatStyle.Flat;
                    disk.FlatAppearance.BorderSize = 0;
                    disk.Font = new Font("Nirmala UI", 10);


                    disk.Location = new Point(0, 40 * i);
                    disk.Click += new EventHandler(this.info_Click);

                    panel2.Controls.Add(disk);
                    i++;
                }
                panel3.AutoScroll = true;
            }
            catch { };
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public void Create(string a)
        {
            try
            {
                if (Directory.Exists(a))
                {

                    panel3.Controls.Clear();
                    int i = 0;
                    var directory = new DirectoryInfo(a + "\\");
                    DirectoryInfo[] dirs = directory.GetDirectories();
                    foreach (DirectoryInfo dir in dirs)
                    {
                        Button butt = new Button();
                        butt.Size = new Size(730, 40);

                        butt.Text = "📂 " + dir.Name;
                        butt.TextAlign = (ContentAlignment)HorizontalAlignment.Right;
                        butt.Font = new Font("Nirmala UI", 10);
                        butt.FlatStyle = FlatStyle.Flat;
                        butt.FlatAppearance.BorderSize = 0;
                        butt.Location = new Point(0, 40 * i);
                        butt.Click += new EventHandler(this.Butt_Click);
                        panel3.Controls.Add(butt);
                        i++;
                    }
                    FileInfo[] files = directory.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        Button butt = new Button();
                        butt.Size = new Size(730, 40);
                        if (file.Name.Substring(file.Name.Length - 3) == "txt")
                        {
                            butt.Text = "📝 " + file.Name;
                        }
                        else if (file.Name.Substring(file.Name.Length - 3) == "mp4")
                        {
                            butt.Text = "🎬 " + file.Name;
                        }
                        else if (file.Name.Substring(file.Name.Length - 3) == "mp3")
                        {
                            butt.Text = "🎵 " + file.Name;
                        }
                        else if (file.Name.Substring(file.Name.Length - 3) == "png" || file.Name.Substring(file.Name.Length - 3) == "jpg")
                        {
                            butt.Text = "📷 " + file.Name;
                        }
                        else butt.Text = "📕 " + file.Name;
                        butt.TextAlign = (ContentAlignment)HorizontalAlignment.Right;
                        butt.Click += new EventHandler(this.Butt_Click);
                        butt.Font = new Font("Nirmala UI", 10);
                        butt.FlatStyle = FlatStyle.Flat;
                        butt.FlatAppearance.BorderSize = 0;

                        butt.Location = new Point(0, 40 * i);
                        panel3.Controls.Add(butt);
                        i++;
                    }
                }
                else
                {
                    string path = a[0].ToString() + ":\\" + a.Substring(3);
                    FileInfo fileInfo = new FileInfo(path);
                    if (fileInfo.Exists)
                    {
                        info_f.Text = $"Fayl nomi : {fileInfo.Name}\n" +
                            $"Yaratilgan vaqti : {fileInfo.CreationTime}\n" +
                            $"Fayl o'lchami : {(int)(fileInfo.Length / 1024)} kb";

                        info_f.ForeColor = Color.FromArgb(200, 200, 200);
                        info_f.Font = new Font("Nirmala UI", 12);
                        info_f.Size = new Size(730, 500);
                        info_f.Location = new Point(0, 0);
                        info.Text = info_f.Text;
                        panel3.Controls.Add(info_f);
                        if (fileInfo.Name.Substring(fileInfo.Name.Length - 3) == "txt")
                        {
                            Class1.path = fileInfo.FullName;
                            Form2 form2 = new Form2();
                            form2.Show();
                        }

                    }
                }
            }
            catch { }
        }
        void info_Click(Object sender, EventArgs e)
        {
            try
            {
                info.Text = "";
                Button clickedButton = (Button)sender;
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in drives)
                {

                    int papka = 0;
                    int fayl = 0;
                    var directory = new DirectoryInfo(drive.Name);
                    DirectoryInfo[] dirs = directory.GetDirectories();
                    foreach (DirectoryInfo dir in dirs) papka++;
                    FileInfo[] files = directory.GetFiles();
                    foreach (FileInfo file in files) fayl++;

                    if (clickedButton.Text[clickedButton.Text.Length - 3] == drive.Name[0])
                    {
                        info.Text += "Disk nomi : " + drive.Name + "\n";
                        info.Text += "Disk turi : " + drive.DriveFormat + "\n";
                        info.Text += "Ishlatilgan maydon : " + ((int)((drive.TotalSize - drive.TotalFreeSpace) / Math.Pow(1024, 3))).ToString() + " GB\n";
                        info.Text += "Bosh joy : " + ((int)(drive.TotalFreeSpace / Math.Pow(1024, 3))).ToString() + " GB\n";
                        info.Text += "Umumiy xotira : " + ((int)(drive.TotalSize / Math.Pow(1024, 3))).ToString() + " GB\n";
                        info.Text += $"Diskdagi kataloglar soni : " + papka + "\n";
                        info.Text += $"Diskdagi fayllar soni : " + fayl + "\n";

                        info.ForeColor = Color.FromArgb(0, 126, 249);
                        info.Size = new Size(200, 180);
                        info.Location = new Point(0, 40 * (i));
                        panel2.Controls.Add(info);
                    }

                }


                txtManzil.Text = clickedButton.Text[clickedButton.Text.Length - 3] + ":";
                Create(txtManzil.Text);
            }
            catch
            {

            }


        }
        void Butt_Click(Object sender, EventArgs e)
        {
            try
            {
                Button clickedButton = (Button)sender;
                txtManzil.Text += "\\" + clickedButton.Text.Substring(3);
                panel3.Controls.Clear();
                Create(txtManzil.Text);
                clickedButton.Enabled = false;

                var directory = new DirectoryInfo(txtManzil.Text);
                if (Directory.Exists(txtManzil.Text))
                {
                    DirectoryInfo[] dirs = directory.GetDirectories();
                    FileInfo[] files = directory.GetFiles();
                    foreach (DirectoryInfo dir in dirs)
                    {

                        info.Text = $"Katalog nomi : {dir.Parent.Name}\n" +
                            $"Undagi kataloglar soni : {dir.Parent.GetDirectories().Length}\n" +
                            $"Undagi fayllar soni :{dir.Parent.GetFiles().Length}\n" +
                            $"Yaratilgan vaqti : {dir.Parent.CreationTime}";

                        foreach (FileInfo file in files)
                        {

                            info.Text = $"Katalog nomi : {file.Directory.Name}\n" +
                                $"Undagi kataloglar soni : {file.Directory.Parent.GetDirectories().Length}\n" +
                                $"Undagi fayllar soni :{file.Directory.Parent.GetFiles().Length}\n" +
                                $"Yaratilgan vaqti : {file.Directory.Parent.CreationTime}";
                        }
                    }
                }
            }
            catch { }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOrqaga_Click(object sender, EventArgs e)
        {
            try
            {
                Button clickedButton = (Button)sender;
                panel3.Controls.Clear();
                int k = 0;
                for (int i = 0; i < txtManzil.Text.Length - 1; i++) if (txtManzil.Text[i] == '\\') k = i - 1;
                txtManzil.Text = txtManzil.Text.Substring(0, k + 1);
                if (txtManzil.Text.Length >= 2) Create(txtManzil.Text);
                else
                {
                    DialogResult d;
                    d = MessageBox.Show("Chiqishni istayszmi?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes) this.Close();
                }
                var directory = new DirectoryInfo(txtManzil.Text);
                if (Directory.Exists(txtManzil.Text))
                {
                    DirectoryInfo[] dirs = directory.GetDirectories();
                    FileInfo[] files = directory.GetFiles();
                    foreach (DirectoryInfo dir in dirs)
                    {

                        info.Text = $"Katalog nomi : {dir.Parent.Name}\n" +
                            $"Undagi kataloglar soni : {dir.Parent.GetDirectories().Length}\n" +
                            $"Undagi fayllar soni :{dir.Parent.GetFiles().Length}\n" +
                            $"Yaratilgan vaqti : {dir.Parent.CreationTime}";
                       
                    }
                }
            }
            catch { }
        }

        private void btnUy_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            info.Text = "";
            txtManzil.Clear();
        }

        private void ochirishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @txtManzil.Text;
                int l = 0;
                for (int i = 0; i < txtManzil.Text.Length - 1; i++) if (txtManzil.Text[i] == '\\') l = i;
                string name = txtManzil.Text.Substring(l + 1);

                if (File.Exists(path))
                {
                    DialogResult d;
                    d = MessageBox.Show($"{name} ushbu faylni o'chirishni istaysizmi?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d == DialogResult.Yes)
                    {
                        File.Delete(path);
                        panel3.Controls.Clear();
                        int k = 0;
                        for (int i = 0; i < txtManzil.Text.Length - 1; i++) if (txtManzil.Text[i] == '\\') k = i - 1;
                        txtManzil.Text = txtManzil.Text.Substring(0, k + 1);
                        Create(txtManzil.Text);
                    }
                }
            }
            catch { }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Class1.path = txtManzil.Text;
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "💡")
            {
                button2.Text = "🌙";
                button2.ForeColor = Color.White;
                txtManzil.BackColor = Color.FromArgb(219, 216, 236);
                txtManzil.ForeColor = Color.DimGray;
                panel1.BackColor = Color.FromArgb(93, 107, 153);
                panel2.BackColor = Color.Gainsboro;
                panel3.BackColor = Color.White;
                panel3.ForeColor = Color.Black;
                panel2.ForeColor = Color.Black;
            }
            else if (button2.Text == "🌙")
            {
                button2.Text = "💡";
                button2.ForeColor = Color.White;
                panel1.BackColor = Color.FromArgb(24, 30, 54);
                txtManzil.ForeColor = Color.Silver;
                txtManzil.BackColor = Color.FromArgb(74, 79, 99); 
                panel2.BackColor = Color.FromArgb(40, 50, 75);
                panel3.BackColor = Color.FromArgb(46, 51, 73);
                panel2.ForeColor = Color.White;
                panel3.ForeColor = Color.White;
            }
        }
    }
}
