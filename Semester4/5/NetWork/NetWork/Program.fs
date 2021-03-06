﻿let random = new System.Random()

type OS = 
    { name : string; 
      probabilityOfInfection : double
    }

type Computer (os : OS, isInfected : bool, random : System.Random) = 
    let mutable infected = isInfected
    member computer.Infected
        with get() = infected
    member c.TryToInfect =
        let value = random.NextDouble()
        infected <- (os.probabilityOfInfection >= value)

type Network(computers : array<Computer>, matrix : array<array<bool>>) =
    let mutable computers = computers
    let mutable indexInfected = List.empty
    let updateInfected (ls : list<int>) (i : int) =
        if (computers.[i].Infected)
        then (i :: ls)
        else ls
    do
        for i in [0..computers.Length - 1] do
            indexInfected <- updateInfected indexInfected i
    member n.MakeStep = 
        for i in [0..indexInfected.Length - 1] do
                for j in [0..computers.Length - 1] do
                    if (not computers.[j].Infected && matrix.[indexInfected.[i]].[j]) then computers.[j].TryToInfect
        for k in [0..computers.Length - 1] do
            indexInfected <- updateInfected indexInfected k
    member n.State =
        for i in [0..computers.Length - 1] do
            if (computers.[i].Infected) then
                printfn "Infected  %d" (i + 1)

let listOfOS = [{name = "Linux"; probabilityOfInfection = 0.3};
                {name = "Windows"; probabilityOfInfection = 0.5};
                {name = "Mac"; probabilityOfInfection = 0.7}]

let arrayOfComputers = [|new Computer(listOfOS.[0], false, random); new Computer(listOfOS.[1], true, random);
                        new Computer(listOfOS.[2], false, random)|]

let connectionMatrix = [|([|false; true; false|]); ([|true; false; true|]);
                        ([|false; true; false|])|]

let network = new Network(arrayOfComputers, connectionMatrix)

network.State
network.MakeStep
network.State
