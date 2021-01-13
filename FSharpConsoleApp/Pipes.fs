module FSharpConsoleApp.Pipes

type Customer = { Name : string ; Id : int }

let loadCustomer id = { Name = "Charles" ; Id = id }

let getNameOfCustomer customer = customer.Name

let getNameOfCustomerFromId id =
    id
    |> loadCustomer
    |> getNameOfCustomer

let getNameOfCustomerFromId' = loadCustomer >> getNameOfCustomer
