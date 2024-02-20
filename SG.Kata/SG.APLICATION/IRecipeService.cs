﻿using SG.ENTITY;
using System.Collections.Generic;

namespace SG.APPLICATION
{
    public interface IRecipeService
    {
        void Add(Recipe entity);

        Recipe FindById(string id);

        int Update(Recipe entity);

        int Delete(Recipe entity);

        List<Recipe> GetAll(string nomRecette = "");
    }
}