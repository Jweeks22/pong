using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pong
{
    public partial class Pong : Form
    {
        int ballSpeedX = 20;
        int ballSpeedY = 20;
        int aiPaddleSpeed = 5;  //5 = pixels per second travel , ai moves slower than player for fairness
        int playerPaddleSpeed = 10;

        int playerScore = 0;
        int aiScore = 0;
        int maxScore = 5;

        int bottomBoundary;
        int topBoundary; 
        
        int xMidPoint;
        int yMidPoint;

        bool playerMoveUp;
        bool playerMoveDown;

        public Pong()
        {
            InitializeComponent();
            
            yMidPoint = ClientSize.Height / 2;
            xMidPoint = ClientSize.Width / 2;
            topBoundary = ClientSize.Height;
            bottomBoundary = topBoundary - player1paddle.Height;
            
        }

        private void Pong_Load(object sender, EventArgs e)
        {

        }

        private void pongTimer_Tick(object sender, EventArgs e)
        {
            //generate a spot for the ball to exist in
            Random newSpot = new Random();
            int newBallSpot = newSpot.Next(50, ClientSize.Height - 50);  //ball spawns under 50 pixels from top, above 50 pixels from the bottom to keep the ball center screen

            //move the ball 
            pongBall.Top += ballSpeedY;
            pongBall.Left += ballSpeedX;

            //make ai paddle moves in the direction that the ball is travelling in the y direction of 5 pixels a second
            if (pongBall.Top < player2paddle.Top + player2paddle.Height / 2)
            {
                //if the ball is above the middle of the paddle, move it up
                if (player2paddle.Top > 0)
                {
                    player2paddle.Top -= aiPaddleSpeed;
                }
            }
            else if (pongBall.Bottom > player2paddle.Top + player2paddle.Height / 2)
            {
                //if ball is below middle of the paddle, move it down
                if (player2paddle.Bottom < ClientSize.Height)
                {
                    player2paddle.Top += aiPaddleSpeed;
                }
            }
            

            //player stop paddle from exiting game window
            if (playerMoveUp == true && player1paddle.Top > 0)
            {
                player1paddle.Top -= playerPaddleSpeed;  
            }
            if (playerMoveDown == true && player1paddle.Top < bottomBoundary)
            {
                player1paddle.Top += playerPaddleSpeed;  
            }



            //determine if the ball has hit the left side of the screen, meaning the ai has scored a point and ball gets respawned
            if (pongBall.Left < 0)
            {
                pongBall.Left = xMidPoint;
                pongBall.Top = newBallSpot;
                ballSpeedX = -ballSpeedX;
                aiScore++;
                player2scorelabel.Text = aiScore.ToString();
            }

            //determine if the ball has hit the right side of the screen, meaning the player has scored a point and ball gets respawned
            if (pongBall.Left + pongBall.Width > ClientSize.Width)
            {
                pongBall.Left = xMidPoint;
                pongBall.Top = newBallSpot;
                ballSpeedX = -ballSpeedX;
                playerScore++;
                player1scorelabel.Text = playerScore.ToString();
            }
            //make the ball 'bounce' off the player or ai's paddle
            if (pongBall.Bounds.IntersectsWith(player1paddle.Bounds)|| pongBall.Bounds.IntersectsWith(player2paddle.Bounds))
            {
                ballSpeedX = -ballSpeedX; //reverse direction of ball in the X direction
            }

            //keep the ball from exiting on the top or bottom of the screen, ie make it 'bounce' back into the game space
            if (pongBall.Top < 0 || pongBall.Top + pongBall.Height > ClientSize.Height)
            {
                ballSpeedY = -ballSpeedY; //reverse direction of the ball in the Y direction
            }

            //check for winner
            if (playerScore >= maxScore || aiScore >= maxScore)
            {
                pongTimer.Stop();
            }

            

        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            //if player presses the 'up' key, the paddle will move up
            if (e.KeyCode == Keys.Up) 
            { 
                playerMoveUp = true; 
            }
            
            //if player presses the 'down' key, the paddle will move down
            if (e.KeyCode == Keys.Down) 
            { 
                playerMoveDown = true; 
            }
        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            //if player is no longer pressing a key, release the direction
            if (e.KeyCode == Keys.Up)
            {
                playerMoveUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                playerMoveDown = false;
            }

        }
    }
}
