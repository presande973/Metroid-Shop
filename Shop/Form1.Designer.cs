namespace Shop
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
            this.label7 = new System.Windows.Forms.Label();
            this.morphballInput = new System.Windows.Forms.TextBox();
            this.supermissileInput = new System.Windows.Forms.TextBox();
            this.missileInput = new System.Windows.Forms.TextBox();
            this.totalsButton = new System.Windows.Forms.Button();
            this.subtotalOutput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.receiptButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.morphballPic = new System.Windows.Forms.PictureBox();
            this.missilePic = new System.Windows.Forms.PictureBox();
            this.supermissilePic = new System.Windows.Forms.PictureBox();
            this.missileLabel = new System.Windows.Forms.Label();
            this.supermissileLabel = new System.Windows.Forms.Label();
            this.morphballLabel = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.TextBox();
            this.taxOutput = new System.Windows.Forms.TextBox();
            this.changeOutput = new System.Windows.Forms.TextBox();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.morphballPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.missilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermissilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 6;
            // 
            // morphballInput
            // 
            this.morphballInput.BackColor = System.Drawing.SystemColors.Window;
            this.morphballInput.Font = new System.Drawing.Font("SimSun", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morphballInput.Location = new System.Drawing.Point(82, 366);
            this.morphballInput.Name = "morphballInput";
            this.morphballInput.Size = new System.Drawing.Size(54, 27);
            this.morphballInput.TabIndex = 8;
            // 
            // supermissileInput
            // 
            this.supermissileInput.Font = new System.Drawing.Font("SimSun", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supermissileInput.Location = new System.Drawing.Point(82, 312);
            this.supermissileInput.Name = "supermissileInput";
            this.supermissileInput.Size = new System.Drawing.Size(54, 27);
            this.supermissileInput.TabIndex = 9;
            // 
            // missileInput
            // 
            this.missileInput.Font = new System.Drawing.Font("SimSun", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missileInput.Location = new System.Drawing.Point(82, 257);
            this.missileInput.Name = "missileInput";
            this.missileInput.Size = new System.Drawing.Size(54, 27);
            this.missileInput.TabIndex = 10;
            this.missileInput.TextChanged += new System.EventHandler(this.missileInput_TextChanged);
            // 
            // totalsButton
            // 
            this.totalsButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalsButton.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsButton.ForeColor = System.Drawing.SystemColors.Window;
            this.totalsButton.Location = new System.Drawing.Point(12, 200);
            this.totalsButton.Name = "totalsButton";
            this.totalsButton.Size = new System.Drawing.Size(154, 30);
            this.totalsButton.TabIndex = 11;
            this.totalsButton.Text = "Calculate Totals";
            this.totalsButton.UseVisualStyleBackColor = false;
            this.totalsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.Enabled = false;
            this.subtotalOutput.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.Location = new System.Drawing.Point(93, 18);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(73, 21);
            this.subtotalOutput.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(439, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 15;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateButton.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.SystemColors.Window;
            this.calculateButton.Location = new System.Drawing.Point(9, 126);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(157, 21);
            this.calculateButton.TabIndex = 18;
            this.calculateButton.Text = "Calculate Change";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.receiptButton.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.ForeColor = System.Drawing.SystemColors.Window;
            this.receiptButton.Location = new System.Drawing.Point(359, 359);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(118, 42);
            this.receiptButton.TabIndex = 20;
            this.receiptButton.Text = " Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtotalLabel.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.subtotalLabel.Location = new System.Drawing.Point(12, 22);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(75, 12);
            this.subtotalLabel.TabIndex = 23;
            this.subtotalLabel.Text = "Sub Total:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.taxLabel.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.taxLabel.Location = new System.Drawing.Point(12, 49);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(33, 12);
            this.taxLabel.TabIndex = 24;
            this.taxLabel.Text = "Tax:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.totalLabel.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalLabel.Location = new System.Drawing.Point(10, 75);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(47, 12);
            this.totalLabel.TabIndex = 25;
            this.totalLabel.Text = "Total:";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tenderedLabel.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tenderedLabel.Location = new System.Drawing.Point(7, 102);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(68, 12);
            this.tenderedLabel.TabIndex = 26;
            this.tenderedLabel.Text = "Tendered:";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.changeLabel.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.changeLabel.Location = new System.Drawing.Point(12, 156);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(54, 12);
            this.changeLabel.TabIndex = 27;
            this.changeLabel.Text = "Change:";
            // 
            // morphballPic
            // 
            this.morphballPic.BackgroundImage = global::Shop.Properties.Resources.Morphball;
            this.morphballPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.morphballPic.Location = new System.Drawing.Point(12, 345);
            this.morphballPic.Name = "morphballPic";
            this.morphballPic.Size = new System.Drawing.Size(64, 48);
            this.morphballPic.TabIndex = 28;
            this.morphballPic.TabStop = false;
            this.morphballPic.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // missilePic
            // 
            this.missilePic.BackgroundImage = global::Shop.Properties.Resources.Missile;
            this.missilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.missilePic.Location = new System.Drawing.Point(12, 236);
            this.missilePic.Name = "missilePic";
            this.missilePic.Size = new System.Drawing.Size(64, 48);
            this.missilePic.TabIndex = 29;
            this.missilePic.TabStop = false;
            this.missilePic.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // supermissilePic
            // 
            this.supermissilePic.BackgroundImage = global::Shop.Properties.Resources.Super_Missle;
            this.supermissilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.supermissilePic.Location = new System.Drawing.Point(12, 290);
            this.supermissilePic.Name = "supermissilePic";
            this.supermissilePic.Size = new System.Drawing.Size(64, 49);
            this.supermissilePic.TabIndex = 30;
            this.supermissilePic.TabStop = false;
            // 
            // missileLabel
            // 
            this.missileLabel.AutoSize = true;
            this.missileLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.missileLabel.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missileLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.missileLabel.Location = new System.Drawing.Point(82, 242);
            this.missileLabel.Name = "missileLabel";
            this.missileLabel.Size = new System.Drawing.Size(47, 12);
            this.missileLabel.TabIndex = 31;
            this.missileLabel.Text = "MISSILE";
            // 
            // supermissileLabel
            // 
            this.supermissileLabel.AutoSize = true;
            this.supermissileLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.supermissileLabel.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supermissileLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.supermissileLabel.Location = new System.Drawing.Point(80, 297);
            this.supermissileLabel.Name = "supermissileLabel";
            this.supermissileLabel.Size = new System.Drawing.Size(83, 12);
            this.supermissileLabel.TabIndex = 32;
            this.supermissileLabel.Text = "SUPER MISSILE";
            // 
            // morphballLabel
            // 
            this.morphballLabel.AutoSize = true;
            this.morphballLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.morphballLabel.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morphballLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.morphballLabel.Location = new System.Drawing.Point(82, 351);
            this.morphballLabel.Name = "morphballLabel";
            this.morphballLabel.Size = new System.Drawing.Size(65, 12);
            this.morphballLabel.TabIndex = 33;
            this.morphballLabel.Text = "MORPH BALL";
            // 
            // totalOutput
            // 
            this.totalOutput.Enabled = false;
            this.totalOutput.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(93, 72);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(73, 21);
            this.totalOutput.TabIndex = 34;
            // 
            // taxOutput
            // 
            this.taxOutput.Enabled = false;
            this.taxOutput.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(93, 45);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(73, 21);
            this.taxOutput.TabIndex = 35;
            // 
            // changeOutput
            // 
            this.changeOutput.Enabled = false;
            this.changeOutput.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(93, 153);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(73, 21);
            this.changeOutput.TabIndex = 36;
            // 
            // tenderedInput
            // 
            this.tenderedInput.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedInput.Location = new System.Drawing.Point(93, 99);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(73, 21);
            this.tenderedInput.TabIndex = 37;
            // 
            // receiptLabel
            // 
            this.receiptLabel.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(365, 9);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(231, 347);
            this.receiptLabel.TabIndex = 38;
            this.receiptLabel.Click += new System.EventHandler(this.receiptLabel_Click);
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newButton.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.ForeColor = System.Drawing.SystemColors.Window;
            this.newButton.Location = new System.Drawing.Point(483, 359);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(118, 42);
            this.newButton.TabIndex = 39;
            this.newButton.Text = "New Order";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Shop.Properties.Resources.Shop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(608, 405);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.morphballLabel);
            this.Controls.Add(this.supermissileLabel);
            this.Controls.Add(this.missileLabel);
            this.Controls.Add(this.supermissilePic);
            this.Controls.Add(this.missilePic);
            this.Controls.Add(this.morphballPic);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.totalsButton);
            this.Controls.Add(this.missileInput);
            this.Controls.Add(this.supermissileInput);
            this.Controls.Add(this.morphballInput);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Metroid Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.morphballPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.missilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermissilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox morphballInput;
        private System.Windows.Forms.TextBox supermissileInput;
        private System.Windows.Forms.TextBox missileInput;
        private System.Windows.Forms.Button totalsButton;
        private System.Windows.Forms.TextBox subtotalOutput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.PictureBox morphballPic;
        private System.Windows.Forms.PictureBox missilePic;
        private System.Windows.Forms.PictureBox supermissilePic;
        private System.Windows.Forms.Label missileLabel;
        private System.Windows.Forms.Label supermissileLabel;
        private System.Windows.Forms.Label morphballLabel;
        private System.Windows.Forms.TextBox totalOutput;
        private System.Windows.Forms.TextBox taxOutput;
        private System.Windows.Forms.TextBox changeOutput;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button newButton;
    }
}

