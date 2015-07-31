namespace FSharpStuff.Tests

open NUnit.Framework
open FsUnit
open FSharpStuff.TwoPointOne


    [<TestFixture>]
    type ``Excercise 2point1`` ()=
        let divisor = new Divisor()

        [<Test>] member test.
         ``24 should give true as divisible by 2 and 3`` ()=
               divisor.checkForDivision 24 
               |> should be True

        [<Test>] member test.
         ``27 should give true as divisible by 3`` ()=
               divisor.checkForDivision 27 
               |> should equal True

        [<Test>] member test.
         ``30 should give false as divisable by 5`` ()=
               divisor.checkForDivision 30 
               |> should equal False

        [<Test>] member test.
         ``29 should give false as not divisible`` ()=
               divisor.checkForDivision 29 
               |> should equal False
