let isCorrect (str: string) =
    let list = List.ofArray (str.ToCharArray())
    let rec closingBracket char st =
        if List.isEmpty st then false 
        else List.head st = char
    let rec helper ls stack =
        match ls with
        | [] -> List.isEmpty stack
        | h :: t -> match h with
                    | _ when h = '(' || h = '{' || h = '[' -> helper t (h :: stack)
                    | ')' -> if closingBracket '(' stack then helper t stack.Tail else false
                    | '}' -> if closingBracket '{' stack then helper t stack.Tail else false
                    | ']' -> if closingBracket '[' stack then helper t stack.Tail else false
                    | _ -> helper t stack
    helper list []