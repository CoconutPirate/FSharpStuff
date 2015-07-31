open FsUnit

module Tests =
    [<Fact>]
    let ``When getting sum of multiples of 3 and 5 to a max number of 10 it should return a sum of 23`` () =  
        GetSumOfMultiplesOf3And5(10) |> should equal 23 

