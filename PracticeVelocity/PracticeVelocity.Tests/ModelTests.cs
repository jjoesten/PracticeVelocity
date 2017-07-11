using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeVelocity.Model;

namespace PracticeVelocity.ViewModel.Tests
{
    [TestClass]
    public class ModelTests
    {
        [TestMethod]
        public void RegisterEventPopulatesList()
        {
            var registerEvent = new RegisterEvent();

            Assert.IsTrue(registerEvent.Items.Count > 0);
        }

        [TestMethod]
        public void RegisterEventCreates100Items()
        {
            var registerEvent = new RegisterEvent();

            Assert.IsTrue(registerEvent.Items.Count.Equals(100));
        }

        [TestMethod]
        public void DiagnoseEventPopulatesList()
        {
            var diagnoseEvent = new DiagnoseEvent();

            Assert.IsTrue(diagnoseEvent.Items.Count > 0);
        }

        [TestMethod]
        public void DiagnoseEventCreates100Items()
        {
            var diagnoseevent = new DiagnoseEvent();

            Assert.IsTrue(diagnoseevent.Items.Count.Equals(100));
        }

        [TestMethod]
        public void RegisterEventHandlesMod3()
        {
            var registerEvent = new RegisterEvent();
            var expected = "Register";
            var actual = registerEvent.Items[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RegisterEventHandlesMod5()
        {
            var registerEvent = new RegisterEvent();
            var expected = "Patient";
            var actual = registerEvent.Items[4];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RegisterEventHandlesMod3And5()
        {
            var registerEvent = new RegisterEvent();
            var expected = "Register Patient";
            var actual = registerEvent.Items[14];

            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void RegisterEventHandlesNonMods()
        {
            var registerEvent = new RegisterEvent();
            var expected = "4";
            var actual = registerEvent.Items[3];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DiagnoseEventHandlesMod2()
        {
            var diagnoseEvent = new DiagnoseEvent();
            var expected = "Diagnose";
            var actual = diagnoseEvent.Items[1];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DiagnoseEventHandlesMod7()
        {
            var diagnoseEvent = new DiagnoseEvent();
            var expected = "Patient";
            var actual = diagnoseEvent.Items[6];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DiagnoseEventHandlesMod2And7()
        {
            var diagnoseEvent = new DiagnoseEvent();
            var expected = "Diagnose Patient";
            var actual = diagnoseEvent.Items[13];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DiagnoseEventHandlesNonMods()
        {
            var diagnoseEvent = new DiagnoseEvent();
            var expected = "3";
            var actual = diagnoseEvent.Items[2];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RegisterEventSetsId()
        {
            var registerEvent = new RegisterEvent();

            Assert.IsNotNull(registerEvent.Id);
        }

        [TestMethod]
        public void DiagnoseEventSetsId()
        {
            var diagnoseEvent = new DiagnoseEvent();

            Assert.IsNotNull(diagnoseEvent.Id);
        }
    }
}
