open System
open System.Collections

type Tree<'a> =
    | Tree of 'a * Tree<'a> * Tree<'a>
    | Tip of 'a
    | Empty

type BinarySearchTree<'a when 'a : comparison> () =
    let mutable tree = Empty
    
    member t.Add value =
        let rec recAdd value tree =
            match tree with
            | Empty -> Tip value
            | Tip(element) -> if element < value then Tree(element, Empty, Tip(value)) 
                              else Tree(element, Tip(value), Empty)
            | Tree(element, left, right) -> if element < value then Tree(element, left, recAdd value right)
                                            else Tree(element, recAdd value left, right)
        if not (t.Exist value) then tree <- recAdd value tree

    member t.Exist value =
        let rec recExist value tree =
            match tree with
            | Empty -> false
            | Tip(element) -> element = value
            | Tree(element, left, right) -> if element < value then recExist value right
                                            elif element > value then recExist value left
                                            else element = value
        recExist value tree

    member t.Remove value =
        let rec findLeft tree =
            match tree with
            | Tip(element) -> element
            | Tree(element, l, r) -> findLeft l

        let rec recRemove value tree =
            match tree with
            | Empty -> Empty
            | Tip element -> 
               if (element = value) then Empty else tree
            | Tree (current, left, right) ->
                if value > current then Tree(current, left, recRemove value right)
                elif value < current then Tree(current, recRemove value left, right)
                else match right with
                     | Empty -> left
                     | Tree(element, Empty, r) -> Tree(element, left, r)
                     | Tree(element, l, r) -> let minLeft = findLeft l
                                              Tree(minLeft, recRemove minLeft l, r)
        tree <- recRemove value tree

    member t.TreeToList =
        let rec recTreeToList (tree : 'a Tree) (list : 'a list) = 
            match tree with
            | Empty -> list
            | Tip element -> [element]
            | Tree (element, left, right) ->
                let r = recTreeToList right list
                let l = recTreeToList left list
                List.append l (element :: r)
        recTreeToList tree List.Empty

    interface IEnumerable with
        member this.GetEnumerator() = 
            let list = ref this.TreeToList
            if !list = List.Empty then
                { new IEnumerator with
                    member x.Current with get() = null
                    member x.Reset() = ()
                    member x.MoveNext() = false
                }
            else
                list := (List.head !list) :: !list
                { new IEnumerator with
                    member x.Current with get() = (List.head !list) :> obj
                    member x.Reset() = 
                        list := this.TreeToList
                    member x.MoveNext() = 
                        match !list with
                        | h :: t ->
                            if t = [] then
                                false
                            else
                                list := t
                                true
                        | [] -> false
                }

let binaryTree = new BinarySearchTree<int>()
binaryTree.Add 9
binaryTree.Add 3
binaryTree.Add 5
binaryTree.Add 7
binaryTree.Add 1
for i in binaryTree do
    printf "%A " i
printfn ""
printfn "%A" (binaryTree.Exist 3)
binaryTree.Remove 3
printfn "%A" (binaryTree.Exist 3)
for i in binaryTree do
    printf "%A " i
printfn ""
binaryTree.Remove 8
binaryTree.Add 2
for i in binaryTree do
    printf "%A " i
printfn ""