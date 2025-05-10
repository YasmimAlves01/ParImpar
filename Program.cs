using System.Diagnostics;

double number;
string decisao;

Console.WriteLine("Bem vindo ao seu definidor de numero!");
Console.WriteLine("Digite um numero e descubra se ele é par ou impar");

number = Convert.ToDouble(Console.ReadLine());

if (number % 2 == 0 ){
    Console.WriteLine($"{number} é um numero par");
}
else{
    Console.WriteLine($"{number} é um numero impar");
}


while (true)
{
Console.WriteLine("Deseja começar novamente?");
Console.WriteLine("Digite S para sim e N para não");
decisao = Console.ReadLine()!.ToUpper();

if(decisao == "S"){
    Console.WriteLine("Digite novamente um numero e descubra se ele é par ou impar");

number = Convert.ToDouble(Console.ReadLine());

if (number % 2 == 0 ){
    Console.WriteLine($"{number} é um numero par");
}
else{
    Console.WriteLine($"{number} é um numero impar");
}

}

else{
    Console.WriteLine("Muito obrigado por usar nossa aplicação ;)");
    break;
}
}
