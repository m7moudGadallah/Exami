using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public  record Answer
    (
       int Id,
       int QuestionId,
       string? Answer_Test,
       bool IsCorrect

    );
}
