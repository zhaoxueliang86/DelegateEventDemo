namespace ConsoleAppDemo
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Working(DateTime date, DelegateWork work)
        {
            Console.WriteLine($"{Name}{date:yyyy年M月d日}");
            work.Invoke();
        }

        public void Play(DateTime date, DelegatePlay play, string name)
        {
            Console.WriteLine($"{Name}{date:yyyy年M月d日}");
            play.Invoke(name);
        }
    }
}
