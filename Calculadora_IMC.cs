using System;

class CalculadoraIMC {
    static void Main() {
        Console.WriteLine("----- Calculadora de IMC -----");

        // Solicita o peso do usuário
        Console.Write("Digite seu peso (kg): ");
        float peso = float.Parse(Console.ReadLine());

        // Solicita a altura do usuário
        Console.Write("Agora, digite sua altura (m): ");
        float altura = float.Parse(Console.ReadLine());

        // Calcula o IMC
        float imc = peso / (altura * altura);

        // Exibe o IMC calculado
        Console.WriteLine($"\nSeu IMC é: {imc:F2}");

        // Classificação de acordo com o IMC
        if (imc < 16) {
            Console.WriteLine("Classificação: Magreza nível III (grave)");
        }
        else if (imc >= 16 && imc < 17) {
            Console.WriteLine("Classificação: Magreza nível II (moderada)");
        }
        else if (imc >= 17 && imc < 18.5) {
            Console.WriteLine("Classificação: Magreza nível I (leve)");
        }
        else if (imc >= 18.5 && imc < 25) {
            Console.WriteLine("Classificação: Peso ideal (normal)");
        }
        else if (imc >= 25 && imc < 30) {
            Console.WriteLine("Classificação: Pré-obesidade (sobrepeso)");
        }
        else if (imc >= 30 && imc < 35) {
            Console.WriteLine("Classificação: Obesidade grau I");
        }
        else if (imc >= 35 && imc < 40) {
            Console.WriteLine("Classificação: Obesidade grau II");
        }
        else {
            Console.WriteLine("Classificação: Obesidade grau III (mórbida)");
        }
    }
}
