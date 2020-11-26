﻿namespace OnlineShop.Models.Products.ProductsModels.ComponentsModels
{
    public class PowerSupply : Component
    {
        private const double MULTIPLIER = 1.05;

        public PowerSupply(int id, string manufacturer, string model, decimal price, double overallPerformance, int generation)
            : base(id, manufacturer, model, price, overallPerformance * MULTIPLIER, generation)
        {
        }
    }
}