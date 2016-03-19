type Tree<'a> =
    | Tree of 'a * Tree<'a> * Tree<'a>
    | Tip of 'a

let rec height tree =
    match tree with
    | Tree(_, l, r) -> 1 + max (height l) (height r)
    | Tip(_) -> 1
