using Discord.Commands;
using System.Threading.Tasks;

namespace Kisaragi.Modules
{
    [Group("AzurLane"), Alias("AL", "Azur Lane")]
    public class AzurLane : ModuleBase
    {
        [Command("Charac")]
        private async Task Character(params string[] args)
        {

        }

        [Command(""), Priority(-1)]
        private async Task Default(params string[] args)
            => await Character(args);
    }
}
