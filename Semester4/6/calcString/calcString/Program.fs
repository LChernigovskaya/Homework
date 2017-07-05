open System

let strToInt str  = 
    match Int32.TryParse(str) with
    | false, _ -> None
    | true, value  -> Some value

type MaybeBuilder() =
    member this.Bind(m, f) = Option.bind f (strToInt m)
    member this.Return(x) = Some(x)

let maybe = new MaybeBuilder()
    
let result = maybe {
        let! x = "1"
        let! y = "2"
        let z = x + y
        return z
    }

let res = maybe {
        let! x = "1"
        let! y = "Ъ"
        let z = x + y
        return z
    }