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
            var client = new OneSignalClient("NWExxx"); //id del cliente

            var options = new NotificationCreateOptions
            {
                AppId = new Guid("xxx"), // id de la aplicacion
                IncludedSegments = new string[] { "All" },
            };

            IList<ActionButtonField> abf = new List<ActionButtonField>() {
                new ActionButtonField() {Id = "cancelar", Text = "Cancelar"},
                new ActionButtonField() {Id = "aceptar", Text = "Aceptar viaje"}
            };

            options.Headings.Add(LanguageCodes.English, "Dummy");
            options.Contents.Add(LanguageCodes.English, "contenido de dummy");
            options.ActionButtons = abf;
            client.Notifications.Create(options);
        }
    }
}
