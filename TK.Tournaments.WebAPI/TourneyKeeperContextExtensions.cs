using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TK.Tournaments.WebAPI.Entities;
using TourneyKeeper.Entities;

namespace TK.Tournaments.WebAPI
{
    public static class TourneyKeeperContextExtensions
    {
        public static void EnsureSeedDataForContext(this TourneyKeeperContext context)
        {
            if (context.Tournaments.Any())
            {
                return;
            }

            var tournaments = new List<Tournament>()
            {
                new Tournament()
                {
                    Name = "SOS Gdansk 2018",
                    City = "Gdansk",
                    Country = "Poland",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now.AddDays(1),
                    Price = 125,
                    Currency = "PLN",
                    SwissRounds = 6,
                    IfTopCut = false,
                    IfProgressiveCut = true,
                    WinsNeededForProgressiveCut = 5,
                    Venue = "Amber Expo",
                    Adress = "Rzemieslnicza 78/8",
                    StreamLink = "https://www.youtube.com/watch?v=Lm4a6-V1jeQ",
                    Description = "Lorem ipsum"
                },
                new Tournament()
                {
                    Name = "Bydgoszcz store",
                    City = "Bydgoszcz",
                    Country = "Poland",
                    StartDateTime = DateTime.Now,
                    EndDateTime = DateTime.Now.AddDays(1),
                    Price = 30,
                    Currency = "PLN",
                    SwissRounds = 4,
                    IfTopCut = true,
                    SizeOfTopCut = 4,
                    IfProgressiveCut = false,
                    Venue = "Sklep Pegaz",
                    Adress = "Gdansak 234",
                    StreamLink = string.Empty,
                    Description =
                        "Zapraszam wszystkich serdecznie na Mistrzostwa Sklepu w Bydgoszczy!\r\n\r\nUWAGA!!! Turniej będzie zorganizowany na zasadach Drugiej Edycji!!!\r\n\r\nGramy 4 rundy + top4:\r\n08.30 - 09.30 - zapisy\r\n09.45 - 11.00 - I runda\r\n11.10 - 12.25 - II runda\r\n12.35 - 13.50 - III runda\r\n13.50 - 14.30 - przerwa obiadowa\r\n14.35 - 15.50 - IV runda\r\n16.00 - 17.15 - top4\r\n17.25 - ... - finał\r\n\r\nWejściówka na turniej kosztuje 30 zł (w prerejestracji, przelew do poniedziałku 10.12.2018) lub 40 zł (przelew od wtorku 11.12.2018 oraz płatne na miejscu).\r\n\r\nDane do wpłaty:\r\nKarol Pruszkowski\r\n25 1750 0012 0000 0000 2984 3546\r\nw tytule wpiszcie: BSC18 i imię oraz nazwisko zgłoszonych graczy\r\n\r\nW razie pytań możecie mnie złapać przez fb, mailem: karol.pruszkowski@gmail.com lub telefonicznie 726-385-098"
                }
            };

            context.Tournaments.AddRange(tournaments);
            context.SaveChanges();
        }
    }
}
