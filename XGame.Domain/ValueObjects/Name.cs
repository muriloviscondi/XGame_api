using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using XGame.Domain.Resources;

namespace XGame.Domain.ValueObjects
{
  public class Name : Notifiable
  {
    public Name(string firstName, string lastName)
    {
      FirstName = firstName;
      LastName = lastName;

      new AddNotifications<Name>(this)
        .IfNullOrInvalidLength(x => 
          x.FirstName, 3, 50, 
          Message.X0_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Primeiro Nome", "3", "50"))
        .IfNullOrInvalidLength(x => 
          x.LastName, 3, 50, 
          Message.X0_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Último Nome", "3", "50"));
    }

    public string FirstName { get; private set; }

    public string LastName { get; private set; }
  }
}
