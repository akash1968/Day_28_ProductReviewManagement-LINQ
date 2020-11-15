// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProductManagement.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akash Kumar Singh"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Day_28_ProductReviewManagement_LINQ
{
    public class ProductManagement
    {
        /// <summary>
        /// UC 2 : Retrieves the top three high rated records.
        /// </summary>
        /// <param name="productList">The product list.</param>
        public static void RetrieveTopThreeHighRatedRecords(List<ProductReview> productList)
        {
            var retrievedData = (from products in productList
                                 orderby products.Rating descending
                                 select products).Take(3);
            Console.WriteLine("\nTop 3 high rated products are:");
            foreach (var v in retrievedData)
            {
                Console.WriteLine($"ProductID:{v.ProductID}\tUserID:{v.UserID}\tRating:{v.Rating}\tReview:{v.Review}\tIsLike:{v.IsLike}");
            }
        }
        /// <summary>
        /// UC 3 : Retrieves the records with rating greater than three.
        /// </summary>
        /// <param name="productList">The product list.</param>
        public static void RetrieveRecordsWithGreaterThanThreeRating(List<ProductReview> productList)
        {
            var retrievedData = productList.Where(r => r.Rating > 3 && (r.ProductID == 1 || r.ProductID == 4 || r.ProductID == 9)).ToList();
            Console.WriteLine("\nProducts with rating greater than 3 and id=1 or 4 or 9 are:");
            foreach (var v in retrievedData)
            {
                Console.WriteLine($"ProductID:{v.ProductID}\tUserID:{v.UserID}\tRating:{v.Rating}\tReview:{v.Review}\tIsLike:{v.IsLike}");
            }
        }
        /// <summary>
        /// UC 4 : Retrieves the count of reviews for each productID.
        /// </summary>
        /// <param name="productList">The product list.</param>
        public static void RetrieveCountOfReviewsForEachProductID(List<ProductReview> productList)
        {
            var retrievedDate = (from products in productList
                                 group products by products.ProductID into g
                                 select new { ProductID = g.Key, Count = g.Count() });
            Console.WriteLine("ProductId and their review count:");
            foreach (var v in retrievedDate)
            {
                Console.WriteLine($"ProductID:{v.ProductID},ReviewCount:{v.Count}");
            }
        }
        /// <summary>
        /// UC 5 : Retrieves only the product id and review of all records.
        /// </summary>
        /// <param name="productList">The product list.</param>
        public static void RetrieveOnlyProductIDAndReviewOfAllRecords(List<ProductReview> productList)
        {
            var retrievedDate = (from products in productList
                                 select new { ProductId = products.ProductID, Review = products.Review });
            Console.WriteLine("\nProductId and its review:");
            foreach (var v in retrievedDate)
            {
                Console.WriteLine($"ProductID:{v.ProductId},ReviewCount:{v.Review}");
            }
        }
        /// <summary>
        /// UC 6 : Skips the top five records and display others.
        /// </summary>
        /// <param name="productList">The product list.</param>
        public static void SkipTopFiveRecordsAndDisplayOthers(List<ProductReview> productList)
        {
            var retrievedDate = (from products in productList
                                 select products).Skip(5);
            Console.WriteLine("\nSkip top 5 records and display others:");
            foreach (var v in retrievedDate)
            {
                Console.WriteLine($"ProductID:{v.ProductID}\tUserID:{v.UserID}\tRating:{v.Rating}\tReview:{v.Review}\tIsLike:{v.IsLike}");
            }
        }
        /// <summary>
        /// UC 7 : Retrieves only the product id and review of all records using LINQ select.
        /// </summary>
        /// <param name="productList">The product list.</param>
        public static void RetrieveOnlyProductIDAndReviewOfAllRecordsUsingSelect(List<ProductReview> productList)
        {
            var retrievedDate = productList.Select(x => new { ProductId = x.ProductID, Review = x.Review });
            Console.WriteLine("\nProductId and its review using LINQ select:");
            foreach (var v in retrievedDate)
            {
                Console.WriteLine($"ProductID:{v.ProductId},ReviewCount:{v.Review}");
            }
        }
    }
}
