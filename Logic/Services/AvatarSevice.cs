using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Logic.Services
{
    public class AvatarSevice : IAvatarService
    {
        private readonly string root;
        private readonly string defaultAvatarPath;

        public AvatarSevice()
        {
            // Находим корень решения, поднимаясь вверх от папки исполняемого файла
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Поднимаемся вверх по каталогам, пока не найдем папку с .sln файлом
            DirectoryInfo? currentDir = new DirectoryInfo(baseDirectory);
            while (currentDir != null && !Directory.GetFiles(currentDir.FullName, "*.sln").Any())
            {
                currentDir = currentDir.Parent;
            }

            // Если нашли корень решения - используем его, иначе используем baseDirectory
            string solutionRoot = currentDir?.FullName ?? baseDirectory;

            root = Path.Combine(solutionRoot, "avatars");
            defaultAvatarPath = Path.Combine(root, "unnamed.jpg");

            // Создаём папку, если её нет
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
        }

        public string GetAvatarPath(int userId)
        {
            return Path.Combine(root, userId.ToString(), "avatar.jpg");
        }

        public Image LoadAvatar(int userId)
        {
            string path = GetAvatarPath(userId);

            // Если у пользователя есть своя аватарка - загружаем её
            if (File.Exists(path))
            {
                return Image.FromFile(path);
            }

            // Если нет своей аватарки - загружаем дефолтную
            if (File.Exists(defaultAvatarPath))
            {
                return Image.FromFile(defaultAvatarPath);
            }

            // Если нет даже дефолтной - возвращаем null
            return null;
        }

        public void SaveAvatar(int userId, Image image)
        {
            string folder = Path.Combine(root, userId.ToString());

            // Создаём папку пользователя, если её нет
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            string path = GetAvatarPath(userId);

            // Сохраняем как JPEG
            var jpegEncoder = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders()
                .FirstOrDefault(e => e.FormatID == System.Drawing.Imaging.ImageFormat.Jpeg.Guid);

            if (jpegEncoder != null)
            {
                var encoderParameters = new System.Drawing.Imaging.EncoderParameters(1);
                encoderParameters.Param[0] = new System.Drawing.Imaging.EncoderParameter(
                    System.Drawing.Imaging.Encoder.Quality, 90L);
                image.Save(path, jpegEncoder, encoderParameters);
            }
            else
            {
                // Если не нашли JPEG кодек, сохраняем напрямую
                image.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        public void DeleteAvatar(int userId)
        {
            string path = GetAvatarPath(userId);
            if (File.Exists(path))
                File.Delete(path);
        }
    }
}
