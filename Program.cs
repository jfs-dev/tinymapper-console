using Nelibur.ObjectMapper;
using tinymapper_console.Models;
using tinymapper_console.DTOs;

TinyMapper.Bind<Usuario, UsuarioDto>(config =>
{
	config.Ignore(x => x.Password);
	config.Ignore(x => x.Admin);
	config.Bind(source => source.Email, target => target.Usuario);
});

var peterParker = new Usuario
{
	Id = Guid.NewGuid(),
	Nome = "Peter Parker",
	Email = "peter.parker@marvel.com",
    Password = "MaryJane",
    Admin = true
};

var peterParkerDto = TinyMapper.Map<UsuarioDto>(peterParker);

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"{peterParker.Id} - {peterParker.Nome} - {peterParker.Email} - {peterParker.Password} - {peterParker.Admin}");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{peterParkerDto.Id} - {peterParkerDto.Nome} - {peterParkerDto.Usuario}");
