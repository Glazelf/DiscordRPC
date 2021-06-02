namespace DiscordRPC.Core
{
    public class Activity
    {
        public static bool UpdateActivity(Discord.Discord discord, Discord.Activity activity)
        {
            var activityManager = discord.GetActivityManager();
            bool returnBool = false;
            activityManager.UpdateActivity(activity, (result) =>
            {
                if (result == Discord.Result.Ok)
                {
                    returnBool = true;
                }
                else
                {
                    returnBool = false;
                }
            });
            return returnBool;
        }
    }
}
