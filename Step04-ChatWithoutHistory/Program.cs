﻿using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.AzureOpenAI;
using Microsoft.SemanticKernel.Connectors.OpenAI;

Console.WriteLine("Hello AI World");
Console.WriteLine("===============");

//IChatCompletionService chatService = new AzureOpenAIChatCompletionService("gpt-4o", "https://devday-semantickernel-test.openai.azure.com/", Environment.GetEnvironmentVariable("AI:AzureOpenAI:Key")); 
IChatCompletionService chatService = new OpenAIChatCompletionService("gpt-3.5-turbo-0125", Environment.GetEnvironmentVariable("AI:OpenAI:Key")); Console.WriteLine("Configuration : OpenAI - gpt-4o-mini");

while (true)
{
    Console.Write("Question ? : ");
    Console.WriteLine(await chatService.GetChatMessageContentAsync(Console.ReadLine()));
}