//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------
using System;
using Full_GRASP_And_SOLID.Library;


namespace Full_GRASP_And_SOLID.Library
{
    public class PrintRecipe 
    {
        
        public static void Print(Recipe recipe)
        {
            ProductCost productCost = new ProductCost();
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            
            foreach (Step step in recipe.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}.");
            }
            Console.WriteLine($"El costo total del producto '{recipe.FinalProduct.Description}' es de {productCost.GetProductionCost(recipe)}.");
        }
    }
}
        
        
        
