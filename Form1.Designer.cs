namespace task5
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
            XTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            YTextBox = new TextBox();
            AddNodeButton = new Button();
            panel1 = new Panel();
            ClearNodeListButton = new Button();
            ClearImageButton = new Button();
            DrawNodes = new Button();
            panel3 = new Panel();
            NodesTextBox = new TextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // XTextBox
            // 
            XTextBox.Location = new Point(24, 3);
            XTextBox.Name = "XTextBox";
            XTextBox.Size = new Size(112, 23);
            XTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 6);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 1;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 35);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 3;
            label2.Text = "Y";
            // 
            // YTextBox
            // 
            YTextBox.Location = new Point(24, 32);
            YTextBox.Name = "YTextBox";
            YTextBox.Size = new Size(112, 23);
            YTextBox.TabIndex = 2;
            // 
            // AddNodeButton
            // 
            AddNodeButton.Location = new Point(24, 61);
            AddNodeButton.Name = "AddNodeButton";
            AddNodeButton.Size = new Size(112, 23);
            AddNodeButton.TabIndex = 4;
            AddNodeButton.Text = "Add node";
            AddNodeButton.UseVisualStyleBackColor = true;
            AddNodeButton.Click += AddNodeButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(ClearNodeListButton);
            panel1.Controls.Add(ClearImageButton);
            panel1.Controls.Add(DrawNodes);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(AddNodeButton);
            panel1.Controls.Add(XTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(YTextBox);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(155, 450);
            panel1.TabIndex = 5;
            // 
            // ClearNodeListButton
            // 
            ClearNodeListButton.Location = new Point(24, 148);
            ClearNodeListButton.Name = "ClearNodeListButton";
            ClearNodeListButton.Size = new Size(112, 23);
            ClearNodeListButton.TabIndex = 8;
            ClearNodeListButton.Text = "Clear node list";
            ClearNodeListButton.UseVisualStyleBackColor = true;
            ClearNodeListButton.Click += ClearNodeListButton_Click;
            // 
            // ClearImageButton
            // 
            ClearImageButton.Location = new Point(24, 119);
            ClearImageButton.Name = "ClearImageButton";
            ClearImageButton.Size = new Size(112, 23);
            ClearImageButton.TabIndex = 7;
            ClearImageButton.Text = "Clear image";
            ClearImageButton.UseVisualStyleBackColor = true;
            ClearImageButton.Click += ClearImageButton_Click;
            // 
            // DrawNodes
            // 
            DrawNodes.Location = new Point(24, 90);
            DrawNodes.Name = "DrawNodes";
            DrawNodes.Size = new Size(112, 23);
            DrawNodes.TabIndex = 6;
            DrawNodes.Text = "Draw";
            DrawNodes.UseVisualStyleBackColor = true;
            DrawNodes.Click += DrawNodes_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(NodesTextBox);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 186);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 264);
            panel3.TabIndex = 5;
            // 
            // NodesTextBox
            // 
            NodesTextBox.Dock = DockStyle.Fill;
            NodesTextBox.Location = new Point(0, 0);
            NodesTextBox.Multiline = true;
            NodesTextBox.Name = "NodesTextBox";
            NodesTextBox.Size = new Size(155, 264);
            NodesTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(155, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(645, 450);
            panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(645, 450);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox XTextBox;
        private Label label1;
        private Label label2;
        private TextBox YTextBox;
        private Button AddNodeButton;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button ClearImageButton;
        private Button DrawNodes;
        private Panel panel3;
        private TextBox NodesTextBox;
        private Button ClearNodeListButton;
    }
}
