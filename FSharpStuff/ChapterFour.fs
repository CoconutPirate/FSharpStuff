namespace FSharpStuff

module ChapterFour =
    let upto n =
        [1..n]
    
    let downto1 n =
        [n .. -1 .. 1]
        

    let isEven n =
        n % 2 = 0
    let evenN n =
        [1..n]
        |> List.filter isEven


    let rec altsum = function
        | [] -> 0
        | x0::x1 -> x0 - altsum x1


    let rec rmodd list =
        match list with
        | [] -> []
        | [x] -> [x]
        | x0::x1::xs -> x0 :: rmodd xs


    let isOdd n =
        n % 2 <> 0
    let removeEven a =
        a
        |> List.filter isOdd

    let rec multiplicity x xs =
        match xs with
        | [] -> 0
        | x0 :: x1 -> (if x0 = x then 1 else 0) + (multiplicity x x1)

    let rec split list =
        match list with
        | x1::xs when xs = [] -> ([x1], xs)
        | x1::x2::xs -> ([x1] @ (fst (split xs)), [x2] @ (snd (split xs)))
        | _ -> ([], [])

    let rec zip (list1, list2) =
        match (list1, list2) with
        | (x1::xs1, x2::xs2) when (xs1 <> [] && xs2 <> [] ) -> [x1] @ [x2] @ zip(xs1,xs2)
        | (x1::xs1, x2::xs2) -> ([x1] @ [x2])
        | _ -> []

    let prefix (list1: int list) (list2: int list) =
        match list1 with
        | list1 when list1.Length > list2.Length -> false
        | _ -> list1 = [for i in 0 .. list1.Length-1 do yield list2.Item i]

    