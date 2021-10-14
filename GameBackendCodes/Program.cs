using GameBackendCodes.Concrete;
using GameBackendCodes.Entities;
using System;

namespace GameBackendCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            BasePlayerManager basePlayerManager = new BasePlayerManager();
            CampaigManager campaigManager = new CampaigManager();
            GameSellingManager gameSellingManager = new GameSellingManager();

            Player player1 = new Player();
            player1.NationalityId = "11111111";
            player1.PlayerName = "Mehmet Alper";
            player1.PlayerLastName = "Ekici";
            player1.BirthYear = 2003;

            Publisher publisher1 = new Publisher();
            publisher1.PublisherId = "123";
            publisher1.PublisherName = "Alper";

            Games game1 = new Games();
            game1.GameId = "123456";
            game1.GameName = "The Withcer 3";
            game1.GameCategory = "RPG";

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = "1234";
            campaign1.CampaignGame = "The Witcher 3";
            campaign1.CampaignExplanation = "is now %30 off!";
            

            if (basePlayerManager.CheckIfRealPerson(player1))
            {
                Console.WriteLine("Checked : Valid person");
                basePlayerManager.SingUp(player1);
            }
            else
            {
                throw new Exception("Not a valid person");
            }

            gameSellingManager.PublishGame(game1, publisher1);
            campaigManager.AddCampaign(campaign1);
            

            
           
        }
    }
}
