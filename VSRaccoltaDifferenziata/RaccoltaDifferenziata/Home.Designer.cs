
namespace RaccoltaDifferenziata
{
    partial class Home
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Title = new System.Windows.Forms.Label();
            this.Phrase1 = new System.Windows.Forms.Label();
            this.Phrase2 = new System.Windows.Forms.Label();
            this.Phrase3 = new System.Windows.Forms.Label();
            this.Bergamo = new System.Windows.Forms.PictureBox();
            this.Link = new System.Windows.Forms.LinkLabel();
            this.Bidone_1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.Bidone_3 = new System.Windows.Forms.RadioButton();
            this.Bidone_4 = new System.Windows.Forms.RadioButton();
            this.Bidone_2 = new System.Windows.Forms.RadioButton();
            this.Bidone_5 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Bergamo)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title.Font = new System.Drawing.Font("Onyx", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(75, 61);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(139, 56);
            this.Title.TabIndex = 0;
            this.Title.Text = "Recycling";
            // 
            // Phrase1
            // 
            this.Phrase1.AutoSize = true;
            this.Phrase1.Font = new System.Drawing.Font("Rage Italic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phrase1.Location = new System.Drawing.Point(151, 223);
            this.Phrase1.Name = "Phrase1";
            this.Phrase1.Size = new System.Drawing.Size(308, 50);
            this.Phrase1.TabIndex = 1;
            this.Phrase1.Text = "They taught me that";
            // 
            // Phrase2
            // 
            this.Phrase2.AutoSize = true;
            this.Phrase2.Font = new System.Drawing.Font("Rage Italic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phrase2.Location = new System.Drawing.Point(152, 273);
            this.Phrase2.Name = "Phrase2";
            this.Phrase2.Size = new System.Drawing.Size(263, 45);
            this.Phrase2.TabIndex = 2;
            this.Phrase2.Text = "even in the garbage";
            // 
            // Phrase3
            // 
            this.Phrase3.AutoSize = true;
            this.Phrase3.Font = new System.Drawing.Font("Rage Italic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phrase3.Location = new System.Drawing.Point(154, 318);
            this.Phrase3.Name = "Phrase3";
            this.Phrase3.Size = new System.Drawing.Size(224, 40);
            this.Phrase3.TabIndex = 3;
            this.Phrase3.Text = "a flower can grow!";
            // 
            // Bergamo
            // 
            this.Bergamo.BackgroundImage = global::RaccoltaDifferenziata.Properties.Resources.Bergamo;
            this.Bergamo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bergamo.Location = new System.Drawing.Point(505, 27);
            this.Bergamo.Name = "Bergamo";
            this.Bergamo.Size = new System.Drawing.Size(450, 457);
            this.Bergamo.TabIndex = 4;
            this.Bergamo.TabStop = false;
            // 
            // Link
            // 
            this.Link.ActiveLinkColor = System.Drawing.Color.White;
            this.Link.AutoSize = true;
            this.Link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Link.Font = new System.Drawing.Font("Onyx", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link.LinkColor = System.Drawing.Color.DarkGreen;
            this.Link.Location = new System.Drawing.Point(68, 517);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(120, 41);
            this.Link.TabIndex = 5;
            this.Link.TabStop = true;
            this.Link.Text = "Link: Aprica";
            this.Link.VisitedLinkColor = System.Drawing.Color.DarkGreen;
            this.Link.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LINK);
            // 
            // Bidone_1
            // 
            this.Bidone_1.AutoSize = true;
            this.Bidone_1.Location = new System.Drawing.Point(599, 273);
            this.Bidone_1.Name = "Bidone_1";
            this.Bidone_1.Size = new System.Drawing.Size(21, 20);
            this.Bidone_1.TabIndex = 7;
            this.Bidone_1.TabStop = true;
            this.Bidone_1.UseVisualStyleBackColor = true;
            this.Bidone_1.Click += new System.EventHandler(this.BTN_NewForm);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Onyx", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.Location = new System.Drawing.Point(846, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Indietro";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bidone_3
            // 
            this.Bidone_3.AutoSize = true;
            this.Bidone_3.Location = new System.Drawing.Point(708, 130);
            this.Bidone_3.Name = "Bidone_3";
            this.Bidone_3.Size = new System.Drawing.Size(21, 20);
            this.Bidone_3.TabIndex = 9;
            this.Bidone_3.TabStop = true;
            this.Bidone_3.UseVisualStyleBackColor = true;
            this.Bidone_3.Click += new System.EventHandler(this.Bidone_3_Click);
            // 
            // Bidone_4
            // 
            this.Bidone_4.AutoSize = true;
            this.Bidone_4.Location = new System.Drawing.Point(687, 210);
            this.Bidone_4.Name = "Bidone_4";
            this.Bidone_4.Size = new System.Drawing.Size(21, 20);
            this.Bidone_4.TabIndex = 10;
            this.Bidone_4.TabStop = true;
            this.Bidone_4.UseVisualStyleBackColor = true;
            this.Bidone_4.Click += new System.EventHandler(this.Bidone_4_Click);
            // 
            // Bidone_2
            // 
            this.Bidone_2.AutoSize = true;
            this.Bidone_2.Location = new System.Drawing.Point(865, 241);
            this.Bidone_2.Name = "Bidone_2";
            this.Bidone_2.Size = new System.Drawing.Size(21, 20);
            this.Bidone_2.TabIndex = 11;
            this.Bidone_2.TabStop = true;
            this.Bidone_2.UseVisualStyleBackColor = true;
            this.Bidone_2.Click += new System.EventHandler(this.Bidone_2_Click);
            // 
            // Bidone_5
            // 
            this.Bidone_5.AutoSize = true;
            this.Bidone_5.Location = new System.Drawing.Point(687, 424);
            this.Bidone_5.Name = "Bidone_5";
            this.Bidone_5.Size = new System.Drawing.Size(21, 20);
            this.Bidone_5.TabIndex = 12;
            this.Bidone_5.TabStop = true;
            this.Bidone_5.UseVisualStyleBackColor = true;
            this.Bidone_5.Click += new System.EventHandler(this.Bidone_5_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1012, 604);
            this.Controls.Add(this.Bidone_5);
            this.Controls.Add(this.Bidone_2);
            this.Controls.Add(this.Bidone_4);
            this.Controls.Add(this.Bidone_3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bidone_1);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.Bergamo);
            this.Controls.Add(this.Phrase3);
            this.Controls.Add(this.Phrase2);
            this.Controls.Add(this.Phrase1);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.Bergamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Phrase1;
        private System.Windows.Forms.Label Phrase2;
        private System.Windows.Forms.Label Phrase3;
        private System.Windows.Forms.PictureBox Bergamo;
        private System.Windows.Forms.LinkLabel Link;
        private System.Windows.Forms.RadioButton Bidone_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Bidone_3;
        private System.Windows.Forms.RadioButton Bidone_4;
        private System.Windows.Forms.RadioButton Bidone_2;
        private System.Windows.Forms.RadioButton Bidone_5;
    }
}

