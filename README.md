# RoboTupiniquim

![GifDaTelaDeBoot](https://imgur.com/kIDcFSk.gif)

## Descrição

Ao pedido da Agência Espacial Brasileira (AEB), a Academia do Programador foi solicitada para criar
um programa para controlar dois rovers que estão operando em marte.

![LogoAEB](https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/AEB-Brazil.svg/1200px-AEB-Brazil.svg.png)

## Tecnologias Utilizadas

[![Tecnologias](https://skillicons.dev/icons?i=git,github,cs,dotnet,visualstudio)](https://skillicons.dev)

## Funcionamento

![GifDoFuncionamento](https://imgur.com/da7Fs6n.gif)

O usuário insere o tamanho da área na qual o robô está operando (coincidentemente, a superfície de marte
onde nosso robô está operando tem um formato muitas vezes retangular), após isso é necessário inserir a 
posição onde o robô atualmente se encontra para podermos iniciar os comandos.<br>
Os comandos são recebidos pelos robôs a partir de uma string fornecida pelo operador.Os comandos sendo:

- E: Vira 90º no próprio eixo a esquerda.
- D: Vira 90º no próprio eixo a direita.
- M: Se move uma posição a frente na dada direção que está apontando.

## Como usar

**Clone o repositório**

```
git clone https://github.com/academiadoprogramador-fullstack/jogo-da-forca-2025.git
```

**Navegue até a pasta raiz da solução**

```
cd jogo-da-forca-2025
```

**Restaure as dependências**

```
dotnet restore
```

**Navegue até a pasta do projeto**

```
cd JogoDaForca.ConsoleApp
```

**Execute o projeto**

```
dotnet run
```


