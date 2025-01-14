namespace AlgProj
{
    partial class AddDeliveryPointForm
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
            saveButton = new Button();
            cancelButton = new Button();
            pointNameLabel = new Label();
            nameTextBox = new TextBox();
            mapPictureBox = new PictureBox();
            xTextBox = new TextBox();
            yTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            positionGroupBox = new GroupBox();
            nameLabelError = new Label();
            pointLabelError = new Label();
            ((System.ComponentModel.ISupportInitialize)mapPictureBox).BeginInit();
            positionGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Location = new System.Drawing.Point(492, 433);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 0;
            saveButton.Text = "Zapisz";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new System.Drawing.Point(411, 433);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Anuluj";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // pointNameLabel
            // 
            pointNameLabel.AutoSize = true;
            pointNameLabel.Location = new System.Drawing.Point(12, 27);
            pointNameLabel.Name = "pointNameLabel";
            pointNameLabel.Size = new Size(130, 15);
            pointNameLabel.TabIndex = 2;
            pointNameLabel.Text = "Nazwa punktu dostawy";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new System.Drawing.Point(12, 45);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(149, 23);
            nameTextBox.TabIndex = 3;
            // 
            // mapPictureBox
            // 
            mapPictureBox.BorderStyle = BorderStyle.FixedSingle;
            mapPictureBox.Image = Properties.Resources.map_image;
            mapPictureBox.Location = new System.Drawing.Point(167, 27);
            mapPictureBox.Name = "mapPictureBox";
            mapPictureBox.Size = new Size(400, 400);
            mapPictureBox.TabIndex = 5;
            mapPictureBox.TabStop = false;
            mapPictureBox.Click += mapPictureBox_Click;
            // 
            // xTextBox
            // 
            xTextBox.Location = new System.Drawing.Point(6, 37);
            xTextBox.Name = "xTextBox";
            xTextBox.ReadOnly = true;
            xTextBox.Size = new Size(100, 23);
            xTextBox.TabIndex = 6;
            // 
            // yTextBox
            // 
            yTextBox.Location = new System.Drawing.Point(6, 81);
            yTextBox.Name = "yTextBox";
            yTextBox.ReadOnly = true;
            yTextBox.Size = new Size(100, 23);
            yTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 8;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 9;
            label2.Text = "Y";
            // 
            // positionGroupBox
            // 
            positionGroupBox.Controls.Add(yTextBox);
            positionGroupBox.Controls.Add(label1);
            positionGroupBox.Controls.Add(label2);
            positionGroupBox.Controls.Add(xTextBox);
            positionGroupBox.Location = new System.Drawing.Point(12, 103);
            positionGroupBox.Name = "positionGroupBox";
            positionGroupBox.Size = new Size(149, 122);
            positionGroupBox.TabIndex = 10;
            positionGroupBox.TabStop = false;
            positionGroupBox.Text = "Położenie";
            // 
            // nameLabelError
            // 
            nameLabelError.AutoSize = true;
            nameLabelError.ForeColor = Color.Red;
            nameLabelError.Location = new System.Drawing.Point(16, 74);
            nameLabelError.Name = "nameLabelError";
            nameLabelError.Size = new Size(0, 15);
            nameLabelError.TabIndex = 11;
            // 
            // pointLabelError
            // 
            pointLabelError.AutoSize = true;
            pointLabelError.ForeColor = Color.Red;
            pointLabelError.Location = new System.Drawing.Point(15, 235);
            pointLabelError.Name = "pointLabelError";
            pointLabelError.Size = new Size(0, 15);
            pointLabelError.TabIndex = 12;
            // 
            // AddDeliveryPointForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 465);
            Controls.Add(pointLabelError);
            Controls.Add(nameLabelError);
            Controls.Add(positionGroupBox);
            Controls.Add(mapPictureBox);
            Controls.Add(nameTextBox);
            Controls.Add(pointNameLabel);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Name = "AddDeliveryPointForm";
            Text = "Dodaj punkt dostawy";
            ((System.ComponentModel.ISupportInitialize)mapPictureBox).EndInit();
            positionGroupBox.ResumeLayout(false);
            positionGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private Button cancelButton;
        private Label pointNameLabel;
        private TextBox nameTextBox;
        private PictureBox mapPictureBox;
        private TextBox xTextBox;
        private TextBox yTextBox;
        private Label label1;
        private Label label2;
        private GroupBox positionGroupBox;
        private Label nameLabelError;
        private Label pointLabelError;
    }
}