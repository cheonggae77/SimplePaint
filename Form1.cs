
namespace SimplePaint
{

    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Imaging;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        enum ToolType { Line, Rectangle, Circle } // 사용할 도형 타입

        private Bitmap canvasBitmap; // 실제 그림이 저장되는 비트맵
        private Graphics canvasGraphics; // 비트맵 위에 그리기 위한객체

        private bool isDrawing = false; // 현재 드래그 중인지 여부
        private Point startPoint; // 드래그 시작점
        private Point endPoint; // 드래그 끝점

        private ToolType currentTool = ToolType.Line; // 현재 선택된 도형
        private Color currentColor = Color.Black; // 현재 색상
        private int currentLineWidth = 2; // 현재 선 두께
        public Form1()
        {
            InitializeComponent();

            // 캔버스 초기화
            canvasBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.Clear(Color.White); // 캔버스를 흰색으로 초기화
            picCanvas.Image = canvasBitmap; // 그린 그림을 화면(PictureBox)에표시

            // 마우스 이벤트 연결
            picCanvas.MouseDown += PicCanvas_MouseDown;
            picCanvas.MouseMove += PicCanvas_MouseMove;
            picCanvas.MouseUp += PicCanvas_MouseUp;

            // picCanvas가 다시 그려질 때 PicCanvas_Paint 함수를 실행하도록 연결
            picCanvas.Paint += PicCanvas_Paint;

            // 도형 선택 버튼 이벤트 연결
            btnLine.Click += btnLine_Click;
            btnRectangle.Click += btnRectangle_Click;
            btnCircle.Click += btnCircle_Click;

            // 색상 콤보박스 이벤트 연결
            cmbColor.SelectedIndexChanged += cmbColor_SelectedIndexChanged;
            cmbColor.SelectedIndex = 0; // 기본값: Black

            // 선 두께 트랙바 이벤트 연결
            trbLineWidth.Minimum = 1; // 최소값
            trbLineWidth.Maximum = 10; // 최대값
            trbLineWidth.Value = 5;
            trbLineWidth.ValueChanged += trbLineWidth_ValueChanged;

            btnSaveFile.Click += BtnSaveFile_Click;
            btnOpenFile.Click += BtnOpenFile_Click;
            btnPlus.Click += BtnPlus_Click;
            btnMinus.Click += BtnMinus_Click;

            // 스크롤바를 지원하기 위한 설정 (AutoScroll 가능성을 위해 패널 내부에 picCanvas가 있다고 가정하거나 크기 모드 변경)
            // 여기서는 picCanvas의 Mode를 설정합니다. 스크롤바는 AutoScroll이 켜져있는 부모 컨테이너(Form 등)에서 작동합니다.
            this.AutoScroll = true;
            picCanvas.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void PicCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true; // 드래그 시작
            startPoint = e.Location; // 시작점 저장
        }
        private void PicCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return; // 그림 그리기와 상관 없는 마우스 움직임은무시

            endPoint = e.Location; // 현재 위치 갱신

            // picCanvas를 다시 그려라 (Paint 이벤트를 발생시킨다)
            picCanvas.Invalidate(); // 화면 다시 그리기 (미리보기)
        }

        private void PicCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isDrawing) return; // 그림 그리기와 상관 없는 마우스 움직임은무시
            isDrawing = false; // 드래그 종료
            endPoint = e.Location;
            // 실제 비트맵에 도형 그리기 (확정)
            using (Pen pen = new Pen(currentColor, currentLineWidth))
            {
                DrawShape(canvasGraphics, pen, startPoint, endPoint);
            }
            picCanvas.Invalidate(); // 다시 그려서 결과 반영, Paint 이벤트 발생}
        }
        private void PicCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (!isDrawing) return;
            // 점선 펜 (미리보기용)
            using (Pen previewPen = new Pen(currentColor, currentLineWidth))
            {
                previewPen.DashStyle = DashStyle.Dash;
                DrawShape(e.Graphics, previewPen, startPoint, endPoint);
            }
        }
        private void DrawShape(Graphics g, Pen pen, Point p1, Point p2)
        {
            Rectangle rect = GetRectangle(p1, p2);
            switch (currentTool)
            {
                case ToolType.Line:
                    g.DrawLine(pen, p1, p2);
                    break;
                case ToolType.Rectangle:
                    g.DrawRectangle(pen, rect);
                    break;
                case ToolType.Circle:
                    g.DrawEllipse(pen, rect);
                    break;
            }
        }
        private Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(
            Math.Min(p1.X, p2.X),
            Math.Min(p1.Y, p2.Y),
            Math.Abs(p1.X - p2.X),
            Math.Abs(p1.Y - p2.Y)
            );
        }
        private void btnLine_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Line;
        }
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Rectangle;
        }
        private void btnCircle_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Circle;
        }
        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbColor.SelectedIndex)
            {
                case 0: // Black 검정
                    currentColor = Color.Black;
                    break;
                case 1: // Red 빨강
                    currentColor = Color.Red;
                    break;
                case 2: // Blue 파랑
                    currentColor = Color.Blue;
                    break;
                case 3: // Green 녹색
                    currentColor = Color.Green;
                    break;
                default:
                    currentColor = Color.Black;
                    break;
            }
        }

        private void trbLineWidth_ValueChanged(object sender, EventArgs e)
        {
            currentLineWidth = trbLineWidth.Value;
        }

        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                saveFileDialog.Title = "Save an Image File";
                saveFileDialog.DefaultExt = "png";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (saveFileDialog.FileName != "")
                    {
                        ImageFormat format = ImageFormat.Png; // Default

                        switch (saveFileDialog.FilterIndex)
                        {
                            case 1:
                                format = ImageFormat.Png;
                                break;
                            case 2:
                                format = ImageFormat.Jpeg;
                                break;
                            case 3:
                                format = ImageFormat.Bmp;
                                break;
                        }

                        canvasBitmap.Save(saveFileDialog.FileName, format);
                    }
                }
            }
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp;*.gif";
                openFileDialog.Title = "Open an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (string.IsNullOrWhiteSpace(openFileDialog.FileName))
                        return;

                    try
                    {
                        // 기존 리소스 백업
                        Bitmap oldBitmap = canvasBitmap;
                        Graphics oldGraphics = canvasGraphics;
                        Image oldImage = picCanvas.Image;

                        // 새 이미지를 로드하고 canvasBitmap에 할당
                        using (Image openedImage = Image.FromFile(openFileDialog.FileName))
                        {
                            canvasBitmap = new Bitmap(openedImage);
                            canvasGraphics = Graphics.FromImage(canvasBitmap);

                            // PictureBox 크기를 이미지에 맞춤
                            picCanvas.Width = canvasBitmap.Width;
                            picCanvas.Height = canvasBitmap.Height;

                            picCanvas.Image = canvasBitmap;
                        }

                        // 새 이미지 할당 성공 후, 기존 리소스 안전하게 해제
                        if (oldImage != null && oldImage != oldBitmap) oldImage.Dispose();
                        oldGraphics?.Dispose();
                        oldBitmap?.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error opening file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Zoom(float factor)
        {
            if (canvasBitmap == null) return;

            try
            {
                int newWidth = (int)(canvasBitmap.Width * factor);
                int newHeight = (int)(canvasBitmap.Height * factor);

                // 너무 작거나 너무 큰 이미지 방지 (GDI+ 예외 방지)
                if (newWidth < 10 || newHeight < 10 || newWidth > 10000 || newHeight > 10000) return;

                // 새로운 크기의 비트맵 생성
                Bitmap newBitmap = new Bitmap(newWidth, newHeight);

                using (Graphics g = Graphics.FromImage(newBitmap))
                {
                    // 고품질 보간 설정
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.DrawImage(canvasBitmap, 0, 0, newWidth, newHeight);
                }

                // 기존 리소스를 보관
                Bitmap oldBitmap = canvasBitmap;
                Graphics oldGraphics = canvasGraphics;

                // 새 리소스 할당
                canvasBitmap = newBitmap;
                canvasGraphics = Graphics.FromImage(newBitmap);

                // PictureBox에 새 이미지를 먼저 할당하여 크래시 방지
                picCanvas.Image = canvasBitmap;
                picCanvas.Width = newWidth;
                picCanvas.Height = newHeight;

                // 이제 기존 리소스 안전하게 해제
                oldGraphics?.Dispose();
                oldBitmap?.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("이미지 크기를 변경하는 중 오류가 발생했습니다: " + ex.Message, "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            Zoom(1.2f); // 20% 확대
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            Zoom(0.8f); // 20% 축소
        }


    }
}