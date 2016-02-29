let rec figerMult number =
    if abs(number) < 10 then number
    else number % 10 * figerMult (number / 10)

let findInd ls number = 
    let rec findIndRec ls number index =
        match ls with
        | h :: t -> if h = number then index else findIndRec t number (index + 1)
        | [] -> -1
    findIndRec ls number 0

let rec palindrome (str: string) =
    let size = str.Length
    match size with
    | 0 -> true
    | 1 -> true
    | _ -> if str.Chars(0) = str.Chars(size - 1) 
           then palindrome (str.Remove(0, 1).Remove(size - 2, 1))
           else false

let rec differentElements ls =
    match ls with
    | h :: t -> if (findInd t h) = -1 
                then differentElements t
                else false
    | [] -> true
