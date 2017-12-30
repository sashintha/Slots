namespace Slots
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.slot1 = new System.Windows.Forms.PictureBox();
            this.slot2 = new System.Windows.Forms.PictureBox();
            this.slot3 = new System.Windows.Forms.PictureBox();
            this.btnPull = new System.Windows.Forms.Button();
            this.lblTag = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.picPlayAgain = new System.Windows.Forms.PictureBox();
            this.lblPlayAgain = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.picBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.slot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayAgain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // slot1
            // 
            this.slot1.Image = global::Slots.Properties.Resources.Bar5;
            this.slot1.Location = new System.Drawing.Point(116, 177);
            this.slot1.Name = "slot1";
            this.slot1.Size = new System.Drawing.Size(126, 109);
            this.slot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slot1.TabIndex = 0;
            this.slot1.TabStop = false;
            // 
            // slot2
            // 
            this.slot2.Image = global::Slots.Properties.Resources.Bar;
            this.slot2.Location = new System.Drawing.Point(246, 177);
            this.slot2.Name = "slot2";
            this.slot2.Size = new System.Drawing.Size(128, 109);
            this.slot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slot2.TabIndex = 1;
            this.slot2.TabStop = false;
            // 
            // slot3
            // 
            this.slot3.Image = global::Slots.Properties.Resources.Cherry;
            this.slot3.Location = new System.Drawing.Point(376, 177);
            this.slot3.Name = "slot3";
            this.slot3.Size = new System.Drawing.Size(136, 109);
            this.slot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slot3.TabIndex = 2;
            this.slot3.TabStop = false;
            // 
            // btnPull
            // 
            this.btnPull.Location = new System.Drawing.Point(206, 399);
            this.btnPull.Name = "btnPull";
            this.btnPull.Size = new System.Drawing.Size(212, 42);
            this.btnPull.TabIndex = 3;
            this.btnPull.Text = "PULL";
            this.btnPull.UseVisualStyleBackColor = true;
            this.btnPull.Click += new System.EventHandler(this.btnPull_Click);
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.BackColor = System.Drawing.Color.Black;
            this.lblTag.Font = new System.Drawing.Font("Vineta BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTag.ForeColor = System.Drawing.Color.White;
            this.lblTag.Location = new System.Drawing.Point(210, 452);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(115, 26);
            this.lblTag.TabIndex = 4;
            this.lblTag.Text = "Points:";
            this.lblTag.Click += new System.EventHandler(this.lblPoints_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.BackColor = System.Drawing.Color.Black;
            this.lblPoints.Font = new System.Drawing.Font("Vineta BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.Color.White;
            this.lblPoints.Location = new System.Drawing.Point(331, 452);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(63, 26);
            this.lblPoints.TabIndex = 5;
            this.lblPoints.Text = "100";
            // 
            // picPlayAgain
            // 
            this.picPlayAgain.BackColor = System.Drawing.Color.Blue;
            this.picPlayAgain.Location = new System.Drawing.Point(215, 226);
            this.picPlayAgain.Name = "picPlayAgain";
            this.picPlayAgain.Size = new System.Drawing.Size(184, 84);
            this.picPlayAgain.TabIndex = 6;
            this.picPlayAgain.TabStop = false;
            this.picPlayAgain.Visible = false;
            this.picPlayAgain.Click += new System.EventHandler(this.picPlayAgain_Click);
            // 
            // lblPlayAgain
            // 
            this.lblPlayAgain.AutoSize = true;
            this.lblPlayAgain.BackColor = System.Drawing.Color.Blue;
            this.lblPlayAgain.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayAgain.Location = new System.Drawing.Point(223, 234);
            this.lblPlayAgain.Name = "lblPlayAgain";
            this.lblPlayAgain.Size = new System.Drawing.Size(171, 32);
            this.lblPlayAgain.TabIndex = 7;
            this.lblPlayAgain.Text = "Would you like to play \r\n again?";
            this.lblPlayAgain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayAgain.Visible = false;
            this.lblPlayAgain.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.Lime;
            this.btnYes.Location = new System.Drawing.Point(248, 269);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(43, 26);
            this.btnYes.TabIndex = 8;
            this.btnYes.Text = "YES";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Red;
            this.btnNo.Location = new System.Drawing.Point(327, 269);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(43, 26);
            this.btnNo.TabIndex = 9;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Visible = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // picBackground
            // 
            this.picBackground.Image = ((System.Drawing.Image)(resources.GetObject("picBackground.Image")));
            this.picBackground.Location = new System.Drawing.Point(-7, -5);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(630, 446);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 10;
            this.picBackground.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(625, 487);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblPlayAgain);
            this.Controls.Add(this.picPlayAgain);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.btnPull);
            this.Controls.Add(this.slot3);
            this.Controls.Add(this.slot2);
            this.Controls.Add(this.slot1);
            this.Controls.Add(this.picBackground);
            this.Name = "Form1";
            this.Text = "Slots";
            ((System.ComponentModel.ISupportInitialize)(this.slot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayAgain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox slot1;
        private System.Windows.Forms.PictureBox slot2;
        private System.Windows.Forms.PictureBox slot3;
        private System.Windows.Forms.Button btnPull;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.PictureBox picPlayAgain;
        private System.Windows.Forms.Label lblPlayAgain;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.PictureBox picBackground;
    }
}

