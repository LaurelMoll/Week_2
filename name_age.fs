open System

// Check that value entered for age is an integer
let checkval (argv : string) : int = 
    let couldparse, consolein = Int32.TryParse(argv)
    if couldparse then consolein
    else
        Console.WriteLine("That is not a valid age.")
        Console.Write("Age: ")
        let canparse, keyin = Int32.TryParse(Console.ReadLine())
        if canparse then keyin
        else 0

// Returns the appropriate string according to the assignment rules given the age.
let determine_teen (n : int) : string =
    if n >= 20 then "is no longer a teenager"
    elif n >= 13 then "is a teenager"
    else "is a child"    
    
[<EntryPoint>]
let main argv =
     // Give instructions
     Console.WriteLine("Please enter the name and age of each person. When finished, enter ? for name,")
     Console.WriteLine("and the program will end.")
     
     // Set up loop to execute until ? is entered as a name.
     let mutable keep_looping = true
     while keep_looping do
         // Ask for name and age, check to make sure name is a string and age is a positive int
         Console.Write("Name: ")
         let name = Console.ReadLine() //Automatically a string... no wrong input?
         
         //check to see if the person wants to exit
         if name = "?" then keep_looping <- false
         else
             // keep asking for the age until we get a valid, positive integer.
             let mutable correct_age = false
             let mutable age = 0
             while not correct_age do
                 Console.Write("Age: ")
                 let input = Console.ReadLine()
                 age <- checkval input
                 if age <= 0 then Console.WriteLine("That is not a valid age.")
                 else correct_age <- true
     
             // Check to see what category the person is in
             let teen_status = determine_teen age
     
             // Write output
             Console.WriteLine("Name: " + name + " | Age: " + (string age) + " | " + name + " " + teen_status + ".")
     
     //Console.ReadKey() |> ignore // in my console, it looks better without this
     
     0 // return exit integer