type Expression =
    | Addition of Expression * Expression
    | Subtraction of Expression * Expression
    | Multiplication of Expression * Expression
    | Division of Expression * Expression
    | Operand of int

let rec calculate (exp: Expression) =
    match exp with
    | Addition(exp1, exp2) -> calculate exp1 + calculate exp2
    | Subtraction(exp1, exp2) -> calculate exp1 - calculate exp2
    | Multiplication(exp1, exp2) -> calculate exp1 * calculate exp2
    | Division(exp1, exp2) -> calculate exp1 / calculate exp2
    | Operand(value) -> value
