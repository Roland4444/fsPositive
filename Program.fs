// For more information see https://aka.ms/fsharp-console-apps

let rec transformLst(input: List<int>, result: List<int>) =
    match input with
    | [] | [ _ ]-> result
    | _ -> let h2 = input.Tail.Head
           let lst = [input.Head * h2] 
           transformLst((input.Tail), (result @ lst))  

[<EntryPoint>]
let main args =
    printfn "Hello from F#"
    let list1 = [1;2;3;4;5]
    printfn "list1.IsEmpty is %b" (list1.IsEmpty)
    printfn "list1.Length is %d" (list1.Length)
    printfn "list1.Head is %d" (list1.Head)
    printfn "list1.Tail.Head is %d" (list1.Tail.Head)
    printfn "list1.Tail.Tail.Head is %d" (list1.Tail.Tail.Head)
    printfn "list1.Item(1) is %d" (list1.Item(1))
    0          