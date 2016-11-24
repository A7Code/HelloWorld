using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalloWorld
{
    class a7HTML
    {
        public a7HTML() { }

        string _html = "";
        HtmlDocument _document;
        public bool setURL(string _inputURL)
        {
            try
            {
                getHTML(ref _inputURL);
                Message.Show("Success!!");
                _document = getDocument(ref _html);
                Console.Read();
                return true;
            }
            catch
            {
                Message.AddWrongMessage(string.Format("This is a Wrong URL : {0}", _inputURL));
                Message.ShowLastWrongMessage();
                return false;
            }
        }

        HtmlDocument getDocument(ref string _inputHTML)
        {
            WebBrowser browser = new WebBrowser();
            browser.ScriptErrorsSuppressed = true;
            browser.DocumentText = _inputHTML;
            browser.Document.OpenNew(true);
            browser.Document.Write(_inputHTML);
            browser.Refresh();
            return browser.Document;
        }

        void getHTML(ref string _inputURL)
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            //Encoding e = AutoEncoding(_html, client.ResponseHeaders.Get("Content-Type"));
            //if (client.Encoding != e)
            //    client.Encoding = e;
            _html = client.DownloadString(_inputURL);
        }
        //_inputWeb = WebRequest.Create(_inputURL)
        void getHTML(WebRequest _inputWeb)
        {
            WebResponse myResponse = _inputWeb.GetResponse();
            StreamReader readStream = new StreamReader(myResponse.GetResponseStream());
            _html = readStream.ReadToEnd();
            readStream.Close();
        }

        public string showA()
        {
            return _html;
        }

        public List<string> showB()
        {
            return a7HTMLString.cutHtmlString(ref _html);
        }
    }
}
