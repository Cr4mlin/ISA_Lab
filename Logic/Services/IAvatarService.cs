using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Logic.Services
{
    public interface IAvatarService
    {
        void SaveAvatar(int userid, Image image);
        Image LoadAvatar(int userid);
        string GetAvatarPath(int userid);
    }
}
