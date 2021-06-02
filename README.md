# DiscordRPC
Implementing a Discord Rich Presence through a C# console app.  
Mostly testing and for personal use as of now.

# Usage
### Achitecture
Download the correct build for your architecture The only difference is the `discord_game_sdk.dll` file.    
If you're using the wrong one you should get an error similar to `"An attempt was made to load a program with an incorrect format"` when trying to click `Connect`. Just try the other one.  
### Application
You will need to create your own application, to so go to the [Discord Developer Portal](https://discord.com/developers/applications). There you can change various settings and upload assets for you to use in your rich presence.  
Copy the Client ID from the OAuth2 tab and paste it in the `Client ID` field in the app, then click Connect.
![client ID example](https://i.imgur.com/1KrHJqW.png)  

# Support
For questions or support either [create a discussion](https://github.com/Glazelf/DiscordRPC/discussions) or join my Discord.  
[<img src="https://canary.discordapp.com/api/guilds/549214833858576395/widget.png?style=banner2">](https://discord.gg/2gkybyu)
