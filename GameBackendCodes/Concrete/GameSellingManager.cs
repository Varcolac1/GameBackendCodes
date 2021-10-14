using GameBackendCodes.Abstract;
using GameBackendCodes.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendCodes.Concrete
{
    public class  GameSellingManager : IGameSellingService
    {
        public void DeleteGame(Games game, Publisher publisher)
        {
            Console.WriteLine("Your game " + game.GameName + " has been deleted from system." + publisher.PublisherName + ".");
        }

        public virtual void  UpdateGame(Games game, Publisher publisher)
        {
            Console.WriteLine("Your game " + game.GameName + " has been updated " + publisher.PublisherName + ".");
        }

        public void PublishGame(Games game, Publisher publisher)
        {
            Console.WriteLine("Your game " + game.GameName + " has been published " + publisher.PublisherName + ".");
        } 

        public void BuyGame(Games game, Player player)
        {
            Console.WriteLine("You have been bought " + game.GameName + " " + player.PlayerName + ".");
        }



               
    }
}
