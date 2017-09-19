using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bully.Models.Movie
{
    public class ListMovieResponse : BaseResponse
    {
        public int? page { get; set; }
        public List<MovieDetail> results { get; set; }
        public int? total_results { get; set; }
        public int? total_pages { get; set; }
    }
}
