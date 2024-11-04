// For more information see https://aka.ms/fsharp-console-apps

let rec transformLst(input: List<int>, result: List<int>) =
    match input with
    | [] | [ _ ]-> result
    | _ -> transformLst((input.Tail), (result @ [input.Head * input.Tail.Head]))  

let calculatePositiveCounter(input: List<int>) = 
    (List.filter(fun (z:int) -> z < 0) (transformLst(List.filter (fun (p:int) -> p <> 0) input, []))).Length

let ListFromString(input: string) = 
    let lstStr = input.Split ' ' 
    List.map (fun f -> f |> int) (lstStr |> Array.toList)
    

[<EntryPoint>]
let main args =
    let lst1 = [-1; 0; 1]
    let lst2 = [-2; -5; 10]
    let lst3 = [11; 23; -5; 0]
    let lst4 = [43; 0; 23; -2; -3; 4; -1]
    let listLst = [lst1; lst2; lst3; lst4]
    List.iter (fun p -> printfn "%d" (calculatePositiveCounter(p))) listLst 
    let lst12 = "-1 0 1"
    let lst22 = "-2 -5 10"
    let lst32 = "11 23 -5 0"
    let lst42 = "43 0 23 -2 -3 4 -1"
    let listLst2 = [lst12; lst22; lst32; lst42]
    List.iter (fun p -> printfn "%d" (calculatePositiveCounter(ListFromString(p)))) listLst2 
    0          