namespace FSharpStuff

module ThreePointOne =
    type RecordDate = {hour: int; minute: int; f: string}

    let checkForF hour f =
        if f.Equals "PM" then hour + 12 else hour

    let (.>.) date1 date2 =
        let firstHour = checkForF date1.hour date1.f
        let secondHour = checkForF date2.hour date2.f
        (firstHour, date1.minute) > (secondHour, date2.minute)

    let (>.) (firstHours, firstMinutes, firstF) (secondHours, secondMinutes, secondF) =
        let firstHour = checkForF firstHours firstF
        let secondHour = checkForF secondHours secondF
        (firstHour, firstMinutes) > (secondHour, secondMinutes)
 
module ThreePointTwo =
    
    let rec matchShillings (pound1, shilling1, pence1) (pound2, shilling2, pence2) =
        match shilling1+shilling2 with
        | x when x >= 20 -> matchShillings (pound1+1, shilling1-20, pence1) (pound2, shilling2, pence2)
        | _ -> (pound1+pound2, shilling1+shilling2, pence1+pence2)

    let rec (+.) (pound1, shilling1, pence1) (pound2, shilling2, pence2) =
        match pence1 + pence2 with
        | x when x >= 12 -> (pound1, shilling1+1, pence1-12) +. (pound2, shilling2, pence2)
        | _ -> matchShillings (pound1, shilling1, pence1) (pound2, shilling2, pence2)
        
    let pencify (pound, shilling, pence) =
        pound * 20 * 12 + shilling * 12 + pence

    let (-.) (pound1, shilling1, pence1) (pound2, shilling2, pence2) =
        let pences1 = pencify (pound1, shilling1, pence1)
        let pences2 = pencify (pound2, shilling2, pence2)
        
        let pences = pences1 - pences2
        (0,0,pences)+.(0,0,0)        


module ThreePointThree =
    type Complex = {real: double; imaginary: double}

    let (.+.) a b  =
        {real = a.real + b.real; imaginary = a.imaginary + b.imaginary}

    let (.*.) a b =
        {real = a.real * b.real - a.imaginary * b.imaginary; imaginary = a.imaginary * b.real + a.real * b.imaginary}

    let inverseAdd a =
        {real = -a.real; imaginary = -a.imaginary}

    let inverseMulti a =
        let denominator = a.real ** 2. + a.imaginary ** 2.
        {real = a.real / denominator; imaginary = -a.imaginary / denominator}

    let (.-.) a b =
        a .+. (inverseAdd b)

    let (./.) a b =
        a .*. (inverseMulti b)