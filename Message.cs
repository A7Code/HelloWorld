using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HalloWorld
{
    static class Message
    {
        static RichTextBox _messageBox;
        public static void setForm(RichTextBox _inputBox)
        {
            _messageBox = _inputBox;
        }
        public static void Clear()
        {
            _messageBox.Text = "";
        }
        public static void Show(string _inputMessage)
        {
            _messageBox.Text = _inputMessage;
        }

        static List<string> _wrong = new List<string>();
        public static int WrongMessageCount
        {
            get
            {
                return _wrong.Count;
            }
        }
        public static List<string> WrongMessages
        {
            get
            {
                return _wrong;
            }
            set { }
        }
        public static void AddWrongMessage(string _inputMessage)
        {
            _wrong.Add(_inputMessage);
        }
        public static void ShowLastWrongMessage()
        {
            _messageBox.Text = _wrong[_wrong.Count - 1];
        }
    }
}
