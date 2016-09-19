module Problem_015

open Xunit

let problem =
    let paths size =
        Common.factorial (size+size) / (Common.factorial size * Common.factorial size)
    paths 20

[<Fact>]
let Test() = Assert.Equal(problem, 137846528820I)