using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AselsanCsharpEducation
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class ArrayLessons
    {
        int[] numbers = new int[5];
        int[] numbers5 = new int[5];

        string[] names = new string[5];
        Product[] products = new Product[5];
        Object[] objects = new Object[5];

        private int[] numbers2 = new int[5] { 1, 2, 3, 4, 5 };

        public void AddNumbers()
        {
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;
            numbers5[0] = 1;
            numbers5[1] = 2;
            numbers5[2] = 3;
            numbers5[3] = 4;
            numbers5[4] = 5;
        }

        public void ForLoop()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]}");
            }

            foreach (var number in numbers)
            {
            }
        }
    }

    internal class CollectionLesson
    {
        private ArrayList arrayList = new ArrayList();
        private List<int> Numbers;
        private List<Person> Persons = new List<Person>();
        private Dictionary<int, string> dictionary = new Dictionary<int, string>();
        private LinkedList<string> linkedList = new LinkedList<string>();
        private Queue<string> QueueAsNames = new Queue<string>();
        private Stack<string> StackAsNames = new Stack<string>();

        private Hashtable hashTable = new Hashtable();
        private HashSet<string> hashSetAsName = new HashSet<string>();


        public void HashSetExample()
        {
            hashSetAsName.Add("ahmet");
            hashSetAsName.Add("hasan");
            hashSetAsName.Add("zeliha");
            hashSetAsName.Add("yeliz");
            hashSetAsName.Add("mehmet");
            hashSetAsName.Add("x");


            foreach (var name in hashSetAsName)
            {
                Console.WriteLine(name);
            }
        }

        public void HashTableExample()
        {
            hashTable.Add(9, "y");
            hashTable.Add(1, "ahmet");
            hashTable.Add(2, "hasan");
            hashTable.Add(3, "zeliha");
            hashTable.Add(4, "yeliz");
            hashTable.Add(30, "mehmet");
            hashTable.Add(10, "x");

            foreach (DictionaryEntry item in hashTable)
            {
                Console.WriteLine($"{item.Key}- {item.Value}");
            }
        }

        public void StackExample()
        {
            StackAsNames.Push("ahmet");
            StackAsNames.Push("hasan");
            StackAsNames.Push("zeliha");
            StackAsNames.Push("yeliz");

            foreach (var name in StackAsNames)
            {
                Console.WriteLine(name);
            }

            var name1 = StackAsNames.Pop();
            var name2 = StackAsNames.Pop();
            var name3 = StackAsNames.Pop();
            var name4 = StackAsNames.Pop();
        }


        public void QueueExample()
        {
            QueueAsNames.Enqueue("ahmet");
            QueueAsNames.Enqueue("hasan");
            QueueAsNames.Enqueue("zeliha");
            QueueAsNames.Enqueue("yeliz");

            foreach (var name in QueueAsNames)
            {
                Console.WriteLine(name);
            }

            var name1 = QueueAsNames.Dequeue();
            var name2 = QueueAsNames.Dequeue();
            var name3 = QueueAsNames.Dequeue();
            var name4 = QueueAsNames.Dequeue();
        }


        public void LinkedListExample()
        {
            linkedList.AddFirst("ahmet");
            linkedList.AddLast("hasan");
            var zelihaPoint = linkedList.AddLast("zeliha");
            linkedList.AddBefore(zelihaPoint, "yeliz");
            foreach (var name in linkedList)
            {
                Console.WriteLine(name);
            }
        }

        public void AddCollection()
        {
            dictionary.Add(1, "ahmet");
            dictionary.Add(2, "ahmet2");
            dictionary.Add(3, "ahmet3");
            dictionary.Add(3, "hasan");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
        }


        public CollectionLesson()
        {
            Numbers = new List<int>();
        }


        public void AddPerson()
        {
            var p1 = new Person() { Id = 1, Name = "ahmet", Age = 20 };
            Persons.Add(p1);
            Persons.Add(new Person { Id = 2, Name = "ahmet2", Age = 40 });
            Persons.Add(new Person { Id = 3, Name = "ahmet2", Age = 60 });


            List<Person> personList = new List<Person>();
        }


        public void AddList()
        {
            Numbers.Add(2);
            Numbers.Add(5);
        }


        public void ArrayMethod()
        {
            arrayList.Add("ahmet");
            arrayList.Add(2);
            arrayList.Add(23f);
            arrayList.Add(new Product());
        }
    }
}