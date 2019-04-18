using Discord;
using Discord.Commands;
using DiscordUtils;
using System.Threading.Tasks;

namespace Kisaragi.Modules
{
    class Communication : ModuleBase
    {
        [Command("Info")]
        private async Task Info()
        {
            await ReplyAsync("", false, Utils.GetBotInfo(Program.P.StartTime, "Kisaragi", Program.P.client.CurrentUser));
        }

        [Command("Help")]
        private async Task Help()
        {
            await ReplyAsync("", false, new EmbedBuilder()
            {
                Color = Color.Purple,
                Title = "Help",
                Description =
                    "Info: Display information about the bot"
            }.Build());
        }
    }
}
