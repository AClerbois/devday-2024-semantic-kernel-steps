using System.ClientModel;
using OpenAI;
using OpenAI.Chat;

Console.WriteLine("Hello AI World");
Console.WriteLine("===============");

OpenAIClient client = new OpenAIClient(new ApiKeyCredential(Environment.GetEnvironmentVariable("AI:OpenAI:Key")));
ChatClient chatService = client.GetChatClient("gpt-4o-mini");

Console.WriteLine("Q: Quel est la couleur du ciel ?");
var result = await chatService.CompleteChatAsync("Quel est la couleur du ciel ?"); 
Console.WriteLine(result.Value.Content.First().Text);