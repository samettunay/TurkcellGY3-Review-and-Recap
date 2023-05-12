namespace basicThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        Thread thread = null;
        private void button1_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(counter));
            thread.Start();
            thread.Join();
            MessageBox.Show("Bitti");
        }

        private void counter()
        {
            for (int i = 0; i < 10000; i++)
            {
                label1.Text = i.ToString();
                progressBar1.Value = i / 100;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Show");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}