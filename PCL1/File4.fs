
module File4

"Life" |> ("Sweet " |> (fun x y z -> x + y + z)) "Challenging "

open System.IO

let dirArray = System.IO.Directory.GetFiles("C:\\pcl1", "*.txt") 
let nameArray = Array.map (fun (x:string)-> (Path.GetFileName(x))) dirArray
Array.iter (fun x -> printfn "%s" x) nameArray

//using |> pipelining
System.IO.Directory.GetFiles("C:\\pcl1","*.txt")
|> Array.map (fun x -> (Path.GetFileName(x)))
|> Array.iter (fun x -> printfn "%s" x)

//remove lambda
System.IO.Directory.GetFiles("C:\\pcl1","*.txt")
|> Array.map Path.GetFileName
|> Array.iter (printfn "%s" )


//Geometry exercise

type PclShape = Rectangle int*int | RightTriangle 
type Rectangle = {
    a : float
    b : float
}
type RightTriangle = {
 a : float
 b : float 
 c: float
}
let pclArea (x:PclShape) = 
    match x with
        | Rectangle -> x.a * x.b
        | RightTriangle -> 0.5 * x.a * x.b


let pclPerimeter x:Rectangle = 
    2f*x.a + 2f*x.b 

type pclShapeR   = {a: float;b:float}