namespace FSharpStuff.Tests

open NUnit.Framework
open FsUnit
open FSharpStuff.ChapterFour


    [<TestFixture>]
        type ``Exercise 4point1`` () =
            [<Test>] member test.
                `` upto 1 gives 1 `` () =
                    upto 1
                    |> should equal [1]

            [<Test>] member test.
                `` upto 10 gives numbers 1 to 10 `` () =
                    upto 10
                    |> should equal [1;2;3;4;5;6;7;8;9;10]

        type ``Exercise 4point2`` () =
            [<Test>] member test.
                `` downto 1 gives 1 `` () =
                    downto1 1
                    |> should equal [1]

            [<Test>] member test.
                ``downto 10 gives numbers 10 to 1`` () =
                    downto1 10
                    |> should equal [10;9;8;7;6;5;4;3;2;1]

        type `` Exercise 4point3 `` () =
            [<Test>] member test.
                ``evenN 6 should give [2;4;6] `` () =
                    evenN 6
                    |> should equal [2;4;6]

            [<Test>] member test.
                `` evenN 5 should give [2;4] `` () =
                    evenN 5
                    |> should equal [2;4]

        type `` Exercise 4point4 `` () =
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
            
        type `` Exercise 4point5 `` () =
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

            [<Test>] member test.
                `` rmodd [1;2;3;4] should give [1;3] `` () =
                    rmodd [1;2;3;4]
                    |> should equal [1;3]

        type `` Exercise 4point6 `` () =
            [<Test>] member test.
                `` removeEven [] should give [] `` () =
                    removeEven []
                    |> should equal []

            [<Test>] member test.
                `` removeEven should not remove odd numbers `` () =
                    removeEven [3;5;7;9]
                    |> should equal [3;5;7;9]

            [<Test>] member test.
                `` removeEven should remove only even numbers `` () =
                    removeEven [2;3;4;5]
                    |> should equal [3;5]

            [<Test>] member test.
                `` removeEven for list of even ints should give [] `` () =
                    removeEven [2;4;6;8;10]
                    |> should equal []


        type `` Exercise 4point7 `` () =
            [<Test>] member test.
                ``multiplicity [1;2;3] 4 should return 0 `` () =
                    multiplicity 4 [1;2;3]
                    |> should equal 0

            [<Test>] member test.
                ``multiplicity [1;2;3] 1 should return 1 `` () =
                    multiplicity 1 [1;2;3]
                    |> should equal 1

            [<Test>] member test.
                ``multiplicity [1;1;1;1;1;1;1] 1 should return 7 `` () =
                    multiplicity 1 [1;1;1;1;1;1;1]
                    |> should equal 7

            [<Test>] member test.
                ``multiplicity [1;1;1;1;1;1;2] 1 should return 6 `` () =
                    multiplicity 1 [1;1;1;1;1;1;2]
                    |> should equal 6

        type `` Exercise 4poin8 `` () =
            [<Test>] member test.
                `` split [] should give ([],[]) `` () =
                    split [] 
                    |> should equal ([],[])

                [<Test>] member test.
                `` split [1] should give ([1],[]) `` () =
                    split [1] 
                    |> should equal ([1],[]:>(int list))

                [<Test>] member test.
                `` split [1;2] should give ([1],[2]) `` () =
                    split [1;2] 
                    |> should equal ([1],[2])

                [<Test>] member test.
                `` split [1;2;3] should give ([1;3],[2]) `` () =
                    split [1;2;3] 
                    |> should equal ([1;3],[2])

                [<Test>] member test.
                `` split [1;2;3;4] should give ([1;3],[2;4]) `` () =
                    split [1;2;3;4] 
                    |> should equal ([1;3],[2;4])

        type `` Exercise 4point9 `` () =
            [<Test>] member test.
                `` zip ([],[]) should give [] `` () =
                    zip ([],[])
                    |> should equal []

            [<Test>] member test.
                `` zip ([1],[2]) should give [1;2] `` () =
                    zip ([1],[2])
                    |> should equal [1;2]

            [<Test>] member test.
                `` zip ([1;3],[2;4]) should give [1;2;3;4] `` () =
                    zip ([1;3],[2;4])
                    |> should equal [1;2;3;4]

        type `` Exercise 4point10 `` () =
            [<Test>] member test.
                `` [] is a prefix of [] `` () =
                    prefix [] []
                    |> should be True

            [<Test>] member test.
                `` [] is a prefix of [1;2] `` () =
                    prefix [] [1;2]
                    |> should be True

            [<Test>] member test.
                `` [1] is a prefix of [1;2] `` () =
                    prefix [1] [1;2]
                    |> should be True

            [<Test>] member test.
                `` [1;2] is a prefix of [1;2] `` () =
                    prefix [1;2] [1;2]
                    |> should be True

            [<Test>] member test.
                `` [1;2] is not a prefix of [1] `` () =
                    prefix [1;2] [1]
                    |> should be False

            [<Test>] member test.
                `` [1;2] is not a prefix of [3;4] `` () =
                    prefix [1;2] [3;4]
                    |> should be False

        type `` Exercise 4point11 `` () =
            [<Test>] member test.
                `` count xs x should give 0 for xs [2;2;3;4;5] 1 `` () =
                    count [2;2;3;4;5] 1
                    |> should equal 0

            [<Test>] member test.
                `` count [0;1;1;1;2] 1 should give 3 `` () =
                    count [0;1;1;1;2] 1
                    |> should equal 3

            [<Test>][<Timeout 300>] member test.
                `` count should terminate quickly `` () =
                    count [1..1000000] 1
                    |> should equal 1

            [<Test>] member test.
                `` insert [] 1 should give [1] `` () =
                    insert [] 1
                    |> should equal [1]

            [<Test>] member test.
                `` insert [1;2] 3 should give [1;2;3] `` () =
                    insert [1;2] 3
                    |> should equal [1;2;3]

             [<Test>] member test.
                `` insert [1;2] 0 should give [0;1;2] `` () =
                    insert [1;2] 0
                    |> should equal [0;1;2]

             [<Test>] member test.
                `` insert [1;3] 2 should give [1;2;3] `` () =
                    insert [1;3] 2
                    |> should equal [1;2;3]

             [<Test>] member test.
                `` insert [1;2;3] 2 should give [1;2;2;3] `` () =
                    insert [1;2;3] 2
                    |> should equal [1;2;2;3]

            [<Test>] member test.
                `` intersect ([1;1;1;2;2],[1;1;2;4]) = [1;1;2] `` () =
                    intersect ([1;1;1;2;2],[1;1;2;4])
                    |> should equal [1;1;2]

            [<Test>] member test.
                `` intersect ([1;2;2], [3;3;4)] = [] `` () =
                    intersect ([1;2;2], [3;3;4])
                    |> should equal ([]:>(int list))

            [<Test>] member test.
                `` plus ([1;1;2],[1;2;4]) should give [1;1;1;2;2;4] `` () =
                    plus ([1;1;2],[1;2;4])
                    |> should equal [1;1;1;2;2;4] 