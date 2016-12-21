namespace AdventOfCode2016FSharp.Test

open Microsoft.VisualStudio.TestTools.UnitTesting
open AdventOfCode2016FSharp.Day1

[<TestClass>]
type DirectionTest2() =
    [<TestMethod>]
    member x.TestTurnLeftFromNorth() =
        Assert.AreEqual(2,2)


[<TestClass>]
type DirectionTest() =
    [<TestMethod>]
    member x.TestTurnLeftFromNorth() =
        let direction = new Direction()
        direction.TurnLeft()
        Assert.AreEqual(Compas.West, direction.ActualCompas)

    [<TestMethod>]
    member x.TestTurnLeftFromEast() =
        let direction = new Direction(Compas.East)
        direction.TurnLeft()
        Assert.AreEqual(Compas.North, direction.ActualCompas)

    [<TestMethod>]
    member x.TestTurnLeftFromSouth() =
        let direction = new Direction(Compas.South)
        direction.TurnLeft()
        Assert.AreEqual(Compas.East, direction.ActualCompas)

    [<TestMethod>]
    member x.TestTurnLeftFromWest() =
        let direction = new Direction(Compas.West)
        direction.TurnLeft()
        Assert.AreEqual(Compas.South, direction.ActualCompas)

    [<TestMethod>]
    member x.TestTurnRightFromNorth() =
        let direction = new Direction()
        direction.TurnRight()
        Assert.AreEqual(Compas.East, direction.ActualCompas)

    [<TestMethod>]
    member x.TestTurnRightFromEast() =
        let direction = new Direction(Compas.East)
        direction.TurnRight()
        Assert.AreEqual(Compas.South, direction.ActualCompas)

    [<TestMethod>]
    member x.TestTurnRightFromSouth() =
        let direction = new Direction(Compas.South)
        direction.TurnRight()
        Assert.AreEqual(Compas.West, direction.ActualCompas)

    [<TestMethod>]
    member x.TestTurnRightFromWest() =
        let direction = new Direction(Compas.West)
        direction.TurnRight()
        Assert.AreEqual(Compas.North, direction.ActualCompas)


[<TestClass>]
type Day1Test() =
    let input = "R4, R4, L1, R3, L5, R2, R5, R1, L4, R3, L5, R2, L3, L4, L3, R1, R5, R1, L3, L1, R3, L1, R2, R2, L2, R5, L3, L4, R4, R4, R2, L4, L1, R5, L1, L4, R4, L1, R1, L2, R5, L2, L3, R2, R1, L194, R2, L4, R49, R1, R3, L5, L4, L1, R4, R2, R1, L5, R3, L5, L4, R4, R4, L2, L3, R78, L5, R4, R191, R4, R3, R1, L2, R1, R3, L1, R3, R4, R2, L2, R1, R4, L5, R2, L2, L4, L2, R1, R2, L3, R5, R2, L3, L3, R3, L1, L1, R5, L4, L4, L2, R5, R1, R4, L3, L5, L4, R5, L4, R5, R4, L3, L2, L5, R4, R3, L3, R1, L5, R5, R1, L3, R2, L5, R5, L3, R1, R4, L5, R4, R2, R3, L4, L5, R3, R4, L5, L5, R4, L4, L4, R1, R5, R3, L1, L4, L3, L4, R1, L5, L1, R2, R2, R4, R4, L5, R4, R1, L1, L1, L3, L5, L2, R4, L3, L5, L4, L1, R3"
    let day1 = new Day1()

    [<TestMethod>]
    member x.TestPart1GoToWest() =
        let distance = day1.Part1 "L2"
        Assert.AreEqual(2, distance)

    [<TestMethod>]
    member x.TestPart1GoToEast() =
        let distance = day1.Part1 "R12"
        Assert.AreEqual(12, distance)

    [<TestMethod>]
    member x.TestPart1Example1() =
        let distance = day1.Part1 "R2, L3"
        Assert.AreEqual(5, distance)

    [<TestMethod>]
    member x.TestPart1Example2() =
        let distance = day1.Part1 "R2, R2, R2"
        Assert.AreEqual(2, distance)

    [<TestMethod>]
    member x.TestPart1Example3() =
        let distance = day1.Part1 "R5, L5, R5, R3"
        Assert.AreEqual(12, distance)

    [<TestMethod>]
    member x.TestPart1() =
        let distance = day1.Part1 input
        Assert.AreEqual(146, distance)

    [<TestMethod>]
    member x.TestPart2Example1() =
        let distance = day1.Part2 "R8, R4, R4, R8"
        Assert.AreEqual(4, distance)

    [<TestMethod>]
    member x.TestPart2() =
        let distance = day1.Part2 input
        Assert.AreEqual(131, distance)
