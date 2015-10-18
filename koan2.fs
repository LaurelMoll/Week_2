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
        
// koan function
let rec dosomethingrandom x =
    if x = 0 then 1
    else dosomethingrandom (x-1) * x

[<EntryPoint>]
let main argv =
    
    let input = checkvalue argv
    let calc = dosomethingrandom input
    Console.WriteLine(calc)
    
    0 // return integer for exit