module Problem_003

let problem =    
    let x = 600851475143L
    {2L..x} 
    |> Seq.tryFind (fun e -> x % e = 0L && Common.isPrime (x/e |> int64)) 
    |> (fun e -> x/e.Value)

// 6857