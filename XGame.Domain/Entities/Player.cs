using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using System;
using XGame.Domain.Enum;
using XGame.Domain.Extensions;
using XGame.Domain.Resources;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Entities
{
  public class Player : Notifiable
  {
    public Player(Email email, string password)
    {
      Email = email;
      Password = password;

      new AddNotifications<Player>(this)
        .IfNullOrInvalidLength(x => x.Password, 6, 32, "A senha deve ter entre 6 a 32 caracteres");
    }

    public Player(Name name, Email email, string password)
    {
      Id = Guid.NewGuid();
      Name = name;
      Email = email;
      Password = password;
      Status = EnumStatusPlayer.Progress;

      new AddNotifications<Player>(this)
        .IfNullOrInvalidLength(x => 
          x.Password, 6, 32, 
          Message.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Senha", "6", "32"));

      if (IsValid())
      {
        Password = Password.ConvertToMD5();
      }

      AddNotifications(name, email);
    }

    public Guid Id { get; private set; }

    public Name Name { get; private set; }

    public Email Email { get; private set; }

    public string Password { get; private set; }

    public EnumStatusPlayer Status { get; private set; }

    public override string ToString()
    {
      return this.Name.FirstName + " " + this.Name.LastName;
    }
  }
}
