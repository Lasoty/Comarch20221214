using Bibliotekarz.Data.Model;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Bibliotekarz.Models
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            Books = new List<Book>();
            //Books.Add(new Book());
            //Book b = Books[0];
            //Books.Remove(b);

            //ObservableCollection<Book> values= new ObservableCollection<Book>();
            //values.CollectionChanged += OnCollectionChanged;
            //values.Add(b);

            //Dictionary<string, Book> dic = new Dictionary<string, Book>();
            //dic.Add("123abc", b);
            //dic.Add("123abd", b);

            //var bb = dic["123abc"];
            //dic.Remove("123abd");

            //Queue<Book> queue = new Queue<Book>();
            //queue.Enqueue(b);
            //var qb = queue.Dequeue();

            //Stack<Book> stack = new Stack<Book>();
            //stack.Push(b);
            //var bbb = stack.Pop();

        }

        //private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        //{
        //    Console.WriteLine("Book aded");
        //}

        public List<Book> Books { get; set; }


    }
}
