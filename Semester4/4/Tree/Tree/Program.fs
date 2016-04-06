type Tree<'a> =
    | Tree of 'a * Tree<'a> * Tree<'a>
    | Tip of 'a

let rec map func tree =
    match tree with
    | Tip(value) -> Tip(func(value))
    | Tree(value, left, right) -> Tree(func(value), map func left, map func right)

let func = (*) 3

let tree = Tree(5, Tree(4, Tip(3), Tree(6, Tip(7), Tip(8))), Tip(10))