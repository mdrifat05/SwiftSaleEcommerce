﻿using DAL.Interface;
using DAL.Models;
using DAL.Models.Login;
using DAL.Models.SignUp;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IAuth<bool> AuthData()
        {
            return new UserRepo();
        }
        public static IRepo<Token, string, Token> TokenData()
        {
            return new TokenRepo();
        }
        public static IRepo<User, int, bool> UserData()
        {
            return new UserRepo();
        }
        public static IRepo<Category, int, bool> CategoryData()
        {
            return new CategoryRepo();
        }
        public static IRepo<Product, int, bool> ProductData()
        {
            return new ProductRepo();
        }
        public static IRepo<Seller, int, bool> SellerData()
        {
            return new SellerRepo();
        }
        public static IRepo<Admin, int, bool> AdminData()
        {
            return new AdminRepo();
        }
        public static IRepo<Cart, int, bool> CartData()
        {
            return new CartRepo();
        }
        public static IRepo<Pay, int, bool> PayData()
        {
            return new PayRepo();
        }
    }
}
