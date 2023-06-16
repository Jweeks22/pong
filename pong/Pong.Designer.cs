namespace pong
{
    partial class Pong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pong));
            this.player1paddle = new System.Windows.Forms.PictureBox();
            this.player2paddle = new System.Windows.Forms.PictureBox();
            this.pongBall = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.player1scorelabel = new System.Windows.Forms.Label();
            this.player2scorelabel = new System.Windows.Forms.Label();
            this.pongTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player1paddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2paddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // player1paddle
            // 
            this.player1paddle.BackColor = System.Drawing.Color.White;
            this.player1paddle.Location = new System.Drawing.Point(12, 264);
            this.player1paddle.Name = "player1paddle";
            this.player1paddle.Size = new System.Drawing.Size(19, 125);
            this.player1paddle.TabIndex = 0;
            this.player1paddle.TabStop = false;
            // 
            // player2paddle
            // 
            this.player2paddle.BackColor = System.Drawing.Color.White;
            this.player2paddle.Location = new System.Drawing.Point(1006, 264);
            this.player2paddle.Name = "player2paddle";
            this.player2paddle.Size = new System.Drawing.Size(19, 125);
            this.player2paddle.TabIndex = 1;
            this.player2paddle.TabStop = false;
            // 
            // pongBall
            // 
            this.pongBall.BackColor = System.Drawing.Color.White;
            this.pongBall.Location = new System.Drawing.Point(506, 312);
            this.pongBall.Name = "pongBall";
            this.pongBall.Size = new System.Drawing.Size(28, 28);
            this.pongBall.TabIndex = 2;
            this.pongBall.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(396, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(241, 129);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // player1scorelabel
            // 
            this.player1scorelabel.AutoSize = true;
            this.player1scorelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1scorelabel.ForeColor = System.Drawing.Color.White;
            this.player1scorelabel.Location = new System.Drawing.Point(12, 12);
            this.player1scorelabel.Name = "player1scorelabel";
            this.player1scorelabel.Size = new System.Drawing.Size(20, 22);
            this.player1scorelabel.TabIndex = 4;
            this.player1scorelabel.Text = "0";
            this.player1scorelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // player2scorelabel
            // 
            this.player2scorelabel.AutoSize = true;
            this.player2scorelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2scorelabel.ForeColor = System.Drawing.Color.White;
            this.player2scorelabel.Location = new System.Drawing.Point(1012, 9);
            this.player2scorelabel.Name = "player2scorelabel";
            this.player2scorelabel.Size = new System.Drawing.Size(20, 22);
            this.player2scorelabel.TabIndex = 5;
            this.player2scorelabel.Text = "0";
            this.player2scorelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pongTimer
            // 
            this.pongTimer.Enabled = true;
            this.pongTimer.Tick += new System.EventHandler(this.pongTimer_Tick);
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1037, 626);
            this.Controls.Add(this.player2scorelabel);
            this.Controls.Add(this.player1scorelabel);
            this.Controls.Add(this.pongBall);
            this.Controls.Add(this.player2paddle);
            this.Controls.Add(this.player1paddle);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Pong";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Pong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player1paddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2paddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player1paddle;
        private System.Windows.Forms.PictureBox player2paddle;
        private System.Windows.Forms.PictureBox pongBall;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label player1scorelabel;
        private System.Windows.Forms.Label player2scorelabel;
        private System.Windows.Forms.Timer pongTimer;
    }
}

