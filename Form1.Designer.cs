namespace SimplePaint
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
            groupBox1 = new GroupBox();
            lblAppName = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btnLine = new Button();
            btnCircle = new Button();
            btnRectangle = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRectangle);
            groupBox1.Controls.Add(btnCircle);
            groupBox1.Controls.Add(btnLine);
            groupBox1.Location = new Point(62, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(310, 104);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "도형 선택";
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.BackColor = SystemColors.Control;
            lblAppName.Font = new Font("맑은 고딕", 30F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.Blue;
            lblAppName.Location = new Point(38, 24);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(328, 67);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "Simple Paint";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(378, 124);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(186, 99);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "색 선택";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(570, 124);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(224, 99);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "선 두께";
            // 
            // btnLine
            // 
            btnLine.Dock = DockStyle.Left;
            btnLine.Font = new Font("맑은 고딕", 10F);
            btnLine.Image = Properties.Resources.선;
            btnLine.ImageAlign = ContentAlignment.TopCenter;
            btnLine.Location = new Point(5, 25);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(100, 74);
            btnLine.TabIndex = 0;
            btnLine.Text = "직선";
            btnLine.TextAlign = ContentAlignment.BottomCenter;
            btnLine.UseVisualStyleBackColor = true;
            // 
            // btnCircle
            // 
            btnCircle.Dock = DockStyle.Right;
            btnCircle.Font = new Font("맑은 고딕", 10F);
            btnCircle.Image = Properties.Resources.동그라미;
            btnCircle.ImageAlign = ContentAlignment.TopCenter;
            btnCircle.Location = new Point(205, 25);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(100, 74);
            btnCircle.TabIndex = 1;
            btnCircle.Text = "원";
            btnCircle.TextAlign = ContentAlignment.BottomCenter;
            btnCircle.UseVisualStyleBackColor = true;
            // 
            // btnRectangle
            // 
            btnRectangle.Dock = DockStyle.Fill;
            btnRectangle.Font = new Font("맑은 고딕", 10F);
            btnRectangle.Image = Properties.Resources.사각형;
            btnRectangle.ImageAlign = ContentAlignment.TopCenter;
            btnRectangle.Location = new Point(105, 25);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(100, 74);
            btnRectangle.TabIndex = 2;
            btnRectangle.Text = "사각형";
            btnRectangle.TextAlign = ContentAlignment.BottomCenter;
            btnRectangle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 853);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(lblAppName);
            Controls.Add(groupBox1);
            Name = "Form1";
            Padding = new Padding(5);
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblAppName;
        private Button btnLine;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnRectangle;
        private Button btnCircle;
    }
}
