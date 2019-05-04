namespace MathQuiz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.equalsLabel = new System.Windows.Forms.Label();
            this.plusLabel = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.minusLabel = new System.Windows.Forms.Label();
            this.equalsLabel2 = new System.Windows.Forms.Label();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.timesLabel = new System.Windows.Forms.Label();
            this.equalsLabel3 = new System.Windows.Forms.Label();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.dividedRightLabel = new System.Windows.Forms.Label();
            this.dividedLabel = new System.Windows.Forms.Label();
            this.equalsLabel4 = new System.Windows.Forms.Label();
            this.dividedLeftLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.timeLabel.Location = new System.Drawing.Point(319, 9);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(150, 25);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Click += new System.EventHandler(this.TimeLabel_Click);
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.AutoSize = true;
            this.timeLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftLabel.Location = new System.Drawing.Point(214, 10);
            this.timeLeftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(101, 25);
            this.timeLeftLabel.TabIndex = 1;
            this.timeLeftLabel.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.Location = new System.Drawing.Point(70, 62);
            this.plusLeftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(45, 41);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalsLabel
            // 
            this.equalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsLabel.Location = new System.Drawing.Point(261, 66);
            this.equalsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.equalsLabel.Name = "equalsLabel";
            this.equalsLabel.Size = new System.Drawing.Size(45, 41);
            this.equalsLabel.TabIndex = 3;
            this.equalsLabel.Text = "=";
            this.equalsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusLabel
            // 
            this.plusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLabel.Location = new System.Drawing.Point(134, 66);
            this.plusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.plusLabel.Name = "plusLabel";
            this.plusLabel.Size = new System.Drawing.Size(45, 41);
            this.plusLabel.TabIndex = 4;
            this.plusLabel.Text = "+";
            this.plusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.Location = new System.Drawing.Point(197, 66);
            this.plusRightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(45, 41);
            this.plusRightLabel.TabIndex = 5;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(328, 66);
            this.sum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(75, 35);
            this.sum.TabIndex = 6;
            this.sum.ValueChanged += new System.EventHandler(this.Sum_ValueChanged);
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difference.Location = new System.Drawing.Point(328, 123);
            this.difference.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(75, 35);
            this.difference.TabIndex = 11;
            this.difference.ValueChanged += new System.EventHandler(this.Difference_ValueChanged);
            this.difference.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // minusLabel
            // 
            this.minusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLabel.Location = new System.Drawing.Point(134, 119);
            this.minusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minusLabel.Name = "minusLabel";
            this.minusLabel.Size = new System.Drawing.Size(45, 41);
            this.minusLabel.TabIndex = 9;
            this.minusLabel.Text = "-";
            this.minusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalsLabel2
            // 
            this.equalsLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsLabel2.Location = new System.Drawing.Point(261, 123);
            this.equalsLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.equalsLabel2.Name = "equalsLabel2";
            this.equalsLabel2.Size = new System.Drawing.Size(45, 41);
            this.equalsLabel2.TabIndex = 8;
            this.equalsLabel2.Text = "=";
            this.equalsLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeftLabel.Location = new System.Drawing.Point(70, 123);
            this.minusLeftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(45, 41);
            this.minusLeftLabel.TabIndex = 7;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(328, 181);
            this.product.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(75, 35);
            this.product.TabIndex = 16;
            this.product.ValueChanged += new System.EventHandler(this.Product_ValueChanged);
            this.product.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesRightLabel.Location = new System.Drawing.Point(197, 181);
            this.timesRightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(45, 41);
            this.timesRightLabel.TabIndex = 15;
            this.timesRightLabel.Text = "?";
            this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLabel
            // 
            this.timesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLabel.Location = new System.Drawing.Point(134, 177);
            this.timesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timesLabel.Name = "timesLabel";
            this.timesLabel.Size = new System.Drawing.Size(45, 41);
            this.timesLabel.TabIndex = 14;
            this.timesLabel.Text = "×";
            this.timesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalsLabel3
            // 
            this.equalsLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsLabel3.Location = new System.Drawing.Point(261, 181);
            this.equalsLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.equalsLabel3.Name = "equalsLabel3";
            this.equalsLabel3.Size = new System.Drawing.Size(45, 41);
            this.equalsLabel3.TabIndex = 13;
            this.equalsLabel3.Text = "=";
            this.equalsLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLeftLabel.Location = new System.Drawing.Point(70, 177);
            this.timesLeftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(45, 41);
            this.timesLeftLabel.TabIndex = 12;
            this.timesLeftLabel.Text = "?";
            this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timesLeftLabel.Click += new System.EventHandler(this.TimesLeftLabel_Click);
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotient.Location = new System.Drawing.Point(328, 235);
            this.quotient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(75, 35);
            this.quotient.TabIndex = 21;
            this.quotient.ValueChanged += new System.EventHandler(this.Quotient_ValueChanged);
            this.quotient.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // dividedRightLabel
            // 
            this.dividedRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedRightLabel.Location = new System.Drawing.Point(197, 235);
            this.dividedRightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dividedRightLabel.Name = "dividedRightLabel";
            this.dividedRightLabel.Size = new System.Drawing.Size(45, 41);
            this.dividedRightLabel.TabIndex = 20;
            this.dividedRightLabel.Text = "?";
            this.dividedRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLabel
            // 
            this.dividedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedLabel.Location = new System.Drawing.Point(134, 235);
            this.dividedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dividedLabel.Name = "dividedLabel";
            this.dividedLabel.Size = new System.Drawing.Size(45, 41);
            this.dividedLabel.TabIndex = 19;
            this.dividedLabel.Text = "÷";
            this.dividedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalsLabel4
            // 
            this.equalsLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsLabel4.Location = new System.Drawing.Point(261, 235);
            this.equalsLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.equalsLabel4.Name = "equalsLabel4";
            this.equalsLabel4.Size = new System.Drawing.Size(45, 41);
            this.equalsLabel4.TabIndex = 18;
            this.equalsLabel4.Text = "=";
            this.equalsLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            this.dividedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedLeftLabel.Location = new System.Drawing.Point(70, 235);
            this.dividedLeftLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dividedLeftLabel.Name = "dividedLeftLabel";
            this.dividedLeftLabel.Size = new System.Drawing.Size(45, 41);
            this.dividedLeftLabel.TabIndex = 17;
            this.dividedLeftLabel.Text = "?";
            this.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(176, 312);
            this.startButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(130, 34);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start the quiz";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRightLabel.Location = new System.Drawing.Point(197, 123);
            this.minusRightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(45, 41);
            this.minusRightLabel.TabIndex = 22;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minusRightLabel.Click += new System.EventHandler(this.MinusRightLabe_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // dateLabel
            // 
            this.dateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dateLabel.Location = new System.Drawing.Point(11, 10);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(150, 25);
            this.dateLabel.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 357);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.dividedRightLabel);
            this.Controls.Add(this.dividedLabel);
            this.Controls.Add(this.equalsLabel4);
            this.Controls.Add(this.dividedLeftLabel);
            this.Controls.Add(this.product);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.timesLabel);
            this.Controls.Add(this.equalsLabel3);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.minusLabel);
            this.Controls.Add(this.equalsLabel2);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusLabel);
            this.Controls.Add(this.equalsLabel);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.timeLeftLabel);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Enter += new System.EventHandler(this.answer_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label equalsLabel;
        private System.Windows.Forms.Label plusLabel;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label minusLabel;
        private System.Windows.Forms.Label equalsLabel2;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label timesLabel;
        private System.Windows.Forms.Label equalsLabel3;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Label dividedRightLabel;
        private System.Windows.Forms.Label dividedLabel;
        private System.Windows.Forms.Label equalsLabel4;
        private System.Windows.Forms.Label dividedLeftLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label dateLabel;
    }
}

