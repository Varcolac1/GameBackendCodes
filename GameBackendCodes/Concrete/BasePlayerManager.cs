using GameBackendCodes.Abstract;
using GameBackendCodes.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendCodes.Concrete
{
    public class BasePlayerManager : IPlayerService, IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            return true;
        }

        public void DeleteAccount(Player player)
        {
            Console.WriteLine("Your account has been deleted!");
        }

        public void SingUp(Player player)
        {
            Console.WriteLine("Your account has been created!");
        }

        public void UpdateAccount(Player player)
        {
            Console.WriteLine("Your account has been Updated!");
        }

    }
}
