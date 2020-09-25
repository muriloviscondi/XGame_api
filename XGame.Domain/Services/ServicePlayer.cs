using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using XGame.Domain.Arguments.Player;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Repositories;
using XGame.Domain.Interfaces.Services;
using XGame.Domain.Resources;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Services
{
  public class ServicePlayer : Notifiable, IServicePlayer
  {
    private readonly IRepositoryPlayer _repositoryPlayer;

    public ServicePlayer() { }

    public ServicePlayer(IRepositoryPlayer repositoryPlayer)
    {
      _repositoryPlayer = repositoryPlayer;
    }

    public AddPlayerResponse AddPlayer(AddPlayerRequest request)
    {
      var name = new Name(request.FirtName, request.LastName);
      var email = new Email(request.Email);
      
      
      Player player = new Player(name, email, request.Password);

      if (IsInvalid())
      {
        return null;
      }
      
      player = _repositoryPlayer.AddPlayer(player);

      return (AddPlayerResponse)player;
    }

    public AuthenticatePlayerResponse AuthenticatePlayer(AuthenticatePlayerRequest request)
    {
      if (request == null)
      {
        AddNotification("AuthenticatePlayerRequest", Message.X0_E_OBRIGATORIO.ToFormat("AuthenticatePlayerRequest"));
      }

      var email = new Email(request.Email);

      var player = new Player(email, request.Password);

      AddNotifications(player, email);

      if(player.IsInvalid())
      {
        return null;
      }

      // player = _repositoryPlayer.AuthenticatePlayer(player.Email.Address, player.Password);

      return (AuthenticatePlayerResponse)player;
    }

    public ChangePlayerResponse ChangePlayer(ChangePlayerRequest request)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<PlayerResponse> ListPlayer()
    {
      return _repositoryPlayer.ListPlayer().ToList().Select(player => (PlayerResponse)player).ToList();
    }
  }
}
