type RoundingBuilder(digit : int) =
    member this.Bind(x : float, f : float -> float) =
        System.Math.Round(f x, digit)
    member this.Return(x) = x

let rounding digit = new RoundingBuilder(digit)
rounding 3 {
        let! a = 2.0 / 12.0
        let! b = 3.5
        return a / b
    }