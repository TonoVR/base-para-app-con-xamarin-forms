using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bully.Models.Movie
{
    public class BaseResponse
    {
        public bool? isCorrect { get; set; }
        public string mensage { get; set; }
    }
}
