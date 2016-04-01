let seq = 
    Seq.initInfinite(fun index -> if index % 2 = 0 then 1 else -1)

let newSeq =
    Seq.map(fun (x, y) -> x * y) (Seq.zip seq (Seq.initInfinite(fun index -> index + 1)))