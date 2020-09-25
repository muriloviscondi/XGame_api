using System.Collections.Generic;
using XGame.Domain.Arguments.Player;

namespace XGame.Domain.Interfaces.Services
{
  public interface IServicePlayer
  {
    AuthenticatePlayerResponse AuthenticatePlayer(AuthenticatePlayerRequest request);

    AddPlayerResponse AddPlayer(AddPlayerRequest request);
    
    ChangePlayerResponse ChangePlayer(ChangePlayerRequest request);

    IEnumerable<PlayerResponse> ListPlayer();
  }
}
