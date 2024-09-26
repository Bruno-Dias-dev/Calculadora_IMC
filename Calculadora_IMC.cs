using system;

class calculadoraIMC {

    static void Main() {

        Console.WriteLine("-----Calculadora IMC-----");
          
        Console.WriteLine("Digite seu peso:");
        float peso = float.Parse(Console.ReadLine());

        Console.WriteLine("Agora, digite sua altura:");
        float altura = float.Parse(Console.ReadLine());

        imc = peso / (altura * altura );

        if (imc < 16 ) {
    
        Console.WriteLine("Você tem magreza nível III");

        }

        else if (imc >= 16 && imc <  16,9 ) {

        Console.WriteLine("Você tem magreza nível II");

        }


        else if (imc >= 17 && imc < 18,4) {

        Console.WriteLine("Você tem magreza nível I");
        }

        else if (imc >= 18,5 && imc < 24,9) {
            Console.WriteLine("Você está no peso ideal");
        }

        else if (imc >= 25,0 && imc < 29,9) {
            Console.WriteLine("Você está Pré-Obeso");
        }

        else if (imc >= 30,0 && imc < 34,9) {
            Console.WriteLine("Você está com obesidade grau I");
        }

        else if (imc >= 35,0 && imc < 39,9) {
            Console.WriteLIne("Você está com obesidade grau II");
        }

        else (imc >= 40) {
            Console.WriteLine("Você está com obesididade grau III");
        }

    }
}
