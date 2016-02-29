let rec figerMult number =
    if abs(number) < 10 then number
    else number % 10 * figerMult (number / 10)

let findInd ls number = 
    let rec findIndRec ls number index =
        match ls with
        | h :: t -> if h = number then index else findIndRec t number (index + 1)
        | [] -> -1
    findIndRec ls number 0
