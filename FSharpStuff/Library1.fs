namespace FSharpStuff

module TwoPointOne =
    type Divisor () =
        member this.checkForDivision x =
            (x % 2 = 0 || x % 3 = 0) && x % 5 <> 0

module TwoPointTwo =
    type Stringifator () =
        member this.power s n =
            match n with
            | 1 -> sprintf "%s" s
            | _ -> (sprintf "%s * " s) + (this.power s (n-1))
            

module TwoPointThree =
    type StringCharChecker () =
        member this.isIthChar (s:string) (i:int) (c:char) =
            s.Chars i = c

//todo:
//module TwoPointEight =
//    type Pascal () =
//        member this.GetBinomial n m =
//            match (n,m) with
//            | (0,_) -> 0 
//            | (_,0) -> 1
//            | _ -> (this.GetBinomial (n-1) (m-1)) + (this.GetBinomial (n-1) (m))


module TwoPointSix =
    type notDivisionChecker () =
        member this.notDivisible d n =
            n % d <> 0