
namespace Кр_Пз_
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
            this.richTextBoxDisplay = new System.Windows.Forms.RichTextBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.SortPointsD = new System.Windows.Forms.Button();
            this.createTable = new System.Windows.Forms.Button();
            this.SortPointsA = new System.Windows.Forms.Button();
            this.FindUniqePoints = new System.Windows.Forms.Button();
            this.textBoxCenterX = new System.Windows.Forms.TextBox();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.textBoxCenterY = new System.Windows.Forms.TextBox();
            this.OpenFile = new System.Windows.Forms.Button();
            this.SaveToFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxDisplay
            // 
            this.richTextBoxDisplay.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxDisplay.Name = "richTextBoxDisplay";
            this.richTextBoxDisplay.Size = new System.Drawing.Size(217, 158);
            this.richTextBoxDisplay.TabIndex = 0;
            this.richTextBoxDisplay.Text = "";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(288, 93);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(142, 23);
            this.comboBoxColor.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(288, 167);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(142, 39);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "AddPoint";
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(288, 12);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(142, 23);
            this.textBoxX.TabIndex = 3;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(288, 53);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(142, 23);
            this.textBoxY.TabIndex = 4;
            // 
            // SortPointsD
            // 
            this.SortPointsD.Location = new System.Drawing.Point(198, 260);
            this.SortPointsD.Name = "SortPointsD";
            this.SortPointsD.Size = new System.Drawing.Size(142, 39);
            this.SortPointsD.TabIndex = 5;
            this.SortPointsD.Text = "SortPointsD";
            this.SortPointsD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.SortPointsD.UseVisualStyleBackColor = true;
            this.SortPointsD.Click += new System.EventHandler(this.SortPointsD_Click);
            // 
            // createTable
            // 
            this.createTable.Location = new System.Drawing.Point(198, 320);
            this.createTable.Name = "createTable";
            this.createTable.Size = new System.Drawing.Size(142, 39);
            this.createTable.TabIndex = 6;
            this.createTable.Text = "createTable";
            this.createTable.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.createTable.UseVisualStyleBackColor = true;
            this.createTable.Click += new System.EventHandler(this.createTable_Click);
            // 
            // SortPointsA
            // 
            this.SortPointsA.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.SortPointsA.Location = new System.Drawing.Point(29, 260);
            this.SortPointsA.Name = "SortPointsA";
            this.SortPointsA.Size = new System.Drawing.Size(142, 39);
            this.SortPointsA.TabIndex = 7;
            this.SortPointsA.Text = "SortPointsA";
            this.SortPointsA.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.SortPointsA.UseVisualStyleBackColor = true;
            this.SortPointsA.Click += new System.EventHandler(this.SortPointsA_Click);
            // 
            // FindUniqePoints
            // 
            this.FindUniqePoints.Location = new System.Drawing.Point(29, 320);
            this.FindUniqePoints.Name = "FindUniqePoints";
            this.FindUniqePoints.Size = new System.Drawing.Size(142, 39);
            this.FindUniqePoints.TabIndex = 8;
            this.FindUniqePoints.Text = "FindUniqePoints";
            this.FindUniqePoints.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.FindUniqePoints.UseVisualStyleBackColor = true;
            this.FindUniqePoints.Click += new System.EventHandler(this.FindUniqePoints_Click_1);
            // 
            // textBoxCenterX
            // 
            this.textBoxCenterX.Location = new System.Drawing.Point(542, 12);
            this.textBoxCenterX.Name = "textBoxCenterX";
            this.textBoxCenterX.Size = new System.Drawing.Size(100, 23);
            this.textBoxCenterX.TabIndex = 9;
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Location = new System.Drawing.Point(542, 108);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(100, 23);
            this.textBoxRadius.TabIndex = 10;
            // 
            // textBoxCenterY
            // 
            this.textBoxCenterY.Location = new System.Drawing.Point(542, 62);
            this.textBoxCenterY.Name = "textBoxCenterY";
            this.textBoxCenterY.Size = new System.Drawing.Size(100, 23);
            this.textBoxCenterY.TabIndex = 11;
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(371, 260);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(142, 39);
            this.OpenFile.TabIndex = 12;
            this.OpenFile.Text = "OpenFile";
            this.OpenFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SaveToFile
            // 
            this.SaveToFile.Location = new System.Drawing.Point(371, 320);
            this.SaveToFile.Name = "SaveToFile";
            this.SaveToFile.Size = new System.Drawing.Size(142, 39);
            this.SaveToFile.TabIndex = 13;
            this.SaveToFile.Text = "SaveToFile";
            this.SaveToFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.SaveToFile.UseVisualStyleBackColor = true;
            this.SaveToFile.Click += new System.EventHandler(this.SaveToFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveToFile);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.textBoxCenterY);
            this.Controls.Add(this.textBoxRadius);
            this.Controls.Add(this.textBoxCenterX);
            this.Controls.Add(this.FindUniqePoints);
            this.Controls.Add(this.SortPointsA);
            this.Controls.Add(this.createTable);
            this.Controls.Add(this.SortPointsD);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.richTextBoxDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxDisplay;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Button SortPointsD;
        private System.Windows.Forms.Button createTable;
        private System.Windows.Forms.Button SortPointsA;
        private System.Windows.Forms.Button FindUniqePoints;
        private System.Windows.Forms.TextBox textBoxCenterX;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.TextBox textBoxCenterY;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button SaveToFile;
    }
}

