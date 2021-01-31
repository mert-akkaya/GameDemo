using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class GameSellManager : IGameSellService
    {
        public void Sell(Game game, Campaign campaign, Player player)
        {
            Console.WriteLine(game.Name+ " for today " +campaign.CampaignDiscountRate + " with rate for : " +player.FirstName +" " +player.LastName );
        }
    }
}
