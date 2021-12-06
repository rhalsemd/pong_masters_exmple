namespace Pong {
    partial class PongForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PongForm));
            this.aPaddle1 = new System.Windows.Forms.PictureBox();
            this.aPaddle2 = new System.Windows.Forms.PictureBox();
            this.aBall = new System.Windows.Forms.PictureBox();
            this.aTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.aLabelPlayer2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aLabelPlayer1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aPaddle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPaddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBall)).BeginInit();
            this.SuspendLayout();
            // 
            // aPaddle1
            // 
            this.aPaddle1.Image = ((System.Drawing.Image)(resources.GetObject("aPaddle1.Image")));
            this.aPaddle1.Location = new System.Drawing.Point(12, 219);
            this.aPaddle1.Name = "aPaddle1";
            this.aPaddle1.Size = new System.Drawing.Size(27, 185);
            this.aPaddle1.TabIndex = 0;
            this.aPaddle1.TabStop = false;
            // 
            // aPaddle2
            // 
            this.aPaddle2.Image = ((System.Drawing.Image)(resources.GetObject("aPaddle2.Image")));
            this.aPaddle2.Location = new System.Drawing.Point(950, 333);
            this.aPaddle2.Name = "aPaddle2";
            this.aPaddle2.Size = new System.Drawing.Size(27, 185);
            this.aPaddle2.TabIndex = 1;
            this.aPaddle2.TabStop = false;
            // 
            // aBall
            // 
            this.aBall.Image = ((System.Drawing.Image)(resources.GetObject("aBall.Image")));
            this.aBall.Location = new System.Drawing.Point(504, 219);
            this.aBall.Name = "aBall";
            this.aBall.Size = new System.Drawing.Size(27, 19);
            this.aBall.TabIndex = 2;
            this.aBall.TabStop = false;
            this.aBall.Visible = false;
            // 
            // aTimer
            // 
            this.aTimer.Enabled = true;
            this.aTimer.Interval = 1;
            this.aTimer.Tick += new System.EventHandler(this.aTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(406, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score";
            // 
            // aLabelPlayer2
            // 
            this.aLabelPlayer2.AutoSize = true;
            this.aLabelPlayer2.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelPlayer2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aLabelPlayer2.Location = new System.Drawing.Point(377, 69);
            this.aLabelPlayer2.Name = "aLabelPlayer2";
            this.aLabelPlayer2.Size = new System.Drawing.Size(45, 51);
            this.aLabelPlayer2.TabIndex = 4;
            this.aLabelPlayer2.Text = "0";
            this.aLabelPlayer2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(450, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 51);
            this.label3.TabIndex = 5;
            this.label3.Text = "|";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // aLabelPlayer1
            // 
            this.aLabelPlayer1.AutoSize = true;
            this.aLabelPlayer1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelPlayer1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aLabelPlayer1.Location = new System.Drawing.Point(521, 69);
            this.aLabelPlayer1.Name = "aLabelPlayer1";
            this.aLabelPlayer1.Size = new System.Drawing.Size(45, 51);
            this.aLabelPlayer1.TabIndex = 6;
            this.aLabelPlayer1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(189, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(719, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 51);
            this.label4.TabIndex = 4;
            this.label4.Text = "0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(985, 576);
            this.Controls.Add(this.aLabelPlayer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aLabelPlayer2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aBall);
            this.Controls.Add(this.aPaddle2);
            this.Controls.Add(this.aPaddle1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PongForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.aPaddle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPaddle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox aPaddle1;
        private System.Windows.Forms.PictureBox aPaddle2;
        private System.Windows.Forms.PictureBox aBall;
        private System.Windows.Forms.Timer aTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aLabelPlayer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label aLabelPlayer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

