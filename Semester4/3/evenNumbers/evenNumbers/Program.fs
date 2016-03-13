let evenNumbersFilter ls =
    (List.filter(fun x -> x % 2 = 0) ls).Length

let evenNumbersFold ls =
    List.fold(fun acc x -> if x % 2 = 0 then acc + 1 else acc) 0 ls

let evenNumbersMap ls =
    List.sum (List.map(fun x -> (x + 1) % 2) ls)