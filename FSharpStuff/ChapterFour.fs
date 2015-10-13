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

    let split list =
        ([],[]) // todo: implement

    let zip (list1, list2) =
        [] // todo: implement

    let prefix list1 list2 =
        false // todo: implement

    