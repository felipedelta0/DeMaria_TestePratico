using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Validacoes;

namespace TestesValidacoesExtras
{
    [TestClass]
    public class TestesValidacoesExtras
    {
        [TestMethod]
        public void TesteCalculoIdadePai()
        {
            ValidacoesExtras ve = new ValidacoesExtras();
            // NascimentoPai - Registro
            Assert.AreEqual(ve.calculaIdade("06/05/1996", "04/09/2019"), 23);
            Assert.AreEqual(ve.calculaIdade("08/07/1994", "04/09/2019"), 25);
            Assert.AreEqual(ve.calculaIdade("29/09/1990", "04/09/2019"), 28);
        }

        [TestMethod]
        public void TesteCalculoIdadeMae()
        {
            ValidacoesExtras ve = new ValidacoesExtras();
            // NascimentoMae - Registro - NascimentoReg - NoPrazo
            Assert.AreEqual(ve.calculaIdade("06/05/1996", "13/09/2019", "15/09/2019", true), 23);
            Assert.AreEqual(ve.calculaIdade("08/07/1994", "04/09/2019", "15/09/2019", false), 25);
            Assert.AreEqual(ve.calculaIdade("25/10/1990", "15/10/2019", "17/10/2019", true), 28);
            Assert.AreEqual(ve.calculaIdade("15/10/1990", "10/11/2019", "29/11/2019", false), 29);
        }

        [TestMethod]
        public void TesteDNVValida()
        {
            ValidacoesExtras ve = new ValidacoesExtras();

            Assert.AreEqual(ve.ValidarDNV("01235640"), "01235640");
            Assert.AreEqual(ve.ValidarDNV("03935640"), "03935640");
            Assert.AreEqual(ve.ValidarDNV("10236543"), "10236543");
            Assert.AreEqual(ve.ValidarDNV("44231654"), "44231654-5");
            Assert.AreEqual(ve.ValidarDNV("46231654"), "46231654-7");
            Assert.AreEqual(ve.ValidarDNV("47965102"), "47965102-9");
        }

        [TestMethod]
        public void TesteDOValida()
        {
            ValidacoesExtras ve = new ValidacoesExtras();

            Assert.AreEqual(ve.ValidarDO("00987321"), "00987321");
            Assert.AreEqual(ve.ValidarDO("01655432"), "01655432");
            Assert.AreEqual(ve.ValidarDO("11423015"), "11423015");
            Assert.AreEqual(ve.ValidarDO("12096654"), "12096654-9");
            Assert.AreEqual(ve.ValidarDO("12941231"), "12941231-6");
            Assert.AreEqual(ve.ValidarDO("13475963"), "13475963-6");
            Assert.AreEqual(ve.ValidarDO("13512796"), "13512796-0");
        }
    }
}
