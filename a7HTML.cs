using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWorld
{
    class a7HTML
    {
        public a7HTML() { }

        string _html = "";
        public bool setURL(string _inputURL)
        {
            try
            {
                setHTML(WebRequest.Create(_inputURL));
                Message.Clear();

                return true;
            }
            catch
            {
                Message.AddWrongMessage(string.Format("This is a Wrong Message : {0}", _inputURL));
                Message.ShowLastWrongMessage();
                return false;
            }
        }

        void setHTML(WebRequest _inputWeb)
        {
            WebResponse myResponse = _inputWeb.GetResponse();
            StreamReader readStream = new StreamReader(myResponse.GetResponseStream());
            _html = readStream.ReadToEnd();
        }

        public string show()
        {
            return _html;
        }
    }
}
