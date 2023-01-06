﻿namespace QRCodeScanner.Maui
{
    // All the code in this file is only included on iOS.
    public class Methods
    {
        public static async Task<bool> AskForRequiredPermission()
        {
            try
            {
                var status = await Permissions.CheckStatusAsync<Permissions.Camera>();
                if (status != PermissionStatus.Granted)
                {
                    await Permissions.RequestAsync<Permissions.Camera>();
                }
                status = await Permissions.CheckStatusAsync<Permissions.Camera>();
                if (status == PermissionStatus.Granted)
                    return true;
            }
            catch 
            {
                //Something went wrong
            }
            return false;


        }
    }
}