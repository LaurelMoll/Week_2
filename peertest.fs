open System

let getPerson =
 Console.Write( "Enter someones name: " )
 let name = Console.ReadLine()
 name

let getAge name =
 Console.Write( "Enter the age of " + name + ": " )
 let age = Console.ReadLine()
 let age = int age
 age

[<EntryPoint>]
let main argv = 
 let person = getPerson
 let age = getAge person
 let comment = 
  if age < 13 then
   sprintf "%s , at %i is still only a child" person age
  elif age < 20 then
   sprintf "%s , at %i is a teenager" person age
  else
   sprintf "%s , at %i is nolonger a teenager" person age
 printfn "%A" comment
 Console.ReadKey() |> ignore

 0 // return an integer exit code