module Common

module Int =
    let sqrt = float >> sqrt >> int

module Int64 =
    let sqrt = float >> sqrt >> int64
    
module String =    
    let Reverse (s:string) = new string(Array.rev (s.ToCharArray()))

let fibonacciSeries =
    let rec fib this previous = seq {
        yield this
        yield! fib (this + previous) this
    }
    fib 0 1
    
let isPrime number =
    if number < 2L then false
    elif number = 2L then true
    elif number % 2L = 0L then false
    else
        {3L..2L..Int64.sqrt number} |> Seq.tryFind (fun e -> number % e = 0L) |> fun e -> e.IsNone
                
let primeSequence =
    let rec s n = seq {
        yield n
        yield! s (n+1L)
    }
    s 2L
    |> Seq.where isPrime
        
