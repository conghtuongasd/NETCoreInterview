using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using SortListInteger.Implements;
using SortListInteger.Interfaces;

namespace SortListInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            services.BuildServiceProvider().GetRequiredService<ISortListService>();
            ISortListService sortList = services.BuildServiceProvider().GetService<ISortListService>();

            // The number of the largest numbers.
            const int NUMBER_OF_BIGGEST_NUMBER = 10;

            List<int> listInteges = new List<int>() { 20, 3, 4, 5, 1, 2, 6, 7, 9, 8, 11, 16, 12, 15, 14, 18, 17, 21, 22, 26, 27, 28 };
            sortList.Sort(listInteges, NUMBER_OF_BIGGEST_NUMBER);
            Console.ReadKey();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ISortListService, SortListService>();
        }
    }
}
