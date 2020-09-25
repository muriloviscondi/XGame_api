namespace XGame.Domain.Arguments.Player
{
  public class AuthenticatePlayerResponse
  {
    public string FirstName { get; set; }
    
    public string Email { get; set; }

    public int Status { get; set; }

    public static explicit operator AuthenticatePlayerResponse(Entities.Player entity)
    {
      return new AuthenticatePlayerResponse()
      {
        Email = entity.Email.Address,
        FirstName = entity.Name.FirstName,
        Status = (int)entity.Status
      };
    }
  }
}
