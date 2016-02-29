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
    let list = List.ofArray (str.ToCharArray())
    let rec reverseRec ls temps =
        match ls with
        | h :: t -> reverseRec t (h :: temps)
        | [] -> temps
    let reverces = reverseRec list []
    reverces = list

let rec differentElements ls =
    match ls with
    | h :: t -> if (findInd t h) = -1 
                then differentElements t
                else false
    | [] -> true
