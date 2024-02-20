using SG.ENTITY;
using System.Collections.Generic;

namespace SG.APPLICATION
{
    public interface IIngredientService
    {
        void Add(Ingredient entity);

        Ingredient FindById(string id);

        int Update(Ingredient entity);

        int Delete(Ingredient entity);

        List<Ingredient> GetAll(string nomIngredient = "");
    }
}