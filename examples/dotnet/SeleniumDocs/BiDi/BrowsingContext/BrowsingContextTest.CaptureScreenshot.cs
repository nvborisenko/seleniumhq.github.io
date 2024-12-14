﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.BiDi;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;
using System.Threading.Tasks;

namespace SeleniumDocs.BiDi.BrowsingContext;

partial class BrowsingContextTest
{
    [TestMethod]
    public async Task CaptureScreenshot()
    {
        var context = await driver.AsBiDiContextAsync();

        var screenshot = await context.CaptureScreenshotAsync();

        Assert.IsNotNull(screenshot);
        Assert.IsNotNull(screenshot.Data);
        Assert.IsNotNull(screenshot.ToByteArray());
    }

    [TestMethod]
    public async Task CaptureViewportScreenshot()
    {
        var context = await driver.AsBiDiContextAsync();

        var screenshot = await context.CaptureScreenshotAsync(new() { Clip = new ClipRectangle.Box(5, 5, 10, 10) });

        Assert.IsNotNull(screenshot);
        Assert.IsNotNull(screenshot.Data);
    }

    [TestMethod]
    public async Task CaptureElementScreenshot()
    {
        var context = await driver.AsBiDiContextAsync();

        driver.Url = "https://www.selenium.dev/selenium/web/formPage.html";

        var element = (await context.LocateNodesAsync(new Locator.Css("#checky")))[0];

        var screenshot = await context.CaptureScreenshotAsync(new() { Clip = new ClipRectangle.Element(element) });

        Assert.IsNotNull(screenshot);
        Assert.IsNotNull(screenshot.Data);
    }
}
