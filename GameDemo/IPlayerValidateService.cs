using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    interface IPlayerValidateService
    {
        bool checkIfPersonPlayer(Player player);
    }
}
