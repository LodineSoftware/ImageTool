namespace LodineImageTool
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
            formTitle = new Label();
            divider = new Label();
            copyrightText = new Label();
            tabControl1 = new TabControl();
            aboutPage = new TabPage();
            openGithubButton = new Button();
            label6 = new Label();
            label5 = new Label();
            resizePage = new TabPage();
            resizeButton = new Button();
            selectImageButton = new Button();
            selectedImagePath = new TextBox();
            label4 = new Label();
            label3 = new Label();
            widthUpDown = new NumericUpDown();
            label2 = new Label();
            heightUpDown = new NumericUpDown();
            label1 = new Label();
            saveTypeExtensions = new ComboBox();
            tabControl1.SuspendLayout();
            aboutPage.SuspendLayout();
            resizePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)widthUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heightUpDown).BeginInit();
            SuspendLayout();
            // 
            // formTitle
            // 
            formTitle.AutoSize = true;
            formTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            formTitle.Location = new Point(11, 8);
            formTitle.Margin = new Padding(4, 0, 4, 0);
            formTitle.Name = "formTitle";
            formTitle.Size = new Size(104, 25);
            formTitle.TabIndex = 0;
            formTitle.Text = "Image Tool";
            // 
            // divider
            // 
            divider.BorderStyle = BorderStyle.Fixed3D;
            divider.Dock = DockStyle.Bottom;
            divider.Location = new Point(0, 358);
            divider.Margin = new Padding(2, 0, 2, 0);
            divider.Name = "divider";
            divider.Size = new Size(641, 29);
            divider.TabIndex = 1;
            divider.Text = " ";
            // 
            // copyrightText
            // 
            copyrightText.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            copyrightText.AutoSize = true;
            copyrightText.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            copyrightText.Location = new Point(407, 362);
            copyrightText.Margin = new Padding(2, 0, 2, 0);
            copyrightText.Name = "copyrightText";
            copyrightText.Size = new Size(224, 19);
            copyrightText.TabIndex = 2;
            copyrightText.Text = "Copyright © 2023 Lodine Software";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(aboutPage);
            tabControl1.Controls.Add(resizePage);
            tabControl1.Location = new Point(11, 36);
            tabControl1.Margin = new Padding(2, 3, 2, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(620, 320);
            tabControl1.TabIndex = 3;
            // 
            // aboutPage
            // 
            aboutPage.Controls.Add(openGithubButton);
            aboutPage.Controls.Add(label6);
            aboutPage.Controls.Add(label5);
            aboutPage.Location = new Point(4, 30);
            aboutPage.Margin = new Padding(2, 3, 2, 3);
            aboutPage.Name = "aboutPage";
            aboutPage.Padding = new Padding(2, 3, 2, 3);
            aboutPage.Size = new Size(612, 286);
            aboutPage.TabIndex = 1;
            aboutPage.Text = "About";
            aboutPage.UseVisualStyleBackColor = true;
            // 
            // openGithubButton
            // 
            openGithubButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            openGithubButton.Location = new Point(523, 243);
            openGithubButton.Name = "openGithubButton";
            openGithubButton.Size = new Size(84, 37);
            openGithubButton.TabIndex = 2;
            openGithubButton.Text = "Github";
            openGithubButton.UseVisualStyleBackColor = true;
            openGithubButton.Click += openGithubButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 35);
            label6.Name = "label6";
            label6.Size = new Size(125, 21);
            label6.TabIndex = 1;
            label6.Text = "Created by Nitro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(5, 3);
            label5.Name = "label5";
            label5.Size = new Size(344, 32);
            label5.TabIndex = 0;
            label5.Text = "Image Tool by Lodine Software";
            // 
            // resizePage
            // 
            resizePage.Controls.Add(resizeButton);
            resizePage.Controls.Add(selectImageButton);
            resizePage.Controls.Add(selectedImagePath);
            resizePage.Controls.Add(label4);
            resizePage.Controls.Add(label3);
            resizePage.Controls.Add(widthUpDown);
            resizePage.Controls.Add(label2);
            resizePage.Controls.Add(heightUpDown);
            resizePage.Controls.Add(label1);
            resizePage.Controls.Add(saveTypeExtensions);
            resizePage.Location = new Point(4, 24);
            resizePage.Margin = new Padding(2, 3, 2, 3);
            resizePage.Name = "resizePage";
            resizePage.Padding = new Padding(2, 3, 2, 3);
            resizePage.Size = new Size(612, 292);
            resizePage.TabIndex = 0;
            resizePage.Text = "Resize Image";
            resizePage.UseVisualStyleBackColor = true;
            // 
            // resizeButton
            // 
            resizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            resizeButton.Location = new Point(486, 41);
            resizeButton.Name = "resizeButton";
            resizeButton.Size = new Size(121, 38);
            resizeButton.TabIndex = 9;
            resizeButton.Text = "Resize";
            resizeButton.UseVisualStyleBackColor = true;
            resizeButton.Click += resizeButton_Click;
            // 
            // selectImageButton
            // 
            selectImageButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            selectImageButton.Location = new Point(556, 6);
            selectImageButton.Name = "selectImageButton";
            selectImageButton.Size = new Size(51, 29);
            selectImageButton.TabIndex = 8;
            selectImageButton.Text = "...";
            selectImageButton.UseVisualStyleBackColor = true;
            selectImageButton.Click += selectImageButton_Click;
            // 
            // selectedImagePath
            // 
            selectedImagePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            selectedImagePath.Location = new Point(133, 6);
            selectedImagePath.Name = "selectedImagePath";
            selectedImagePath.Size = new Size(417, 29);
            selectedImagePath.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 9);
            label4.Name = "label4";
            label4.Size = new Size(118, 21);
            label4.TabIndex = 6;
            label4.Text = "Selected Image:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Bottom;
            label3.Location = new Point(2, 139);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 5;
            label3.Text = "Width";
            // 
            // widthUpDown
            // 
            widthUpDown.Dock = DockStyle.Bottom;
            widthUpDown.Location = new Point(2, 160);
            widthUpDown.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            widthUpDown.Name = "widthUpDown";
            widthUpDown.Size = new Size(608, 29);
            widthUpDown.TabIndex = 4;
            widthUpDown.Value = new decimal(new int[] { 128, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Location = new Point(2, 189);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 3;
            label2.Text = "Height";
            // 
            // heightUpDown
            // 
            heightUpDown.Dock = DockStyle.Bottom;
            heightUpDown.Location = new Point(2, 210);
            heightUpDown.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            heightUpDown.Name = "heightUpDown";
            heightUpDown.Size = new Size(608, 29);
            heightUpDown.TabIndex = 2;
            heightUpDown.Value = new decimal(new int[] { 128, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Location = new Point(2, 239);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 1;
            label1.Text = "Save As";
            // 
            // saveTypeExtensions
            // 
            saveTypeExtensions.Dock = DockStyle.Bottom;
            saveTypeExtensions.FormattingEnabled = true;
            saveTypeExtensions.Location = new Point(2, 260);
            saveTypeExtensions.Name = "saveTypeExtensions";
            saveTypeExtensions.Size = new Size(608, 29);
            saveTypeExtensions.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 387);
            Controls.Add(tabControl1);
            Controls.Add(copyrightText);
            Controls.Add(divider);
            Controls.Add(formTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MinimumSize = new Size(600, 400);
            Name = "Form1";
            Text = "Lodine Image Tool";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            aboutPage.ResumeLayout(false);
            aboutPage.PerformLayout();
            resizePage.ResumeLayout(false);
            resizePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)widthUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)heightUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formTitle;
        private Label divider;
        private Label copyrightText;
        private TabControl tabControl1;
        private TabPage resizePage;
        private TabPage aboutPage;
        private Label label1;
        private ComboBox saveTypeExtensions;
        private Label label2;
        private NumericUpDown heightUpDown;
        private Label label3;
        private NumericUpDown widthUpDown;
        private Label label4;
        private TextBox selectedImagePath;
        private Button selectImageButton;
        private Button resizeButton;
        private Label label5;
        private Label label6;
        private Button openGithubButton;
    }
}