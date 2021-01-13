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

let optional id =
    option {
        let! r =
            if id % 2 = 0 then Some id
            else None
        return r
    }

let result id =
    result {
        let! r =
            if id % 2 = 0 then Ok id
            else Error "odd number"
        return r
    }

let asyncResult id =
    asyncResult {
        let! async = asynchronous id
        let! optional =
            id
            |> optional
            |> Result.requireSome "no value"
        let! result = result id

        return async + optional + result
    }
