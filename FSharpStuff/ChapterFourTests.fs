﻿namespace FSharpStuff.Tests

open NUnit.Framework
open FsUnit
open FSharpStuff.FourPointOneAndTwo
open FSharpStuff.FourPointThree
open FSharpStuff.FourPointFour
open FSharpStuff.FourPointFive


    [<TestFixture>]
        type ``Excercise 4point1`` () =
            [<Test>] member test.
                `` upto 1 gives 1 `` () =
                    upto 1
                    |> should equal [1]

            [<Test>] member test.
                `` upto 10 gives numbers 1 to 10 `` () =
                    upto 10
                    |> should equal [1;2;3;4;5;6;7;8;9;10]

        type ``Excercise 4point2`` () =
            [<Test>] member test.
                `` downto 1 gives 1 `` () =
                    downto1 1
                    |> should equal [1]

            [<Test>] member test.
                ``downto 10 gives numbers 10 to 1`` () =
                    downto1 10
                    |> should equal [10;9;8;7;6;5;4;3;2;1]

        type `` Excercise 4point3 `` () =
            [<Test>] member test.
                ``evenN 6 should give [2;4;6] `` () =
                    evenN 6
                    |> should equal [2;4;6]

            [<Test>] member test.
                `` evenN 5 should give [2;4] `` () =
                    evenN 5
                    |> should equal [2;4]

        type `` Excercise 4point4 `` () =
            [<Test>] member test.
                `` altsum for [] gives 0 `` () =
                    altsum []
                    |> should equal 0

            [<Test>] member test.
                `` altsum for [5] gives 5 `` () =
                    altsum [5]
                    |> should equal 5

            [<Test>] member test.
                `` altsum for [2;-1;3] gives 6 `` () =
                    altsum [2;-1;3]
                    |> should equal 6
            
        type `` Excercise 4point5 `` () =
            [<Test>] member test.
                `` rmodd [] should give [] `` () =
                    rmodd []
                    |> should equal []

            [<Test>] member test.
                `` rmodd [1] should give [1] `` () =
                    rmodd [1]
                    |> should equal [1]

            [<Test>] member test.
                `` rmodd [1;2;3;4;5] should give [1;3;5] `` () =
                    rmodd [1;2;3;4;5]
                    |> should equal [1;3;5]

