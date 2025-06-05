namespace Academia2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {   
            string? host = Environment.GetEnvironmentVariable("DB_HOST");
            string? database = Environment.GetEnvironmentVariable("DB_DATABASE");
            string? user = Environment.GetEnvironmentVariable("DB_USER");
            string? password = Environment.GetEnvironmentVariable("DB_PASSWORD");

            MessageBox.Show(
                $"Host: {host ?? "N/A"}\nDatabase: {database ?? "N/A"}\nUser: {user ?? "N/A"}\nPassword: {password ?? "N/A"}",
                "Variáveis .env"
            );
        }
    }
}
