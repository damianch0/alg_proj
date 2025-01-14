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
            raportyToolStripMenuItem = new ToolStripMenuItem();
            raportTrasyToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            addPointButton = new Button();
            removePointButton = new Button();
            pointsDataGridView = new DataGridView();
            editPointButton = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pointsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem, raportyToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1129, 24);
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
            zapiszToolStripMenuItem.Size = new Size(107, 22);
            zapiszToolStripMenuItem.Text = "Zapisz";
            // 
            // raportyToolStripMenuItem
            // 
            raportyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { raportTrasyToolStripMenuItem });
            raportyToolStripMenuItem.Name = "raportyToolStripMenuItem";
            raportyToolStripMenuItem.Size = new Size(60, 20);
            raportyToolStripMenuItem.Text = "Raporty";
            // 
            // raportTrasyToolStripMenuItem
            // 
            raportTrasyToolStripMenuItem.Name = "raportTrasyToolStripMenuItem";
            raportTrasyToolStripMenuItem.Size = new Size(137, 22);
            raportTrasyToolStripMenuItem.Text = "Raport trasy";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.map_image;
            pictureBox1.Location = new System.Drawing.Point(717, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 400);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // addPointButton
            // 
            addPointButton.Image = Properties.Resources.Add_16xMD;
            addPointButton.Location = new System.Drawing.Point(42, 27);
            addPointButton.Name = "addPointButton";
            addPointButton.Size = new Size(24, 24);
            addPointButton.TabIndex = 3;
            addPointButton.UseVisualStyleBackColor = true;
            addPointButton.Click += addPointButton_Click;
            // 
            // removePointButton
            // 
            removePointButton.Image = Properties.Resources.DeleteTableRow_16x;
            removePointButton.Location = new System.Drawing.Point(12, 27);
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
            pointsDataGridView.Size = new Size(290, 400);
            pointsDataGridView.TabIndex = 5;
            // 
            // editPointButton
            // 
            editPointButton.Location = new System.Drawing.Point(72, 27);
            editPointButton.Name = "editPointButton";
            editPointButton.Size = new Size(24, 24);
            editPointButton.TabIndex = 6;
            editPointButton.Text = "E";
            editPointButton.UseVisualStyleBackColor = true;
            editPointButton.Click += editPointButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 621);
            Controls.Add(editPointButton);
            Controls.Add(pointsDataGridView);
            Controls.Add(removePointButton);
            Controls.Add(addPointButton);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pointsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem plikToolStripMenuItem;
        private ToolStripMenuItem zapiszToolStripMenuItem;
        private ToolStripMenuItem raportyToolStripMenuItem;
        private ToolStripMenuItem raportTrasyToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button addPointButton;
        private Button removePointButton;
        private DataGridView pointsDataGridView;
        private Button editPointButton;
    }
}