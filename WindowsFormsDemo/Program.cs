using Microsoft.Identity.Client;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemo
{
    static class Program
    {
        private static IPublicClientApplication _pca;
        private static string _clientId = "your-client-id"; // Substitua pelo seu Client ID do Azure AD
        private static string _tenantId = "your-tenant-id"; // Substitua pelo seu Tenant ID do Azure AD
        private static string[] _scopes = new string[] { "user.read" }; // Escopos necessários

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            _pca = PublicClientApplicationBuilder.Create(_clientId)
                .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
                .WithRedirectUri("http://localhost")
                .Build();

            AuthenticateUser().GetAwaiter().GetResult();
        }

        private static async Task AuthenticateUser()
        {
            try
            {
                var result = await _pca.AcquireTokenInteractive(_scopes)
                    .ExecuteAsync();

                MessageBox.Show("Usuário Autenticado! Token: " + result.AccessToken);

                Application.Run(new Home());
            }
            catch (MsalException ex)
            {
                MessageBox.Show("Erro de autenticação: " + ex.Message);
                Application.Exit();
            }
        }
    }
}
