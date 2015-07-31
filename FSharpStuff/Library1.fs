namespace FSharpStuff

module TwoPointOne =
    let checkForDivision x =
        x % 2 = 0 && x % 3 = 0 && x % 5 <> 0
