module FSharpConsoleApp.Equality

type Data = { Name : string ; Values : string[] }

let compute () =
    let a =
        {
           Name = "Charles"
           Values = [| "1" ; "2" |]
        }

    let b =
        {
           Name = "Charles"
           Values = [| "1" ; "2" |]
        }

    a = b