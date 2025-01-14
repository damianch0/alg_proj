namespace AlgProj
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
            menuStrip1 = new MenuStrip();
            plikToolStripMenuItem = new ToolStripMenuItem();
            zapiszToolStripMenuItem = new ToolStripMenuItem();
            routePictureBox = new PictureBox();
            addPointButton = new Button();
            removePointButton = new Button();
            pointsDataGridView = new DataGridView();
            editPointButton = new Button();
            routeRichTextBox = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)routePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pointsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(979, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zapiszToolStripMenuItem });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(38, 20);
            plikToolStripMenuItem.Text = "Plik";
            // 
            // zapiszToolStripMenuItem
            // 
            zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            zapiszToolStripMenuItem.Size = new Size(135, 22);
            zapiszToolStripMenuItem.Text = "Zapisz trase";
            zapiszToolStripMenuItem.Click += zapiszToolStripMenuItem_Click;
            // 
            // routePictureBox
            // 
            routePictureBox.BorderStyle = BorderStyle.FixedSingle;
            routePictureBox.Image = Properties.Resources.map_image;
            routePictureBox.Location = new System.Drawing.Point(568, 57);
            routePictureBox.Name = "routePictureBox";
            routePictureBox.Size = new Size(400, 400);
            routePictureBox.TabIndex = 1;
            routePictureBox.TabStop = false;
            // 
            // addPointButton
            // 
            addPointButton.Image = Properties.Resources.Add_16xMD;
            addPointButton.Location = new System.Drawing.Point(199, 27);
            addPointButton.Name = "addPointButton";
            addPointButton.Size = new Size(24, 24);
            addPointButton.TabIndex = 3;
            addPointButton.UseVisualStyleBackColor = true;
            addPointButton.Click += addPointButton_Click;
            // 
            // removePointButton
            // 
            removePointButton.Image = Properties.Resources.DeleteTableRow_16x;
            removePointButton.Location = new System.Drawing.Point(169, 27);
            removePointButton.Name = "removePointButton";
            removePointButton.Size = new Size(24, 24);
            removePointButton.TabIndex = 4;
            removePointButton.UseVisualStyleBackColor = true;
            removePointButton.Click += removePointButton_Click;
            // 
            // pointsDataGridView
            // 
            pointsDataGridView.AllowUserToAddRows = false;
            pointsDataGridView.AllowUserToDeleteRows = false;
            pointsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pointsDataGridView.Location = new System.Drawing.Point(12, 57);
            pointsDataGridView.Name = "pointsDataGridView";
            pointsDataGridView.ReadOnly = true;
            pointsDataGridView.RowTemplate.Height = 25;
            pointsDataGridView.Size = new Size(241, 400);
            pointsDataGridView.TabIndex = 5;
            // 
            // editPointButton
            // 
            editPointButton.Location = new System.Drawing.Point(229, 27);
            editPointButton.Name = "editPointButton";
            editPointButton.Size = new Size(24, 24);
            editPointButton.TabIndex = 6;
            editPointButton.Text = "E";
            editPointButton.UseVisualStyleBackColor = true;
            editPointButton.Click += editPointButton_Click;
            // 
            // routeRichTextBox
            // 
            routeRichTextBox.Location = new System.Drawing.Point(270, 57);
            routeRichTextBox.Name = "routeRichTextBox";
            routeRichTextBox.ReadOnly = true;
            routeRichTextBox.Size = new Size(282, 400);
            routeRichTextBox.TabIndex = 7;
            routeRichTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(270, 32);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 8;
            label1.Text = "Przebieg trasy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(568, 32);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 9;
            label2.Text = "Wizualizacja trasy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 32);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 10;
            label3.Text = "Punkty";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 468);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(routeRichTextBox);
            Controls.Add(editPointButton);
            Controls.Add(pointsDataGridView);
            Controls.Add(removePointButton);
            Controls.Add(addPointButton);
            Controls.Add(routePictureBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Kurierex";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)routePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pointsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem plikToolStripMenuItem;
        private ToolStripMenuItem zapiszToolStripMenuItem;
        private PictureBox routePictureBox;
        private Button addPointButton;
        private Button removePointButton;
        private DataGridView pointsDataGridView;
        private Button editPointButton;
        private RichTextBox routeRichTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}