
module File1
//PCL1 Course 
(*djnjdnjvnfiodnfiondfw*)
//XML document
//sunny and nice day
let funnyDay = "Fun and sunny day"

let point1 = 5
let point2 = 10
//add two points
let addPoints = point2 + point1

//compute the factorial of an interger
let rec factorial1 x =
    if x <= 1 then 
        1 
    else
        x * factorial1(x-1)

let a = factorial1 10

//add element '1' to the array 
1 :: [2; 5; 3; 7];;

//lenght of array
List.length [2; 5; 3; 7];;

[2; 5; 3; 7] : 4;; //expected: 'int list list'  found: int 


[1; 2; 3] @ [4] //ok? 

// a second factorial function
// base case ===> when n = 0
// recursive case ====> n > 1

let rec factorialPM n = 
    match n with   
    | 0 -> 1
    | _ -> n * factorialPM(n-1)

/// Adding Vectors
let vecAdd (x1:float,y1:float) (x2,y2) = (x1+x2, y1+y2)

/// Calculate the length of a list
let rec lengthOfList lst =
    match lst with
    | [] -> 0
    | (hd::rest) -> 1 + lengthOfList rest


let rec factorialFailWith n = 
    match n with   
    | 0 -> 1
    | _ -> if n > 0 
           then n * factorialFailWith(n-1)
           else failwith "Non natural number. It should be a positive number"