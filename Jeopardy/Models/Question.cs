using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Jeopardy.Models
{
  public class Question
  {
    public string Id { get; set; }
    public string Answer { get; set; }
    public string Body { get; set; }
    public string Value { get; set; }
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
  }
}