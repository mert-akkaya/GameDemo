using GameDemo.Entities;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player { Id = 1, FirstName = "Mert",
                LastName = "Akkaya", DateOfBirth = new DateTime(2000, 11, 21),
                NationalityId = "10061591058" };
            Game game1 = new Game { Id = 1, Name = "The Witcher 3", Cost = "80" };
            Campaign campaign1 = new Campaign { CampaignId = 1, CampaignDiscountRate = "%70" };

            PlayerManager playerManager = new PlayerManager(new MernisPlayerValidateManager());
            playerManager.Register(player1);
            GameSellManager gameSellManager = new GameSellManager();
            gameSellManager.Sell(game1, campaign1, player1);
        }
    }
}
