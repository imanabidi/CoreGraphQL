using System;
using GraphQL;
using GraphQL.Types;

namespace GraphQlHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://graphql-dotnet.github.io/docs/getting-started/introduction

            var schema=Schema.For(@"
                              type Query { 
                                  hello: String  
                              }");

            var json=schema.Execute( _ => 
            {
                _.Query = "{hello}"  ;
                _.Root  = new { hello= "Hello World"};
                
            });

            Console.WriteLine(json);
        }
    }
}
