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
open FSharpStuff.TwoPointEleven
open FSharpStuff.TwoPointTwelve

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

        [<Test>] member test.
            ``divisible is false`` () =
                notDivisible 3 9
                |> should be False

        [<Test>] member test.
            ``not divisible is true`` () =
                notDivisible 2 5
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

        [<Test>] member test.
            `` test should return true for 1, 4 and 5 `` () =
                testF 2 4 5
                |> should be True

        [<Test>] member test.
            `` test should return false for 1, 4 and 6 `` () =
                testF 2 4 6
                |> should be False

        [<Test>] member test.
            `` prime should return true for prime number `` () =
                prime 19
                |> should be True

        [<Test>] member test.
            `` prime should return false for not prime number `` () =
                prime 20
                |> should be False

        [<Test>] member test.
            `` nextPrime should give next prime number to one provided `` () =
                nextPrime 20
                |> should equal 23

        [<Test>] member test.
            `` nextPrime should give next prime number to provided prime `` () =
                nextPrime 5
                |> should equal 7

    [<TestFixture>]
    type `` Excercise 2point8 `` () =

        [<Test>] member test.
            `` pascal should get 6 for n = 4 m = 2 `` () =
                GetBinomial 4 2
                |> should equal 6

        [<Test>] member test.
            `` pascal should get 2 for n = 2 and m = 1 `` () =
                GetBinomial 2 1
                |> should equal 2

        [<Test>] member test.
            `` pascal should get 155 117 520 for n = 30 m = 15 `` () =
                GetBinomial 30 15
                |> should equal 155117520

    [<TestFixture>]
    type `` Excercise 2point11 `` () =
        
        [<Test>] member test.
            `` 100 with 23 vat should give 123 `` () =
                VAT 23.0f 100
                |> should equal 123.0f

        [<Test>] member test.
            `` 123 with 23 vat should unvat to 100 `` () =
                unVAT 23.0f 123.0f
                |> should equal 100


[<TestFixture>]
type `` EXcercisee 2point12 `` () =

    [<Test>] member test.
        `` y = x should give 0 `` () =
            min (fun x-> x)
            |> should equal 0

    [<Test>] member test.
        `` y = x - 5 should give 5 `` () =
            min (fun x -> x - 5)
            |> should equal 5

    [<Test>] member test.
        `` 2x^2 - 5x + 3 should give 1 `` () =
            min (fun x-> 2*x*x - 5*x + 3)
            |> should equal 1