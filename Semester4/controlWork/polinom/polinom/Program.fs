type Polinom =
    | Constant of string
    | Variable of string
    | Addition of Polinom * Polinom
    | Subtraction of Polinom * Polinom
    | Multiplication of Polinom * Polinom

let degree n (pol: Polinom) =
    match pol with
    | Variable(x) -> x 