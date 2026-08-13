string NomeProfissional = "João Programador";
string EmailContato = "joao.prog@exemplo.com";
int AnoNascimento = 2007;
bool EstaDisponivel = true;
int Idade = DateTime.Now.Year - AnoNascimento;

Console.WriteLine($"Nome do Profissional: {NomeProfissional}");
Console.WriteLine($"Email de Contato: {EmailContato}");
Console.WriteLine($"Idade do Contato: {Idade}");
Console.WriteLine($"Disponibilidade: {(EstaDisponivel ? "Disponível para projeto!" : "Indisponível no momento")}");
Console.WriteLine();

EstaDisponivel =  false;
Console.WriteLine($"Nome do Profissional: {NomeProfissional}");
Console.WriteLine($"Email de Contato: {EmailContato}");
Console.WriteLine($"Idade do Contato: {Idade}");
Console.WriteLine($"Disponibilidade: {(EstaDisponivel ? "Disponível para projeto!" : "Indisponível no momento")}");