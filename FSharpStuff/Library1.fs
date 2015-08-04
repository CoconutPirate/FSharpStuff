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
