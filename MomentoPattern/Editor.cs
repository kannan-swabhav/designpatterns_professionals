using System;
using System.Collections.Generic;
using System.Text;

namespace MomentoPattern
{
    class Editor
    {
        private string _content;

        public EditorSnapshot Snapshot => new EditorSnapshot(_content);
        public string Content {
            get => _content; 
            set => _content = value; 
        }
        public EditorSnapshot Checkout
        {
            set
            {
                _content = value.Content;
            }
        }
        
    }
}
