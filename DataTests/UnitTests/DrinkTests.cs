﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using CowboyCafe.Data.Entrees;
using CowboyCafe.Data.Drinks;
using CowboyCafe.Data.Sides;

namespace CowboyCafe.DataTests
{
    
    public class DrinkTests
    {
        [Theory]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(Water))]
        public void TypeShouldBeADrink(Type type)
        {
            var drink = Activator.CreateInstance(type);
            Assert.IsAssignableFrom<Drink>(drink);
        }
    }
    
}

