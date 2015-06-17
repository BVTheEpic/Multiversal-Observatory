namespace Multiversal_Observatory__Version_2._0
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.viewScreen = new System.Windows.Forms.Button();
            this.earthDescription = new System.Windows.Forms.RichTextBox();
            this.multiversalDesignate = new System.Windows.Forms.TextBox();
            this.goTo = new System.Windows.Forms.Button();
            this.multiversalOrrery = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // viewScreen
            // 
            this.viewScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("viewScreen.BackgroundImage")));
            this.viewScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewScreen.Enabled = false;
            this.viewScreen.Location = new System.Drawing.Point(441, 12);
            this.viewScreen.Name = "viewScreen";
            this.viewScreen.Size = new System.Drawing.Size(429, 429);
            this.viewScreen.TabIndex = 0;
            this.viewScreen.UseVisualStyleBackColor = true;
            this.viewScreen.Click += new System.EventHandler(this.viewScreen_Click);
            // 
            // earthDescription
            // 
            this.earthDescription.Location = new System.Drawing.Point(13, 198);
            this.earthDescription.Name = "earthDescription";
            this.earthDescription.ReadOnly = true;
            this.earthDescription.Size = new System.Drawing.Size(422, 243);
            this.earthDescription.TabIndex = 1;
            this.earthDescription.Text = "";
            // 
            // multiversalDesignate
            // 
            this.multiversalDesignate.Location = new System.Drawing.Point(13, 13);
            this.multiversalDesignate.Name = "multiversalDesignate";
            this.multiversalDesignate.Size = new System.Drawing.Size(206, 22);
            this.multiversalDesignate.TabIndex = 2;
            // 
            // goTo
            // 
            this.goTo.Location = new System.Drawing.Point(226, 11);
            this.goTo.Name = "goTo";
            this.goTo.Size = new System.Drawing.Size(209, 23);
            this.goTo.TabIndex = 3;
            this.goTo.Text = "Go to this Earth!";
            this.goTo.UseVisualStyleBackColor = true;
            this.goTo.Click += new System.EventHandler(this.goTo_Click);
            // 
            // multiversalOrrery
            // 
            this.multiversalOrrery.Location = new System.Drawing.Point(13, 55);
            this.multiversalOrrery.Name = "multiversalOrrery";
            this.multiversalOrrery.ReadOnly = true;
            this.multiversalOrrery.Size = new System.Drawing.Size(422, 111);
            this.multiversalOrrery.TabIndex = 4;
            this.multiversalOrrery.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.multiversalOrrery);
            this.Controls.Add(this.goTo);
            this.Controls.Add(this.multiversalDesignate);
            this.Controls.Add(this.earthDescription);
            this.Controls.Add(this.viewScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Multiversal Observatory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewScreen;
        private System.Windows.Forms.RichTextBox earthDescription;
        private System.Windows.Forms.TextBox multiversalDesignate;
        private System.Windows.Forms.Button goTo;
        private System.Windows.Forms.RichTextBox multiversalOrrery;
    }
}