namespace FSharpStuff.Tests

open NUnit.Framework
open FsUnit

    [<TestFixture>]
    type ``Excercise 2point1`` () =
        let divisor = new FSharpStuff.TwoPointOne.Divisor()

        [<Test>] member test.
            ``24 should give true as divisible by 2 and 3`` () =
                divisor.checkForDivision 24 
                |> should be True

        [<Test>] member test.
            ``27 should give true as divisible by 3`` () =
                divisor.checkForDivision 27 
                |> should be True

        [<Test>] member test.
            ``30 should give false as divisable by 5`` () =
                divisor.checkForDivision 30 
                |> should be False

        [<Test>] member test.
            ``29 should give false as not divisible`` () =
                divisor.checkForDivision 29 
                |> should be False


    [<TestFixture>]
    type ``Excercise 2point2`` () =
        let stringifator = new FSharpStuff.TwoPointTwo.Stringifator()

        [<Test>] member test.
            ``pow 4 1 should return 4`` () =
                stringifator.power "4" 1
                |> should equal "4"

        [<Test>] member test.
            ``pow 5 3 should return 5 * 5 * 5 `` () =
                stringifator.power "5" 3
                |> should equal "5 * 5 * 5"



    [<TestFixture>]
    type ``Excercise 2point3`` () =
        let checker = new FSharpStuff.TwoPointThree.StringCharChecker()

        [<Test>] member test.
            ``should be true when char is ith char of the string`` () =
                checker.isIthChar "abc" 1 'b'
                |> should be True

        [<Test>] member test.
            ``should be false when char is not ith char of the string`` () =
                checker.isIthChar "abc" 1 'z'
                |> should be False