using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kakao_map_api
{
    public class Locale
    {
        public string Name { get; set; }
        public double Lat { get; set; }
        public double Lng { get; private set; } //수정은 못하게됨

        public Locale(string name, double lat, double lng)
        {
            Name = name;
            Lat = lat;
            Lng = lng;
        }

        public override string ToString()
        {
            return Name;
        }











    }
}
