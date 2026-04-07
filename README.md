#  Termo 2026!

![](/docs/termo.gif)

##  Introdução
O **Termo** é um jogo de adivinhação de palavras onde o jogador precisa descobrir uma palavra secreta de 5 letras. A cada tentativa, o sistema fornece dicas visuais para ajudar o jogador.

---
##  Objetivo do Jogo
Descobrir a palavra secreta antes que as tentativas acabem.

A cada tentativa:
-  Letra não existe  
-  Letra existe, posição errada  
-  Letra correta  

---

##  Regras e Funcionalidades

### 1.  Escolha da Palavra
- Lista de palavras com 5 letras  
- Palavra escolhida aleatoriamente  
- Palavra oculta ao jogador  

### 2.  Feedback Visual
-  Vermelho: não existe  
-  Amarelo: posição errada  
-  Verde: posição correta  

---

##  Vitória
- Acertar a palavra  
- Exibe mensagem de sucesso  
- Pressione S ou N para continuar  

---

##  Derrota
- Máximo de 5 tentativas  
- Exibe mensagem de derrota  
- Pressione S ou N para continuar   

---
 ## Como utilizar o programa
 
 1. Clone o repositório ou baixe o código comprimido em .zip.
 2. Abra o emulador de terminal e navegue até a pasta raiz.
 3. Utilize o 'comando' abaixo para restaurar as dependencias do projeto.

 ```
 dotnet restore
 ```

 4. Em seguida compile e execute o projeto com o comando:

 ```
 dotnet run --project CalculadoraConsoleApp
 ````
 ## Requisitos
 - .NET SDK 10.0