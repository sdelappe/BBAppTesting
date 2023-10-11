using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReengagementAppAlpha2
{
    internal static class SpreadSheetConnector
    {
        public static SheetsService Service { get; set; }
        public const string APPLICATION_NAME = "BEHSStudentData";
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        public const string spreadSheetId = "1AJMBnDBcH96gTWyRtwiPz9Bb9fZanQzlhPWpWcem-qk";

        public static void ConnectToGoogle()
        {
            var credential = GetCredentialFromFile();
            Service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = APPLICATION_NAME
            });

            Console.WriteLine("Connection made?");
        }

        public static GoogleCredential GetCredentialFromFile()
        {
            GoogleCredential credential;

            using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream).CreateScoped(Scopes);
            }

            return credential;
        }
    }
}
