using GameBackendCodes.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendCodes.Abstract
{
    public interface IGameSellingService
    {
        void PublishGame(Games game, Publisher publisher);
        void DeleteGame(Games game, Publisher publisher);
        void UpdateGame(Games game, Publisher publisher);


    }
}
