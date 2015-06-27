namespace ExamForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.OutputRTB = new System.Windows.Forms.RichTextBox();
            this.FizzTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BuzzTextBox = new System.Windows.Forms.TextBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.HintLabelThatShouldBeReplacedWithAFinishedMessageWhenTheOperationIsFinished = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Location = new System.Drawing.Point(155, 12);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(627, 46);
            this.DescriptionLabel.TabIndex = 0;
            this.DescriptionLabel.Text = resources.GetString("DescriptionLabel.Text");
            // 
            // OutputRTB
            // 
            this.OutputRTB.Location = new System.Drawing.Point(1, 99);
            this.OutputRTB.Name = "OutputRTB";
            this.OutputRTB.Size = new System.Drawing.Size(790, 365);
            this.OutputRTB.TabIndex = 1;
            this.OutputRTB.Text = "<Output should go here and each number should be on a new line>";
            // 
            // FizzTextBox
            // 
            this.FizzTextBox.Location = new System.Drawing.Point(49, 38);
            this.FizzTextBox.Name = "FizzTextBox";
            this.FizzTextBox.Size = new System.Drawing.Size(100, 20);
            this.FizzTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buzz: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fizz: ";
            // 
            // BuzzTextBox
            // 
            this.BuzzTextBox.Location = new System.Drawing.Point(49, 12);
            this.BuzzTextBox.Name = "BuzzTextBox";
            this.BuzzTextBox.Size = new System.Drawing.Size(100, 20);
            this.BuzzTextBox.TabIndex = 4;
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(49, 64);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 6;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // HintLabelThatShouldBeReplacedWithAFinishedMessageWhenTheOperationIsFinished
            // 
            this.HintLabelThatShouldBeReplacedWithAFinishedMessageWhenTheOperationIsFinished.Location = new System.Drawing.Point(155, 64);
            this.HintLabelThatShouldBeReplacedWithAFinishedMessageWhenTheOperationIsFinished.Name = "HintLabelThatShouldBeReplacedWithAFinishedMessageWhenTheOperationIsFinished";
            this.HintLabelThatShouldBeReplacedWithAFinishedMessageWhenTheOperationIsFinished.Size = new System.Drawing.Size(612, 23);
            this.HintLabelThatShouldBeReplacedWithAFinishedMessageWhenTheOperationIsFinished.TabIndex = 7;
            this.HintLabelThatShouldBeReplacedWithAFinishedMessageWhenTheOperationIsFinished.Text = "Hint: You can double click on a control in the designer to create an event handle" +
    "r.";
            this.HintLabelThatShouldBeReplacedWithAFinishedMessageWhenTheOperationIsFinished.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(927, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Why doesn\'t this resize correctly?";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 465);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HintLabelThatShouldBeReplacedWithAFinishedMessageWhenTheOperationIsFinished);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BuzzTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FizzTextBox);
            this.Controls.Add(this.OutputRTB);
            this.Controls.Add(this.DescriptionLabel);
            this.Name = "MainForm";
            this.Text = "Exam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.RichTextBox OutputRTB;
        private System.Windows.Forms.TextBox FizzTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BuzzTextBox;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Label HintLabelThatShouldBeReplacedWithAFinishedMessageWhenTheOperationIsFinished;
        private System.Windows.Forms.Label label5;
    }
}

