namespace AdventOfCode2016FSharp.Day2

type Keypad() = 
    let mutable actualPossition = (1, 1)
    let keypad =
        [|
            [| 1; 2; 3 |]
            [| 4; 5; 6 |]
            [| 7; 8; 9 |]
        |]

    let processInstruction instruction =
        let actualX = fst actualPossition
        let actualY = snd actualPossition
        match instruction with
        | 'L' -> if actualX > 0 then  actualPossition <- (actualX - 1, actualY)
        | 'R' -> if actualX < keypad.[actualY].GetLength(0) - 1 then actualPossition <- (actualX + 1, actualY)
        | 'U' -> if actualY > 0 then  actualPossition <- (actualX, actualY - 1)
        | 'D' -> if actualY < keypad.GetLength(0) - 1 then actualPossition <- (actualX, actualY + 1)
        | _ -> ()

    let getNumberFromActualtPosition() =
        keypad.[snd actualPossition].[fst actualPossition]

    member this.GetNumber instructions =
        instructions |> Seq.iter(fun instr -> processInstruction instr)
        getNumberFromActualtPosition()
