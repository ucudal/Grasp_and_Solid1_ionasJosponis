//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------
using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class ProductCost
    {
        double totalCost;
        double equipmentTotalCost;
        double insumosTotalCost;
        public double GetProductionCost(Recipe recipe)
        {
            foreach (Step paso in recipe.steps)
            {
                equipmentTotalCost += ((paso.Time * paso.Equipment.HourlyCost) / 3600);
                insumosTotalCost += paso.Quantity * paso.Input.UnitCost;
            }
            totalCost = equipmentTotalCost + insumosTotalCost;
            return totalCost;
        }
        /*
        Comentarios: 
        1- Por patron expert, la clase Recipe es la clase que tiene la información necesaria para poder cumplir 
        con la responsabilidad para calcular el costo total de un producto. Ya que esta conoce todos los
        elementos que necesitamos para conocer para calcular el total(Tiempo y Costo por hora, Cantidad y costo por unidad).
        
        2- Cree una nueva clase PrintRecipe para cumplir con el principio SRP porque antes la clase Recipe tenia la responsabilidad
        de crear la receta e imprimirla, y no cumplia con este principio. 
        Ahora cumple con el principio SRP ya que la unica responsabilidad de la clase Recipe es crear la receta, y la unica responsabilidad
        de la clase PrintRecipe es imprimir la receta.
        
        3- Como no esta especificada la unidad de tiempo, yo supongo que un cafe se hace en 120 segundos.
        Como el HourlyCost es el precio por hora, pase de horas a segundos multiplicando por 3600, para que 
        esten en la misma unidad. Para obtener cuanto cuesta usar el equipamiento determinados segundos hice 
        una regla de 3, multiplicando el tiempo (en segundos) por el HourlyCost dividido 3600 (ya que el precio
        del equipamiento es el mismo, cambia la unidad de horas a segundos). 
        */ 
    }
}