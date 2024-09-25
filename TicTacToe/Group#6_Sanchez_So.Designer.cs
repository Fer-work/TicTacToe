namespace TicTacToe
{
    partial class TicTacToe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            btnStart = new Button();
            comboBoxGameSize = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            Player1GBox = new GroupBox();
            lblPlayer1Score = new Label();
            label3 = new Label();
            Player1PBox = new PictureBox();
            pictureBox1 = new PictureBox();
            PBoxLeadingIcon1 = new PictureBox();
            lblLeadingStatus1 = new Label();
            groupBox4 = new GroupBox();
            lblLeadingStatus2 = new Label();
            label4 = new Label();
            PBoxLeadingIcon2 = new PictureBox();
            Player2GBox = new GroupBox();
            lblPlayer2Score = new Label();
            label5 = new Label();
            Player2PBox = new PictureBox();
            pictureBox8 = new PictureBox();
            btnExit = new Button();
            btnPlayer1LoadPicture = new Button();
            btnLoadPlayer2Picture = new Button();
            lblRound = new Label();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            gameArea = new GroupBox();
            Player1GBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Player1PBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBoxLeadingIcon1).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBoxLeadingIcon2).BeginInit();
            Player2GBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Player2PBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Arial", 10F);
            btnStart.Location = new Point(838, 652);
            btnStart.Margin = new Padding(4, 2, 4, 2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(220, 35);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start a New Game";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // comboBoxGameSize
            // 
            comboBoxGameSize.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxGameSize.FormattingEnabled = true;
            comboBoxGameSize.Items.AddRange(new object[] { "3 x 3", "5 x 5" });
            comboBoxGameSize.Location = new Point(949, 594);
            comboBoxGameSize.Margin = new Padding(4, 10, 4, 3);
            comboBoxGameSize.Name = "comboBoxGameSize";
            comboBoxGameSize.Size = new Size(109, 31);
            comboBoxGameSize.TabIndex = 3;
            comboBoxGameSize.SelectedIndexChanged += comboBoxGameSize_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(838, 599);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 19);
            label1.TabIndex = 4;
            label1.Text = "Grid Size:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(741, 38);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 4;
            label2.Text = "Round:";
            // 
            // Player1GBox
            // 
            Player1GBox.Controls.Add(lblPlayer1Score);
            Player1GBox.Controls.Add(label3);
            Player1GBox.Controls.Add(Player1PBox);
            Player1GBox.Controls.Add(pictureBox1);
            Player1GBox.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Player1GBox.ForeColor = Color.White;
            Player1GBox.Location = new Point(38, 77);
            Player1GBox.Name = "Player1GBox";
            Player1GBox.Size = new Size(175, 333);
            Player1GBox.TabIndex = 6;
            Player1GBox.TabStop = false;
            Player1GBox.Text = "Player 1";
            // 
            // lblPlayer1Score
            // 
            lblPlayer1Score.AutoSize = true;
            lblPlayer1Score.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayer1Score.Location = new Point(120, 283);
            lblPlayer1Score.Name = "lblPlayer1Score";
            lblPlayer1Score.Size = new Size(21, 24);
            lblPlayer1Score.TabIndex = 7;
            lblPlayer1Score.Text = "0";
            lblPlayer1Score.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 283);
            label3.Name = "label3";
            label3.Size = new Size(72, 24);
            label3.TabIndex = 18;
            label3.Text = "Score:";
            // 
            // Player1PBox
            // 
            Player1PBox.Location = new Point(32, 167);
            Player1PBox.Name = "Player1PBox";
            Player1PBox.Size = new Size(113, 97);
            Player1PBox.SizeMode = PictureBoxSizeMode.Zoom;
            Player1PBox.TabIndex = 6;
            Player1PBox.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // PBoxLeadingIcon1
            // 
            PBoxLeadingIcon1.Image = (Image)resources.GetObject("PBoxLeadingIcon1.Image");
            PBoxLeadingIcon1.Location = new Point(50, 420);
            PBoxLeadingIcon1.Name = "PBoxLeadingIcon1";
            PBoxLeadingIcon1.Size = new Size(59, 35);
            PBoxLeadingIcon1.SizeMode = PictureBoxSizeMode.Zoom;
            PBoxLeadingIcon1.TabIndex = 6;
            PBoxLeadingIcon1.TabStop = false;
            // 
            // lblLeadingStatus1
            // 
            lblLeadingStatus1.AutoSize = true;
            lblLeadingStatus1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLeadingStatus1.ForeColor = Color.White;
            lblLeadingStatus1.Location = new Point(104, 425);
            lblLeadingStatus1.Name = "lblLeadingStatus1";
            lblLeadingStatus1.Size = new Size(71, 19);
            lblLeadingStatus1.TabIndex = 13;
            lblLeadingStatus1.Text = "Leading";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblLeadingStatus2);
            groupBox4.Controls.Add(lblLeadingStatus1);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(PBoxLeadingIcon2);
            groupBox4.Controls.Add(PBoxLeadingIcon1);
            groupBox4.Controls.Add(Player2GBox);
            groupBox4.Controls.Add(Player1GBox);
            groupBox4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(600, 94);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(458, 462);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            // 
            // lblLeadingStatus2
            // 
            lblLeadingStatus2.AutoSize = true;
            lblLeadingStatus2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLeadingStatus2.ForeColor = Color.White;
            lblLeadingStatus2.Location = new Point(314, 425);
            lblLeadingStatus2.Name = "lblLeadingStatus2";
            lblLeadingStatus2.Size = new Size(71, 19);
            lblLeadingStatus2.TabIndex = 13;
            lblLeadingStatus2.Text = "Leading";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(138, 33);
            label4.Name = "label4";
            label4.Size = new Size(155, 29);
            label4.TabIndex = 14;
            label4.Text = "Score Board";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PBoxLeadingIcon2
            // 
            PBoxLeadingIcon2.Image = (Image)resources.GetObject("PBoxLeadingIcon2.Image");
            PBoxLeadingIcon2.Location = new Point(260, 420);
            PBoxLeadingIcon2.Name = "PBoxLeadingIcon2";
            PBoxLeadingIcon2.Size = new Size(59, 35);
            PBoxLeadingIcon2.SizeMode = PictureBoxSizeMode.Zoom;
            PBoxLeadingIcon2.TabIndex = 6;
            PBoxLeadingIcon2.TabStop = false;
            // 
            // Player2GBox
            // 
            Player2GBox.Controls.Add(lblPlayer2Score);
            Player2GBox.Controls.Add(label5);
            Player2GBox.Controls.Add(Player2PBox);
            Player2GBox.Controls.Add(pictureBox8);
            Player2GBox.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Player2GBox.ForeColor = Color.White;
            Player2GBox.Location = new Point(248, 79);
            Player2GBox.Name = "Player2GBox";
            Player2GBox.Size = new Size(175, 331);
            Player2GBox.TabIndex = 6;
            Player2GBox.TabStop = false;
            Player2GBox.Text = "Player 2";
            // 
            // lblPlayer2Score
            // 
            lblPlayer2Score.AutoSize = true;
            lblPlayer2Score.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayer2Score.Location = new Point(119, 283);
            lblPlayer2Score.Name = "lblPlayer2Score";
            lblPlayer2Score.Size = new Size(21, 24);
            lblPlayer2Score.TabIndex = 7;
            lblPlayer2Score.Text = "0";
            lblPlayer2Score.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(31, 283);
            label5.Name = "label5";
            label5.Size = new Size(72, 24);
            label5.TabIndex = 18;
            label5.Text = "Score:";
            // 
            // Player2PBox
            // 
            Player2PBox.Location = new Point(32, 167);
            Player2PBox.Name = "Player2PBox";
            Player2PBox.Size = new Size(113, 97);
            Player2PBox.SizeMode = PictureBoxSizeMode.Zoom;
            Player2PBox.TabIndex = 6;
            Player2PBox.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(32, 42);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(113, 97);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 6;
            pictureBox8.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Arial", 10F);
            btnExit.Location = new Point(719, 708);
            btnExit.Margin = new Padding(4, 2, 4, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(220, 35);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnPlayer1LoadPicture
            // 
            btnPlayer1LoadPicture.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlayer1LoadPicture.Location = new Point(600, 595);
            btnPlayer1LoadPicture.Margin = new Padding(4, 2, 4, 2);
            btnPlayer1LoadPicture.Name = "btnPlayer1LoadPicture";
            btnPlayer1LoadPicture.Size = new Size(219, 34);
            btnPlayer1LoadPicture.TabIndex = 15;
            btnPlayer1LoadPicture.Text = "Load Player 1 Picture";
            btnPlayer1LoadPicture.UseVisualStyleBackColor = true;
            btnPlayer1LoadPicture.Click += btnPlayer1LoadPicture_Click;
            // 
            // btnLoadPlayer2Picture
            // 
            btnLoadPlayer2Picture.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoadPlayer2Picture.Location = new Point(600, 652);
            btnLoadPlayer2Picture.Margin = new Padding(4, 2, 4, 2);
            btnLoadPlayer2Picture.Name = "btnLoadPlayer2Picture";
            btnLoadPlayer2Picture.Size = new Size(219, 34);
            btnLoadPlayer2Picture.TabIndex = 16;
            btnLoadPlayer2Picture.Text = "Load Player 2 Picture";
            btnLoadPlayer2Picture.UseVisualStyleBackColor = true;
            btnLoadPlayer2Picture.Click += btnLoadPlayer2Picture_Click;
            // 
            // lblRound
            // 
            lblRound.AutoSize = true;
            lblRound.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRound.ForeColor = Color.White;
            lblRound.Location = new Point(879, 38);
            lblRound.Name = "lblRound";
            lblRound.Size = new Size(29, 32);
            lblRound.TabIndex = 17;
            lblRound.Text = "1";
            lblRound.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // gameArea
            // 
            gameArea.Location = new Point(38, 94);
            gameArea.Name = "gameArea";
            gameArea.Size = new Size(500, 500);
            gameArea.TabIndex = 18;
            gameArea.TabStop = false;
            // 
            // TicTacToe
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(1105, 785);
            Controls.Add(gameArea);
            Controls.Add(lblRound);
            Controls.Add(btnLoadPlayer2Picture);
            Controls.Add(btnPlayer1LoadPicture);
            Controls.Add(btnExit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxGameSize);
            Controls.Add(btnStart);
            Controls.Add(groupBox4);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 2, 4, 2);
            MaximizeBox = false;
            Name = "TicTacToe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Group6_Sanchez_So";
            Player1GBox.ResumeLayout(false);
            Player1GBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Player1PBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBoxLeadingIcon1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PBoxLeadingIcon2).EndInit();
            Player2GBox.ResumeLayout(false);
            Player2GBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Player2PBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblPlayer1Score;
        private Label label1;
        private Button btnStart;
        private ComboBox comboBoxGameSize;
        private Label label2;
        private GroupBox Player1GBox;
        private GroupBox groupBox4;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private PictureBox PBoxLeadingIcon1;
        private PictureBox Player1PBox;
        private Button btnExit;
        private Label lblLeadingStatus1;
        private Label lblLeadingStatus2;
        private GroupBox Player2GBox;
        private Label lblPlayer2Score;
        private PictureBox Player2PBox;
        private PictureBox pictureBox8;
        private Button btnPlayer1LoadPicture;
        private Button btnLoadPlayer2Picture;
        private Label lblRound;
        private Label label4;
        private PictureBox PBoxLeadingIcon2;
        private Label label3;
        private Label label5;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private GroupBox gameArea;
    }
}
