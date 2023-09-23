using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilderLab
{
    internal class BannedGame : IClassModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Series { get; set; }
        public string Country { get; set; }
        public string Details { get; set; }

        public BannedGame() { }

        public BannedGame(int id, string name, string name2, string country, string reason)
        {
            Id = id;
            Title = name;
            Series = name2;
            Country = country;
            Details = reason;
        }

        public override string ToString()
        {
            string msg = $"Title: {Title}\n";
            msg += $"Series: {Series}";
            msg += $"Country: {Country}";
            msg += $"Details: {Details}";
            return msg;
        }
    }
}
