namespace HockeyStars
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            lbPlayers = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lbPlayers
            // 
            lbPlayers.FormattingEnabled = true;
            lbPlayers.ItemHeight = 25;
            lbPlayers.Items.AddRange(new object[] { "Bobby McMann", "Cale Makar", "Cole Koepke", "Connor McDavid", "Danton Heinen", "Justin Kirkland", "Michael Pezzetta", "Morgan Geekie", "Nolan Allan", "Sidney Crosby" });
            lbPlayers.Location = new Point(215, 118);
            lbPlayers.Name = "lbPlayers";
            lbPlayers.Size = new Size(351, 279);
            lbPlayers.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(173, 46, 69);
            label1.Location = new Point(25, 26);
            label1.Name = "label1";
            label1.Size = new Size(305, 57);
            label1.TabIndex = 0;
            label1.Text = "Hockey Stars";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Maiandra GD", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(173, 46, 69);
            label2.Location = new Point(45, 448);
            label2.Name = "label2";
            label2.Size = new Size(722, 29);
            label2.TabIndex = 1;
            label2.Text = "Please double click any player from the list above, to continue";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(804, 532);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbPlayers);
            Name = "HomePage";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbPlayers;
        private Label label1;
        private Label label2;
    }
}
