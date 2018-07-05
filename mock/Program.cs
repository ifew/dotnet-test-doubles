using System;

namespace member_mock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Member member = new Member(new Authorize());
            string is_authorized = member.Profile();

            Console.WriteLine(is_authorized);
        }
    }
}
