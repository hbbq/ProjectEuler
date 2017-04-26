module Problem_055

open Xunit

let problem =
    let test (n:int) =
        let rec i n l =
            if l > 50 then l
            elif l > 1 && n.ToString() = Common.String.reverse (n.ToString()) then l
            else i (n + bigint.Parse(Common.String.reverse (n.ToString()))) (l + 1)
        i (bigint n) 1
   
    [1..9999] |> List.map test |> List.filter (fun e -> e > 50) |> List.length
       
[<Fact>]
let Test() = Assert.Equal(problem, 249)