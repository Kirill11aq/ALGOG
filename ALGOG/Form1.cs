namespace ALGOG
{
    public partial class Form1 : Form
    {
        private List<Button> ListBut;
        private Random r = new();
        public Form1()
        {
            InitializeComponent();
            ListBut = new()
            {
                button1,
                button2,
                button3,
                button4,
                button5,

            };
            for (int i = 0; i < ListBut.Count; i++)
            {
                ListBut[i].Size = new(r.Next(10, 100), r.Next(10, 100));
                ListBut[i].BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
            
        }
    
        private void button5_Click(object sender, EventArgs e)
        {

            ListBut = ListBut.OrderBy(Button => Button.Size.Height).ToList();
            for (int i = 0; i < ListBut.Count; i++) 
            {
                ListBut[i].Text = i.ToString();
            }

            for (int i = 1; i < ListBut.Count;i++) 
            {
                ListBut[i].Location = new(ListBut[i - 1].Location.X + ListBut[i - 1].Size.Width, 
                    ListBut[0].Location.Y - ListBut[i].Size.Height + ListBut[0].Size.Height);
            }
        }
    }
}

