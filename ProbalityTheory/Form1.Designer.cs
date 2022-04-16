namespace ProbalityTheory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CreateFiles = new System.Windows.Forms.Button();
            this.TextNumOfVariants = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.NumbersOfVariants = new System.Windows.Forms.NumericUpDown();
            this.TextSearchStudentFile = new System.Windows.Forms.Label();
            this.StudentFileButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.NumbersOfVariants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateFiles
            // 
            this.CreateFiles.BackColor = System.Drawing.Color.Transparent;
            this.CreateFiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.CreateFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateFiles.Location = new System.Drawing.Point(700, 506);
            this.CreateFiles.Name = "CreateFiles";
            this.CreateFiles.Size = new System.Drawing.Size(200, 35);
            this.CreateFiles.TabIndex = 0;
            this.CreateFiles.Text = "Создать";
            this.CreateFiles.UseVisualStyleBackColor = false;
            this.CreateFiles.Click += new System.EventHandler(this.CreateFiles_Click);
            // 
            // TextNumOfVariants
            // 
            this.TextNumOfVariants.AutoSize = true;
            this.TextNumOfVariants.BackColor = System.Drawing.Color.Transparent;
            this.TextNumOfVariants.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextNumOfVariants.ForeColor = System.Drawing.Color.Gainsboro;
            this.TextNumOfVariants.Location = new System.Drawing.Point(12, 79);
            this.TextNumOfVariants.Name = "TextNumOfVariants";
            this.TextNumOfVariants.Size = new System.Drawing.Size(256, 31);
            this.TextNumOfVariants.TabIndex = 1;
            this.TextNumOfVariants.Text = "Количество вариантов:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NumbersOfVariants
            // 
            this.NumbersOfVariants.BackColor = System.Drawing.Color.Black;
            this.NumbersOfVariants.ForeColor = System.Drawing.Color.White;
            this.NumbersOfVariants.Location = new System.Drawing.Point(274, 86);
            this.NumbersOfVariants.Name = "NumbersOfVariants";
            this.NumbersOfVariants.Size = new System.Drawing.Size(150, 27);
            this.NumbersOfVariants.TabIndex = 9;
            // 
            // TextSearchStudentFile
            // 
            this.TextSearchStudentFile.AutoSize = true;
            this.TextSearchStudentFile.BackColor = System.Drawing.Color.Transparent;
            this.TextSearchStudentFile.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextSearchStudentFile.ForeColor = System.Drawing.Color.LightGray;
            this.TextSearchStudentFile.Location = new System.Drawing.Point(12, 418);
            this.TextSearchStudentFile.Name = "TextSearchStudentFile";
            this.TextSearchStudentFile.Size = new System.Drawing.Size(435, 31);
            this.TextSearchStudentFile.TabIndex = 10;
            this.TextSearchStudentFile.Text = "Выберите файл с фамилиями студентов:";
            // 
            // StudentFileButton
            // 
            this.StudentFileButton.BackColor = System.Drawing.Color.Transparent;
            this.StudentFileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.StudentFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentFileButton.Location = new System.Drawing.Point(453, 420);
            this.StudentFileButton.Name = "StudentFileButton";
            this.StudentFileButton.Size = new System.Drawing.Size(200, 35);
            this.StudentFileButton.TabIndex = 11;
            this.StudentFileButton.Text = "Выбрать";
            this.StudentFileButton.UseVisualStyleBackColor = false;
            this.StudentFileButton.Click += new System.EventHandler(this.StudentFileButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(906, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(664, 529);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(12, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 178);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор задач:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButton2.Location = new System.Drawing.Point(6, 84);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 32);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "1-10";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.radioButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.radioButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButton3.Location = new System.Drawing.Point(6, 122);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 32);
            this.radioButton3.TabIndex = 20;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "11-18";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.radioButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.radioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButton1.Location = new System.Drawing.Point(6, 46);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 34);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Все";
            this.radioButton1.UseCompatibleTextRendering = true;
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1582, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StudentFileButton);
            this.Controls.Add(this.TextSearchStudentFile);
            this.Controls.Add(this.NumbersOfVariants);
            this.Controls.Add(this.TextNumOfVariants);
            this.Controls.Add(this.CreateFiles);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Varinats";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumbersOfVariants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CreateFiles;
        private Label TextNumOfVariants;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private NumericUpDown NumbersOfVariants;
        private Label TextSearchStudentFile;
        private Button StudentFileButton;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton1;
    }
}