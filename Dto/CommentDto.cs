using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp21.Dto
{
    internal class CommentDto
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
    }
}
