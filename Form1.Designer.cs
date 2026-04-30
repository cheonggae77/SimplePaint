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
            btnRectangle = new Button();
            btnCircle = new Button();
            btnLine = new Button();
            lblAppName = new Label();
            groupBox2 = new GroupBox();
            cmbColor = new ComboBox();
            groupBox3 = new GroupBox();
            trbLineWidth = new TrackBar();
            picCanvas = new PictureBox();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRectangle);
            groupBox1.Controls.Add(btnCircle);
            groupBox1.Controls.Add(btnLine);
            groupBox1.Location = new Point(26, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(310, 104);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "도형 선택";
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
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.BackColor = SystemColors.Control;
            lblAppName.Font = new Font("맑은 고딕", 30F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.Blue;
            lblAppName.Location = new Point(17, 18);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(328, 67);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "Simple Paint";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbColor);
            groupBox2.Location = new Point(342, 98);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(186, 99);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "색 선택";
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "Black 검정", "Red 빨강", "Blue 파랑", "Green 녹색" });
            cmbColor.Location = new Point(17, 42);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(151, 28);
            cmbColor.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(trbLineWidth);
            groupBox3.Location = new Point(534, 98);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(224, 99);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "선 두께";
            // 
            // trbLineWidth
            // 
            trbLineWidth.Location = new Point(6, 35);
            trbLineWidth.Name = "trbLineWidth";
            trbLineWidth.Size = new Size(212, 56);
            trbLineWidth.TabIndex = 0;
            // 
            // picCanvas
            // 
            picCanvas.Location = new Point(17, 208);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(1042, 627);
            picCanvas.TabIndex = 3;
            picCanvas.TabStop = false;
            // 
            // btnOpenFile
            // 
            btnOpenFile.BackColor = Color.PeachPuff;
            btnOpenFile.Font = new Font("맑은 고딕", 18F);
            btnOpenFile.Location = new Point(825, 123);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(106, 74);
            btnOpenFile.TabIndex = 4;
            btnOpenFile.Text = "열기";
            btnOpenFile.UseVisualStyleBackColor = false;
            // 
            // btnSaveFile
            // 
            btnSaveFile.BackColor = Color.Gold;
            btnSaveFile.Font = new Font("맑은 고딕", 18F);
            btnSaveFile.Location = new Point(950, 123);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(109, 74);
            btnSaveFile.TabIndex = 5;
            btnSaveFile.Text = "저장";
            btnSaveFile.UseVisualStyleBackColor = false;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.ActiveCaption;
            btnPlus.Font = new Font("맑은 고딕", 20F);
            btnPlus.Location = new Point(825, 24);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(88, 69);
            btnPlus.TabIndex = 6;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.Green;
            btnMinus.Font = new Font("맑은 고딕", 20F);
            btnMinus.Location = new Point(950, 24);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(88, 69);
            btnMinus.TabIndex = 7;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 853);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Controls.Add(picCanvas);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(lblAppName);
            Controls.Add(groupBox1);
            Name = "Form1";
            Padding = new Padding(5);
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
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
        private ComboBox cmbColor;
        private TrackBar trbLineWidth;
        private PictureBox picCanvas;
        private Button btnOpenFile;
        private Button btnSaveFile;
        private Button btnPlus;
        private Button btnMinus;
    }
}
