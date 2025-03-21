namespace Homework1
{
    partial class Gallery
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
            pictureBoxForShow = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            pictureBoxDisplayImage = new PictureBox();
            listBoxImages = new ListBox();
            TitleNameTxtBox = new TextBox();
            downloadBtn = new Button();
            safeBtn = new Button();
            saveFileDialog1 = new SaveFileDialog();
            imageLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            OpenBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDisplayImage).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxForShow
            // 
            pictureBoxForShow.Image = Properties.Resources.image;
            pictureBoxForShow.Location = new Point(12, 80);
            pictureBoxForShow.Name = "pictureBoxForShow";
            pictureBoxForShow.Size = new Size(131, 112);
            pictureBoxForShow.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxForShow.TabIndex = 0;
            pictureBoxForShow.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBoxDisplayImage
            // 
            pictureBoxDisplayImage.Location = new Point(185, 51);
            pictureBoxDisplayImage.Name = "pictureBoxDisplayImage";
            pictureBoxDisplayImage.Size = new Size(280, 256);
            pictureBoxDisplayImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDisplayImage.TabIndex = 1;
            pictureBoxDisplayImage.TabStop = false;
            // 
            // listBoxImages
            // 
            listBoxImages.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBoxImages.Cursor = Cursors.Hand;
            listBoxImages.FormattingEnabled = true;
            listBoxImages.Location = new Point(634, 23);
            listBoxImages.Name = "listBoxImages";
            listBoxImages.Size = new Size(216, 304);
            listBoxImages.TabIndex = 2;
            listBoxImages.SelectedIndexChanged += listBoxImages_SelectedIndexChanged;
            // 
            // TitleNameTxtBox
            // 
            TitleNameTxtBox.Location = new Point(12, 472);
            TitleNameTxtBox.Name = "TitleNameTxtBox";
            TitleNameTxtBox.Size = new Size(681, 27);
            TitleNameTxtBox.TabIndex = 4;
            TitleNameTxtBox.TextChanged += TitleNameTxtBox_TextChanged;
            // 
            // downloadBtn
            // 
            downloadBtn.Cursor = Cursors.Hand;
            downloadBtn.Location = new Point(482, 23);
            downloadBtn.Name = "downloadBtn";
            downloadBtn.Size = new Size(117, 140);
            downloadBtn.TabIndex = 5;
            downloadBtn.Text = "Загрузить изображение";
            downloadBtn.UseVisualStyleBackColor = true;
            downloadBtn.Click += downloadBtn_Click;
            // 
            // safeBtn
            // 
            safeBtn.Cursor = Cursors.Hand;
            safeBtn.Location = new Point(482, 180);
            safeBtn.Name = "safeBtn";
            safeBtn.Size = new Size(117, 127);
            safeBtn.TabIndex = 6;
            safeBtn.Text = "Сохранить изображение в файл.txt";
            safeBtn.UseVisualStyleBackColor = true;
            safeBtn.Click += safeBtn_Click;
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            imageLabel.Location = new Point(2, 10);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new Size(201, 38);
            imageLabel.TabIndex = 7;
            imageLabel.Text = "Изображение:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(629, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 8;
            label1.Text = "Выбор изображений:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 411);
            label2.Name = "label2";
            label2.Size = new Size(361, 41);
            label2.TabIndex = 9;
            label2.Text = "Заголовок изображения:";
            // 
            // OpenBtn
            // 
            OpenBtn.Location = new Point(634, 338);
            OpenBtn.Name = "OpenBtn";
            OpenBtn.Size = new Size(211, 56);
            OpenBtn.TabIndex = 10;
            OpenBtn.Text = "Добавить изображение";
            OpenBtn.UseVisualStyleBackColor = true;
            OpenBtn.Click += OpenBtn_Click;
            // 
            // Gallery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 201, 245);
            ClientSize = new Size(847, 511);
            Controls.Add(OpenBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(imageLabel);
            Controls.Add(safeBtn);
            Controls.Add(downloadBtn);
            Controls.Add(TitleNameTxtBox);
            Controls.Add(listBoxImages);
            Controls.Add(pictureBoxDisplayImage);
            Controls.Add(pictureBoxForShow);
            Name = "Gallery";
            Text = "Gallery";
            ((System.ComponentModel.ISupportInitialize)pictureBoxForShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDisplayImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxForShow;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBoxDisplayImage;
        private ListBox listBoxImages;
        private TextBox TitleNameTxtBox;
        private Button downloadBtn;
        private Button safeBtn;
        private SaveFileDialog saveFileDialog1;
        private Label imageLabel;
        private Label label1;
        private Label label2;
        private Button OpenBtn;
    }
}
