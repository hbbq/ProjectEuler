module Common

module Int =
    let sqrt = float >> sqrt >> int

module Int64 =
    let sqrt = float >> sqrt >> int64
    
module String =    
    let Reverse (s:string) = s.ToCharArray() |> Array.rev |> Array.map string |> String.concat ""

module List =
    let exclude excludes source =
        source 
        |> List.where (fun e -> not (List.contains e excludes))

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
        {3L..2L..Int64.sqrt number} |> Seq.tryFind (fun e -> number % e = 0L) |> (=) None
                
let infinite start =
    Seq.initInfinite ((+) start)
    
let rec infiniteSeq start increment = 
    seq {
        yield start
        yield! infiniteSeq (start + increment) increment
    }

let primeSequence = 
    seq {
        yield 2L
        yield! ((infiniteSeq 3L 2L) |> Seq.filter isPrime)
    }

let getDivisors n = 
    {1..n/2}
    |> Seq.filter (fun e -> n % e = 0)

let factorial n =
    [1..n] 
    |> List.fold (fun a e -> a * (bigint e)) 1I
