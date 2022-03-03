
module GoodiesToGo

type Customer = VIAPerson | SOSUPerson 

type Size = Small | Medium | Large
type CoffeType = Latte | Mocca | Cappuchino
type TeaType  = EarlGrey | GreenTea | BlackTea
type JuiceType = AppleJuice | OrangeJuice | GrapeJuice


type Coffe = {
coffeType: CoffeType
size: Size
}

type Tea = {
teaType: TeaType
size: Size
}

type Juice = {
juiceType = JuiceType
size: Size
}

type Drink = Coffe | Tea | Juice


let coffePrice (coffe:Coffe) = 
    match coffe.coffeType with 
    | Latte -> if coffe.size = Small then 12 elif coffe.size = Medium then 15 else 20 
    | Mocca -> if coffe.size = Small then 11 elif coffe.size = Medium then 18 else 20
    | Cappuchino -> if coffe.size = Small then 10 elif coffe.size = Medium then 20 else 30

let teaPrice (tea:Tea) = 
    match tea.teaType with
    | EarlGrey -> if tea.size = Small then 5 elif tea.size = Medium then 7 else 9 
    | GreenTea -> if tea.size = Small then 6 elif tea.size = Medium then 8 else 10 
    | BlackTea -> if tea.size = Small then 4 elif tea.size = Medium then 5 else 6 

let juicePrice (juice:Juice) = 
    match juice.juiceType with
    | AppleJuice -> if juice.size = Small then 5 elif juice.size = Medium then 7 else 9 
    | OrangeJuice -> if juice.size = Small then 5 elif juice.size = Medium then 7 else 9  
    | GrapeJuice -> if juice.size = Small then 5 elif juice.size = Medium then 7 else 9 

let calculatePrice d:Drink = 
    match 



