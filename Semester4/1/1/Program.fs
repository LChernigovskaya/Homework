let rec factorial x =
    if x = 0 then 1 else x * factorial (x - 1)

let rec fibonacci x =
    if x = 0 || x = 1 then 1 else fibonacci (x - 1) + fibonacci (x - 2)

let reverse ls =
    let rec reverseRec ls temps: int list =
        match ls with
        | h :: t -> reverseRec t (h :: temps)
        | [] -> temps
    reverseRec ls []

let rec powerOf number power =
    if power = 0 then 1 else number * powerOf number (power-1)
let listOfPowers number quantity = 
    List.init quantity (fun i -> powerOf number i)
