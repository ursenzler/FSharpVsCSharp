module FSharpConsoleApp.DiscriminatedUnions

type Temperature =
    | Celsius of float
    | Fahrenheit of int

let isItWarm temperature =
    match temperature with
    | Celsius c when c > 25.0 -> true
    | Fahrenheit f when f > 77 -> true
    | _ -> false

let getMeasure temperature =
    match temperature with
    | Celsius _ -> "Celsius"
    | Fahrenheit _ -> "Fahrenheit"


let (|IsWarm|IsCold|) temperature =
    match temperature with
    | Celsius c when c > 25.0 -> IsWarm
    | Celsius _ -> IsCold
    | Fahrenheit f when f > 77 -> IsCold
    | Fahrenheit _ -> IsCold

let isItWarm' temperature =
    match temperature with
    | IsWarm -> true
    | IsCold -> false


module Bob =

    open System.Text.RegularExpressions

    let response (input: string): string =
        let (|Silence|_|) x = if x = "" then Some() else None
        let (|Asking|_|) (x: string) = if x.EndsWith("?") then Some() else None
        let (|Shouting|_|) (x: string) = if x.ToUpper() = x then Some() else None
        let (|HasText|_|) x = if Regex.IsMatch(x, "[a-zA-Z]") then Some() else None

        match input.Trim() with
        | Shouting & Asking & HasText -> "Calm down, I know what I'm doing!"
        | Shouting & HasText -> "Whoa, chill out!"
        | Silence -> "Fine. Be that way!"
        | Asking -> "Sure."
        | _ -> "Whatever."