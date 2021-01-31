using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    interface IGameSellService
    {
        void Sell(Game game, Campaign campaign, Player player);
    }
}
