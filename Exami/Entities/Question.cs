using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public record Question
    (
       int Id,
       double Mark,
       string? Body,
       string QuestionType,
       int SubjectId
       );
}
