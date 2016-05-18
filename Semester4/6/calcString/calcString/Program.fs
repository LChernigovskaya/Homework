open System

let strToInt str f = 
    match Int32.TryParse(str) with
    | false, _ -> None
    | true, value  -> f value

type MaybeBuilder() =
    member this.Bind(m, f) = strToInt m f
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