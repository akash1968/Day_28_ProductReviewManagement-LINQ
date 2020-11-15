
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akash Kumar Singh"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
namespace Day_28_ProductReviewManagement_LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review management!\n");
            //UC 1
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1,UserID=1,Rating=5,Review="Excellent",IsLike=true },
                new ProductReview(){ProductID=5,UserID=10,Rating=1,Review="Poor     ",IsLike=false },
                new ProductReview(){ProductID=3,UserID=3,Rating=3,Review="Average  ",IsLike=true },
                new ProductReview(){ProductID=3,UserID=6,Rating=5,Review="Excellent",IsLike=true },
                new ProductReview(){ProductID=2,UserID=2,Rating=4,Review="Good     ",IsLike=true },
                new ProductReview(){ProductID=4,UserID=7,Rating=4,Review="Good     ",IsLike=true },
                new ProductReview(){ProductID=2,UserID=8,Rating=3,Review="Average  ",IsLike=true },
                new ProductReview(){ProductID=4,UserID=4,Rating=2,Review="Satisfactory",IsLike=false },
                new ProductReview(){ProductID=1,UserID=9,Rating=2,Review="Satisfactory",IsLike=false },
                new ProductReview(){ProductID=9,UserID=5,Rating=1,Review="Poor     ",IsLike=false }
            };
            //Printing contents of the list
            foreach (var v in productReviewList)
            {
                Console.WriteLine($"ProductID:{v.ProductID}\tUserID:{v.UserID}\tRating:{v.Rating}\tReview:{v.Review}\tIsLike:{v.IsLike}");
            }
            //UC 2
            ProductManagement.RetrieveTopThreeHighRatedRecords(productReviewList);
            Console.ReadLine();
            //UC 3
            ProductManagement.RetrieveRecordsWithGreaterThanThreeRating(productReviewList);
            Console.ReadLine();
            //UC 4
            ProductManagement.RetrieveCountOfReviewsForEachProductID(productReviewList);
            //UC 5
            ProductManagement.RetrieveOnlyProductIDAndReviewOfAllRecords(productReviewList);
            //UC 6
            ProductManagement.SkipTopFiveRecordsAndDisplayOthers(productReviewList);
            //UC 7
            ProductManagement.RetrieveOnlyProductIDAndReviewOfAllRecordsUsingSelect(productReviewList);
            //UC 8
            ProductReviewDataTable.AddDataIntoDataTable();
            //UC 9
            ProductReviewDataTable.RetrieveAllRecordsWhoseIsLikeIsTrue();
            //UC 10
            ProductReviewDataTable.FindAverageRatingForEachProductId();
            //UC 11
            ProductReviewDataTable.RetrieveRecordsWithParticularReviewMessage();
            //UC 12
            ProductReviewDataTable.RetrieveRecordsForGivenUserIdSortedByRating();
            Console.ReadLine();
        }
    }
}
