type Expression = 
    | Variable of char
    | Const of int
    | Addition of Expression * Expression
    | Substraction of Expression * Expression
    | Multiplication of Expression * Expression
    | Division of Expression * Expression

let rec derivative(exp: Expression) =
    match exp with
    | Const(_) -> Const 0
    | Variable(_) -> Const 1
    | Addition(exp1, exp2) -> Addition (derivative(exp1), derivative(exp2))
    | Substraction(exp1, exp2) -> Substraction (derivative(exp1), derivative(exp2))
    | Multiplication(exp1, exp2) -> Addition (Multiplication(derivative(exp1), exp2), 
                                              Multiplication(exp1, derivative(exp2)))
    | Division(exp1, exp2) -> Division(Substraction(Multiplication(derivative(exp1), exp2),
                                                    Multiplication(exp2, derivative(exp1))),
                                                    Multiplication(exp2, exp2))

let rec simplification (exp: Expression) = 
    match exp with
    | Const(_) -> Const 0
    | Variable(_) -> Const 1
    | Addition(exp1, exp2) -> match exp1, exp2 with
                              | Const(value1), Const(value2) -> Const(value1 + value2)
                              | _, _ -> simplification(Addition(simplification(exp1), simplification(exp2)))
    | Substraction(exp1, exp2) -> match exp1, exp2 with
                                  | Const(value1), Const(value2) -> Const(value1 - value2)
                                  | _, _ -> simplification(Substraction(simplification(exp1), simplification(exp2)))
    | Multiplication(exp1, exp2) -> match exp1, exp2 with
                                    | Const(value1), Const(value2) -> Const(value1 * value2)
                                    | _, _ -> simplification(Multiplication(simplification(exp1),
                                                                            simplification(exp2)))
    | Division(exp1, exp2) -> match exp1, exp2 with
                                    | Const(value1), Const(value2) -> Const(value1 / value2)
                                    | _, _ -> simplification(Division(simplification(exp1),
                                                                      simplification(exp2)))