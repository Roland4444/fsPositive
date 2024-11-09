let rec transformLst(input: List<int>, result: List<int>) =
    match input with
    | [] | [ _ ]-> result
    | _ -> transformLst((input.Tail), (result @ [input.Head * input.Tail.Head]))  

let calculatePositiveCounter(input: List<int>) = 
    (List.filter(fun (z:int) -> z < 0) (transformLst(List.filter (fun (p:int) -> p <> 0) input, []))).Length

let ListFromString(input: string) = 
    List.map (fun f -> f |> int) (input.Split ' '  |> Array.toList)    

[<EntryPoint>]
let main args =
    let listLst2 = ["-1 0 1"; "-2 -5 10"; "11 23 -5 0"; "43 0 23 -2 -3 4 -1"]
    List.iter (fun p -> printfn "%d" (calculatePositiveCounter(ListFromString(p)))) listLst2 
    0          