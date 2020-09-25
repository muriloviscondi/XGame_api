using System;

namespace XGame.Domain.Arguments.Player
{
  public class ChangePlayerResponse
  {
    public Guid Id { get; set; }

    public string Email { get; set; }

    public string FirtName { get; set; }

    public string LastName { get; set; }

    public string Message { get; set; }

    public static explicit operator ChangePlayerResponse(Entities.Player entity)
    {
      return new ChangePlayerResponse()
      {
        Id = entity.Id,
        Email = entity.Email.Address,
        FirtName = entity.Name.FirstName,
        LastName = entity.Name.LastName,
        Message = XGame.Domain.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO
      };
    }
  }
}
