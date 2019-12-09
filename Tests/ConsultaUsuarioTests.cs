using APIConsultaUsuario.Requests;
using FluentAssertions;
using NUnit.Framework;
using RestSharp;
using APIConsultaUsuario.Bases;
using APIConsultaUsuario.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIConsultaUsuario.Tests
{
    [TestFixture]
    public class ConsultaUsuarioTests : TestBase
    {
        [Test]
        public void DadosValidos()
        {
            #region Parameters
            string idUsuario = "jessicabenfica";

            //Resultado esperado
            string statusCodeEsperado = "OK";
            string loginId = "jessicabenfica";
            string html_Url = "https://github.com/jessicabenfica";
            string name = "Jessica Rodrigues Benfica Pires";
            string type = "User";
            string location = "Belo Horizonte";
            #endregion


            ConsultaUsuarioRequest consultaUsuario = new ConsultaUsuarioRequest(idUsuario);
            
            IRestResponse<dynamic> response = consultaUsuario.ExecuteRequest();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(statusCodeEsperado, response.StatusCode.ToString());
                Assert.AreEqual(loginId, response.Data.login.ToString());
                Assert.AreEqual(name, response.Data.name.ToString());
                Assert.AreEqual(html_Url, response.Data.html_url.ToString());
                Assert.AreEqual(type, response.Data.type.ToString());
                Assert.AreEqual(location, response.Data.location.ToString());
            });
        }
    }
}