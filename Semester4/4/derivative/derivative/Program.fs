type Expression = 
    | Variable of char
    | Const of int
    | Addition of Expression * Expression
    | Subtraction of Expression * Expression
    | Multiplication of Expression * Expression
    | Division of Expression * Expression

let rec derivative(exp: Expression) =
    match exp with
    | Const(_) -> Const 0
    | Variable(_) -> Const 1
    | Addition(exp1, exp2) -> Addition (derivative(exp1), derivative(exp2))
    | Subtraction(exp1, exp2) -> Subtraction (derivative(exp1), derivative(exp2))
    | Multiplication(exp1, exp2) -> Addition (Multiplication(derivative(exp1), exp2), 
                                              Multiplication(exp1, derivative(exp2)))
    | Division(exp1, exp2) -> Division(Subtraction(Multiplication(derivative(exp1), exp2),
                                                   Multiplication(exp1, derivative(exp2))),
                                                   Multiplication(exp2, exp2))

let rec simplification (exp: Expression) = 
    let func exp1 exp2 action = 
        let left = simplification(exp1)
        let right = simplification(exp2)
        if left = Const 0 then right elif right = Const 0 then left else action (left, right)
    match exp with
    | Const(value) -> Const(value)
    | Variable(value) -> Variable(value)
    | Addition(exp1, exp2) -> match exp1, exp2 with
                              | Const(value1), Const(value2) -> Const(value1 + value2)
                              | _, _ -> func exp1 exp2 Addition
    | Subtraction(exp1, exp2) -> match exp1, exp2 with
                                  | Const(value1), Const(value2) -> Const(value1 - value2)
                                  | _, _ -> func exp1 exp2 Subtraction
    | Multiplication(exp1, exp2) -> match exp1, exp2 with
                                    | Const(value1), Const(value2) -> Const(value1 * value2)
                                    | Const(value), exp | exp, Const(value) -> match value with
                                                                               | 0 -> Const 0
                                                                               | 1 -> simplification exp
                                                                               | _ -> Multiplication(Const(value),
                                                                                                     simplification exp)
                                    | _, _ -> func exp1 exp2 Multiplication
    | Division(exp1, exp2) -> match exp1, exp2 with
                                    | Const(value1), Const(value2) -> Const(value1 / value2)
                                    | Const 0, Variable(_) -> Const 0
                                    | Const(value1), Variable(value2) | Variable(value2), Const(value1) -> Division(Variable(value2), Const(value1))
                                    | _, _ -> func exp1 exp2 Division

let exp: Expression = Division (Multiplication (Const 5, Variable 'x'), Variable 'x')
let der = derivative exp
let sim = simplification der

let exp2: Expression = Division (Subtraction (Addition(Multiplication(Const 10,Variable 'x'), Multiplication(Variable 'x', Variable 'x')), Addition (Multiplication(Const 5, Variable 'x'), Multiplication(Variable 'x', Variable 'x'))), Multiplication (Const 2, Variable 'x'))
let der2 = derivative exp2
let sim2 = simplification der2