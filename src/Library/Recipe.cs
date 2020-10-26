//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            //precondicion step distinto de nulo
            //precondicion crear el step si no esta duplicado
            this.steps.Add(step);
            //postcondicion se espera un ArrayList con el step agregado
            /*invariante en este caso la invariante podria ser el ArrayList puesto que a la hora de verificar si existe un duplicado se realiza sobre el ArrayList
            y a su ves depende de objetos de su mismo tipo*/
        }

        public void RemoveStep(Step step)
        {
            //precondicion step ingresado debe estar en la lista steps
            this.steps.Remove(step);
            //postcondicion se espera un ArrayList sin el step eliminado
            /*invariante en este caso la invariante podria ser el ArrayList puesto que a la hora de verificar la existencia se realiza sobre el ArrayList
            y a su ves depende de objetos de su mismo tipo*/
        }

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}