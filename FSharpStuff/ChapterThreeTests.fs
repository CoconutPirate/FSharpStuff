namespace FSharpStuff.Tests

open NUnit.Framework
open FsUnit
open FSharpStuff.ThreePointOne


 [<TestFixture>]
    type ``Excercise 3point1`` () =

        [<Test>] member test.
            `` 11:30 AM should be treated as later than 10:30 AM `` () =
                checkTimeWithTriples (11,30,"AM") (10, 30, "AM")
                |> should be True

        [<Test>] member test.
            ``11:30 AM should be treated as later than 11:25 AM `` () =
                checkTimeWithTriples (11,30, "AM") (11,25, "AM") 
                |> should be True

        [<Test>] member test.
            `` 10:30 AM should be treated as earlier than 11:30 AM `` () =
                checkTimeWithTriples (10,30,"AM") (11, 30, "AM")
                |> should be False

        [<Test>] member test.
            ``11:25 AM should be treated as later than 11:30 AM `` () =
                checkTimeWithTriples (11,25, "AM") (11,30, "AM") 
                |> should be False

        [<Test>] member test.
            ``11:30 AM should be treated as not later than 11:30AM `` () =
                checkTimeWithTriples (11,30,"AM") (11,30,"AM")
                |> should be False

        [<Test>] member test.
            ``10:30 PM should be treated as later than 11:30 AM `` () =
                checkTimeWithTriples (10,30,"PM") (11,30,"AM") 
                |> should be True