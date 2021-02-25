using System;

namespace MomentoPattern
{
    class Program
    {
        //Good for doing undo mechanism
        static void Main(string[] args)
        {

            var editor = new Editor();
            var history = new History();

            Console.WriteLine(editor.Snapshot.Content);
            editor.Content = "Hello";
            history.Push(editor.Snapshot);

            editor.Content = "Hello World";
            history.Push(editor.Snapshot);

            editor.Content = "Hello World,How are you ?";
           // history.Push(editor.Snapshot);

            editor.Checkout = history.Pop();
            Console.WriteLine(editor.Content);

            editor.Checkout = history.Pop();
            Console.WriteLine(editor.Content);
        }
    }
}
