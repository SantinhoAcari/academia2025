namespace Academia2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Owner = this;

            // Calcula a posição para o canto inferior direito do Form1
            int x = this.Left + this.Width - s.Width - 40;
            int y = this.Top + this.Height - s.Height - 35;
            //s.StartPosition = FormStartPosition.Manual;
            s.Location = new Point(x, y);
            s.ShowDialog();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Form3 st = new Form3();
            st.Owner = this;

            // Calcula a posição para o canto inferior direito do Form1
            int x = this.Left + this.Width - st.Width - 40;
            int y = this.Top + this.Height - st.Height - 35;
            //s.StartPosition = FormStartPosition.Manual;
            st.Location = new Point(x, y);
            st.ShowDialog();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Form4 sts = new Form4();
            sts.Owner = this;

            // Calcula a posição para o canto inferior direito do Form1
            int x = this.Left + this.Width - sts.Width - 40;
            int y = this.Top + this.Height - sts.Height - 35;
            //s.StartPosition = FormStartPosition.Manual;
            sts.Location = new Point(x, y);
            sts.ShowDialog();
        }
    }
}
