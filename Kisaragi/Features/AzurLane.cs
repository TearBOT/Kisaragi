using System.Threading.Tasks;
using static DiscordUtils.Utils;

namespace Kisaragi.Features
{
    public static class AzurLane
    {
        public static async Task<FeatureRequest<Response.AzurLane, Error.AzurLane>> Character(params string[] args)
        {
            return (new FeatureRequest<Response.AzurLane, Error.AzurLane>(new Response.AzurLane(), Error.AzurLane.None));
        }
    }
}
