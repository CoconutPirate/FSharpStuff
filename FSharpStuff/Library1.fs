namespace FSharpStuff

module TwoPointOne =
    type Divisor () =
        member this.checkForDivision x =
            (x % 2 = 0 || x % 3 = 0) && x % 5 <> 0
