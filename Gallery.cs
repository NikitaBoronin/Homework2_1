using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Homework1
{
    public partial class Gallery : Form
    {
        private List<ImageInfo> images = new List<ImageInfo>();

        public Gallery()
        {
            InitializeComponent();
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;

                try
                {
                    var lines = File.ReadAllLines(openFileDialog.FileName);
                    images.Clear();
                    listBoxImages.Items.Clear();

                    foreach (var line in lines)
                    {
                        var parts = line.Split(',', 2);
                        if (parts.Length > 0)
                        {
                            var path = parts[0].Trim();
                            var title = parts.Length > 1 ? parts[1].Trim() : "";
                            images.Add(new ImageInfo { FilePath = path, Title = title });
                            listBoxImages.Items.Add(Path.GetFileName(path));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}");
                }
            }
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;

                string filePath = openFileDialog.FileName;

                var imageInfo = new ImageInfo
                {
                    FilePath = filePath,
                    Title = Path.GetFileNameWithoutExtension(filePath)
                };

                images.Add(imageInfo);
                listBoxImages.Items.Add(Path.GetFileName(filePath));
            }
        }



        private void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxImages.SelectedIndex;
            if (index < 0 || index >= images.Count)
                return;

            ImageInfo info = images[index];
            try
            {
                pictureBoxDisplayImage.Image = Image.FromFile(info.FilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}");
                pictureBoxDisplayImage.Image = null;
            }
            TitleNameTxtBox.Text = info.Title;
        }

        private void safeBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;

                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (ImageInfo info in images)
                        {
                            writer.WriteLine($"{info.FilePath},{info.Title}");
                        }
                    }
                    MessageBox.Show("Файл успешно сохранён!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}");
                }
            }
        }

        private void TitleNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            int index = listBoxImages.SelectedIndex;
            if (index >= 0 && index < images.Count)
            {
                images[index].Title = TitleNameTxtBox.Text;
            }
        }
    }

}
