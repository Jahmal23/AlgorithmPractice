using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class AsyncFun
    {
        public async void GetPeople()
        {
            Console.WriteLine("Do something else");

            Task<List<string>> list = FakeSearch();


            Console.WriteLine("Do something else");

            var results = await list;


            Console.WriteLine("go it");
        }

        public async Task<List<string>> FakeSearch()
        {
            await Task.Delay(3000);

            return new List<string>() { "foo", "man", "choo" };
        }
    }


}
