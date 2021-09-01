using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipelines;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CrmWebUi.Controllers
{
    public class VeriCekmeController : Controller
    {
        public IActionResult Index()
        {
            Uri url = new Uri("https://onedio.com/");
            WebClient client = new WebClient();
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);
            HtmlNodeCollection basliklar = dokuman.DocumentNode.SelectNodes("//a");
            var node = dokuman.DocumentNode.SelectSingleNode("//head/title");

             
            ViewBag.result = html;


           
               
            //foreach (var baslik in basliklar)
            //{

            //    string link = baslik.Attributes["href"].Value;

            //    ViewBag.result = baslik;
            //}
            
            return View();
        }
        public IActionResult index2()
        {
            // deneme
            var url2 = "https://www.haberler.com/";
            WebClient client = new WebClient();
            string html = client.DownloadString(url2);

            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);

            var haber = new List<string>();
            HtmlNodeCollection box = dokuman.DocumentNode.SelectNodes("//div[contains(@class,'box boxStyle color-magazine')]");
            foreach (var inbox in box)
            {
                string haberzaman = inbox.SelectSingleNode("./a/p").InnerText;
                string haberimage = inbox.SelectSingleNode("./a").Attributes["href"].Value;
                haber.Add(haberzaman);
                haber.Add(haberimage);
            }
            ViewBag.result = html;

            return View();
        }
        public IActionResult index3()
        {
            string url3 = "https://uyg.sgk.gov.tr/IsverenSistemi";
            WebClient client = new WebClient();
            string html = client.DownloadString(url3);
            //siteyi indirdik
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);

            var listem = new List<string>();
            //HtmlNodeCollection box = dokuman.DocumentNode.SelectNodes("//span[contains(@class,'css-901oao css-16my406 r-poiln3 r-bcqeeo r-qvutc0')]");
            //foreach (var item in box)
            //{
            //    string bio = item.SelectSingleNode("./").InnerText;
            //    listem.Add(bio);
            //}
            ViewBag.result = html;
            return View();
        }
        public async Task<IActionResult> index4()
        {
            //ASCIIEncoding encoding = new ASCIIEncoding();
            //Uri url = new Uri("https://api.1000kitap.com/girisYap?fr=1");
            //string postdata = "kadi=" + "ofurkanmeral" + "&sifre=" + "17492154";
            //byte[] data = encoding.GetBytes(postdata);

            //WebRequest request = WebRequest.Create(url);
            //request.Method = "POST";
            //request.ContentType = "application/x-www-form-urlencoded";
            //request.ContentLength = data.Length;

            //Stream stream = request.GetRequestStream();
            //stream.Write(data, 0, data.Length);
            //stream.Close();

            //WebResponse response = request.GetResponse();
            //stream = response.GetResponseStream();


            HttpClient client = new HttpClient();
            StringContent Content = new StringContent($"verilerimBen=1&kadi=ofurkanmeral&sifre=17492154");
            Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/x-www-form-urlencoded");

            HttpResponseMessage response=await client.PostAsync("https://api.1000kitap.com/girisYap?fr=1", Content);
           //=await client.GetAsync("https://1000kitap.com");
            HttpContent content = response.Content;
            string result = await content.ReadAsStringAsync();
            ViewBag.result = result;
            
            return View();
        }
    }
}
