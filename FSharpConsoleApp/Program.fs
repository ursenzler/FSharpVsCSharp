open FSharpConsoleApp

[<EntryPoint>]
let main argv =
    Equality.compute() |> printf "%b"
    0