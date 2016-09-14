module Common

module Int =
    let sqrt = float >> sqrt >> int

let fibonacciSeries =
    let rec fib this previous = seq {
        yield this
        yield! fib (this + previous) this
    }
    fib 0 1

let isPrime number =
    if number < 2 then false
    elif number = 2 then true
    elif number % 2 = 0 then false
    else
        {3..2..Int.sqrt number} |> Seq.tryFind (fun e -> number % e = 0) |> fun e -> e.IsNone