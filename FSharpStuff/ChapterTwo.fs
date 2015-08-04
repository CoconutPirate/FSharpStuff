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

module TwoPointFive =
    open System.Linq
    type OccurenceFinder () =
        member this.occInString (s: string) (c:char) =
            s.Count(fun x -> x = c) 

module TwoPointFour =
    open TwoPointFive
    let occCounter = new OccurenceFinder ()
    type ithOccCounter () =
        member this.occFromIth (s: string) (i: int) (c: char) =
            occCounter.occInString (s.Substring(i)) c

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


module TwoPointSeven =
    open TwoPointSix

    let checker = new notDivisionChecker ()

    type Primer () =
        member this.test a b c =
            match a with
            |  x when x = b -> checker.notDivisible b c
            | _ -> (this.test (a+1) b c) && (checker.notDivisible a c)
                
        member this.prime n =
            let finish = (int)(sqrt ((float) n))
            this.test 2 finish n

        member this.nextPrime n =
            let check = this.prime n
            match check with
            | false -> this.nextPrime (n+1)
            | true -> n