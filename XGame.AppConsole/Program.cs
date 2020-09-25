using System;
using System.Linq;
using XGame.Domain.Arguments.Player;
using XGame.Domain.Services;

namespace XGame.AppConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Iniciando...");

      var service = new ServicePlayer();
      Console.WriteLine("Criando instancia do serviço.");

      AuthenticatePlayerRequest authRequest = new AuthenticatePlayerRequest();
      Console.WriteLine("Criando instancia do meu objeto request.");

      authRequest.Email = "teste@name.com";
      authRequest.Password = "123456";

      var addRequest = new AddPlayerRequest() 
      {
        FirtName = "Murilo",
        LastName = "Viscondi",
        Email = "muriloviscondi@gmail.com",
        Password = "123456"
      };

      var addResponse = service.AddPlayer(addRequest);
      
      var authResponse = service.AuthenticatePlayer(authRequest);

      Console.WriteLine("Serviço é valido -> " + service.IsValid());

      service.Notifications.ToList().ForEach(x =>
      {
        Console.WriteLine(x.Message);
      });

      Console.ReadKey();
    }
  }
}
