namespace Shapesv3
{
    partial class Form1
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
            this.IntroductionLabel1 = new System.Windows.Forms.Label();
            this.IntroductionLabel2 = new System.Windows.Forms.Label();
            this.ShapeChoiceBox = new System.Windows.Forms.ComboBox();
            this.ShapeChoiceLabel = new System.Windows.Forms.Label();
            this.DimensionLabel1 = new System.Windows.Forms.Label();
            this.DimensionLabel2 = new System.Windows.Forms.Label();
            this.DimensionBox1 = new System.Windows.Forms.TextBox();
            this.DimensionBox2 = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.AreaResultLabel = new System.Windows.Forms.Label();
            this.PerimResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IntroductionLabel1
            // 
            this.IntroductionLabel1.AutoSize = true;
            this.IntroductionLabel1.Location = new System.Drawing.Point(12, 40);
            this.IntroductionLabel1.Name = "IntroductionLabel1";
            this.IntroductionLabel1.Size = new System.Drawing.Size(740, 20);
            this.IntroductionLabel1.TabIndex = 0;
            this.IntroductionLabel1.Text = "This program will allow you to perform calculation on 2D shapes ( Equalateral tri" +
    "angles, rectangles and circles)";
            // 
            // IntroductionLabel2
            // 
            this.IntroductionLabel2.AutoSize = true;
            this.IntroductionLabel2.Location = new System.Drawing.Point(12, 60);
            this.IntroductionLabel2.Name = "IntroductionLabel2";
            this.IntroductionLabel2.Size = new System.Drawing.Size(695, 20);
            this.IntroductionLabel2.TabIndex = 1;
            this.IntroductionLabel2.Text = "When using this application make sure that to keep the units used the same for ea" +
    "ch dimension entered.";
            // 
            // ShapeChoiceBox
            // 
            this.ShapeChoiceBox.FormattingEnabled = true;
            this.ShapeChoiceBox.Items.AddRange(new object[] {
            "Triangle",
            "Rectangle",
            "Circle"});
            this.ShapeChoiceBox.Location = new System.Drawing.Point(182, 80);
            this.ShapeChoiceBox.Name = "ShapeChoiceBox";
            this.ShapeChoiceBox.Size = new System.Drawing.Size(151, 28);
            this.ShapeChoiceBox.TabIndex = 2;
            this.ShapeChoiceBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ShapeChoiceLabel
            // 
            this.ShapeChoiceLabel.AutoSize = true;
            this.ShapeChoiceLabel.Location = new System.Drawing.Point(12, 83);
            this.ShapeChoiceLabel.Name = "ShapeChoiceLabel";
            this.ShapeChoiceLabel.Size = new System.Drawing.Size(164, 20);
            this.ShapeChoiceLabel.TabIndex = 3;
            this.ShapeChoiceLabel.Text = "Please Choose a Shape:";
            // 
            // DimensionLabel1
            // 
            this.DimensionLabel1.AutoSize = true;
            this.DimensionLabel1.Location = new System.Drawing.Point(12, 119);
            this.DimensionLabel1.Name = "DimensionLabel1";
            this.DimensionLabel1.Size = new System.Drawing.Size(0, 20);
            this.DimensionLabel1.TabIndex = 4;
            this.DimensionLabel1.Click += new System.EventHandler(this.DimensionLabel1_Click);
            // 
            // DimensionLabel2
            // 
            this.DimensionLabel2.AutoSize = true;
            this.DimensionLabel2.Location = new System.Drawing.Point(12, 159);
            this.DimensionLabel2.Name = "DimensionLabel2";
            this.DimensionLabel2.Size = new System.Drawing.Size(0, 20);
            this.DimensionLabel2.TabIndex = 5;
            // 
            // DimensionBox1
            // 
            this.DimensionBox1.Location = new System.Drawing.Point(663, 112);
            this.DimensionBox1.Name = "DimensionBox1";
            this.DimensionBox1.Size = new System.Drawing.Size(125, 27);
            this.DimensionBox1.TabIndex = 7;
            this.DimensionBox1.Visible = false;
            this.DimensionBox1.TextChanged += new System.EventHandler(this.DimensionBox1_TextChanged);
            // 
            // DimensionBox2
            // 
            this.DimensionBox2.Location = new System.Drawing.Point(663, 159);
            this.DimensionBox2.Name = "DimensionBox2";
            this.DimensionBox2.Size = new System.Drawing.Size(125, 27);
            this.DimensionBox2.TabIndex = 8;
            this.DimensionBox2.Visible = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(260, 208);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(204, 61);
            this.SubmitButton.TabIndex = 9;
            this.SubmitButton.Text = "Calculate perimeter n area";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Visible = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // AreaResultLabel
            // 
            this.AreaResultLabel.AutoSize = true;
            this.AreaResultLabel.Location = new System.Drawing.Point(260, 273);
            this.AreaResultLabel.Name = "AreaResultLabel";
            this.AreaResultLabel.Size = new System.Drawing.Size(0, 20);
            this.AreaResultLabel.TabIndex = 10;
            this.AreaResultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PerimResultLabel
            // 
            this.PerimResultLabel.AutoSize = true;
            this.PerimResultLabel.Location = new System.Drawing.Point(260, 381);
            this.PerimResultLabel.Name = "PerimResultLabel";
            this.PerimResultLabel.Size = new System.Drawing.Size(0, 20);
            this.PerimResultLabel.TabIndex = 12;
            this.PerimResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PerimResultLabel);
            this.Controls.Add(this.AreaResultLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.DimensionBox2);
            this.Controls.Add(this.DimensionBox1);
            this.Controls.Add(this.DimensionLabel2);
            this.Controls.Add(this.DimensionLabel1);
            this.Controls.Add(this.ShapeChoiceLabel);
            this.Controls.Add(this.ShapeChoiceBox);
            this.Controls.Add(this.IntroductionLabel2);
            this.Controls.Add(this.IntroductionLabel1);
            this.Name = "Form1";
            this.Text = "Shape app";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label IntroductionLabel1;
        private Label IntroductionLabel2;
        private ComboBox ShapeChoiceBox;
        private Label ShapeChoiceLabel;
        private Label DimensionLabel1;
        private Label DimensionLabel2;
        private TextBox DimensionBox1;
        private TextBox DimensionBox2;
        private Button SubmitButton;
        private Label AreaResultLabel;
        private Label PerimResultLabel;

        public EventHandler Form1_Load { get; private set; }
    }
}