namespace CashRegister
{
    partial class background
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(background));
            this.burgersLabel = new System.Windows.Forms.Label();
            this.cokesLabel = new System.Windows.Forms.Label();
            this.friesLabel = new System.Windows.Forms.Label();
            this.burgerInput = new System.Windows.Forms.TextBox();
            this.cokeInput = new System.Windows.Forms.TextBox();
            this.friesInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.taxLabel = new System.Windows.Forms.Label();
            this.ta = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.dollarLabel = new System.Windows.Forms.Label();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.burgerPicture = new System.Windows.Forms.PictureBox();
            this.friesPicture = new System.Windows.Forms.PictureBox();
            this.cokePicture = new System.Windows.Forms.PictureBox();
            this.orderProgress = new System.Windows.Forms.ProgressBar();
            this.completionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.burgerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friesPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cokePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // burgersLabel
            // 
            this.burgersLabel.AutoSize = true;
            this.burgersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgersLabel.Location = new System.Drawing.Point(94, 138);
            this.burgersLabel.Name = "burgersLabel";
            this.burgersLabel.Size = new System.Drawing.Size(196, 26);
            this.burgersLabel.TabIndex = 0;
            this.burgersLabel.Text = "Number of Burgers";
            // 
            // cokesLabel
            // 
            this.cokesLabel.AutoSize = true;
            this.cokesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cokesLabel.Location = new System.Drawing.Point(94, 282);
            this.cokesLabel.Name = "cokesLabel";
            this.cokesLabel.Size = new System.Drawing.Size(182, 26);
            this.cokesLabel.TabIndex = 1;
            this.cokesLabel.Text = "Number of Cokes";
            // 
            // friesLabel
            // 
            this.friesLabel.AutoSize = true;
            this.friesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesLabel.Location = new System.Drawing.Point(94, 211);
            this.friesLabel.Name = "friesLabel";
            this.friesLabel.Size = new System.Drawing.Size(168, 26);
            this.friesLabel.TabIndex = 2;
            this.friesLabel.Text = "Number of Fries";
            // 
            // burgerInput
            // 
            this.burgerInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.burgerInput.Location = new System.Drawing.Point(302, 148);
            this.burgerInput.Name = "burgerInput";
            this.burgerInput.Size = new System.Drawing.Size(114, 26);
            this.burgerInput.TabIndex = 3;
            this.burgerInput.TextChanged += new System.EventHandler(this.burgerInput_TextChanged);
            // 
            // cokeInput
            // 
            this.cokeInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cokeInput.Location = new System.Drawing.Point(302, 286);
            this.cokeInput.Name = "cokeInput";
            this.cokeInput.Size = new System.Drawing.Size(114, 26);
            this.cokeInput.TabIndex = 5;
            this.cokeInput.TextChanged += new System.EventHandler(this.cokeInput_TextChanged);
            // 
            // friesInput
            // 
            this.friesInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.friesInput.Location = new System.Drawing.Point(302, 220);
            this.friesInput.Name = "friesInput";
            this.friesInput.Size = new System.Drawing.Size(114, 26);
            this.friesInput.TabIndex = 4;
            this.friesInput.TextChanged += new System.EventHandler(this.friesInput_TextChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateButton.FlatAppearance.BorderSize = 2;
            this.calculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.calculateButton.Location = new System.Drawing.Point(99, 345);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(222, 58);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate ";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click_1);
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(94, 474);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(47, 26);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax";
            // 
            // ta
            // 
            this.ta.AutoSize = true;
            this.ta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ta.Location = new System.Drawing.Point(94, 545);
            this.ta.Name = "ta";
            this.ta.Size = new System.Drawing.Size(115, 26);
            this.ta.TabIndex = 8;
            this.ta.Text = "Total Price";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(94, 425);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(92, 26);
            this.subtotalLabel.TabIndex = 7;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(302, 477);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(114, 27);
            this.taxOutput.TabIndex = 11;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(302, 546);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(114, 27);
            this.totalOutput.TabIndex = 12;
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subtotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subtotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.Location = new System.Drawing.Point(302, 425);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(114, 27);
            this.subtotalOutput.TabIndex = 10;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(94, 778);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(88, 26);
            this.changeLabel.TabIndex = 15;
            this.changeLabel.Text = "Change";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(94, 640);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(103, 26);
            this.tenderedLabel.TabIndex = 14;
            this.tenderedLabel.Text = "Tendered";
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(302, 778);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(114, 27);
            this.changeOutput.TabIndex = 13;
            // 
            // tenderedInput
            // 
            this.tenderedInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tenderedInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedInput.Location = new System.Drawing.Point(302, 640);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(114, 28);
            this.tenderedInput.TabIndex = 7;
            this.tenderedInput.TextChanged += new System.EventHandler(this.tenderedInput_TextChanged);
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.changeButton.Enabled = false;
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changeButton.Location = new System.Drawing.Point(99, 698);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(222, 52);
            this.changeButton.TabIndex = 8;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.printButton.Enabled = false;
            this.printButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.printButton.Location = new System.Drawing.Point(588, 134);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(222, 52);
            this.printButton.TabIndex = 9;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // dollarLabel
            // 
            this.dollarLabel.AutoSize = true;
            this.dollarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollarLabel.Location = new System.Drawing.Point(278, 643);
            this.dollarLabel.Name = "dollarLabel";
            this.dollarLabel.Size = new System.Drawing.Size(24, 26);
            this.dollarLabel.TabIndex = 19;
            this.dollarLabel.Text = "$";
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.Color.Honeydew;
            this.receiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiptLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(478, 205);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(444, 0);
            this.receiptLabel.TabIndex = 20;
            this.receiptLabel.Visible = false;
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.newButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newButton.Location = new System.Drawing.Point(588, 825);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(222, 52);
            this.newButton.TabIndex = 10;
            this.newButton.Text = "New Order";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.DarkOrange;
            this.titleLabel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(-2, -6);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1029, 137);
            this.titleLabel.TabIndex = 21;
            this.titleLabel.Text = "Morrison\'s Morsels";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // burgerPicture
            // 
            this.burgerPicture.BackColor = System.Drawing.Color.PaleTurquoise;
            this.burgerPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("burgerPicture.BackgroundImage")));
            this.burgerPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.burgerPicture.Image = ((System.Drawing.Image)(resources.GetObject("burgerPicture.Image")));
            this.burgerPicture.Location = new System.Drawing.Point(9, 132);
            this.burgerPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.burgerPicture.Name = "burgerPicture";
            this.burgerPicture.Size = new System.Drawing.Size(110, 54);
            this.burgerPicture.TabIndex = 22;
            this.burgerPicture.TabStop = false;
            // 
            // friesPicture
            // 
            this.friesPicture.BackColor = System.Drawing.Color.PaleTurquoise;
            this.friesPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("friesPicture.BackgroundImage")));
            this.friesPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.friesPicture.Image = ((System.Drawing.Image)(resources.GetObject("friesPicture.Image")));
            this.friesPicture.Location = new System.Drawing.Point(9, 200);
            this.friesPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.friesPicture.Name = "friesPicture";
            this.friesPicture.Size = new System.Drawing.Size(110, 60);
            this.friesPicture.TabIndex = 23;
            this.friesPicture.TabStop = false;
            // 
            // cokePicture
            // 
            this.cokePicture.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cokePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cokePicture.BackgroundImage")));
            this.cokePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cokePicture.Image = ((System.Drawing.Image)(resources.GetObject("cokePicture.Image")));
            this.cokePicture.Location = new System.Drawing.Point(9, 269);
            this.cokePicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cokePicture.Name = "cokePicture";
            this.cokePicture.Size = new System.Drawing.Size(110, 60);
            this.cokePicture.TabIndex = 24;
            this.cokePicture.TabStop = false;
            // 
            // orderProgress
            // 
            this.orderProgress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.orderProgress.ForeColor = System.Drawing.SystemColors.Desktop;
            this.orderProgress.Location = new System.Drawing.Point(99, 837);
            this.orderProgress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderProgress.MarqueeAnimationSpeed = 1000;
            this.orderProgress.Name = "orderProgress";
            this.orderProgress.Size = new System.Drawing.Size(318, 35);
            this.orderProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.orderProgress.TabIndex = 25;
            // 
            // completionLabel
            // 
            this.completionLabel.AutoSize = true;
            this.completionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completionLabel.Location = new System.Drawing.Point(154, 877);
            this.completionLabel.Name = "completionLabel";
            this.completionLabel.Size = new System.Drawing.Size(184, 26);
            this.completionLabel.TabIndex = 26;
            this.completionLabel.Text = "Order Completion";
            // 
            // background
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1022, 934);
            this.Controls.Add(this.completionLabel);
            this.Controls.Add(this.orderProgress);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.ta);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.friesInput);
            this.Controls.Add(this.cokeInput);
            this.Controls.Add(this.burgerInput);
            this.Controls.Add(this.friesLabel);
            this.Controls.Add(this.cokesLabel);
            this.Controls.Add(this.burgersLabel);
            this.Controls.Add(this.dollarLabel);
            this.Controls.Add(this.burgerPicture);
            this.Controls.Add(this.friesPicture);
            this.Controls.Add(this.cokePicture);
            this.Controls.Add(this.titleLabel);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "background";
            this.Text = "Morrison\'s Morsels";
            ((System.ComponentModel.ISupportInitialize)(this.burgerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friesPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cokePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label burgersLabel;
        private System.Windows.Forms.Label cokesLabel;
        private System.Windows.Forms.Label friesLabel;
        private System.Windows.Forms.TextBox burgerInput;
        private System.Windows.Forms.TextBox cokeInput;
        private System.Windows.Forms.TextBox friesInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label ta;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label dollarLabel;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox burgerPicture;
        private System.Windows.Forms.PictureBox friesPicture;
        private System.Windows.Forms.PictureBox cokePicture;
        private System.Windows.Forms.ProgressBar orderProgress;
        private System.Windows.Forms.Label completionLabel;
    }
}

