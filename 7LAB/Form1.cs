namespace _7LAB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Microsoft.VisualBasic.Interaction.InputBox("Введите точность", "Точность = ", "0,001");
            label3.Text = "";
            label5.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            int n = 1;
            double toch = Convert.ToDouble(textBox1.Text);
            double sl = 1+n; // 1+1/n = (1+n)/n, поэтому присвоим sl = 1+n
            double s = 0;
            while (sl>toch)
            {
                n+=1;
                sl = Math.Pow((sl/n),n);
                s+=sl;
            }
            label3.Text = Convert.ToString(s);
            label5.Text = Convert.ToString(n);
        }
    }
}