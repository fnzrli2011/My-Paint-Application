namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Graphics g;
        int control = 0;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }
        private void Form1_QueryAccessibilityHelp(object sender, QueryAccessibilityHelpEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (control == 1)
            {
                
                g.FillEllipse(Brushes.Red, e.X, e.Y, 10, 10);
            }
        }


        private void Form1_MouseUp_1(object sender, MouseEventArgs e)
        {
            control = 0;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            control = 1;
        }
    }
}
