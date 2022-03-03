//session 3
module File3

//map , filter, fold , lambda

//[1] = 1 :: []

let negate x = -x
List.map negate [1 .. 10]
//same using lambda:
List.map (fun x -> -x) [1 .. 10]

//Currying 
//VIA fitness customers
type Cuustomer = {
    id : string
    Name : string
    isVIAStudent : bool
}
let calculateMonthlyPoints customer points = 
    let bonus  =
        if customer.isVIAStudent && points >= 200.0 then
            (points * 0.1)
        else 
            0.0
    let total = points + bonus
    if total >= 250.0 then printfn "Your reward for %.2f is: 1 week free entrance" total
    else printfn "Keep on working hard. You need %.2f points to get a reward" (250.0 - total)
    
let jannik = {id= "stu100"; Name= "Jannik"; isVIAStudent = true}
let paw = {id= "paw100"; Name = "Paw patrol"; isVIAStudent = false}

// 3.1 F# function countNumOfVowelsto count the number of vowels in a given string.
//without fold
let rec countNumOfVowels (s:string) =   
        match s with 
            | "" -> 0
            | s -> if (s.[0] = 'a') || (s.[0]  = 'o')|| (s.[0]  = 'i')|| (s.[0]  = 'e')|| (s.[0]  = 'u') then 1 + countNumOfVowels s.[1..] else countNumOfVowels s.[1..]


let a = countNumOfVowels "Higher-order functions can take and return functions of any order"
//using fold //???? NOT FINISHED
let a = List.fold (fun (a:char) -> if (a = 'a') || (a  = 'o')|| (a  = 'i')|| (a  = 'e')|| (a  = 'u') then () else (do nothing)) 0 s

//3.2 Define a function primesUpTo nto create a list of prime numbers up to a given number. For instance: primesUpTo 10results in [2; 3; 5; 7]

let isPrime n =
    match n with
    | _ when n < 2 -> false
    | _ when n > 3 && (n % 2 = 0 || n % 3 = 0) -> false
    | _ ->
        let maxDiv = int(System.Math.Sqrt(float n)) + 1
        let rec f d i = 
            if d > maxDiv then 
                true
            else
                if n % d = 0 then 
                    false
                else
                    f (d + i) (6 - i)     
        f 5 2

let rec listToN n = 
     match n with
        | 0 -> [0]
        | _ -> n :: listToN (n-1)

let b = listToN 10

let primesUpTo n = 
    List.rev (List.filter isPrime (listToN n))

let result  = primesUpTo 10

//3.3 Definean F# function pclFib n that, when given a number, returns the nth Fibonacci number.
//let rec pclFib n  = 
    
//n long fib sequence
//last element?

let rec pclFib n = 
    match n with 
        | 0 -> 0
        | 1 -> 1
        | 2 -> 1
        | _ -> pclFib(n-1) + pclFib(n-2)

let a = pclFib 9 

//3.4
let doubleNum x =
    x*2

let sqrNum x = 
    x*x

let pclQuad x = 
    doubleNum (doubleNum x)

let pclFourth x = 
    sqrNum (sqrNum x)