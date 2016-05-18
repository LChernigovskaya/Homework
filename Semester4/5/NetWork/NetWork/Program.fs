let random = new System.Random()

type OS = 
    { name : string; 
      probabilityOfInfection : double
    }

type Computer (os : OS, isInfected : bool, random : System.Random) = 
    member val Infected = isInfected with get, set
    member c.TryToInfect =
        let value = random.NextDouble()
        os.probabilityOfInfection >= value

type Network(computers : array<Computer>, matrix : array<array<bool>>) =
    let mutable computers = computers
    let mutable indexInfected = List.empty
    member n.MakeStep =  
        for i in [0..computers.Length - 1] do
            if (computers.[i].Infected) then
                for j in [0..computers.Length - 1] do
                    if (matrix.[i].[j] && computers.[j].TryToInfect) then 
                        indexInfected <- j :: indexInfected
        for k in [0..indexInfected.Length - 1] do
            computers.[indexInfected.[k]].Infected <- true
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
