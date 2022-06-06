namespace Shop
{
    partial class ShopForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonCart = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GroupBoxProducti = new System.Windows.Forms.GroupBox();
            this.pictureBoxi = new System.Windows.Forms.PictureBox();
            this.buttonShowi = new System.Windows.Forms.Button();
            this.labelPricei = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.GroupBoxProducti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonLogOut);
            this.panel1.Controls.Add(this.buttonCart);
            this.panel1.Controls.Add(this.buttonProfile);
            this.panel1.Controls.Add(this.buttonSettings);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 62);
            this.panel1.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Location = new System.Drawing.Point(3, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(105, 59);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Location = new System.Drawing.Point(543, 3);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(119, 56);
            this.buttonProfile.TabIndex = 3;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = false;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Location = new System.Drawing.Point(785, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(118, 59);
            this.buttonLogOut.TabIndex = 4;
            this.buttonLogOut.UseVisualStyleBackColor = false;
            // 
            // buttonCart
            // 
            this.buttonCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonCart.FlatAppearance.BorderSize = 0;
            this.buttonCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCart.Location = new System.Drawing.Point(114, 0);
            this.buttonCart.Name = "buttonCart";
            this.buttonCart.Size = new System.Drawing.Size(106, 59);
            this.buttonCart.TabIndex = 5;
            this.buttonCart.Text = "My Cart";
            this.buttonCart.UseVisualStyleBackColor = false;
            this.buttonCart.Click += new System.EventHandler(this.buttonCart_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Location = new System.Drawing.Point(668, 2);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(111, 59);
            this.buttonSettings.TabIndex = 6;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(226, 27);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(190, 28);
            this.textBoxSearch.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "search:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.GroupBoxProducti);
            this.panel2.Location = new System.Drawing.Point(3, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 425);
            this.panel2.TabIndex = 7;
            // 
            // GroupBoxProducti
            // 
            this.GroupBoxProducti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GroupBoxProducti.Controls.Add(this.label2);
            this.GroupBoxProducti.Controls.Add(this.labelPricei);
            this.GroupBoxProducti.Controls.Add(this.buttonShowi);
            this.GroupBoxProducti.Controls.Add(this.pictureBoxi);
            this.GroupBoxProducti.Location = new System.Drawing.Point(17, 22);
            this.GroupBoxProducti.Name = "GroupBoxProducti";
            this.GroupBoxProducti.Size = new System.Drawing.Size(260, 218);
            this.GroupBoxProducti.TabIndex = 0;
            this.GroupBoxProducti.TabStop = false;
            this.GroupBoxProducti.Text = "ProductNamei";
            // 
            // pictureBoxi
            // 
            this.pictureBoxi.Location = new System.Drawing.Point(6, 27);
            this.pictureBoxi.Name = "pictureBoxi";
            this.pictureBoxi.Size = new System.Drawing.Size(112, 123);
            this.pictureBoxi.TabIndex = 0;
            this.pictureBoxi.TabStop = false;
            // 
            // buttonShowi
            // 
            this.buttonShowi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.buttonShowi.FlatAppearance.BorderSize = 0;
            this.buttonShowi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowi.Location = new System.Drawing.Point(127, 160);
            this.buttonShowi.Name = "buttonShowi";
            this.buttonShowi.Size = new System.Drawing.Size(112, 41);
            this.buttonShowi.TabIndex = 1;
            this.buttonShowi.Text = "Show More";
            this.buttonShowi.UseVisualStyleBackColor = false;
            this.buttonShowi.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPricei
            // 
            this.labelPricei.AutoSize = true;
            this.labelPricei.Location = new System.Drawing.Point(6, 179);
            this.labelPricei.Name = "labelPricei";
            this.labelPricei.Size = new System.Drawing.Size(53, 22);
            this.labelPricei.TabIndex = 2;
            this.labelPricei.Text = "pricei";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(123, 24);
            this.label2.MaximumSize = new System.Drawing.Size(140, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 88);
            this.label2.TabIndex = 3;
            this.label2.Text = "huuuuge description blabklarjlgakrjglakjrlerj";
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(908, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShopForm";
            this.Text = "Shop";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.GroupBoxProducti.ResumeLayout(false);
            this.GroupBoxProducti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonCart;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox GroupBoxProducti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPricei;
        private System.Windows.Forms.Button buttonShowi;
        private System.Windows.Forms.PictureBox pictureBoxi;
    }
}