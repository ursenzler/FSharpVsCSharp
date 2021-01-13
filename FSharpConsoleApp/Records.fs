module FSharpConsoleApp.Records

type A =
    {
        Name : string
        Id : int
    }

type A' = { Name : string ; Id : int }

let a =
    {
        Name = "Name"
        Id = 42
    }