using System;

namespace XGame.Domain.Entities
{
  public class MyGames
  {
    public Guid Id { get; set; }

    public GamePlataform GamePlataform { get; set; }

    public bool Wishlist { get; set; }

    public bool GameExchange { get; set; }

    public bool GameSale { get; set; }

    public DateTime WishDate { get; set; }
  }
}
