namespace Pong
{
    partial class ScoreBoard
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
            this.winrank = new System.Windows.Forms.Button();
            this.record = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.scorerank = new System.Windows.Forms.Button();
            this.recordwrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // winrank
            // 
            this.winrank.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.winrank.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.winrank.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.winrank.Location = new System.Drawing.Point(26, 73);
            this.winrank.Name = "winrank";
            this.winrank.Size = new System.Drawing.Size(175, 42);
            this.winrank.TabIndex = 0;
            this.winrank.Text = "승리 횟수 순위";
            this.winrank.UseVisualStyleBackColor = false;
            this.winrank.Click += new System.EventHandler(this.winrank_Click);
            // 
            // record
            // 
            this.record.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.record.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.record.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.record.Location = new System.Drawing.Point(449, 73);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(143, 42);
            this.record.TabIndex = 0;
            this.record.Text = "최근 기록";
            this.record.UseVisualStyleBackColor = false;
            this.record.Click += new System.EventHandler(this.record_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(371, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 40);
            this.button3.TabIndex = 0;
            this.button3.Text = "홈으로";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold);
            this.listBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(151, 121);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(306, 212);
            this.listBox1.TabIndex = 1;
            // 
            // scorerank
            // 
            this.scorerank.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scorerank.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.scorerank.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scorerank.Location = new System.Drawing.Point(231, 73);
            this.scorerank.Name = "scorerank";
            this.scorerank.Size = new System.Drawing.Size(175, 42);
            this.scorerank.TabIndex = 0;
            this.scorerank.Text = "누적 점수 순위";
            this.scorerank.UseVisualStyleBackColor = false;
            this.scorerank.Click += new System.EventHandler(this.scorerank_Click);
            // 
            // recordwrite
            // 
            this.recordwrite.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.recordwrite.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.recordwrite.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recordwrite.Location = new System.Drawing.Point(151, 12);
            this.recordwrite.Name = "recordwrite";
            this.recordwrite.Size = new System.Drawing.Size(122, 42);
            this.recordwrite.TabIndex = 0;
            this.recordwrite.Text = "점수 기록";
            this.recordwrite.UseVisualStyleBackColor = false;
            this.recordwrite.Click += new System.EventHandler(this.recordwrite_Click);
            // 
            // ScoreBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(632, 392);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.record);
            this.Controls.Add(this.scorerank);
            this.Controls.Add(this.recordwrite);
            this.Controls.Add(this.winrank);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ScoreBoard";
            this.Text = "ScoreBoard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button winrank;
        private System.Windows.Forms.Button record;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button scorerank;
        private System.Windows.Forms.Button recordwrite;
    }
}