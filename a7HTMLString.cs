using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWorld
{
    static class a7HTMLString
    {
        public static List<string> cutHtmlString(ref string _inputHTMLString)
        {
            List<string> returnLabel = new List<string>();

            int indexOfHead = 0, indexOfTail = 0;

            indexChange(ref _inputHTMLString, ref indexOfHead, ref indexOfTail, '<', '>');

            while (indexOfHead != -1 && indexOfTail != -1)
            {
                returnLabel.Add(_inputHTMLString.Substring(indexOfHead, indexOfTail - indexOfHead + 1));
                indexChange(ref _inputHTMLString, ref indexOfHead, ref indexOfTail, '<', '>');
            }

            return returnLabel;
        }

        static void indexChange(ref string _inputHtml, ref int _inputHead, ref int _inputTail, char _headCheck, char _tailCheck)
        {
            _inputHead = _inputHtml.IndexOf(_headCheck, _inputTail);
            _inputTail = _inputHtml.IndexOf(_tailCheck, ++_inputTail);
        }
    }
}
