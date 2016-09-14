module Problem_003

let problem =    
    let x = 600851475143.0
    {2.0..x} |> Seq.tryFind (fun e -> x % e = 0.0 && Common.isPrime (x/e |> int)) |> (fun e -> x / e.Value)

// 6857