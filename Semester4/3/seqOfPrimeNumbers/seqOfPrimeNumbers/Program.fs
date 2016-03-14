let isPrime n =
    let maxDiv = sqrt (float n)
    let rec check i =
        i > (int maxDiv) || (n % i <> 0 && check (i + 1))
    check 2

let infSeqOfPrime =
    Seq.initInfinite (fun index -> if index = 0 then 2 else 2 * index + 1) |> 
                                   Seq.filter(fun x -> isPrime x)