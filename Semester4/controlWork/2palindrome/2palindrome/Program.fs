let palindrome (number: int) =
    let list = List.ofArray (number.ToString().ToCharArray())
    let rec reverseRec ls temps =
        match ls with
        | h :: t -> reverseRec t (h :: temps)
        | [] -> temps
    let reverces = reverseRec list []
    reverces = list

let find =
    let rec findMax number1 number2 max =
        let rec loop number1 number2 max =
            let newMax = number1 * number2
            if newMax > max && palindrome newMax then newMax
            elif number1 > 99 then loop (number1 - 1) number2 max
            else max
        let aux = loop number1 number2 max
        if aux > max then findMax number1 (number2 - 1) aux
        elif number2 > 99 then findMax number1 (number2 - 1) max
        else max
    findMax 999 999 -1