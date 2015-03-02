using Newtonsoft.Json;
using SnapchatHelper.JSONObjects.bq;
using SnapchatHelper.JSONObjects.ph;
using System.Threading.Tasks;

namespace SnapchatHelper
{
    public partial class Snapchat
    {
        public static async Task<Snapchat> Login(string username, string password)
        {
            var response = await bqCommands.Login(username, password);

            if (!string.IsNullOrEmpty(response))
            {
                return JsonConvert.DeserializeObject<Snapchat>(response);
            }
            else
            {
                Snapchat snapchat = new Snapchat()
                {
                    Message = "Failed.",
                    Logged = false
                };
                return snapchat;
            }
        }

        public async Task<bool> Logout(Snapchat snapchat)
        {
            if (await phCommands.Logout(snapchat))
                return true;
            else
                return false;
        }
    }
}
