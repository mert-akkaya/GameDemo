using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class PlayerManager : IPlayerService
    {
        private IPlayerValidateService _playerValidateService;
        public PlayerManager(IPlayerValidateService playerValidateService)
        {
            _playerValidateService = playerValidateService;
        }
        public void Delete(Player player)
        {
            Console.WriteLine("Player information deleted");
        }

        public void Register(Player player)
        {
            if (_playerValidateService.checkIfPersonPlayer(player))
            {
                 Console.WriteLine("Registered in system");
                Console.WriteLine("Welcome : "+player.FirstName);
            }
            else
            {
                throw new Exception("Player is not valid");
            }
           
        }

        public void Update(Player player)
        {
            Console.WriteLine("player information updated");
        }
    }
}
