using Newtonsoft.Json;
using OneSignal.RestAPIv3.Client;
using OneSignal.RestAPIv3.Client.Resources;
using OneSignal.RestAPIv3.Client.Resources.Notifications;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace SendPN
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new OneSignalClient("NWExMmU5YmQtMjc0MS00YWM3LWFjMDktYzk1NjY5ZDZlMjQ4");

            var options = new NotificationCreateOptions
            {
                AppId = new Guid("3f0f65fa-c129-43da-a412-a3767cb0838f"),
                IncludedSegments = new string[] { "All" },
            };

            IList<ActionButtonField> abf = new List<ActionButtonField>() {
                new ActionButtonField() {Id = "cancelar", Text = "Cancelar"},
                new ActionButtonField() {Id = "aceptar", Text = "Aceptar viaje"}
            };

            options.Headings.Add(LanguageCodes.English, "Eco Taxi");
            options.Contents.Add(LanguageCodes.English, "Nuevo viaje en espera");
            options.ActionButtons = abf;
            client.Notifications.Create(options);
        }
    }
}
