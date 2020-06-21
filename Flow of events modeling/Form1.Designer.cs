namespace Flow_of_events_modeling
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modelButton = new System.Windows.Forms.Button();
            this.lambda1UpDown = new System.Windows.Forms.NumericUpDown();
            this.nUpDown = new System.Windows.Forms.NumericUpDown();
            this.lambda2UpDown = new System.Windows.Forms.NumericUpDown();
            this.tUpDown = new System.Windows.Forms.NumericUpDown();
            this.flow1Text = new System.Windows.Forms.RichTextBox();
            this.flow2Text = new System.Windows.Forms.RichTextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lambda1UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambda2UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(113, 33);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "λ1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "λ2: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "N: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "T: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Flow 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(431, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Flow 2:";
            // 
            // modelButton
            // 
            this.modelButton.Location = new System.Drawing.Point(113, 100);
            this.modelButton.Name = "modelButton";
            this.modelButton.Size = new System.Drawing.Size(75, 23);
            this.modelButton.TabIndex = 7;
            this.modelButton.Text = "Modeling";
            this.modelButton.UseVisualStyleBackColor = true;
            this.modelButton.Click += new System.EventHandler(this.modelButton_Click);
            // 
            // lambda1UpDown
            // 
            this.lambda1UpDown.DecimalPlaces = 2;
            this.lambda1UpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.lambda1UpDown.Location = new System.Drawing.Point(39, 21);
            this.lambda1UpDown.Name = "lambda1UpDown";
            this.lambda1UpDown.Size = new System.Drawing.Size(52, 20);
            this.lambda1UpDown.TabIndex = 8;
            // 
            // nUpDown
            // 
            this.nUpDown.Location = new System.Drawing.Point(39, 88);
            this.nUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUpDown.Name = "nUpDown";
            this.nUpDown.Size = new System.Drawing.Size(52, 20);
            this.nUpDown.TabIndex = 9;
            // 
            // lambda2UpDown
            // 
            this.lambda2UpDown.DecimalPlaces = 2;
            this.lambda2UpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.lambda2UpDown.Location = new System.Drawing.Point(39, 51);
            this.lambda2UpDown.Name = "lambda2UpDown";
            this.lambda2UpDown.Size = new System.Drawing.Size(52, 20);
            this.lambda2UpDown.TabIndex = 10;
            // 
            // tUpDown
            // 
            this.tUpDown.Location = new System.Drawing.Point(39, 121);
            this.tUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tUpDown.Name = "tUpDown";
            this.tUpDown.Size = new System.Drawing.Size(52, 20);
            this.tUpDown.TabIndex = 11;
            // 
            // flow1Text
            // 
            this.flow1Text.Location = new System.Drawing.Point(250, 37);
            this.flow1Text.Name = "flow1Text";
            this.flow1Text.Size = new System.Drawing.Size(100, 364);
            this.flow1Text.TabIndex = 12;
            this.flow1Text.Text = "";
            // 
            // flow2Text
            // 
            this.flow2Text.Location = new System.Drawing.Point(401, 39);
            this.flow2Text.Name = "flow2Text";
            this.flow2Text.Size = new System.Drawing.Size(100, 362);
            this.flow2Text.TabIndex = 13;
            this.flow2Text.Text = "";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(12, 172);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(35, 13);
            this.errorLabel.TabIndex = 14;
            this.errorLabel.Text = "Error: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 417);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.flow2Text);
            this.Controls.Add(this.flow1Text);
            this.Controls.Add(this.tUpDown);
            this.Controls.Add(this.lambda2UpDown);
            this.Controls.Add(this.nUpDown);
            this.Controls.Add(this.lambda1UpDown);
            this.Controls.Add(this.modelButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lambda1UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lambda2UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button modelButton;
        private System.Windows.Forms.NumericUpDown lambda1UpDown;
        private System.Windows.Forms.NumericUpDown nUpDown;
        private System.Windows.Forms.NumericUpDown lambda2UpDown;
        private System.Windows.Forms.NumericUpDown tUpDown;
        private System.Windows.Forms.RichTextBox flow1Text;
        private System.Windows.Forms.RichTextBox flow2Text;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label errorLabel;
    }
}

