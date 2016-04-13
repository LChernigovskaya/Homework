type Contact =
    { Name: string;
      Number: int; }

let compare (cont1: Contact) (cont2: Contact) =
    if cont1.Name >= cont2.Name then 1 else -1

let rec add ls (cont: Contact) =
    match ls with
    | h :: t -> if compare h cont = 1 then cont :: ls else h :: add t cont
    | [] -> cont :: ls

let rec searchByName ls name =
    match ls with
    | [] -> -1
    | h :: t -> if name = h.Name then h.Number else searchByName t name

let rec searchByNumber ls number = 
    match ls with
    | [] -> ""
    | h :: t -> if number = h.Number then h.Name else searchByNumber t number

let contactsToStrings ls =
    let rec loop ls str = 
        match ls with
        | h :: t -> loop t ((h.Name + " " + h.Number.ToString()) :: str)
        | [] -> str
    loop ls []

let saveToFile ls fileName =
    System.IO.File.WriteAllLines(fileName, contactsToStrings ls)

let stringsToContacts (str: List<string>) =
    let rec loop ls (str: List<string>) = 
        match str with
        | h :: t -> let spl = h.Split(' ')
                    loop ({Name = spl.[0]; Number = int (spl.[1])} :: ls) t
        | [] -> ls
    loop [] str

let readFromFile fileName =
    if  System.IO.File.Exists fileName then
        let contactes = List.ofArray (System.IO.File.ReadAllLines(fileName))
        stringsToContacts contactes
    else []

let user =
    printfn "0 - exit"
    printfn "1 - add contact"
    printfn "2 - search by name"
    printfn "3 - search by number"
    printfn "4 - write to file"
    printfn "5 - read from file"

    let rec loop ls =
        printfn "Please, enter command"
        let command = System.Console.ReadLine()
        match command with
        | "0" -> ()
        | "1" -> printfn "Please, enter name"
                 let name = System.Console.ReadLine()
                 printfn "Please, enter number"
                 let number = int (System.Console.ReadLine())
                 loop <| add ls {Name = name; Number = number}
        | "2" -> printfn "Please, input name"
                 let name = System.Console.ReadLine()
                 printfn "Number %d" <| searchByName ls name
                 loop ls
        | "3" -> printfn "Please, input number"
                 let number = int (System.Console.ReadLine())
                 printfn "Name %s" <| searchByNumber ls number
                 loop ls
        | "4" -> saveToFile ls "phones.txt"
                 printfn "Saved"
                 loop ls
        | "5" -> loop (readFromFile "phones.txt")
        | _ -> printfn "Wrong command"
               loop ls
    loop []
