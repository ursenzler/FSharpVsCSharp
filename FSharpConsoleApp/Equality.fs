module FSharpConsoleApp.Equality

type Customer = { Id : int ; Name : string option }

let compute () =
    let listOfCustomers1 =
        [
            {
                Id = 1
                Name = Some "Charles"
            }
            {
                Id = 2
                Name = None
            }
        ]

    let listOfCustomers2 =
        [
            {
                Id = 1
                Name = Some "Charles"
            }
            {
                Id = 2
                Name = None
            }
        ]

    listOfCustomers1 = listOfCustomers2