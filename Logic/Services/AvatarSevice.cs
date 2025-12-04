using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Logic.Services
{
    internal class AvatarSevice : IAvatarService
    {
        private readonly string root = "../../avatars";

        public string GetAvatarPath(int userId)
        {
            return Path.Combine(root, userId.ToString(), "avatar.png");
        }

        public Image LoadAvatar(int userId)
        {
            string path = GetAvatarPath(userId);
            return File.Exists(path) ? Image.FromFile(path) : null;
        }

        public void SaveAvatar(int userId, Image image)
        {
            string folder = Path.Combine(root, userId.ToString());
            Directory.CreateDirectory(folder);

            string path = GetAvatarPath(userId);

            image.Save(path);
        }

        public void DeleteAvatar(int userId)
        {
            string path = GetAvatarPath(userId);
            if (File.Exists(path))
                File.Delete(path);
        }
    }
}
