# CoreGraphQL
Discovering GraphQL features running on ASP.NET Core.
It is mainly influenced by https://www.lynda.com/NET-tutorials/API-Development-NET-GraphQL serie from Glenn Block

- it just uses in memory collections 

- at first we can just explore the basics without adding inner objects and also Mutations and subscription.
and we can both run it inside GraphiQL and also any other client like PostMan And see how clean it works

query Orders{
   orders{
    id, 
    name }
}

