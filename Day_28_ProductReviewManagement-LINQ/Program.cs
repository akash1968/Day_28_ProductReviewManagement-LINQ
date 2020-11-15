
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akash Kumar Singh"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

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
                new ProductReview(){ProductID=1,UserID=101,Rating=5,Review="Excellent",IsLike=true },
                new ProductReview(){ProductID=3,UserID=106,Rating=5,Review="Excellent",IsLike=true },
                new ProductReview(){ProductID=2,UserID=102,Rating=4,Review="Good     ",IsLike=true },
                new ProductReview(){ProductID=4,UserID=107,Rating=4,Review="Good     ",IsLike=true },
                new ProductReview(){ProductID=3,UserID=103,Rating=3,Review="Average  ",IsLike=true },
                new ProductReview(){ProductID=2,UserID=108,Rating=3,Review="Average  ",IsLike=true },
                new ProductReview(){ProductID=4,UserID=104,Rating=2,Review="Satisfactory",IsLike=false },
                new ProductReview(){ProductID=1,UserID=109,Rating=2,Review="Satisfactory",IsLike=false },
                new ProductReview(){ProductID=5,UserID=105,Rating=1,Review="Poor     ",IsLike=false },
                new ProductReview(){ProductID=5,UserID=110,Rating=1,Review="Poor     ",IsLike=false }
            };
            //Printing contents of the list
            foreach (var v in productReviewList)
            {
                Console.WriteLine($"ProductID:{v.ProductID}\tUserID:{v.UserID}\tRating:{v.Rating}\tReview:{v.Review}\tIsLike:{v.IsLike}");
            }
            //UC 2
            ProductManagement.RetrieveTopThreeHighRatedRecords(productReviewList);
            Console.ReadLine();
        }
    }
}
