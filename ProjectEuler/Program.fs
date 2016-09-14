module main
   
open System

[<EntryPoint>]
let main argv = 

    //Get result from Problem X
    let result = Problem_001.problem.ToString()

    //Write to trace and Console
    Diagnostics.Trace.WriteLine result
    printfn "%A" result

    //Wait for key in console
    Console.ReadKey() |> ignore

    0
