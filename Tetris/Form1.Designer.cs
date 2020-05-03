namespace ProjectTet {
partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed;
    /// otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.gameBoard = new System.Windows.Forms.PictureBox();
        this.holdLabel = new System.Windows.Forms.Label();
        this.nextLabel = new System.Windows.Forms.Label();
        this.holdBox = new System.Windows.Forms.PictureBox();
        this.nextBox = new System.Windows.Forms.PictureBox();
        this.statsLabel = new System.Windows.Forms.Label();
        this.scoreLabel = new System.Windows.Forms.Label();
        this.scoreBox = new System.Windows.Forms.TextBox();
        this.levelLabel = new System.Windows.Forms.Label();
        this.levelBox = new System.Windows.Forms.TextBox();
        this.linesLabel = new System.Windows.Forms.Label();
        this.linesBox = new System.Windows.Forms.TextBox();
        this.playButton = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.gameBoard)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.holdBox)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.nextBox)).BeginInit();
        this.SuspendLayout();
        //
        // gameBoard
        //
        this.gameBoard.BackColor = System.Drawing.Color.White;
        this.gameBoard.Location = new System.Drawing.Point(116, 10);
        this.gameBoard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        this.gameBoard.Name = "gameBoard";
        this.gameBoard.Size = new System.Drawing.Size(304, 619);
        this.gameBoard.TabIndex = 2;
        this.gameBoard.TabStop = false;
        this.gameBoard.Click += new System.EventHandler(this.gameBoard_Click);
        //
        // holdLabel
        //
        this.holdLabel.AutoSize = true;
        this.holdLabel.Location = new System.Drawing.Point(22, 25);
        this.holdLabel.Name = "holdLabel";
        this.holdLabel.Size = new System.Drawing.Size(58, 20);
        this.holdLabel.TabIndex = 3;
        this.holdLabel.Text = "HOLD";
        //
        // nextLabel
        //
        this.nextLabel.AutoSize = true;
        this.nextLabel.Location = new System.Drawing.Point(456, 25);
        this.nextLabel.Name = "nextLabel";
        this.nextLabel.Size = new System.Drawing.Size(53, 20);
        this.nextLabel.TabIndex = 4;
        this.nextLabel.Text = "NEXT";
        //
        // holdBox
        //
        this.holdBox.BackColor = System.Drawing.Color.White;
        this.holdBox.Location = new System.Drawing.Point(26, 50);
        this.holdBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        this.holdBox.Name = "holdBox";
        this.holdBox.Size = new System.Drawing.Size(56, 62);
        this.holdBox.TabIndex = 5;
        this.holdBox.TabStop = false;
        this.holdBox.Click += new System.EventHandler(this.pictureBox1_Click);
        //
        // nextBox
        //
        this.nextBox.BackColor = System.Drawing.Color.White;
        this.nextBox.Location = new System.Drawing.Point(459, 50);
        this.nextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        this.nextBox.Name = "nextBox";
        this.nextBox.Size = new System.Drawing.Size(56, 62);
        this.nextBox.TabIndex = 6;
        this.nextBox.TabStop = false;
        this.nextBox.Click += new System.EventHandler(this.nextBox_Click);
        //
        // statsLabel
        //
        this.statsLabel.AutoSize = true;
        this.statsLabel.Location = new System.Drawing.Point(22, 149);
        this.statsLabel.Name = "statsLabel";
        this.statsLabel.Size = new System.Drawing.Size(62, 20);
        this.statsLabel.TabIndex = 7;
        this.statsLabel.Text = "STATS";
        //
        // scoreLabel
        //
        this.scoreLabel.AutoSize = true;
        this.scoreLabel.Location = new System.Drawing.Point(456, 149);
        this.scoreLabel.Name = "scoreLabel";
        this.scoreLabel.Size = new System.Drawing.Size(68, 20);
        this.scoreLabel.TabIndex = 8;
        this.scoreLabel.Text = "SCORE";
        //
        // scoreBox
        //
        this.scoreBox.Enabled = false;
        this.scoreBox.Location = new System.Drawing.Point(459, 174);
        this.scoreBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        this.scoreBox.Name = "scoreBox";
        this.scoreBox.ReadOnly = true;
        this.scoreBox.Size = new System.Drawing.Size(75, 26);
        this.scoreBox.TabIndex = 9;
        this.scoreBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        //
        // levelLabel
        //
        this.levelLabel.AutoSize = true;
        this.levelLabel.Location = new System.Drawing.Point(456, 224);
        this.levelLabel.Name = "levelLabel";
        this.levelLabel.Size = new System.Drawing.Size(62, 20);
        this.levelLabel.TabIndex = 10;
        this.levelLabel.Text = "LEVEL";
        //
        // levelBox
        //
        this.levelBox.Enabled = false;
        this.levelBox.Location = new System.Drawing.Point(459, 249);
        this.levelBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        this.levelBox.Name = "levelBox";
        this.levelBox.ReadOnly = true;
        this.levelBox.Size = new System.Drawing.Size(74, 26);
        this.levelBox.TabIndex = 11;
        this.levelBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        //
        // linesLabel
        //
        this.linesLabel.AutoSize = true;
        this.linesLabel.Location = new System.Drawing.Point(456, 296);
        this.linesLabel.Name = "linesLabel";
        this.linesLabel.Size = new System.Drawing.Size(57, 20);
        this.linesLabel.TabIndex = 12;
        this.linesLabel.Text = "LINES";
        //
        // linesBox
        //
        this.linesBox.Enabled = false;
        this.linesBox.Location = new System.Drawing.Point(458, 321);
        this.linesBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        this.linesBox.Name = "linesBox";
        this.linesBox.ReadOnly = true;
        this.linesBox.Size = new System.Drawing.Size(75, 26);
        this.linesBox.TabIndex = 13;
        this.linesBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        //
        // playButton
        //
        this.playButton.Location = new System.Drawing.Point(450, 372);
        this.playButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        this.playButton.Name = "playButton";
        this.playButton.Size = new System.Drawing.Size(84, 29);
        this.playButton.TabIndex = 14;
        this.playButton.Text = "PLAY";
        this.playButton.UseVisualStyleBackColor = true;
        this.playButton.Click += new System.EventHandler(this.playButton_Click);
        //
        // Form1
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(565, 644);
        this.Controls.Add(this.playButton);
        this.Controls.Add(this.linesBox);
        this.Controls.Add(this.linesLabel);
        this.Controls.Add(this.levelBox);
        this.Controls.Add(this.levelLabel);
        this.Controls.Add(this.scoreBox);
        this.Controls.Add(this.scoreLabel);
        this.Controls.Add(this.statsLabel);
        this.Controls.Add(this.nextBox);
        this.Controls.Add(this.holdBox);
        this.Controls.Add(this.nextLabel);
        this.Controls.Add(this.holdLabel);
        this.Controls.Add(this.gameBoard);
        this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        this.Name = "Form1";
        ((System.ComponentModel.ISupportInitialize)(this.gameBoard)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.holdBox)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.nextBox)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.PictureBox gameBoard;
    private System.Windows.Forms.Label holdLabel;
    private System.Windows.Forms.Label nextLabel;
    private System.Windows.Forms.PictureBox holdBox;
    private System.Windows.Forms.PictureBox nextBox;
    private System.Windows.Forms.Label statsLabel;
    private System.Windows.Forms.Label scoreLabel;
    private System.Windows.Forms.TextBox scoreBox;
    private System.Windows.Forms.Label levelLabel;
    private System.Windows.Forms.TextBox levelBox;
    private System.Windows.Forms.Label linesLabel;
    private System.Windows.Forms.TextBox linesBox;
    private System.Windows.Forms.Button playButton;
}
}
