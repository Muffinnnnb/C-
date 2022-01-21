using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace kakao_map_api
{
    public class KakaoAPI
    {
        public static List<Locale> Search(string qstr)
        {
            List<Locale> mls = new List<Locale>();

            string site = "https://dapi.kakao.com/v2/local/search/keyword.json";

            string query = $"{site}?query={qstr}";
            WebRequest request = WebRequest.Create(query);

            string rKey = "6526f088bfc5ef602944c97da872c9e6";
            string header = "KakaoAK " + rKey;
            request.Headers.Add("Authorization", header);

            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string json=reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();

            dynamic dob = js.Deserialize<dynamic>(json);
            dynamic docs = dob["documents"];
            object[] buf = docs;
            int length = buf.Length;


            

            for (int i = 0; i < length; i++)
            {
                string lname = docs[i]["place_name"];
                double x = double.Parse(docs[i]["x"]);
                double y = double.Parse(docs[i]["y"]);
                mls.Add(new Locale(lname, y, x));
            }



            return mls;
        }







    }
}
