
using Days.Shared;
using System.Collections.Generic;
using System.Linq;

namespace AOC_2016
{
    public class Day10
    {
        public static int PartOne(string[] input)
        {
            Dictionary<int, Bot> botCreation = new Dictionary<int, Bot>();
            foreach (var item in input)
            {
                if (item.StartsWith("value"))
                {
                    string[] vs = item.Split(" ");
                    var value = int.Parse(vs[1]);
                    var botID = int.Parse(vs[5]);
                    if (botCreation.ContainsKey(botID))
                    {
                        botCreation[botID].Chips.Add(value);
                    }
                    else
                    {
                        botCreation.Add(botID, new Bot(botID));
                        botCreation[botID].Chips.Add(value);
                    }
                }
                else
                {
                    string[] vs = item.Split(" ");
                    var botID = int.Parse(vs[1]);
                    var lowBotId = int.Parse(vs[6]);
                    var highBotId = int.Parse(vs[11]);
                    Bot lowBot;
                    Bot highBot;

                    if (vs[5].Equals("bot"))
                    {


                        if (botCreation.ContainsKey(lowBotId))
                        {
                            lowBot = botCreation[lowBotId];
                        }
                        else
                        {
                            lowBot = new Bot(lowBotId);
                            botCreation.Add(lowBotId, lowBot);
                        }
                    }
                    else
                    {
                        lowBot = null;
                    }

                    if (vs[10].Equals("bot"))
                    {
                        if (botCreation.ContainsKey(highBotId))
                        {
                            highBot = botCreation[highBotId];
                        }
                        else
                        {
                            highBot = new Bot(highBotId);
                            botCreation.Add(highBotId, highBot);
                        }
                    }
                    else
                    {
                        highBot = null;
                    }

                    if (botCreation.ContainsKey(botID))
                    {
                        botCreation[botID].LowBot = lowBot;
                        botCreation[botID].HighBot = highBot;
                    }
                    else
                    {
                        botCreation.Add(botID, new Bot(botID));
                        botCreation[botID].LowBot = lowBot;
                        botCreation[botID].HighBot = highBot;
                    }
                }
            }
            List<Bot> bots = botCreation.Values.OrderByDescending(a => a.Chips.Count).ToList();
            if (bots.Count < 10)
            {
                return 0;
            }
            while (true)
            {
                var curCount = bots.OrderByDescending(a => a.Chips.Count).ToList();
                var bot = curCount.First();
                if (bot.Chips.Count != 2)
                {
                    return -1;
                }
                if (bot.Chips[0] == 61 && bot.Chips[1] == 17 ||
                    bot.Chips[0] == 17 && bot.Chips[1] == 61)
                {
                    return bot.ID;
                }
                if (bot.Chips[0] < bot.Chips[1])
                {
                    if (bot.LowBot != null)
                    {
                        bot.LowBot.Chips.Add(bot.Chips[0]);
                    }
                    if (bot.HighBot != null)
                    {
                        bot.HighBot.Chips.Add(bot.Chips[1]);
                    }
                }
                else
                {
                    if (bot.LowBot != null)
                    {
                        bot.LowBot.Chips.Add(bot.Chips[1]);
                    }
                    if (bot.HighBot != null)
                    {
                        bot.HighBot.Chips.Add(bot.Chips[0]);
                    }
                }
                bot.Chips.Clear();
            }
        }

        public static int PartTwo(string[] input)
        {
            Dictionary<int, Bot> botCreation = new Dictionary<int, Bot>();
            Dictionary<int, Bot> outputCreation = new Dictionary<int, Bot>();
            foreach (var item in input)
            {
                if (item.StartsWith("value"))
                {
                    string[] vs = item.Split(" ");
                    var value = int.Parse(vs[1]);
                    var botID = int.Parse(vs[5]);
                    if (botCreation.ContainsKey(botID))
                    {
                        botCreation[botID].Chips.Add(value);
                    }
                    else
                    {
                        botCreation.Add(botID, new Bot(botID));
                        botCreation[botID].Chips.Add(value);
                    }
                }
                else
                {
                    string[] vs = item.Split(" ");
                    var botID = int.Parse(vs[1]);
                    var lowBotId = int.Parse(vs[6]);
                    var highBotId = int.Parse(vs[11]);
                    Bot lowBot;
                    Bot highBot;

                    if (vs[5].Equals("bot"))
                    {
                        if (botCreation.ContainsKey(lowBotId))
                        {
                            lowBot = botCreation[lowBotId];
                        }
                        else
                        {
                            lowBot = new Bot(lowBotId);
                            botCreation.Add(lowBotId, lowBot);
                        }
                    }
                    else
                    {
                        if (outputCreation.ContainsKey(lowBotId))
                        {
                            lowBot = outputCreation[lowBotId];
                        }
                        else
                        {
                            lowBot = new Bot(lowBotId);
                            outputCreation.Add(lowBotId, lowBot);
                        }
                    }

                    if (vs[10].Equals("bot"))
                    {
                        if (botCreation.ContainsKey(highBotId))
                        {
                            highBot = botCreation[highBotId];
                        }
                        else
                        {
                            highBot = new Bot(highBotId);
                            botCreation.Add(highBotId, highBot);
                        }
                    }
                    else
                    {
                        if (outputCreation.ContainsKey(highBotId))
                        {
                            highBot = outputCreation[highBotId];
                        }
                        else
                        {
                            highBot = new Bot(highBotId);
                            outputCreation.Add(highBotId, highBot);
                        }
                    }

                    if (botCreation.ContainsKey(botID))
                    {
                        botCreation[botID].LowBot = lowBot;
                        botCreation[botID].HighBot = highBot;
                    }
                    else
                    {
                        botCreation.Add(botID, new Bot(botID));
                        botCreation[botID].LowBot = lowBot;
                        botCreation[botID].HighBot = highBot;
                    }
                }
            }
            List<Bot> bots = botCreation.Values.OrderByDescending(a => a.Chips.Count).ToList();
            List<Bot> outputs = outputCreation.Values.OrderBy(a => a.ID).ToList();
            var output0 = outputs[0];
            var output1 = outputs[1];
            var output2 = outputs[2];
            if (bots.Count < 10)
            {
                return 0;
            }
            while (output0.Chips.Count < 1 || output1.Chips.Count < 1 || output2.Chips.Count < 1)
            {
                var curCount = bots.OrderByDescending(a => a.Chips.Count).ToList();
                var bot = curCount.First();
                if (bot.Chips[0] < bot.Chips[1])
                {
                    if (bot.LowBot != null)
                    {
                        bot.LowBot.Chips.Add(bot.Chips[0]);
                    }
                    if (bot.HighBot != null)
                    {
                        bot.HighBot.Chips.Add(bot.Chips[1]);
                    }
                }
                else
                {
                    if (bot.LowBot != null)
                    {
                        bot.LowBot.Chips.Add(bot.Chips[1]);
                    }
                    if (bot.HighBot != null)
                    {
                        bot.HighBot.Chips.Add(bot.Chips[0]);
                    }
                }
                bot.Chips.Clear();
            }
            return output0.Chips[0] * output1.Chips[0] * output2.Chips[0];
        }
    }
}

