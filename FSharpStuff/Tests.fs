namespace FSharpStuff.Tests

open NUnit.Framework
open FsUnit
open FSharpStuff.TwoPointOne
open FSharpStuff.TwoPointTwo
open FSharpStuff.TwoPointThree
open FSharpStuff.TwoPointSix
open FSharpStuff.TwoPointFive
open FSharpStuff.TwoPointFour
open FSharpStuff.TwoPointSeven
open FSharpStuff.TwoPointEight

    [<TestFixture>]
    type ``Excercise 2point1`` () =

        [<Test>] member test.
            ``24 should give true as divisible by 2 and 3`` () =
                checkForDivision 24 
                |> should be True

        [<Test>] member test.
            ``27 should give true as divisible by 3`` () =
                checkForDivision 27 
                |> should be True

        [<Test>] member test.
            ``30 should give false as divisable by 5`` () =
                checkForDivision 30 
                |> should be False

        [<Test>] member test.
            ``29 should give false as not divisible`` () =
                checkForDivision 29 
                |> should be False


    [<TestFixture>]
    type ``Excercise 2point2`` () =

        [<Test>] member test.
            ``pow 4 1 should return 4`` () =
                power "4" 1
                |> should equal "4"

        [<Test>] member test.
            ``pow 5 3 should return 5 * 5 * 5 `` () =
                power "5" 3
                |> should equal "5 * 5 * 5"



    [<TestFixture>]
    type ``Excercise 2point3`` () =

        [<Test>] member test.
            ``should be true when char is ith char of the string`` () =
                isIthChar "abc" 1 'b'
                |> should be True

        [<Test>] member test.
            ``should be false when char is not ith char of the string`` () =
                isIthChar "abc" 1 'z'
                |> should be False

    [<TestFixture>]
    type ``Excercise 2point6`` () =
        let checker = new notDivisionChecker()

        [<Test>] member test.
            ``divisible is false`` () =
                checker.notDivisible 3 9
                |> should be False

        [<Test>] member test.
            ``not divisible is true`` () =
                checker.notDivisible 2 5
                |> should be True

    [<TestFixture>]
    type `` Excercise 2point5`` () =

        [<Test>] member test.
           ``should get 5 for aaaaa string and a char`` () =
               occInString "aaaaa" 'a'
               |> should equal 5

    [<TestFixture>]
    type `` Excercise 2point4`` () =

        [<Test>] member test.
           ``should get 3 for aaaaa string, char a and 2`` () =
               occFromIth "aaaaa" 2 'a'
               |> should equal 3


    [<TestFixture>]
    type `` Excercise 2point7 `` () =
        let primer = new Primer()

        [<Test>] member test.
            `` test should return true for 1, 4 and 5 `` () =
                primer.test 2 4 5
                |> should be True

        [<Test>] member test.
            `` test should return false for 1, 4 and 6 `` () =
                primer.test 2 4 6
                |> should be False

        [<Test>] member test.
            `` prime should return true for prime number `` () =
                primer.prime 19
                |> should be True

        [<Test>] member test.
            `` prime should return false for not prime number `` () =
                primer.prime 20
                |> should be False

        [<Test>] member test.
            `` nextPrime should give next prime number to one provided `` () =
                primer.nextPrime 20
                |> should equal 23

        [<Test>] member test.
            `` nextPrime should give next prime number to provided prime `` () =
                primer.nextPrime 5
                |> should equal 7

    [<TestFixture>]
    type `` Excercise 2point8 `` () =
        let pascal = new Pascal()

        [<Test>] member test.
            `` pascal should get 6 for n = 4 m = 2 `` () =
                pascal.GetBinomial 4 2
                |> should equal 6

        [<Test>] member test.
            `` pascal should get 2 for n = 2 and m = 1 `` () =
                pascal.GetBinomial 2 1
                |> should equal 2

        [<Test>] member test.
            `` pascal should get 155 117 520 for n = 30 m = 15 `` () =
                pascal.GetBinomial 30 15
                |> should equal 155117520