using Generics;
using Generics.Modelos;

Console.WriteLine("Hello, World!");

Carro carro = new Carro()
{
    Marca = "FIAT",
    Modelo = "UNO"
};

Casa casa = new Casa()
{
    Cidade = "Brasília",
    Endereco = "QSQ 400"
};

Usuario usuario = new Usuario()
{
    Nome = "Maria",
    Email = "maria@email.com.br",
    Senha = "123456"
};

Serializador.Serializar(carro);
Serializador.Serializar(casa);
Serializador.Serializar(usuario);

Carro carroDeserializado = Serializador.Deserializar<Carro>();
Casa casaDeserializado = Serializador.Deserializar<Casa>();
Usuario usuarioDeserializado = Serializador.Deserializar<Usuario>();

Console.WriteLine($"CarroDeserializado: {carroDeserializado.Marca} - {carroDeserializado.Modelo}");
Console.WriteLine($"CasaDeserializado: {casaDeserializado.Cidade} - {casaDeserializado.Endereco}");
Console.WriteLine($"UsuarioDeserializado: {usuarioDeserializado.Nome} - {usuarioDeserializado.Email} - {usuarioDeserializado.Senha}");

Console.ReadKey();

