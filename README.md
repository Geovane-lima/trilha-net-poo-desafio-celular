📱 Desafio de Projeto: Abstração de Celulares em C# 🚀
Este projeto faz parte do desafio proposto no módulo de Orientação a Objetos da trilha .NET da Digital Innovation One. O objetivo é criar uma aplicação console que modele o comportamento de diferentes marcas de celulares utilizando conceitos de orientação a objetos.

📝 Descrição do Projeto
O projeto consiste em desenvolver uma aplicação em .NET que simule o funcionamento de diferentes modelos de celulares (Nokia e iPhone), abstraindo suas características e comportamentos, de acordo com o diagrama abaixo:
![Diagrama classes](Imagens/diagrama.png)


🔧 Tecnologias Utilizadas
1 - C#
2 - .NET Core

🛠️ Estrutura do Projeto
Classe Abstrata Smartphone: Contém os atributos e métodos básicos que todo celular deve ter.
1. Atributos:
 - string Numero
 - string Modelo
 - string IMEI
 - int Memoria
2. Métodos:
 - void Ligar(): Liga o celular.
 - void ReceberLigacao(): Recebe uma chamada.
 - abstract void InstalarAplicativo(string nomeApp): Método abstrato para instalar um aplicativo.
  
Classe Nokia: Herda da classe Smartphone e implementa o método InstalarAplicativo.
Método:
void InstalarAplicativo(string nomeApp): Lógica específica para instalar aplicativos em um Nokia.
Classe Iphone: Herda da classe Smartphone e implementa o método InstalarAplicativo.
Método:
void InstalarAplicativo(string nomeApp): Lógica específica para instalar aplicativos em um iPhone.

📊 Funcionalidades Demonstradas
Criar instâncias de diferentes marcas de celulares.
Simular ligações e recebimento de chamadas.
Instalar aplicativos de acordo com a marca do celular.

💡 Conceitos Aplicados
Herança: As classes Nokia e Iphone herdam da classe Smartphone.
Polimorfismo: Implementação do método InstalarAplicativo de forma diferente em cada classe filha.
Abstração: Criação de uma classe base abstrata que define as propriedades e métodos comuns a todos os smartphones.