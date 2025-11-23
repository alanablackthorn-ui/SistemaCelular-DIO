# Sistema de Celulares – DIO

Projeto desenvolvido como parte de um desafio da trilha **.NET da DIO**, com o objetivo de praticar **POO em C#** criando uma abstração de celular com diferentes modelos.

O sistema simula ações básicas de um celular, permitindo que cada marca tenha seu próprio comportamento.

---

## Tecnologias utilizadas

- [.NET](https://dotnet.microsoft.com/)
- C#
- VS Code

---

## Descrição do projeto

O projeto contém uma classe base abstrata `Celular` e algumas classes que herdam dela:

- `Iphone`
- `Samsung`
- `Xiaomi` (extra que eu adicionei 💚)

Cada aparelho pode:

- Ligar
- Receber ligação
- Enviar mensagem

No `Program.cs` são criadas instâncias dos celulares e chamadas as ações para demonstrar o funcionamento.

Exemplo de saída no console:

```text
iPhone está ligando...
Samsung recebendo ligação...
Redmi Note 13 (1199999-0003) enviou: Oi, sou um Xiaomi!

SistemaCelular-DIO/
 ├── Models/
 │   ├── Celular.cs
 │   ├── Iphone.cs
 │   ├── Samsung.cs
 │   └── Xiaomi.cs
 ├── Program.cs
 └── SistemaCelular.csproj
## Como executar o projeto

### Clonar o repositório:
```bash
git clone https://github.com/alanablackthorn-ui/SistemaCelular-DIO.git

Entrar na pasta do projeto:
cd SistemaCelular-DIO

Rodar a aplicação:
dotnet run
