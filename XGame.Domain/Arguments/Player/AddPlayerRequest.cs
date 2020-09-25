using XGame.Domain.Interfaces.Arguments;

namespace XGame.Domain.Arguments.Player
{
  public class AddPlayerRequest : IRequest
  {
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirtName { get; set; }
    public string LastName { get; set; }
  }
}
