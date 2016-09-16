module Problem_006

open Xunit

let problem =
    let square x = x * x
    let sumOfSquares x = x |> List.sumBy square
    let squareOfSum x = x |> List.sum |> square
    let diff x = squareOfSum x - sumOfSquares x
    diff [1..100]
    
[<Fact>]
let Test() = Assert.Equal(problem, 25164150)