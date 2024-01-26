namespace Generics
{
    public class Any<T>
    {
        private T[] _list;

        public void Add(T item)
        {
            if (_list == null)
            {
                _list = new T[] { item };
            }
            else
            {
                var length = _list.Length;
                var list2 = new T[length + 1];
                for (int i = 0; i < length; i++)
                {
                    list2[i] = _list[i];
                }
                list2[list2.Length - 1] = item;
                _list = list2;
            }
        }

        public void RemoveAt(int position)
        {
            if (_list.Length > 0)
            {
                if (position > _list.Length - 1) return;
                var index = 0;
                var list2 = new T[_list.Length - 1];
                for (int i = 0; i < _list.Length; i++)
                {
                    if (i == position) continue;
                    list2[index++] = _list[i];
                }
                _list = list2;
            }
            else
            {
                Console.WriteLine("List Empty");
            }
        }

        public void DisplayList()
        {
            Console.Write("{ ");
            for (int i = 0; i < _list.Length; i++)
            {
                Console.Write(_list[i]);
                if (i < _list.Length - 1)
                {
                    Console.Write(" , ");
                }
            }
            Console.Write(" }");
        }
    }
}
