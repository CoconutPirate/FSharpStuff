namespace FSharpStuff

module ThreePointOne =
    let checkTimeWithTriples (firstHours, firstMinutes, firstF) (secondHours, secondMinutes, secondF) =
        let firstHour = if firstF.Equals "PM" then firstHours + 12 else firstHours
        let secondHour = if secondF.Equals "PM" then secondHours + 12 else secondHours
        match firstHour with
        | x when x < secondHour -> false
        | x when x > secondHour -> true
        | x when x = secondHour -> match firstMinutes with
                                    | x when x < secondMinutes -> false
                                    | x when x > secondMinutes -> true
                                    | _ -> false
        | _ -> false
    //todo: records

