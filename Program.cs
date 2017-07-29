using System;

namespace FairyNames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------");
            Console.WriteLine("FairyNames");
            Console.WriteLine("----------");

            Console.WriteLine("Answer questions to reveal your fairy name!");
            Console.WriteLine();

            //Ask a question
            Console.Write("blue or yellow? ");
            var name = "bananna head";
            //Check for the answer
            var blueOrYellow = Console.ReadLine();
            switch (blueOrYellow)
            {
                case "blue":
                    Console.Write("winter or fall? ");
                    var winterOrFall = Console.ReadLine();
                    switch (winterOrFall)
                    {
                        case "winter":
                            Console.Write("snow or ice? ");
                            var snowOrIce = Console.ReadLine();
                            switch (snowOrIce)
                            {
                                case "snow":
                                    name = "Holly Happyfeather";
                                    break;
                                case "ice":
                                    name = "Snowdrop Coldweather";
                                    break;
                                default:
                                    Console.WriteLine($"'{snowOrIce}' is not a valid selection!");
                                    break;
                            }
                            break;
                        case "fall":
                            Console.Write("nuts or berries? ");
                            var nutsOrBerries = Console.ReadLine();
                            switch (nutsOrBerries)
                            {
                                case "nuts":
                                    name = "Acorn Leafytree";
                                    break;
                                case "berries":
                                    name = "Blackberry Yummybush";
                                    break;
                                default:
                                    Console.WriteLine($"'{nutsOrBerries}' is not a valid selection!");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine($"'{winterOrFall}' is not a valid selection!");
                            break;
                    }
                    break;
                case "yellow":
                    Console.Write("spring or summer? ");
                    var springOrSummer = Console.ReadLine();
                    switch (springOrSummer)
                    {
                        case "spring":
                            Console.Write("flowers or butterflies? ");
                            var flowersOrButterflies = Console.ReadLine();
                            switch (flowersOrButterflies)
                            {
                                case "flowers":
                                    name = "Tulip Rainbowsparkle";
                                    break;
                                case "butterflies":
                                    name = "Appleblossom Floatwings";
                                    break;
                                default:
                                    Console.WriteLine($"'{flowersOrButterflies}' is not a valid selection!");
                                    break;
                            }
                            break;
                        case "summer":
                            Console.Write("icecream or smores? ");
                            var icecreamOrSmores = Console.ReadLine();
                            switch (icecreamOrSmores)
                            {
                                case "icecream":
                                    name = "Rose Sunpetal";
                                    break;
                                case "smores":
                                    name = "Buttercup Sparkleson";
                                    break;
                                default:
                                    Console.WriteLine($"'{icecreamOrSmores}' is not a valid selection!");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine($"'{springOrSummer}' is not a valid selection!");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine($"'{blueOrYellow}' is not a valid selection!");
                    break;
            }

            //Decide a name
            Console.WriteLine($"Your name is {name}.");
        }
    }
}
