namespace MegaDesk
{
    partial class AddQuote
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
            this.GetQuoteButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NewQuoteLabel = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.DrawersLabel = new System.Windows.Forms.Label();
            this.MaterialLabel = new System.Windows.Forms.Label();
            this.DeliveryLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // GetQuoteButton
            // 
            this.GetQuoteButton.Location = new System.Drawing.Point(149, 265);
            this.GetQuoteButton.Name = "GetQuoteButton";
            this.GetQuoteButton.Size = new System.Drawing.Size(179, 51);
            this.GetQuoteButton.TabIndex = 0;
            this.GetQuoteButton.Text = "Get Quote";
            this.GetQuoteButton.UseVisualStyleBackColor = true;
            this.GetQuoteButton.Click += new System.EventHandler(this.GetQuoteButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(385, 265);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(179, 51);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NewQuoteLabel
            // 
            this.NewQuoteLabel.AutoSize = true;
            this.NewQuoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewQuoteLabel.Location = new System.Drawing.Point(263, 20);
            this.NewQuoteLabel.Name = "NewQuoteLabel";
            this.NewQuoteLabel.Size = new System.Drawing.Size(156, 32);
            this.NewQuoteLabel.TabIndex = 2;
            this.NewQuoteLabel.Text = "New Quote";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(48, 91);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(147, 24);
            this.CustomerNameLabel.TabIndex = 3;
            this.CustomerNameLabel.Text = "Customer Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(201, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 22);
            this.textBox1.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(159, 165);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(159, 206);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 6;
            this.numericUpDown2.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(456, 138);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(50, 22);
            this.numericUpDown3.TabIndex = 7;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(90, 167);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(63, 16);
            this.WidthLabel.TabIndex = 10;
            this.WidthLabel.Text = "Width (in)";
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Location = new System.Drawing.Point(88, 208);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(65, 16);
            this.DepthLabel.TabIndex = 11;
            this.DepthLabel.Text = "Depth (in)";
            // 
            // DrawersLabel
            // 
            this.DrawersLabel.AutoSize = true;
            this.DrawersLabel.Location = new System.Drawing.Point(327, 140);
            this.DrawersLabel.Name = "DrawersLabel";
            this.DrawersLabel.Size = new System.Drawing.Size(123, 16);
            this.DrawersLabel.TabIndex = 12;
            this.DrawersLabel.Text = "Number of Drawers";
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.AutoSize = true;
            this.MaterialLabel.Location = new System.Drawing.Point(345, 179);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(105, 16);
            this.MaterialLabel.TabIndex = 13;
            this.MaterialLabel.Text = "Surface Material";
            // 
            // DeliveryLabel
            // 
            this.DeliveryLabel.AutoSize = true;
            this.DeliveryLabel.Location = new System.Drawing.Point(392, 217);
            this.DeliveryLabel.Name = "DeliveryLabel";
            this.DeliveryLabel.Size = new System.Drawing.Size(58, 16);
            this.DeliveryLabel.TabIndex = 14;
            this.DeliveryLabel.Text = "Delivery";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Veneer",
            "Pine",
            "Rosewood"});
            this.comboBox1.Location = new System.Drawing.Point(456, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "3 Days",
            "5 Days",
            "7 Days"});
            this.comboBox2.Location = new System.Drawing.Point(456, 214);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 16;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DeliveryLabel);
            this.Controls.Add(this.MaterialLabel);
            this.Controls.Add(this.DrawersLabel);
            this.Controls.Add(this.DepthLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.NewQuoteLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.GetQuoteButton);
            this.Name = "AddQuote";
            this.Text = "Add New Quote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddNewQuote_FormClosed);
            this.Load += new System.EventHandler(this.AddNewQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetQuoteButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label NewQuoteLabel;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.Label DrawersLabel;
        private System.Windows.Forms.Label MaterialLabel;
        private System.Windows.Forms.Label DeliveryLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}