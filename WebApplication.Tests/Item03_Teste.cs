using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebApplication.Tests
{
    [TestClass]
    public class Item03_Teste
    {
        [TestMethod]
        public void CriouDiretorios()
        {
            //arrange:
            string dirOrigem = @"C:\Imagens_Origem";
            string dirDestino = @"C:\Imagens_Destino";

            //act:
            bool dirOrigemExiste = Directory.Exists(dirOrigem);
            bool dirDestinoExists = Directory.Exists(dirDestino);

            //assert:
            Assert.IsTrue(dirOrigemExiste);
            Assert.IsTrue(dirDestinoExists);
        }
    }
}
