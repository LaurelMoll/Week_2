open System

// converts input value to an integer (or reads it from the console)
let checkvalue (argv : string []) : int = 
    if argv.Length > 0 then
        let couldparse, consolein = Int32.TryParse(argv.[0])
        if couldparse then consolein
        else
            let canparse, keyin = Int32.TryParse(Console.ReadLine())
            if canparse then keyin
            else 0
    else
        let canparse, keyin = Int32.TryParse(Console.ReadLine())
        if canparse then keyin
        else 0

// code that gives fibonacci number (no recursion)
let fibonacci n =
    let mutable first = 0
    let mutable second = 1
    let mutable temp = 0
    
    for index = 1 to n do
        temp <- first + second
        first <- second
        second <-temp
    
    first // return number

[<EntryPoint>]
    let main argv =
        
        let input = checkvalue argv
        
        // find fib num
        let fib = fibonacci input
        Console.WriteLine(fib)
        Console.ReadKey() |> ignore
        
        0 //return int