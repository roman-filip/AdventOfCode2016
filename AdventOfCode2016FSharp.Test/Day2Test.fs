namespace AdventOfCode2016FSharp.Test

open Microsoft.VisualStudio.TestTools.UnitTesting
open AdventOfCode2016FSharp.Day2

[<TestClass>]
type KeypadTest() =
    [<TestMethod>]
    member x.TestMoveLeft() =
        Assert.AreEqual(4, (new Keypad()).GetNumber "L")

    [<TestMethod>]
    member x.TestMoveRight() =
        Assert.AreEqual(6, (new Keypad()).GetNumber "R")

    [<TestMethod>]
    member x.TestMoveUp() =
        Assert.AreEqual(2, (new Keypad()).GetNumber "U")

    [<TestMethod>]
    member x.TestMoveDown() =
        Assert.AreEqual(8, (new Keypad()).GetNumber "D")

    member x.TestMoveLeft3x() =
        Assert.AreEqual(4, (new Keypad()).GetNumber "LLL")

    [<TestMethod>]
    member x.TestMoveRight3x() =
        Assert.AreEqual(6, (new Keypad()).GetNumber "RRR")

    [<TestMethod>]
    member x.TestMoveUp3x() =
        Assert.AreEqual(2, (new Keypad()).GetNumber "UUU")

    [<TestMethod>]
    member x.TestMoveDown3x() =
        Assert.AreEqual(8, (new Keypad()).GetNumber "DDD")

    [<TestMethod>]
    member x.TestNumber1() =
        Assert.AreEqual(1, (new Keypad()).GetNumber "ULL")


[<TestClass>]
type Day2Test() =
    let day2 = new Day2()

    [<TestMethod>]
    member x.TestPart1Example1() =
        let result = day2.Part1 "TODO"
        Assert.Fail()

    [<TestMethod>]
    [<Ignore>]
    member x.TestPart1() =
        let result = day2.Part1 "TODO"
        ()

    [<TestMethod>]
    [<Ignore>]
    member x.TestPart2Example1() =
        let result = day2.Part1 "TODO"
        ()

    [<TestMethod>]
    [<Ignore>]
    member x.TestPart2() =
        let result = day2.Part1 "TODO"
        ()
