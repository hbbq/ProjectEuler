module Common

let fibonacciSeries =
    let rec fib this previous = seq {
        yield this
        yield! fib (this + previous) this
    }
    fib 0 1