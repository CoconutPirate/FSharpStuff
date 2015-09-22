namespace FSharpStuff

module FourPointOneAndTwo =
    let upto n =
        [1..n]
    
    let downto1 n =
        [n .. -1 .. 1]
        
module FourPointThree =
    let isEven n =
        n % 2 = 0
    let evenN n =
        [1..n]
        |> List.filter isEven

module FourPointFour =
    let rec altsum = function
        | [] -> 0
        | x0::x1 -> x0 - altsum x1

module FourPointFive =
    let rec rmodd list =
        match list with
        | [] -> []
        | [x] -> [x]
        | x0::x1::xs -> rmodd (x0 :: xs)