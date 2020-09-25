using System.Collections;
using System.Collections.Generic;
using XGame.Domain.Entities;

namespace XGame.Domain.Interfaces.Repositories
{
  public interface IRepositoryPlayer
  {
    Player AuthenticatePlayer(string email, string password);

    Player AddPlayer(Player player);

    IEnumerable<Player> ListPlayer();
  }
}
