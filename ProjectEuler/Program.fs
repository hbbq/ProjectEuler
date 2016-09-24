module main
   
open System

[<EntryPoint>]
let main argv = 
    
    Console.WriteLine "Calulating..."

    let stopwatch = Diagnostics.Stopwatch.StartNew()

    //Get result from Problem X
    let result = Problem_028.problem.ToString()

    stopwatch.Stop()

    Console.WriteLine "Done\n"

    let resultText = sprintf "Result: %A\n\nExecution time: %d ms" result stopwatch.ElapsedMilliseconds
    
    //Write to trace and Console
    Diagnostics.Trace.WriteLine result
    Console.WriteLine resultText


    //Wait for key in console
    Console.WriteLine "\nPress any key"
    Console.ReadKey() |> ignore

    0
