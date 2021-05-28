using System;
using eBay.ApiClient.Auth.OAuth2.Model;
using eBay.ApiClient.Auth.OAuth2;


namespace ebay 
{
    class Search
    {
        public Search()
        {
            Initalize();
        }

        private static void Initalize()
        {
            string path = @"./config/config.yaml";
            CredentialUtil.Load(path);

            CredentialUtil.Credentials credentials = CredentialUtil.GetCredentials(OAuthEnvironment.SANDBOX);

            Console.WriteLine(credentials.Get(CredentialType.APP_ID));
        }   

        public static string[] Query(string API)
        {   
            string[] test = {"hi", "hi"};
            return(test);
        }
    }
}