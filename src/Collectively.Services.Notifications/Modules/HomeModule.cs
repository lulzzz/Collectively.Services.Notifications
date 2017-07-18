﻿namespace Collectively.Services.Notifications.Modules
{
    public class HomeModule : ModuleBase
    {
        public HomeModule() : base(requireAuthentication: false)
        {
            Get("", args => "Welcome to the Collectively.Services.Notifications API!");
        }
    }
}