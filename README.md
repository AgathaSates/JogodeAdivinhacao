# Jogo de Adivinhação

![](https://i.imgur.com/LHtpLvv.gif)

## Introdução

Este é um jogo de adivinhar um número aleatório entre 1 e 20. O jogador deve tentar adivinhar este número com a quantidade de chances disponiveis de acordo com a dificuldade escolhida.

## Como Jogar

- Escolha o nivel de dificuldade.

Os níveis de dificuldade serão: 

1. Fácil = 10 chances 
2. Normal = 5 chances     
3. Difícil = 3 chances

- Digite um número até suas chances acabarem ou acertar o número.

## Funcionalidades

- **Geração de Número Secreto:** Ao início do jogo, um número secreto é gerado aleatoriamente entre 1 e 20.
- **Nível de Dificuldade:** Os jogadores podem escolher entre três níveis de dificuldade (Fácil, Normal e Difícil), que influenciam o número de tentativas.
- **Dica:** Após cada tentativa, o jogo fornece uma dica indicando se o número escolhido é maior ou menor que o número secreto.

## Como utilizar

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.

## 1. Clone o repositório.
 
```
git clone https://github.com/AgathaSates/JogodeAdivinhacao.git
```
### 2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz

```
cd jogodeadivinhacao
```

### 3. Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```

#### 4. Navegue até a pasta do projeto

```
cd JogodeAdivinhacao.ConsoleApp
```

#### 5. Execute o projeto

```
dotnet run
```

