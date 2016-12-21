namespace AdventOfCode2016FSharp.Day1

type Compas = North = 0 | East = 1 | South = 2 | West = 3

type Direction(compas) = 
    member val ActualCompas = compas with get, set

    new() = Direction(Compas.North)

    member this.TurnLeft() =
        match this.ActualCompas with
        | Compas.North -> this.ActualCompas <- Compas.West
        | Compas.East -> this.ActualCompas <- Compas.North
        | Compas.South -> this.ActualCompas <- Compas.East
        | Compas.West -> this.ActualCompas <- Compas.South
        | _ -> ()

    member this.TurnRight() = 
        match this.ActualCompas with
        | Compas.North -> this.ActualCompas <- Compas.East
        | Compas.East -> this.ActualCompas <- Compas.South
        | Compas.South -> this.ActualCompas <- Compas.West
        | Compas.West -> this.ActualCompas <- Compas.North
        | _ -> ()