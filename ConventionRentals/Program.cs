using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;

namespace ConventionRentals
{
    internal static class Program
    {

        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static readonly string ApplicationName = "ConventionProgram";
        static readonly string SpreadsheetID = "1jr13-sd99JoC-CH1SWRcrhAUDms4LDQOZBtEoyCIzig";
        static readonly string sheet = "CurrentStock";
        static SheetsService service;

/// <summary>
/// The main entry point for the application.
/// </summary>
[STAThread]
        static void Main()
        {
            GoogleCredential credential;
            using (var stream = new FileStream("../../client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream)
                    .CreateScoped(Scopes);
            }

            service = new SheetsService(new Google.Apis.Services.BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            ReadEntries();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RentalForm());
        }

        static void ReadEntries()
        {
            var range = $"{sheet}!A1:A1";
            var request = service.Spreadsheets.Values.Get(SpreadsheetID, range);
            var response = request.Execute();
            var values = response.Values;
            if (values != null && values.Count > 0) 
            {
                foreach (var row in values) 
                {
                    Console.WriteLine("{0}", row[0]);
                }
            }
            else 
            {
                Console.WriteLine("No data was found");
            }
        }

    }
}
