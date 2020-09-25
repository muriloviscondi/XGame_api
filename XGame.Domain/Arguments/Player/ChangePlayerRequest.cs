using System;

namespace XGame.Domain.Arguments.Player
{
  public class ChangePlayerRequest
  {
    public Guid Id { get; set; }

    public string Email { get; set; }

    public string FirtName { get; set; }

    public string LastName { get; set; }
  }
}
