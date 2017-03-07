using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business;
using Strategy;
namespace BusinessTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Factory f = new Factory();
            //string cosasPorHacer = f.CreateStrategy().Ejecutar();
            string test = String.Empty;
            Context c = new Context(new Persona());
            test = c.EjecutarStrategy();
            c.SetStrategy(new Gato());
            test = c.EjecutarStrategy();
            c.SetStrategy(new Perro());
            test = c.EjecutarStrategy();
            c.SetStrategy(new Persona());
            test = c.EjecutarStrategy();

        }
    }
}
