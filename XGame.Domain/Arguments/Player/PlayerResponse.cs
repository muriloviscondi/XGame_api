using System;

namespace XGame.Domain.Arguments.Player
{
  public class PlayerResponse
  {
    public Guid Id { get; private set; }

    public string CompleteName { get; private set; }
    
    public string FirstName { get; private set; }
    
    public string LastName { get; private set; }

    public string Email { get; private set; }

    public string Status { get; private set; }

    public static explicit operator PlayerResponse(Entities.Player entity)
    {
      return new PlayerResponse()
      {
        Id = entity.Id,
        FirstName = entity.Name.FirstName,
        LastName = entity.Name.LastName,
        CompleteName = entity.ToString(),
        Email = entity.Email.Address,
        // Status = entity.Status.ToString(),
      };
    }
  }
}
