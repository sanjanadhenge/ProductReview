﻿using ProductReview;

public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to product review management problem statement");
        List<Product> list = new List<Product>()
        {
            new Product() {UserId=1, ProductId=11,Rating=5,Review="Good",IsLike=true},
            new Product() {UserId=2, ProductId=12,Rating=4,Review="Nice",IsLike=true},
            new Product() {UserId=3, ProductId=13,Rating=3,Review="Avg",IsLike=false},
            new Product() {UserId=4, ProductId=14,Rating=2,Review="Bad",IsLike=true},
            new Product() {UserId=5, ProductId=15,Rating=5,Review="Good",IsLike=true},
            new Product() {UserId=6, ProductId=16,Rating=5,Review="Good",IsLike=true},
            new Product() {UserId=7, ProductId=18,Rating=4,Review="nice",IsLike=true},
            new Product() {UserId=8, ProductId=20,Rating=3,Review="Avg",IsLike=false},
            new Product() {UserId=9, ProductId=11,Rating=5,Review="Good",IsLike=true},
            new Product() {UserId=10,ProductId=13,Rating=3,Review="Avg",IsLike=true},
            new Product() {UserId=11,ProductId=12,Rating=4,Review="Nice",IsLike=true},
            new Product() {UserId=12,ProductId=15,Rating=5,Review="Good",IsLike=true},
            new Product() {UserId=13,ProductId=16,Rating=5,Review="Good",IsLike=true},
            new Product() {UserId=14,ProductId=11,Rating=5,Review="Good",IsLike=true},
            new Product() {UserId=15,ProductId=11,Rating=5,Review="Good",IsLike=true},
            new Product() {UserId=16,ProductId=12,Rating=4,Review="Nice",IsLike=true},
            new Product() {UserId=17,ProductId=13,Rating=3,Review="Avg",IsLike=true},
            new Product() {UserId=18,ProductId=12,Rating=4,Review="Nice",IsLike=true},
            new Product() {UserId=19,ProductId=15,Rating=5,Review="Good",IsLike=true},
            new Product() {UserId=20,ProductId=18,Rating=4,Review="Nice",IsLike=true},
            new Product() {UserId=21,ProductId=20,Rating=3,Review="Avg",IsLike=true},
            new Product() {UserId=22,ProductId=11,Rating=5,Review="Good",IsLike=true},
            new Product() {UserId=23,ProductId=12,Rating=4,Review="Nice",IsLike=true},
            new Product() {UserId=24,ProductId=13,Rating=3,Review="Avg",IsLike=true},
            new Product() {UserId=25,ProductId=14,Rating=2,Review="Bad",IsLike=true},
        };
        foreach(var item in list)
        {
            Console.WriteLine(item.UserId+" " + item.ProductId+" "+item.Rating+" "+item.Review+" "+item.IsLike);
        }
    }
}
