using System;

namespace XGame.Domain.Entities
{
  public class Game
  {
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Production { get; set; }

    public string Distribuction { get; set; }

    public string Genre { get; set; }

    public string Site { get; set; }
  }
}
