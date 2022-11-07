using System;
using System.Collections.Generic;

namespace FilterRestaurants
{
    class Program
    {
        static IList<int> FilterRestaurants(int[,] restaurants, int veganFriendly, int maxPrice, int maxDistance)
        {
            List<int> rest = new List<int>();

            if (veganFriendly == 1)
            {
                for (int j = 10; j > 0; j--)
                {
                    for (int i = 0; i < Math.Sqrt(restaurants.Length); i++)
                    {
                        if (restaurants[i, 1] == j && restaurants[i, 2] == 1)
                        {
                            rest.Add(i + 1);
                            break;
                        }
                    }
                }
            }
            else
            {
                for (int j = 10; j > 0; j--)
                {
                    for (int i = 4; i >= 0; i--)
                    {
                        if (restaurants[i, 1] == j)
                        {
                            rest.Add(i + 1);

                        }
                    }
                }
            }

            for (int i = rest.Count - 1; i > 0; i--)
            {
                if (restaurants[rest[i] - 1, 3] > maxPrice || restaurants[rest[i] - 1, 4] > maxDistance)
                {
                    rest.RemoveAt(i);
                }
            }

            return rest;
        }

            static void Main(string[] args)
            {
                string[] str = Console.ReadLine().Replace("[", "").Replace("]", "").Split(",");
                int veganFriendly = int.Parse(Console.ReadLine());
                int maxPrice = int.Parse(Console.ReadLine());
                int maxDistance = int.Parse(Console.ReadLine());

                int[,] restaurants = new int[5, 5];

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        restaurants[i, j] = int.Parse(str[(i * 5 + j)]);
                    }
                }

                Console.WriteLine(FilterRestaurants(restaurants, veganFriendly, maxPrice, maxDistance));
            }


        }
    }

