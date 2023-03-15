namespace ExercicioAlunos;
class Program
{
    static void Main(string[] args){
        Console.Write("Digite seu nome: ");
        string? nome = Console.ReadLine();
        Console.WriteLine("Seu nome é: " + nome);
        Console.Write("Digite um número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("O número digitado foi " + numero1);
        Console.Write("Digite um número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("O número digitado foi " + numero2);
        
        double media = (numero1+numero2)/2;
        
        Console.Write("A média é "+ media);
    } 
    }
