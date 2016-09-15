﻿module Problem_055

let problem =
    let test (n:int) =
        let rec i n l =
            if l > 50 then l
            elif l > 1 && n.ToString() = Common.String.Reverse (n.ToString()) then l
            else i (n + bigint.Parse(Common.String.Reverse (n.ToString()))) (l + 1)
        i (bigint n) 1
   
    [1..9999] |> List.map test |> List.filter (fun e -> e > 50) |> List.length

// 249