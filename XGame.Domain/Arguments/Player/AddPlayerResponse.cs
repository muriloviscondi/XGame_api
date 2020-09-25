using System;
using XGame.Domain.Interfaces.Arguments;

namespace XGame.Domain.Arguments.Player
{
  public class AddPlayerResponse : IResponse
  {
    public Guid Id { get; set; }

    public string Message { get; set; }

    public static explicit operator AddPlayerResponse(Entities.Player entity)
    {
      return new AddPlayerResponse()
      {
        Id = entity.Id,
        Message = XGame.Domain.Resources.Message.OPERACAO_REALIZADA_COM_SUCESSO
      };
    }
  }
}
