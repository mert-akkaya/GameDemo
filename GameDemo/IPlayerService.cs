using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    interface IPlayerService
    {
        void Register(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}
