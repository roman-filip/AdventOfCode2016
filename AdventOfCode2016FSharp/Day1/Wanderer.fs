namespace AdventOfCode2016FSharp.Day1

open System
open System.Collections.Generic

type Wanderer() =
    let direction = new Direction()
    let mutable actualLocation = (0, 0)

    let extractSteps(instructions:string) =
        instructions.Split(',') |> Array.map(fun(s) -> s.Trim())

    let extractRotation(step:string) =
        step.[0]

    let extractStepsCount(step:string) =
        Convert.ToInt32(step.Substring(1, step.Length - 1))

    let extractRotationAndStepsCount(step:string) =
        extractRotation step, extractStepsCount step

    let makeStep rotation stepsCount =
        match rotation with
        | 'L' -> direction.TurnLeft()
        | 'R' -> direction.TurnRight()
        | _ -> ()

        match direction.ActualCompas with
        | Compas.North -> actualLocation <- (fst actualLocation, snd actualLocation + stepsCount)
        | Compas.East -> actualLocation <- (fst actualLocation + stepsCount, snd actualLocation)
        | Compas.South -> actualLocation <- (fst actualLocation, snd actualLocation - stepsCount)
        | Compas.West -> actualLocation <- (fst actualLocation - stepsCount, snd actualLocation)
        | _ -> ()

    member this.Wander instructions =
        for step in extractSteps instructions do
            let (rotation, stepsCount) = extractRotationAndStepsCount step
            makeStep rotation stepsCount

    member this.WanderTillFirstDuplicit instructions =
        let visitedPlaces = new HashSet<int*int>()
        visitedPlaces.Add actualLocation |> ignore
        let mutable firstDuplicit = (0, 0)
        for step in extractSteps instructions do
            let (rotation, stepsCount) = extractRotationAndStepsCount step
            makeStep rotation 1
            visitedPlaces.Add actualLocation |> ignore
            for i in 2..stepsCount do
                makeStep '-' 1
                let newlyAdded = visitedPlaces.Add actualLocation
                if newlyAdded = false && firstDuplicit = (0, 0) then firstDuplicit <- actualLocation
        actualLocation <- firstDuplicit

    member this.GetDistance() = 
        Math.Abs(fst actualLocation) + Math.Abs(snd actualLocation)
