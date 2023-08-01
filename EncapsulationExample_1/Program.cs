//Encapsulation is information hiding/secured
using EncapsulationExample_1;

var erik = new Person();
var myWallet = erik.CheckWallet();

Console.WriteLine("Money in wallet:");
Console.WriteLine(myWallet);

Console.WriteLine("Adding money...");


erik.AddMoney(1000.00);
myWallet = erik.CheckWallet();

Console.WriteLine(myWallet);
var str = "string";
 

