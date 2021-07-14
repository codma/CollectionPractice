using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region 리스트
            List<string> categories = new List<string>();
            categories.Add("가방");
            categories.Add("신발");
            categories.Add("바지");

            //Console.WriteLine(categories[1]);

            //foreach (var category in categories)
            //{
            //    Console.WriteLine(category);
            //}
            #endregion

            #region 

            Dictionary<string, string> products = new Dictionary<string, string>();
            products.Add("가방", "숄더백");
            products.Add("치마", "리바이스");
            products.Add("신발", "아디다스");
            products.Add("바지", "리바이스");

            //Console.WriteLine(products["치마"]);
            foreach (var product in products)
            {
                if (product.Value == "리바이스")
                {
                    Console.WriteLine(product.Key + ":" + product.Value);
                }

                #endregion

            }

        }
    }
}
