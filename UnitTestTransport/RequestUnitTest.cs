using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport;
using UnitTestTransport.Fakes;

namespace UnitTestTransport
{
    [TestClass]
    public class RequestUnitTest
    {
        [TestMethod]
// méthode pour tester le fonctionnement de la requête
        public void GetlisteTransportAutour_FakeTest()
        {
            ISendRequest fakeSendRequest = new FakeSendRequest();
            RequeteListeTransportAutour target = new RequeteListeTransportAutour(fakeSendRequest);

            Assert.AreEqual("test", target.listeTransportAutour());
        }
    }
}
