// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("The current time is" + DateTime.Now);
Console.WriteLine("Hello Courtney!");

const int newNum = 7; 
double myDoubleNum = 19.99;

Console.WriteLine(myDoubleNum);
Console.WriteLine(newNum);

string firstName = "Jonathan";
Console.WriteLine(firstName);

string lastName = "Palalay";
string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);

int x = 20, y = 21, z = 50;
Console.WriteLine(x + y + z);

if (x > y){
    Console.WriteLine("x is greater than y");
}
else{
    Console.WriteLine("Fail");
}

int time = 22;

if(time < 10)
{
    Console.WriteLine("Good Morn");
}
else if(time < 23)
{
    Console.Write("Good day");
}
else
{
    Console.Write("Good evening");
}


int day = 4;
switch(day)
{
    case 1: 
        Console.Write(" Monday");
        break;
    case 2: 
        Console.Write(" Tuesday");
        break;
    case 3: 
        Console.Write(" Wednesday");
        break;
    case 4: 
        Console.Write(" Thursday");
        break;
    case 5: 
        Console.Write(" Friday");
        break;
    case 6: 
        Console.Write(" Saturday");
        break;
    case 7: 
        Console.Write(" Sunday");
        break;
}

string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
cars[0] = "Honda";
Console.WriteLine(cars[0]);
Console.WriteLine(cars.Length);

for(int i = 0; i<cars.Length; i++){
    Console.WriteLine(cars[i]);
}

foreach(string i in cars){
    Console.WriteLine(i);
}

Car myObj = new Car();

class Car{
    public string color = "red";
    public Car()
    {
        
        Console.WriteLine(color);    
    }
}