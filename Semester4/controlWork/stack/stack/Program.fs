open System
open System.Collections.Generic

exception ErrorEmpty of string

type Stack<'a>() = 
   let list = new List<'a>()
   
   member this.push value = 
      list.Add(value)

   member this.pop() =
      if (this.IsEmpty()) then
         raise(ErrorEmpty("empty stack")) 
      let lastInd = list.Count - 1
      let value = list.Item (lastInd)
      list.RemoveAt (lastInd)
      value

   member this.IsEmpty() =
      list.Count = 0

let stack = new Stack<int>()
stack.push 3
stack.push 2

try
   printfn "%d" (stack.pop())
   printfn "%d" (stack.pop())
   printfn "%d" (stack.pop())
    
with
    | ErrorEmpty(message) -> printfn "%A" message