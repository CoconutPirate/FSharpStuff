namespace FSharpStuff
open System.Linq

module ChaperTwo =

    let checkForDivision x =
        (x % 2 = 0 || x % 3 = 0) && x % 5 <> 0
    
    let rec power s n =
        match n with
        | 1 -> s
        | _ -> (sprintf "%s * " s) + (power s (n-1))
            
    let isIthChar (s:string) (i:int) (c:char) =
        s.Chars i = c
    
    let occInString (s: string) (c:char) =
            s.Count(fun x -> x = c) 
    
    let occFromIth (s: string) (i: int) (c: char) =
            occInString (s.Substring(i)) c

    let rec GetBinomial n m =
        match m with
        | 0 -> 1 
        | m when m = n -> 1
        | _ -> 
                let getBinomial = GetBinomial (n-1)
                (getBinomial (m-1)) + (getBinomial (m))

    let notDivisible d n =
        n % d <> 0

    let rec testF a b c =
        match a with
        |  x when x = b -> notDivisible b c
        | _ -> (testF (a+1) b c) && (notDivisible a c)
                
    let prime n =
        let finish = (int)(sqrt ((float) n))
        testF 2 finish n

    let rec nextPrime n =
        let check = prime (n+1)
        match check with
        | false -> nextPrime (n+1)
        | true -> (n+1)

    let VAT (vatPercent:float32) (value:int) =
        (float32)(value) * (1.0f+(vatPercent/100.0f))

    let unVAT (vatPercent:float32) (vatedValue:float32) =
        (int)(vatedValue / (1.0f + (vatPercent/100.0f)))
    
    let rec check (func: int -> int) number =
        match func number with 
        | 0 -> number
        | _ -> check func (number+1)

    let min (func: int -> int) =
        check func 0 
        
        
