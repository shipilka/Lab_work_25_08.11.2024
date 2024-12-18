namespace Lab_work_25_08._11._2024
{
    partial class MainForm
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
            DateOfBirth = new Label();
            DateOfBirthTimePicker = new DateTimePicker();
            Age = new Label();
            AgeText = new TextBox();
            Price = new Label();
            PriceTrackBar = new TrackBar();
            PriceText = new Label();
            textBox1 = new TextBox();
            Length = new Label();
            Width = new Label();
            Square = new Label();
            Perimeter = new Label();
            SquareText = new TextBox();
            PerimeterText = new TextBox();
            numericUpDownLength = new NumericUpDown();
            numericUpDownWidth = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)PriceTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).BeginInit();
            SuspendLayout();
            // 
            // DateOfBirth
            // 
            DateOfBirth.AutoSize = true;
            DateOfBirth.Location = new Point(18, 14);
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Size = new Size(176, 20);
            DateOfBirth.TabIndex = 0;
            DateOfBirth.Text = "Введите дату рождения:";
            // 
            // DateOfBirthTimePicker
            // 
            DateOfBirthTimePicker.Location = new Point(18, 37);
            DateOfBirthTimePicker.MaxDate = new DateTime(2024, 11, 8, 0, 0, 0, 0);
            DateOfBirthTimePicker.Name = "DateOfBirthTimePicker";
            DateOfBirthTimePicker.Size = new Size(263, 27);
            DateOfBirthTimePicker.TabIndex = 2;
            DateOfBirthTimePicker.Value = new DateTime(2024, 11, 8, 0, 0, 0, 0);
            DateOfBirthTimePicker.ValueChanged += DateOfBirthTimePicker_ValueChanged;
            // 
            // Age
            // 
            Age.AutoSize = true;
            Age.Location = new Point(321, 14);
            Age.Name = "Age";
            Age.Size = new Size(64, 20);
            Age.TabIndex = 3;
            Age.Text = "Возраст";
            // 
            // AgeText
            // 
            AgeText.Location = new Point(321, 37);
            AgeText.Name = "AgeText";
            AgeText.Size = new Size(325, 27);
            AgeText.TabIndex = 4;
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(18, 82);
            Price.Name = "Price";
            Price.Size = new Size(196, 20);
            Price.TabIndex = 5;
            Price.Text = "Введите стоимость товара:";
            // 
            // PriceTrackBar
            // 
            PriceTrackBar.Location = new Point(18, 105);
            PriceTrackBar.Maximum = 100000;
            PriceTrackBar.Name = "PriceTrackBar";
            PriceTrackBar.Size = new Size(271, 56);
            PriceTrackBar.TabIndex = 6;
            PriceTrackBar.Scroll += PriceTrackBar_Scroll;
            // 
            // PriceText
            // 
            PriceText.AutoSize = true;
            PriceText.Location = new Point(321, 82);
            PriceText.Name = "PriceText";
            PriceText.Size = new Size(335, 20);
            PriceText.TabIndex = 7;
            PriceText.Text = "Вы выбрали максимальную стоимость товара:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(321, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(325, 27);
            textBox1.TabIndex = 8;
            // 
            // Length
            // 
            Length.AutoSize = true;
            Length.Location = new Point(18, 164);
            Length.Name = "Length";
            Length.Size = new Size(234, 20);
            Length.TabIndex = 9;
            Length.Text = "Введите длину прямоугольника:";
            // 
            // Width
            // 
            Width.AutoSize = true;
            Width.Location = new Point(18, 229);
            Width.Name = "Width";
            Width.Size = new Size(248, 20);
            Width.TabIndex = 11;
            Width.Text = "Введите ширину прямоугольника:";
            // 
            // Square
            // 
            Square.AutoSize = true;
            Square.Location = new Point(321, 164);
            Square.Name = "Square";
            Square.Size = new Size(197, 20);
            Square.TabIndex = 13;
            Square.Text = "Площадь прямоугольника:";
            // 
            // Perimeter
            // 
            Perimeter.AutoSize = true;
            Perimeter.Location = new Point(321, 229);
            Perimeter.Name = "Perimeter";
            Perimeter.Size = new Size(204, 20);
            Perimeter.TabIndex = 14;
            Perimeter.Text = "Периметр прямоугольника:";
            // 
            // SquareText
            // 
            SquareText.Location = new Point(321, 187);
            SquareText.Name = "SquareText";
            SquareText.Size = new Size(325, 27);
            SquareText.TabIndex = 15;
            // 
            // PerimeterText
            // 
            PerimeterText.Location = new Point(321, 252);
            PerimeterText.Name = "PerimeterText";
            PerimeterText.Size = new Size(325, 27);
            PerimeterText.TabIndex = 16;
            // 
            // numericUpDownLength
            // 
            numericUpDownLength.Location = new Point(18, 188);
            numericUpDownLength.Name = "numericUpDownLength";
            numericUpDownLength.Size = new Size(150, 27);
            numericUpDownLength.TabIndex = 17;
            numericUpDownLength.ValueChanged += numericUpDownLength_ValueChanged;
            // 
            // numericUpDownWidth
            // 
            numericUpDownWidth.Location = new Point(18, 253);
            numericUpDownWidth.Name = "numericUpDownWidth";
            numericUpDownWidth.Size = new Size(150, 27);
            numericUpDownWidth.TabIndex = 18;
            numericUpDownWidth.ValueChanged += numericUpDownWidth_ValueChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 450);
            Controls.Add(numericUpDownWidth);
            Controls.Add(numericUpDownLength);
            Controls.Add(PerimeterText);
            Controls.Add(SquareText);
            Controls.Add(Perimeter);
            Controls.Add(Square);
            Controls.Add(Width);
            Controls.Add(Length);
            Controls.Add(textBox1);
            Controls.Add(PriceText);
            Controls.Add(PriceTrackBar);
            Controls.Add(Price);
            Controls.Add(AgeText);
            Controls.Add(Age);
            Controls.Add(DateOfBirthTimePicker);
            Controls.Add(DateOfBirth);
            Name = "MainForm";
            Text = "Лабораторная работа №25";
            ((System.ComponentModel.ISupportInitialize)PriceTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DateOfBirth;
        private DateTimePicker DateOfBirthTimePicker;
        private Label Age;
        private TextBox AgeText;
        private Label Price;
        private TrackBar PriceTrackBar;
        private Label PriceText;
        private TextBox textBox1;
        private Label Length;
        private Label Width;
        private Label Square;
        private Label Perimeter;
        private TextBox SquareText;
        private TextBox PerimeterText;
        private NumericUpDown numericUpDownLength;
        private NumericUpDown numericUpDownWidth;
    }
}
