using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WikiClientLibrary;
using WikiClientLibrary.Client;
using WikiClientLibrary.Sites;

namespace WikiTrekdotNET.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static async Task MainAsync(string UserName, string Password)
        { 
            WikiClient GeneralClient = new WikiClient
            {
                ClientUserAgent = "WCLQuickStart/1.0 (your user name or contact information here)"
            };

            // WikiSite WikiTrek = new WikiSite(GeneralClient, "https://wikitrek.org/wt/api.php");
            WikiSite DataTrek = new WikiSite(GeneralClient, "https://data.wikitrek.org/dt/api.php");

            Console.WriteLine("Initialization");
            await DataTrek.Initialization;
            Console.WriteLine("Initialized");

            try
            {
                await DataTrek.LoginAsync(UserName, Password);
                
            }
            catch (WikiClientException ex)
            {
                Console.WriteLine(ex.Message);
                // Add your exception handler for failed login attempt.
            }
                        
            try
            {
                // Do what you want
                Console.WriteLine(DataTrek.SiteInfo.SiteName);
                Console.WriteLine(DataTrek.AccountInfo);
                Console.WriteLine("{0} extensions", DataTrek.Extensions.Count);
                Console.WriteLine("{0} interwikis", DataTrek.InterwikiMap.Count);
                Console.WriteLine("{0} namespaces", DataTrek.Namespaces.Count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            // We're done here
            await DataTrek.LogoutAsync();
            GeneralClient.Dispose();
        }

        private void BTNTest_Click(object sender, EventArgs e)
        {
            MainAsync(TXTUser.Text, TXTPassword.Text).Wait();
            //MainSync(TXTUser.Text, TXTPassword.Text);
        }

        static void MainSync(string UserName, string Password)
        {
            WikiClient GeneralClient = new WikiClient();

            // WikiSite WikiTrek = new WikiSite(GeneralClient, "https://wikitrek.org/wt/api.php");
            WikiSite DataTrek = new WikiSite(GeneralClient, "https://data.wikitrek.org/dt/api.php");

            Console.WriteLine("Initialization");
            //DataTrek.Initialization;
            Console.WriteLine("Initialized");

            try
            {
                DataTrek.LoginAsync(UserName, Password);

                // Do what you want
                Console.WriteLine(DataTrek.SiteInfo.SiteName);
                Console.WriteLine(DataTrek.AccountInfo);
                Console.WriteLine("{0} extensions", DataTrek.Extensions.Count);
                Console.WriteLine("{0} interwikis", DataTrek.InterwikiMap.Count);
                Console.WriteLine("{0} namespaces", DataTrek.Namespaces.Count);
            }
            catch (WikiClientException ex)
            {
                Console.WriteLine(ex.Message);
                // Add your exception handler for failed login attempt.
            }

            // We're done here
            DataTrek.LogoutAsync();
            GeneralClient.Dispose();
        }
    }
}
