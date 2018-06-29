using System;

namespace member
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Authorize authorize = new Authorize();

            Member member = new Member(new Authorize());
            string is_authorized = member.Profile();

            Console.WriteLine(is_authorized);
        }
    }
}
