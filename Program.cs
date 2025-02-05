// Classe Conta que representa uma conta bancária, com atributos Titular, agência, número da conta, saldo e limite.  
// Inclui um método que retorna as informações detalhadas da conta.  
Titular t = new();
Conta c = new();

t.Nome = "George Harrison";
t.Cpf = "000.000.000-00";
t.Endereco = "Rua dos Besouros - Liverpool";

c.Titular = t;
c.Agencia = 1;
c.NumeroConta = 2234;
c.Saldo = 10000000.0;
c.Limite = 100000.0;

Console.WriteLine("Informações do Titular: ");
Console.WriteLine($"Nome: {c.Titular.Nome}");
Console.WriteLine($"CPF: {c.Titular.Cpf}");
Console.WriteLine($"Endereço: {c.Titular.Endereco}");

Console.WriteLine("\nInformações da conta");
Console.WriteLine(c.Informacoes);
Console.WriteLine($"Limite: {c.Limite}");