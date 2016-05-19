open System.ComponentModel

let array = Array.create 1000000 1
let sum10000Elements startPos =
    let rec sum i acc =
        if i > startPos + 9999 then acc
        else sum (i + 1) (acc + array.[i])
    sum startPos 0

let mutable result = 0

let flags = Array.create 100 false

for i in 0..99 do
    let worker = new BackgroundWorker()
    worker.DoWork.Add(fun args -> args.Result <- box <| sum10000Elements (10000 * i)) 
    worker.RunWorkerCompleted.Add(fun args -> 
                                    result <- result + (args.Result :?> int)
                                    flags.[i] <- true)
    worker.RunWorkerAsync()

while not (Array.forall(fun x -> x = true) flags) do ()

printfn "%A" result