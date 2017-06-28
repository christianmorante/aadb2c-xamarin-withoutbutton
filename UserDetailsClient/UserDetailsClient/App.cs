﻿using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace UserDetailsClient
{
    public class App : Application
    {
        public static PublicClientApplication PCA = null;

        // Azure AD B2C Coordinates
        //public static string ClientID = "90c0fe63-bcf2-44d5-8fb7-b8bbc0b29dc6";
        //public static string PolicySignUpSignIn = "b2c_1_susi";
        //public static string PolicyEditProfile = "b2c_1_edit_profile";
        //public static string PolicyResetPassword = "b2c_1_reset";
        public static string ClientID = "491deba1-9404-4900-bc12-da2648a5c7e9";
        public static string PolicySignUpSignIn = "B2C_1_RSA_SignUpSignInPol";
        public static string PolicyEditProfile = "B2C_1_RSA_ProfEditPol";
        public static string PolicyResetPassword = "B2C_1_RSA_PassResetPol";

        //public static string[] Scopes = { "https://fabrikamb2c.onmicrosoft.com/demoapi/demo.read" };
        public static string[] Scopes = { "https://agisolb2c.onmicrosoft.com/giros/read" };

        public static string ApiEndpoint = "https://fabrikamb2chello.azurewebsites.net/hello";

        //public static string AuthorityBase = "https://login.microsoftonline.com/tfp/fabrikamb2c.onmicrosoft.com/";
        public static string AuthorityBase = "https://login.microsoftonline.com/tfp/agisolb2c.onmicrosoft.com/";

        public static string Authority = $"{AuthorityBase}{PolicySignUpSignIn}";
        public static string AuthorityEditProfile = $"{AuthorityBase}{PolicyEditProfile}";
        public static string AuthorityPasswordReset = $"{AuthorityBase}{PolicyResetPassword}";

        public static UIParent UiParent = null;
        
        public App()
        {
            // default redirectURI; each platform specific project will have to override it with its own
            PCA = new PublicClientApplication(ClientID, Authority);
                        
            MainPage = new NavigationPage(new MainPage());        
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
