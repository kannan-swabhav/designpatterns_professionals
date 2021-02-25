using System;
using System.Collections.Generic;
using System.Text;

namespace MomentoPattern
{
    class History
    {
        private List<EditorSnapshot> snapshots = new List<EditorSnapshot>();

        public void Push(EditorSnapshot snapshot) {
            snapshots.Add(snapshot);
        }

        public EditorSnapshot Pop() {
            var lastIndex = snapshots.Count - 1;
            var lastSnapShot = snapshots[lastIndex];
            snapshots.RemoveAt(lastIndex);

            return lastSnapShot;
        }
    }
}
