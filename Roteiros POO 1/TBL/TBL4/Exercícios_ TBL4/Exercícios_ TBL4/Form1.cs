using System.Runtime.InteropServices;

namespace Exercícios__TBL4
{
    public partial class Form1 : Form
    {

        public const int WM_NCLBUTTONDOWN = 0x00A1;
        public const int HT_CAPTION = 0x02;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern int ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form2>();
        }

        private void bntMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            bntRestaurar.Visible = true;
        }

        private void bntRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            bntRestaurar.Visible = false;
            bntMaximizar.Visible = true;
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form3>();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form4>();

        }

        private void btnSugestões_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form5>();

        }

        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario = new Forms();
            formulario.Show();
        }
    }
}
