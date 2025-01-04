using System.Security.Cryptography.X509Certificates;

namespace CheckerboardExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ilk parametre verdiğiniz değere göre grid oluşturacak örn 10x10
            //ikinci parametre her bir butonun boyutunun kaç piksel olacağını belirler
            addButtons(5, 200);
            
        }
        public void addButtons(int gridSize, int buttonSize )
        {
            Button[,] buttons = new Button[gridSize, gridSize];
            int top = 0, left = 0;
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = buttonSize;
                    buttons[i, j].Height = buttonSize;
                    // buttons[i, j].Text = i.ToString() + j.ToString();
                    buttons[i, j].Top = top;
                    buttons[i, j].Left = left;
                    if ((i + j) % 2 == 0)
                        buttons[i, j].BackColor = Color.White;
                    else buttons[i, j].BackColor = Color.Black;

                    this.Controls.Add(buttons[i, j]);
                    left += buttonSize;
                }
                left = 0;
                top += buttonSize;
            }

        }
    }
}
