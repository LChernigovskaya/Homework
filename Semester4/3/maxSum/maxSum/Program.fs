let indexOfMaxSum ls =
    let newls = List.ofSeq (Seq.map(fun(x, y) -> x + y) (Seq.zip (ls) (List.tail ls)))
    let maxElement ls =
        let rec maxElementRec ls index max acc =
            match ls with
            | h :: t -> if h > max 
                        then let max = h
                             let index = acc
                             maxElementRec t index max (acc + 1)
                        else maxElementRec t index max (acc + 1)
            | [] -> index
        maxElementRec ls 0 0 1
    maxElement newls