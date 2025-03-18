# Jogo de Adivinha��o

![Status Desenvolvimento](https://img.shields.io/badge/Status-Em%20Desenvolvimento%20-yellow)

### Demonstra��o
Este � um jogo de adivinhar um n�mero aleat�rio entre 1 e 20. O jogador deve tentar adivinhar este n�mero com a quantidade de chances disponiveis de acordo com a dificuldade escolhida.
>![](https://i.imgur.com/PkEJPYz.gif)

## �ndice

- [Introdu��o](#introducao)
- [Funcionalidades](#funcionalidades)
- [Como Usar](#como-usar)
- [Sobre o Projeto](#sobre-o-projeto)


## Introdu��o

- Escolha o n�vel de dificuldade.
- Digite um n�mero at� suas chances acabarem ou acertar o n�mero.

## Funcionalidades

- **Gera��o de N�mero Secreto:** Ao in�cio do jogo, um n�mero secreto � gerado aleatoriamente entre 1 e 20.
- **N�vel de Dificuldade:** Os jogadores podem escolher entre tr�s n�veis de dificuldade , que influenciam o n�mero de tentativas.
- **Dica:** Ap�s cada tentativa, o jogo fornece uma dica indicando se o n�mero escolhido � maior ou menor que o n�mero secreto.
- **Valida��o de entrada:** Garante que apenas as op��es v�lidas sejam aceitas. 

## Como utilizar

### Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.

### 1. Clone o reposit�rio.
 
```
git clone https://github.com/AgathaSates/JogodeAdivinhacao.git
```
### 2. Abra o terminal ou o prompt de comando e navegue at� a pasta raiz

```
cd jogodeadivinhacao
```

### 3. Utilize o comando abaixo para restaurar as depend�ncias do projeto.

```
dotnet restore
```

### 4. Navegue at� a pasta do projeto

```
cd JogodeAdivinhacao.ConsoleApp
```

### 5. Execute o projeto

```
dotnet run
```

