using GameDemo.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    class MernisPlayerValidateManager : IPlayerValidateService
    {
        public bool checkIfPersonPlayer(Player player)
        {
            return TaskAsync(player).Result;
        }
        
        public static async Task<bool> TaskAsync(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var status = await (client.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.NationalityId), player.FirstName.ToUpper(), player.LastName.ToUpper(), player.DateOfBirth.Year));

            return status.Body.TCKimlikNoDogrulaResult;
        }
    }
}
