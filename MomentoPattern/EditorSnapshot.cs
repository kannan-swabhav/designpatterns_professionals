using System;
using System.Collections.Generic;
using System.Text;

namespace MomentoPattern
{
    class EditorSnapshot
    {
        private readonly string _content;

        public EditorSnapshot(String content) {
            _content = content;
        }
        public string Content => _content;
    }
}
