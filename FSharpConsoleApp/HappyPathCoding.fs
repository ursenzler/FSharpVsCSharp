module FSharpConsoleApp.HappyPathCoding

open FsToolkit.ErrorHandling

type Customer =
    {
        Id : int
        Name : string option
    }

type Data =
    {
        Id : int
        Amount : int
    }

let loadCustomer customerId =
    asyncResult {
        return
            {
                Customer.Id = customerId
                Name = Some "Charles"
            }
    }

let loadData dataId =
    asyncResult {
        return
            {
                Data.Id = dataId
                Amount = 100
            }
    }

let getNameOfCustomer customer =
    option {
        let! name = customer.Name
        return name
    }

let getCustomerNameAndAmount customerId dataId =
    asyncResult {
        let! customer = loadCustomer customerId
        let! data = loadData dataId

        let! name =
            customer
            |> getNameOfCustomer
            |> Result.requireSome
                   "customer has no name"

        return name, data.Amount
    }

let compute () =
    async {
        let! result = getCustomerNameAndAmount 42 17
        match result with
        | Ok (name, amount) -> printf $"customer = {name}, amount = {amount}"
        | Error error -> printf $"error is {error}"
    }