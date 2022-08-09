using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;


namespace UITest
{
    [TestFixture(Platform.Android)]
    
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp();
        }

        [Test]
        [Category("UI")]
        public void PrompedLabelIsDisplayed()
        {
            AppResult[] results = app.WaitForElement(c => c.Marked("Select a die:"));

            Assert.IsTrue(results.Any());
        }

        [Test]
        [Category("UI")]
        public void OptionsAreDisplayed()
        {
            Assert.IsTrue(app.Query(c => c.Marked("d4")).Any());
            Assert.IsTrue(app.Query(c => c.Marked("d6")).Any());
            Assert.IsTrue(app.Query(c => c.Marked("d8")).Any());
            Assert.IsTrue(app.Query(c => c.Marked("d10")).Any());
            Assert.IsTrue(app.Query(c => c.Marked("d12")).Any());
            Assert.IsTrue(app.Query(c => c.Marked("d20")).Any());
        }

        [Test]
        [Category("UI")]
        public void OptionsCanBeChecked()
        {
            app.Tap(c => c.Marked("d4"));
            Assert.IsTrue(app.Query(c => 
            c.Marked("d4")                     // look for items 
            .Invoke("isChecked"))              // call the isChecked method of the RadioButton
                .FirstOrDefault()              // get the first result (there should only be one)
                .Equals(true)                   // check that the view is checked (isChecked = true)
                );

            app.Tap(c => c.Marked("d6"));
            Assert.IsTrue(app.Query(c =>
            c.Marked("d6")                     // look for items 
            .Invoke("isChecked"))              // call the isChecked method of the RadioButton
                .FirstOrDefault()              // get the first result (there should only be one)
                .Equals(true)                   // check that the view is checked (isChecked = true)
                );
            Assert.IsTrue(app.Query(c =>
            c.Marked("d4")                      
            .Invoke("isChecked"))              
                .FirstOrDefault()              
                .Equals(false)                 
                );

        }

        [Test]
        [Category("UI")]
        public void RollButtonsAreDisplayed()
        {
            //Assert.IsTrue(app.Query("Display one result").Any());
            //Assert.IsTrue(app.Query("Display two results").Any());
            AppResult[] results = app.Query(c => c.Property("text").Contains("Display "));
            Assert.IsTrue(results.Length == 2);
        }
    }
}
