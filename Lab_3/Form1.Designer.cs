namespace Lab_3
{
    partial class LevenshteinDistance_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevenshteinDistance_Form));
            FirstString_label = new Label();
            SecondString_label = new Label();
            FirstString_textBox = new TextBox();
            SecondString_textBox = new TextBox();
            LevenshteinDistance_tabControl = new TabControl();
            CulculateDistance_tabPage = new TabPage();
            TimeComparison_tabPage = new TabPage();
            pictureBox1 = new PictureBox();
            LevenshteinDistance_tabControl.SuspendLayout();
            CulculateDistance_tabPage.SuspendLayout();
            TimeComparison_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // FirstString_label
            // 
            FirstString_label.BackColor = Color.Snow;
            FirstString_label.BorderStyle = BorderStyle.FixedSingle;
            FirstString_label.ForeColor = Color.DarkRed;
            FirstString_label.Location = new Point(27, 134);
            FirstString_label.Name = "FirstString_label";
            FirstString_label.Size = new Size(339, 49);
            FirstString_label.TabIndex = 0;
            FirstString_label.Text = "Введите строку 1";
            // 
            // SecondString_label
            // 
            SecondString_label.BackColor = Color.Snow;
            SecondString_label.BorderStyle = BorderStyle.FixedSingle;
            SecondString_label.ForeColor = Color.DarkRed;
            SecondString_label.Location = new Point(27, 57);
            SecondString_label.Name = "SecondString_label";
            SecondString_label.Size = new Size(338, 49);
            SecondString_label.TabIndex = 1;
            SecondString_label.Text = "Введите строку 2";
            // 
            // FirstString_textBox
            // 
            FirstString_textBox.BackColor = Color.Snow;
            FirstString_textBox.BorderStyle = BorderStyle.FixedSingle;
            FirstString_textBox.ForeColor = Color.DarkRed;
            FirstString_textBox.Location = new Point(438, 134);
            FirstString_textBox.Multiline = true;
            FirstString_textBox.Name = "FirstString_textBox";
            FirstString_textBox.Size = new Size(608, 49);
            FirstString_textBox.TabIndex = 3;
            // 
            // SecondString_textBox
            // 
            SecondString_textBox.BackColor = Color.Snow;
            SecondString_textBox.BorderStyle = BorderStyle.FixedSingle;
            SecondString_textBox.ForeColor = Color.DarkRed;
            SecondString_textBox.Location = new Point(438, 54);
            SecondString_textBox.Multiline = true;
            SecondString_textBox.Name = "SecondString_textBox";
            SecondString_textBox.Size = new Size(608, 49);
            SecondString_textBox.TabIndex = 4;
            // 
            // LevenshteinDistance_tabControl
            // 
            LevenshteinDistance_tabControl.Controls.Add(CulculateDistance_tabPage);
            LevenshteinDistance_tabControl.Controls.Add(TimeComparison_tabPage);
            LevenshteinDistance_tabControl.Location = new Point(45, 54);
            LevenshteinDistance_tabControl.Name = "LevenshteinDistance_tabControl";
            LevenshteinDistance_tabControl.SelectedIndex = 0;
            LevenshteinDistance_tabControl.Size = new Size(1097, 630);
            LevenshteinDistance_tabControl.TabIndex = 5;
            // 
            // CulculateDistance_tabPage
            // 
            CulculateDistance_tabPage.BackColor = Color.WhiteSmoke;
            CulculateDistance_tabPage.Controls.Add(SecondString_textBox);
            CulculateDistance_tabPage.Controls.Add(FirstString_label);
            CulculateDistance_tabPage.Controls.Add(SecondString_label);
            CulculateDistance_tabPage.Controls.Add(FirstString_textBox);
            CulculateDistance_tabPage.Location = new Point(8, 46);
            CulculateDistance_tabPage.Name = "CulculateDistance_tabPage";
            CulculateDistance_tabPage.Padding = new Padding(3);
            CulculateDistance_tabPage.Size = new Size(1081, 576);
            CulculateDistance_tabPage.TabIndex = 0;
            CulculateDistance_tabPage.Text = "Вычисление расстояния ";
            // 
            // TimeComparison_tabPage
            // 
            TimeComparison_tabPage.BackColor = Color.WhiteSmoke;
            TimeComparison_tabPage.Controls.Add(pictureBox1);
            TimeComparison_tabPage.Location = new Point(8, 46);
            TimeComparison_tabPage.Name = "TimeComparison_tabPage";
            TimeComparison_tabPage.Padding = new Padding(3);
            TimeComparison_tabPage.Size = new Size(1081, 576);
            TimeComparison_tabPage.TabIndex = 1;
            TimeComparison_tabPage.Text = "Сравнение времени выполнения";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(542, 169);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(458, 309);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LevenshteinDistance_Form
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1196, 720);
            Controls.Add(LevenshteinDistance_tabControl);
            Name = "LevenshteinDistance_Form";
            Text = "LevenshteinDistance";
            LevenshteinDistance_tabControl.ResumeLayout(false);
            CulculateDistance_tabPage.ResumeLayout(false);
            CulculateDistance_tabPage.PerformLayout();
            TimeComparison_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label FirstString_label;
        private Label SecondString_label;
        private PictureBox pictureBox1;
        private TextBox FirstString_textBox;
        private TextBox SecondString_textBox;
        private TabControl LevenshteinDistance_tabControl;
        private TabPage CulculateDistance_tabPage;
        private TabPage TimeComparison_tabPage;
    }
}
