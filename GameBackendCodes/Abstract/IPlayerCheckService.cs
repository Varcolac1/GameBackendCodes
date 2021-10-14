using GameBackendCodes.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendCodes.Abstract
{
    public interface IPlayerCheckService
    {
        bool CheckIfRealPerson(Player player);
    }
}
