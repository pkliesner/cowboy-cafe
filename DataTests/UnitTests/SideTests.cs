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
    public class SideTests
    {

        [Theory]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(CornDodgers))]
        [InlineData(typeof(PanDeCampo))]
        public void TypeShouldBeASide(Type type)
        {
            var side = Activator.CreateInstance(type);
            Assert.IsAssignableFrom<Side>(side);
        }
    }
}

