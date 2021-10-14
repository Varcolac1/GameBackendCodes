using GameBackendCodes.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendCodes.Abstract
{
    public interface IPlayerService
    {
        void SingUp(Player player);
        void UpdateAccount(Player player);
        void DeleteAccount(Player player);
    }
}
