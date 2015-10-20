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
        | _ -> list1 = ((Seq.truncate (List.length list1) list2) |> List.ofSeq)

    let rec count (list: int list) number =
        match number with
        | number when list.Head < number -> count list.Tail number
        | number when list.Head = number -> 1 + count list.Tail number
        | number when list.Head > number -> 0
        | _ -> 0

    let rec insert (list: int list) number =
        match list with
        | [] -> [number]
        | list when list.Head < number -> list.Head :: insert list.Tail number
        | list when list.Head = number -> number :: list
        | list when list.Head > number -> number :: list
        | _ -> list

    let rec intersect ((list1: int list), (list2: int list)) =
        match list1 with
        | [] -> []
        | x when List.head x > List.head list2 -> intersect (list1, (List.tail list2))  
        | x when List.head x = List.head list2 -> [List.head x] @ intersect(List.tail list1, List.tail list2) 
        | x when List.head x < List.head list2 -> intersect (List.tail list1, list2)
        | _ -> []

    let plus ((list1: int list), (list2: int list)) =
        List.append list1 list2
        |> List.sort
    