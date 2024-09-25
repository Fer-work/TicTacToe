using System.Windows.Forms;
using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        private const int gap = 10;

        private int round;
        private int numberOfRows = 0;
        private int clickIndex = 0;

        private Bitmap playerCircle;
        private Bitmap playerX;
        public TicTacToe()
        {
            InitializeComponent();
            using (var ms = new MemoryStream(Resources.PlayerCircle))
            {
                playerCircle = new Bitmap(ms);
            }
            using (var ms = new MemoryStream(Resources.PlayerX))
            {
                playerX = new Bitmap(ms);
            }

        }

        private void InitializeGrid(int numberOfRows)
        {

            int gameAreaSize = 500;
            int gap = 5;

            // Calculate the size of each square
            int squareSize = (gameArea.Width - (gap * (numberOfRows - 1))) / numberOfRows;

            // Starting position for the grid

            int x = 0;
            int y = 5;

            gameArea.Controls.Clear();

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfRows; j++)
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        Left = x,
                        Top = y,
                        Width = squareSize,
                        Height = squareSize,
                        BackColor = Color.White,
                        Name = i.ToString() + "," + j.ToString(),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                 

                    gameArea.Controls.Add(pictureBox);
                    pictureBox.Click += B_Click;

                    x += squareSize + gap;

                }
                x = 0;
                y += squareSize + gap;
            }

        }

        private void ResetGrid(int numberOfRows)
        {
            foreach (Control control in this.Controls.OfType<PictureBox>().ToList())
            {
                this.Controls.Remove(control);
                control.Dispose();
            }

        }

        private void B_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;

            if (pictureBox.Image == null)
            {
                if (clickIndex++ % 2 == 0)
                {
                    pictureBox.Image = playerCircle;
                }
                else
                {
                    pictureBox.Image = playerX;
                }
            }
        }

        private void comboBoxGameSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetGrid(numberOfRows);
            string gameSize = comboBoxGameSize.Text.Substring(0, 1);
            numberOfRows = int.Parse(gameSize);
            InitializeGrid(numberOfRows);
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            ResetGrid(numberOfRows);
            //int roundCalculated = round++;
            //lblRound.Text = roundCalculated.ToString();
            lblRound.Text = "1";
            Player1PBox.Image = null;
            Player2PBox.Image = null;
            lblPlayer1Score.Text = "0";
            lblPlayer2Score.Text = "0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPlayer1LoadPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filepath = openFileDialog1.FileName;
            Player1PBox.Image = Image.FromFile(filepath);
        }

        private void btnLoadPlayer2Picture_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            string filepath = openFileDialog2.FileName;
            Player2PBox.Image = Image.FromFile(filepath);
        }
    }
}
