namespace W0701WFPreCounter
{
    public partial class Form1 : Form
    {
        private int Count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void OnAdd(object sender, EventArgs e)
        {
            labelCount.Text = "" + ++Count;
            // labelCount.Text = $"{++Count}";
        }

        private void OnSub(object sender, EventArgs e)
        {
            if (Count > 0)
                labelCount.Text = "" + --Count;
        }
    }
}