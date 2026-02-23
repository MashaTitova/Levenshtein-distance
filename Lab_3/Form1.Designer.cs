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
            FirstString_textBox = new TextBox();
            SecondString_textBox = new TextBox();
            Inf_button = new Button();
            LevenshteinDistance_tabControl = new TabControl();
            RecursiveMethod_tabPage = new TabPage();
            RecursiveMethod_button = new Button();
            OperationNumbersRecursion_textBox = new TextBox();
            OperationNumbersRecursion_label = new Label();
            TimeRecursive_textBox = new TextBox();
            TimeRecursive_label = new Label();
            InfRecursive_button = new Button();
            LevenshteinDistanceRecursive_textBox = new TextBox();
            LevenshteinDistanceRecursive_label = new Label();
            RecursiveMethod_label = new Label();
            DynamicProgramming_tabPage = new TabPage();
            DynamicProgramming_button = new Button();
            OperationNumbersDymanic_textBox = new TextBox();
            OperationNumbersDymanic_label = new Label();
            TimeDynamic_textBox = new TextBox();
            TimeDynamic_label = new Label();
            InfDynamicProgramming_button = new Button();
            LevenshteinDistanceDynamic_textBox = new TextBox();
            LevenshteinDistanceDynamic_label = new Label();
            DynamicProgramming_label = new Label();
            MethodСomparison_tabPage = new TabPage();
            dataGridView1 = new DataGridView();
            Method = new DataGridViewTextBoxColumn();
            Distance = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            OperationNumbers = new DataGridViewTextBoxColumn();
            Show_button = new Button();
            InfcComparison_button = new Button();
            LevenshteinDistance_tabControl.SuspendLayout();
            RecursiveMethod_tabPage.SuspendLayout();
            DynamicProgramming_tabPage.SuspendLayout();
            MethodСomparison_tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // FirstString_textBox
            // 
            FirstString_textBox.BackColor = Color.Snow;
            FirstString_textBox.BorderStyle = BorderStyle.FixedSingle;
            FirstString_textBox.ForeColor = Color.DarkRed;
            FirstString_textBox.Location = new Point(70, 81);
            FirstString_textBox.Name = "FirstString_textBox";
            FirstString_textBox.PlaceholderText = "Введите строку 1";
            FirstString_textBox.Size = new Size(608, 39);
            FirstString_textBox.TabIndex = 3;
            // 
            // SecondString_textBox
            // 
            SecondString_textBox.AccessibleDescription = "";
            SecondString_textBox.BackColor = Color.Snow;
            SecondString_textBox.BorderStyle = BorderStyle.FixedSingle;
            SecondString_textBox.ForeColor = Color.DarkRed;
            SecondString_textBox.Location = new Point(70, 158);
            SecondString_textBox.Name = "SecondString_textBox";
            SecondString_textBox.PlaceholderText = "Введите строку 2";
            SecondString_textBox.Size = new Size(608, 39);
            SecondString_textBox.TabIndex = 4;
            // 
            // Inf_button
            // 
            Inf_button.BackColor = Color.Snow;
            Inf_button.ForeColor = Color.DarkRed;
            Inf_button.Location = new Point(1068, 12);
            Inf_button.Name = "Inf_button";
            Inf_button.Size = new Size(150, 46);
            Inf_button.TabIndex = 5;
            Inf_button.Text = "Справка";
            Inf_button.UseVisualStyleBackColor = false;
            // 
            // LevenshteinDistance_tabControl
            // 
            LevenshteinDistance_tabControl.Controls.Add(RecursiveMethod_tabPage);
            LevenshteinDistance_tabControl.Controls.Add(DynamicProgramming_tabPage);
            LevenshteinDistance_tabControl.Controls.Add(MethodСomparison_tabPage);
            LevenshteinDistance_tabControl.Location = new Point(70, 253);
            LevenshteinDistance_tabControl.Name = "LevenshteinDistance_tabControl";
            LevenshteinDistance_tabControl.SelectedIndex = 0;
            LevenshteinDistance_tabControl.Size = new Size(1086, 554);
            LevenshteinDistance_tabControl.TabIndex = 8;
            // 
            // RecursiveMethod_tabPage
            // 
            RecursiveMethod_tabPage.Controls.Add(RecursiveMethod_button);
            RecursiveMethod_tabPage.Controls.Add(OperationNumbersRecursion_textBox);
            RecursiveMethod_tabPage.Controls.Add(OperationNumbersRecursion_label);
            RecursiveMethod_tabPage.Controls.Add(TimeRecursive_textBox);
            RecursiveMethod_tabPage.Controls.Add(TimeRecursive_label);
            RecursiveMethod_tabPage.Controls.Add(InfRecursive_button);
            RecursiveMethod_tabPage.Controls.Add(LevenshteinDistanceRecursive_textBox);
            RecursiveMethod_tabPage.Controls.Add(LevenshteinDistanceRecursive_label);
            RecursiveMethod_tabPage.Controls.Add(RecursiveMethod_label);
            RecursiveMethod_tabPage.Location = new Point(8, 46);
            RecursiveMethod_tabPage.Name = "RecursiveMethod_tabPage";
            RecursiveMethod_tabPage.Padding = new Padding(3);
            RecursiveMethod_tabPage.Size = new Size(1070, 500);
            RecursiveMethod_tabPage.TabIndex = 0;
            RecursiveMethod_tabPage.Text = "Рекурсивный метод";
            RecursiveMethod_tabPage.UseVisualStyleBackColor = true;
            // 
            // RecursiveMethod_button
            // 
            RecursiveMethod_button.BackColor = Color.Snow;
            RecursiveMethod_button.ForeColor = Color.DarkRed;
            RecursiveMethod_button.Location = new Point(20, 364);
            RecursiveMethod_button.Name = "RecursiveMethod_button";
            RecursiveMethod_button.Size = new Size(192, 66);
            RecursiveMethod_button.TabIndex = 15;
            RecursiveMethod_button.Text = "Рассчитать";
            RecursiveMethod_button.UseVisualStyleBackColor = false;
            RecursiveMethod_button.Click += Recursive_Method;
            // 
            // OperationNumbersRecursion_textBox
            // 
            OperationNumbersRecursion_textBox.BackColor = Color.Snow;
            OperationNumbersRecursion_textBox.BorderStyle = BorderStyle.FixedSingle;
            OperationNumbersRecursion_textBox.Enabled = false;
            OperationNumbersRecursion_textBox.ForeColor = Color.DarkRed;
            OperationNumbersRecursion_textBox.Location = new Point(541, 285);
            OperationNumbersRecursion_textBox.Multiline = true;
            OperationNumbersRecursion_textBox.Name = "OperationNumbersRecursion_textBox";
            OperationNumbersRecursion_textBox.Size = new Size(478, 49);
            OperationNumbersRecursion_textBox.TabIndex = 14;
            // 
            // OperationNumbersRecursion_label
            // 
            OperationNumbersRecursion_label.BackColor = Color.Snow;
            OperationNumbersRecursion_label.BorderStyle = BorderStyle.FixedSingle;
            OperationNumbersRecursion_label.ForeColor = Color.DarkRed;
            OperationNumbersRecursion_label.Location = new Point(20, 285);
            OperationNumbersRecursion_label.Name = "OperationNumbersRecursion_label";
            OperationNumbersRecursion_label.Size = new Size(451, 49);
            OperationNumbersRecursion_label.TabIndex = 13;
            OperationNumbersRecursion_label.Text = "Количество элементарных операций";
            // 
            // TimeRecursive_textBox
            // 
            TimeRecursive_textBox.BackColor = Color.Snow;
            TimeRecursive_textBox.BorderStyle = BorderStyle.FixedSingle;
            TimeRecursive_textBox.Enabled = false;
            TimeRecursive_textBox.ForeColor = Color.DarkRed;
            TimeRecursive_textBox.Location = new Point(411, 195);
            TimeRecursive_textBox.Multiline = true;
            TimeRecursive_textBox.Name = "TimeRecursive_textBox";
            TimeRecursive_textBox.Size = new Size(608, 49);
            TimeRecursive_textBox.TabIndex = 12;
            // 
            // TimeRecursive_label
            // 
            TimeRecursive_label.BackColor = Color.Snow;
            TimeRecursive_label.BorderStyle = BorderStyle.FixedSingle;
            TimeRecursive_label.ForeColor = Color.DarkRed;
            TimeRecursive_label.Location = new Point(20, 195);
            TimeRecursive_label.Name = "TimeRecursive_label";
            TimeRecursive_label.Size = new Size(339, 49);
            TimeRecursive_label.TabIndex = 11;
            TimeRecursive_label.Text = "Время выполнения";
            // 
            // InfRecursive_button
            // 
            InfRecursive_button.BackColor = Color.Snow;
            InfRecursive_button.ForeColor = Color.DarkRed;
            InfRecursive_button.Location = new Point(896, 6);
            InfRecursive_button.Name = "InfRecursive_button";
            InfRecursive_button.Size = new Size(150, 46);
            InfRecursive_button.TabIndex = 10;
            InfRecursive_button.Text = "Справка";
            InfRecursive_button.UseVisualStyleBackColor = false;
            // 
            // LevenshteinDistanceRecursive_textBox
            // 
            LevenshteinDistanceRecursive_textBox.BackColor = Color.Snow;
            LevenshteinDistanceRecursive_textBox.BorderStyle = BorderStyle.FixedSingle;
            LevenshteinDistanceRecursive_textBox.Enabled = false;
            LevenshteinDistanceRecursive_textBox.ForeColor = Color.DarkRed;
            LevenshteinDistanceRecursive_textBox.Location = new Point(411, 110);
            LevenshteinDistanceRecursive_textBox.Multiline = true;
            LevenshteinDistanceRecursive_textBox.Name = "LevenshteinDistanceRecursive_textBox";
            LevenshteinDistanceRecursive_textBox.Size = new Size(608, 49);
            LevenshteinDistanceRecursive_textBox.TabIndex = 9;
            // 
            // LevenshteinDistanceRecursive_label
            // 
            LevenshteinDistanceRecursive_label.BackColor = Color.Snow;
            LevenshteinDistanceRecursive_label.BorderStyle = BorderStyle.FixedSingle;
            LevenshteinDistanceRecursive_label.ForeColor = Color.DarkRed;
            LevenshteinDistanceRecursive_label.Location = new Point(20, 111);
            LevenshteinDistanceRecursive_label.Name = "LevenshteinDistanceRecursive_label";
            LevenshteinDistanceRecursive_label.Size = new Size(339, 49);
            LevenshteinDistanceRecursive_label.TabIndex = 9;
            LevenshteinDistanceRecursive_label.Text = "Расстояние Левенштейна";
            // 
            // RecursiveMethod_label
            // 
            RecursiveMethod_label.BackColor = Color.Snow;
            RecursiveMethod_label.BorderStyle = BorderStyle.FixedSingle;
            RecursiveMethod_label.ForeColor = Color.DarkRed;
            RecursiveMethod_label.Location = new Point(356, 36);
            RecursiveMethod_label.Name = "RecursiveMethod_label";
            RecursiveMethod_label.Size = new Size(339, 49);
            RecursiveMethod_label.TabIndex = 6;
            RecursiveMethod_label.Text = "Рекурсивный метод";
            RecursiveMethod_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // DynamicProgramming_tabPage
            // 
            DynamicProgramming_tabPage.Controls.Add(DynamicProgramming_button);
            DynamicProgramming_tabPage.Controls.Add(OperationNumbersDymanic_textBox);
            DynamicProgramming_tabPage.Controls.Add(OperationNumbersDymanic_label);
            DynamicProgramming_tabPage.Controls.Add(TimeDynamic_textBox);
            DynamicProgramming_tabPage.Controls.Add(TimeDynamic_label);
            DynamicProgramming_tabPage.Controls.Add(InfDynamicProgramming_button);
            DynamicProgramming_tabPage.Controls.Add(LevenshteinDistanceDynamic_textBox);
            DynamicProgramming_tabPage.Controls.Add(LevenshteinDistanceDynamic_label);
            DynamicProgramming_tabPage.Controls.Add(DynamicProgramming_label);
            DynamicProgramming_tabPage.ForeColor = Color.DarkRed;
            DynamicProgramming_tabPage.Location = new Point(8, 46);
            DynamicProgramming_tabPage.Name = "DynamicProgramming_tabPage";
            DynamicProgramming_tabPage.Padding = new Padding(3);
            DynamicProgramming_tabPage.Size = new Size(1070, 500);
            DynamicProgramming_tabPage.TabIndex = 1;
            DynamicProgramming_tabPage.Text = "Метод динамического программирования";
            DynamicProgramming_tabPage.UseVisualStyleBackColor = true;
            // 
            // DynamicProgramming_button
            // 
            DynamicProgramming_button.BackColor = Color.Snow;
            DynamicProgramming_button.ForeColor = Color.DarkRed;
            DynamicProgramming_button.Location = new Point(19, 359);
            DynamicProgramming_button.Name = "DynamicProgramming_button";
            DynamicProgramming_button.Size = new Size(192, 66);
            DynamicProgramming_button.TabIndex = 23;
            DynamicProgramming_button.Text = "Рассчитать";
            DynamicProgramming_button.UseVisualStyleBackColor = false;
            DynamicProgramming_button.Click += Dynamic_Method;
            // 
            // OperationNumbersDymanic_textBox
            // 
            OperationNumbersDymanic_textBox.BackColor = Color.Snow;
            OperationNumbersDymanic_textBox.BorderStyle = BorderStyle.FixedSingle;
            OperationNumbersDymanic_textBox.Enabled = false;
            OperationNumbersDymanic_textBox.ForeColor = Color.DarkRed;
            OperationNumbersDymanic_textBox.Location = new Point(540, 280);
            OperationNumbersDymanic_textBox.Multiline = true;
            OperationNumbersDymanic_textBox.Name = "OperationNumbersDymanic_textBox";
            OperationNumbersDymanic_textBox.Size = new Size(478, 49);
            OperationNumbersDymanic_textBox.TabIndex = 22;
            // 
            // OperationNumbersDymanic_label
            // 
            OperationNumbersDymanic_label.BackColor = Color.Snow;
            OperationNumbersDymanic_label.BorderStyle = BorderStyle.FixedSingle;
            OperationNumbersDymanic_label.ForeColor = Color.DarkRed;
            OperationNumbersDymanic_label.Location = new Point(19, 280);
            OperationNumbersDymanic_label.Name = "OperationNumbersDymanic_label";
            OperationNumbersDymanic_label.Size = new Size(451, 49);
            OperationNumbersDymanic_label.TabIndex = 21;
            OperationNumbersDymanic_label.Text = "Количество элементарных операций";
            // 
            // TimeDynamic_textBox
            // 
            TimeDynamic_textBox.BackColor = Color.Snow;
            TimeDynamic_textBox.BorderStyle = BorderStyle.FixedSingle;
            TimeDynamic_textBox.Enabled = false;
            TimeDynamic_textBox.ForeColor = Color.DarkRed;
            TimeDynamic_textBox.Location = new Point(410, 190);
            TimeDynamic_textBox.Multiline = true;
            TimeDynamic_textBox.Name = "TimeDynamic_textBox";
            TimeDynamic_textBox.Size = new Size(608, 49);
            TimeDynamic_textBox.TabIndex = 20;
            // 
            // TimeDynamic_label
            // 
            TimeDynamic_label.BackColor = Color.Snow;
            TimeDynamic_label.BorderStyle = BorderStyle.FixedSingle;
            TimeDynamic_label.ForeColor = Color.DarkRed;
            TimeDynamic_label.Location = new Point(19, 190);
            TimeDynamic_label.Name = "TimeDynamic_label";
            TimeDynamic_label.Size = new Size(339, 49);
            TimeDynamic_label.TabIndex = 19;
            TimeDynamic_label.Text = "Время выполнения";
            // 
            // InfDynamicProgramming_button
            // 
            InfDynamicProgramming_button.BackColor = Color.Snow;
            InfDynamicProgramming_button.ForeColor = Color.DarkRed;
            InfDynamicProgramming_button.Location = new Point(896, 6);
            InfDynamicProgramming_button.Name = "InfDynamicProgramming_button";
            InfDynamicProgramming_button.Size = new Size(150, 46);
            InfDynamicProgramming_button.TabIndex = 18;
            InfDynamicProgramming_button.Text = "Справка";
            InfDynamicProgramming_button.UseVisualStyleBackColor = false;
            // 
            // LevenshteinDistanceDynamic_textBox
            // 
            LevenshteinDistanceDynamic_textBox.BackColor = Color.Snow;
            LevenshteinDistanceDynamic_textBox.BorderStyle = BorderStyle.FixedSingle;
            LevenshteinDistanceDynamic_textBox.Enabled = false;
            LevenshteinDistanceDynamic_textBox.ForeColor = Color.DarkRed;
            LevenshteinDistanceDynamic_textBox.Location = new Point(410, 110);
            LevenshteinDistanceDynamic_textBox.Multiline = true;
            LevenshteinDistanceDynamic_textBox.Name = "LevenshteinDistanceDynamic_textBox";
            LevenshteinDistanceDynamic_textBox.Size = new Size(608, 49);
            LevenshteinDistanceDynamic_textBox.TabIndex = 16;
            // 
            // LevenshteinDistanceDynamic_label
            // 
            LevenshteinDistanceDynamic_label.BackColor = Color.Snow;
            LevenshteinDistanceDynamic_label.BorderStyle = BorderStyle.FixedSingle;
            LevenshteinDistanceDynamic_label.ForeColor = Color.DarkRed;
            LevenshteinDistanceDynamic_label.Location = new Point(19, 110);
            LevenshteinDistanceDynamic_label.Name = "LevenshteinDistanceDynamic_label";
            LevenshteinDistanceDynamic_label.Size = new Size(339, 49);
            LevenshteinDistanceDynamic_label.TabIndex = 17;
            LevenshteinDistanceDynamic_label.Text = "Расстояние Левенштейна";
            // 
            // DynamicProgramming_label
            // 
            DynamicProgramming_label.BackColor = Color.Snow;
            DynamicProgramming_label.BorderStyle = BorderStyle.FixedSingle;
            DynamicProgramming_label.ForeColor = Color.DarkRed;
            DynamicProgramming_label.Location = new Point(251, 32);
            DynamicProgramming_label.Name = "DynamicProgramming_label";
            DynamicProgramming_label.Size = new Size(536, 49);
            DynamicProgramming_label.TabIndex = 15;
            DynamicProgramming_label.Text = "Метод динамического программирования";
            DynamicProgramming_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // MethodСomparison_tabPage
            // 
            MethodСomparison_tabPage.BackColor = Color.WhiteSmoke;
            MethodСomparison_tabPage.Controls.Add(dataGridView1);
            MethodСomparison_tabPage.Controls.Add(Show_button);
            MethodСomparison_tabPage.Controls.Add(InfcComparison_button);
            MethodСomparison_tabPage.ForeColor = Color.DarkRed;
            MethodСomparison_tabPage.Location = new Point(8, 46);
            MethodСomparison_tabPage.Name = "MethodСomparison_tabPage";
            MethodСomparison_tabPage.Padding = new Padding(3);
            MethodСomparison_tabPage.Size = new Size(1070, 500);
            MethodСomparison_tabPage.TabIndex = 2;
            MethodСomparison_tabPage.Text = "Сравнение методов";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Method, Distance, Time, OperationNumbers });
            dataGridView1.Location = new Point(42, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(885, 368);
            dataGridView1.TabIndex = 9;
            // 
            // Method
            // 
            Method.HeaderText = "Метод";
            Method.MinimumWidth = 10;
            Method.Name = "Method";
            Method.ReadOnly = true;
            Method.Width = 200;
            // 
            // Distance
            // 
            Distance.HeaderText = "Расстояние Левенштейна ";
            Distance.MinimumWidth = 10;
            Distance.Name = "Distance";
            Distance.ReadOnly = true;
            Distance.Width = 200;
            // 
            // Time
            // 
            Time.HeaderText = "Время";
            Time.MinimumWidth = 10;
            Time.Name = "Time";
            Time.ReadOnly = true;
            Time.Width = 200;
            // 
            // OperationNumbers
            // 
            OperationNumbers.HeaderText = "Количество операций";
            OperationNumbers.MinimumWidth = 10;
            OperationNumbers.Name = "OperationNumbers";
            OperationNumbers.ReadOnly = true;
            OperationNumbers.Width = 200;
            // 
            // Show_button
            // 
            Show_button.BackColor = Color.Snow;
            Show_button.ForeColor = Color.DarkRed;
            Show_button.Location = new Point(820, 413);
            Show_button.Name = "Show_button";
            Show_button.Size = new Size(192, 66);
            Show_button.TabIndex = 24;
            Show_button.Text = "Обновить";
            Show_button.UseVisualStyleBackColor = false;
            Show_button.Click += Comparison;
            // 
            // InfcComparison_button
            // 
            InfcComparison_button.BackColor = Color.Snow;
            InfcComparison_button.ForeColor = Color.DarkRed;
            InfcComparison_button.Location = new Point(6, 448);
            InfcComparison_button.Name = "InfcComparison_button";
            InfcComparison_button.Size = new Size(150, 46);
            InfcComparison_button.TabIndex = 11;
            InfcComparison_button.Text = "Справка";
            InfcComparison_button.UseVisualStyleBackColor = false;
            // 
            // LevenshteinDistance_Form
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1304, 872);
            Controls.Add(LevenshteinDistance_tabControl);
            Controls.Add(Inf_button);
            Controls.Add(SecondString_textBox);
            Controls.Add(FirstString_textBox);
            Name = "LevenshteinDistance_Form";
            Text = "LevenshteinDistance";
            LevenshteinDistance_tabControl.ResumeLayout(false);
            RecursiveMethod_tabPage.ResumeLayout(false);
            RecursiveMethod_tabPage.PerformLayout();
            DynamicProgramming_tabPage.ResumeLayout(false);
            DynamicProgramming_tabPage.PerformLayout();
            MethodСomparison_tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FirstString_textBox;
        private TextBox SecondString_textBox;
        private Button Inf_button;
        private TabControl LevenshteinDistance_tabControl;
        private TabPage RecursiveMethod_tabPage;
        private TabPage DynamicProgramming_tabPage;
        private Label RecursiveMethod_label;
        private Label LevenshteinDistanceRecursive_label;
        private Button InfRecursive_button;
        private TextBox OperationNumbersRecursion_textBox;
        private Label OperationNumbersRecursion_label;
        private TextBox TimeRecursive_textBox;
        private Label TimeRecursive_label;
        private Button InfDynamicProgramming_button;
        private TextBox LevenshteinDistanceDynamic_textBox;
        private Label LevenshteinDistanceDynamic_label;
        private Label DynamicProgramming_label;
        private TextBox LevenshteinDistanceRecursive_textBox;
        private Button RecursiveMethod_button;
        private TabPage MethodСomparison_tabPage;
        private Button DynamicProgramming_button;
        private TextBox OperationNumbersDymanic_textBox;
        private Label OperationNumbersDymanic_label;
        private TextBox TimeDynamic_textBox;
        private Label TimeDynamic_label;
        private Button InfcComparison_button;
        private Button Show_button;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Method;
        private DataGridViewTextBoxColumn Distance;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn OperationNumbers;
    }
}
