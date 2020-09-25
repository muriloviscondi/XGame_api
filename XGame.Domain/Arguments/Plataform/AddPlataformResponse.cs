using System;
using System.Collections.Generic;
using System.Text;

namespace XGame.Domain.Arguments.Plataform
{
  public class AddPlataformResponse
  {
    public Guid Id { get; set; }

    public string Name { get; set; }
    
    public string Message { get; set; }
  }
}
