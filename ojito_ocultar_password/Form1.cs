namespace ojito_ocultar_password
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool passwordVisible = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (passwordVisible)
            {
                // Oculta la contraseña
                txtPassword.UseSystemPasswordChar = true;
                pictureBox1.Image = ByteArrayToImage(Properties.Resources.ojo_cerrado); // imagen del ojito cerrado
                passwordVisible = false;
            }
            else
            {
                // Muestra la contraseña
                txtPassword.UseSystemPasswordChar = false;
                pictureBox1.Image = ByteArrayToImage(Properties.Resources.ojo_abierto); // imagen del ojito abierto
                passwordVisible = true;
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Oculta la contraseña por defecto
            txtPassword.UseSystemPasswordChar = true;

            // Carga el ojito cerrado como imagen inicial
            pictureBox1.Image = ByteArrayToImage(Properties.Resources.ojo_cerrado);

            // Inicializa el estado
            passwordVisible = false;
        }
    }
}
