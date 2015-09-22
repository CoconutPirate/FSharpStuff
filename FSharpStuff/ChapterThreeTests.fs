namespace FSharpStuff.Tests

open NUnit.Framework
open FsUnit
open FSharpStuff.ThreePointOne
open FSharpStuff.ThreePointTwo
open FSharpStuff.ThreePointThree
open FSharpStuff.ThreePointFour


 [<TestFixture>]
    type ``Excercise 3point1`` () =

        [<Test>] member test.
            ``tripe: 11:30 AM should be treated as later than 10:30 AM `` () =
                (11,30,"AM") >. (10, 30, "AM")
                |> should be True

        [<Test>] member test.
            ``triple: 11:30 AM should be treated as later than 11:25 AM `` () =
                (11,30, "AM") >. (11,25, "AM") 
                |> should be True

        [<Test>] member test.
            ``triple: 10:30 AM should be treated as earlier than 11:30 AM `` () =
                (10,30,"AM") >. (11, 30, "AM")
                |> should be False

        [<Test>] member test.
            ``triple: 11:25 AM should be treated as later than 11:30 AM `` () =
                (11,25, "AM") >. (11,30, "AM") 
                |> should be False

        [<Test>] member test.
            ``triple: 11:30 AM should be treated as not later than 11:30AM `` () =
                (11,30,"AM") >. (11,30,"AM")
                |> should be False

        [<Test>] member test.
            ``triple: 10:30 PM should be treated as later than 11:30 AM `` () =
                (10,30,"PM") >. (11,30,"AM") 
                |> should be True

        [<Test>] member test.
            ``record: 11:30 AM should be treated as later than 10:30 AM `` () =
                {hour = 11 ; minute = 30 ; f = "AM"} .>. { hour = 10 ; minute = 30; f = "AM"}
                |> should be True

        [<Test>] member test.
            ``record: 11:30 AM should be treated as later than 11:25 AM `` () =
                 {hour = 11 ; minute = 30 ; f = "AM"} .>.  {hour = 11 ; minute = 25 ; f = "AM"}
                |> should be True

        [<Test>] member test.
            ``record: 10:30 AM should be treated as earlier than 11:30 AM `` () =
                { hour = 10 ; minute = 30; f = "AM"} .>.  {hour = 11 ; minute = 30 ; f = "AM"}
                |> should be False

        [<Test>] member test.
            ``record: 11:25 AM should be treated as later than 11:30 AM `` () =
                {hour = 11 ; minute = 25 ; f = "AM"} .>. {hour = 11 ; minute = 30 ; f = "AM"}
                |> should be False

        [<Test>] member test.
            ``record: 11:30 AM should be treated as not later than 11:30AM `` () =
                {hour = 11 ; minute = 30 ; f = "AM"} .>. {hour = 11 ; minute = 30 ; f = "AM"}
                |> should be False

        [<Test>] member test.
            ``record: 10:30 PM should be treated as later than 11:30 AM `` () =
                { hour = 10 ; minute = 30; f = "PM"} .>. {hour = 11 ; minute = 30 ; f = "AM"}
                |> should be True

    type ``Excercise 3point2`` () =
        [<Test>] member test.
            `` 1 pound + 1 shilling + 1 pence = 1f1s1p `` () =
                (1,0,0)+.(0,1,0)+.(0,0,1)
                |> should equal (1,1,1)

        [<Test>] member test.
            `` 6 + 6 pences is 1 shilling `` () =
                (0,0,6)+.(0,0,6)
                |> should equal (0,1,0)

        [<Test>] member test.
            `` 10 + 10 shillings is 1 pound `` () =
                (0,10,0)+.(0,10,0)
                |> should equal (1,0,0)

        [<Test>] member test.
            `` (1,9,8) + (2, 11, 8) = (4,1,4) `` () =
                (1,9,8)+.(2,11,8)
                |> should equal (4,1,4)

        [<Test>] member test.
            `` (3,3,3) - (2,2,2) = (1,1,1) `` () =
                (3,3,3) -. (2,2,2)
                |> should equal (1,1,1)

        [<Test>] member test.
            `` 1 pound - 5 shillings = 15 shilling `` () =
                (1,0,0) -. (0,5,0)
                |> should equal (0,15,0)

        [<Test>] member test.
            `` 1 shilling - 5 pences = 7 pences `` () =
                (0,1,0) -. (0,0,5)
                |> should equal (0,0,7)

        [<Test>] member test.
            `` (4,1,4) - (2, 11, 8) = (1,9,8) `` () =
                (4,1,4) -. (2,11,8)
                |> should equal (1,9,8)
    type `` Excercise 3point3`` () =
        [<Test>] member test.
            `` 3+5i + 1+4i = 4+9i `` () =
                {real = 3.; imaginary = 5.} .+. {real = 1.; imaginary = 4.}
                |> should equal {real = 4.; imaginary = 9.}

        [<Test>] member test.
            `` 3+5i * 1+4i = 3-20 + 5+12i `` () =
                {real = 3.; imaginary = 5.} .*. {real = 1.; imaginary = 4.}
                |> should equal {real = -17.; imaginary = 17.}

        [<Test>] member test.
            `` 3-5i inversed with regard to addition = -3+5i `` () =
                inverseAdd {real = 3.; imaginary = -5.}
                |> should equal {real = -3.; imaginary = 5.}

        [<Test>] member test.
            `` 2+4i inversed with regard to multiplication should equal 0.1-0.2i `` () =
                inverseMulti {real = 2.; imaginary = 4.}
                |> should equal {real = 0.1; imaginary = -0.2}

        [<Test>] member test.
            `` 4 + 9i - 1+4i = 3+5i `` () =
                {real = 4.; imaginary = 9.} .-. {real = 1.; imaginary = 4.}
                |> should equal {real = 3.; imaginary = 5.}

        [<Test>] member test.
            `` -17+17i / 1+4i = 3+5i `` () =
                {real = -17.; imaginary = 17.} ./. {real = 1.; imaginary = 4.}
                |> should equal {real = 3.; imaginary = 5.}

    type `` Excercise 3point4 `` () =
        [<Test>] member test.
            `` y = 2x + 1 mirrored around x axis should equal to y = -2x - 1 `` () =
                mirrorX {a = 2.; b = 1.}
                |> should equal {a = -2.; b = -1.}

        [<Test>] member test.
            `` y = 2x + 1 mirrored around y axis should equal to y = -2x + 1 `` () =
                mirrorY {a = 2.; b = 1.}
                |> should equal {a = -2.; b = 1.}

        [<Test>] member test.
            `` y = 2x + 1 should be represented correctly as a string `` () =
                stringRepresentation {a = 2.; b = 1.}
                |> should equal "y = 2.0x + 1.0"

         [<Test>] member test.
            `` y = 2x - 1 should be represented correctly as a string `` () =
                stringRepresentation {a = 2.; b = -1.}
                |> should equal "y = 2.0x - 1.0"

         [<Test>] member test.
            `` y = -2x - 1 should be represented correctly as a string `` () =
                stringRepresentation {a = -2.; b = -1.}
                |> should equal "y = -2.0x - 1.0"