﻿using Final_Project.Sturucture.Enums;
using Final_Project.Sturucture.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project.Sturucture.NewFolder
{
    interface IRestaurantManager
    {
        public  MenuItem MenuItem { get; set; }
        public List<Order> Orders { get; set; }
        public void AddOrder(List<OrderItem> orderItems);
        public void RemoveOrder(int orderNo);
        public void RemoveItem(string menuItemNo);
        public List<Order> GetOrdersByDatesInterval(DateTime firstDate, DateTime lastDate);
        public List<Order> GetOrderByDate(DateTime date);
        public List<Order> GetOrdersByPriceInterval(double firstPrice, double secondPrice);
        public void GetOrderByNo(int no);
        public void AddMenuItem(string name, double price, Category category);
        public MenuItem EditMenuItem( string name, double price, string no);
        public List<MenuItem> GetMenuItemsCategory(Category category);
        public List<MenuItem> GetMenuItemsPriceInterval(double firstPrice, double secondPrice);
        public List<MenuItem> Search(string searchStr);
        public List<MenuItem> GetMenuItems();
        public List<Order> GetOrders();


    }
}
