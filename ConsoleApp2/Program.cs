using Azure.Identity;
using Microsoft.Graph;
using Microsoft.Identity.Client;
using System;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			// Build a client application.
			IPublicClientApplication publicClientApplication = PublicClientApplicationBuilder
						.Create("INSERT-CLIENT-APP-ID")
						.Build();

			// Create an authentication provider by passing in a client application and graph scopes.
			DeviceCodeCredential authProvider = new DeviceCodeCredential(publicClientApplication, graphScopes);

			// Create a new instance of GraphServiceClient with the authentication provider.
			GraphServiceClient graphClient = new GraphServiceClient(authProvider);
		}
	}
}
