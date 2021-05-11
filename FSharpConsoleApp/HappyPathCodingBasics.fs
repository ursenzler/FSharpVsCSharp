module FSharpConsoleApp.HappyPathCodingBasics

open FsToolkit.ErrorHandling

let asynchronous id =
    async {
        return id + 1
    }

let caller id =
    async {
        let! r = asynchronous id
        return r
    }

let optional id = if id % 2 = 0 then Some id else None

let optionalPlus17 id =
    option {
        let! r = optional id
        return r + 17
    }

let getResult id =
    if id % 2 = 0 then Ok id
    else Error "odd number"

let resultPlus17 id =
    result {
        let! r = getResult id
        return r + 17
    }

let callResult () =
    let r = getResult 42
    match r with
    | Ok value -> "value"
    | Error error -> "error"
