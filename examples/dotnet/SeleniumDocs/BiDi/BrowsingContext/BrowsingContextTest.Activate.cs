﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.BiDi;
using System.Threading.Tasks;

namespace SeleniumDocs.BiDi.BrowsingContext;

partial class BrowsingContextTest
{
    [TestMethod]
    public async Task Activate()
    {
        var context = await driver.AsBiDirectionalContextAsync();

        await context.ActivateAsync();
    }
}
