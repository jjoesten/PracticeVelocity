using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PracticeVelocity.ViewModel.Tests
{
    [TestClass]
    public class EventViewModelTests
    {
        [TestMethod]
        public void RegisterCommandAssignsDisplayItem()
        {
            EventViewModel vm = new EventViewModel();

            vm.RegisterCommand.Execute(null);

            Assert.IsNotNull(vm.DisplayEvent);
            Assert.IsInstanceOfType(vm.DisplayEvent, typeof(Model.Event));
        }

        [TestMethod]
        public void DiagnoseCommandAssignsDisplayItem()
        {
            var vm = new EventViewModel();

            vm.DiagnoseCommand.Execute(null);

            Assert.IsNotNull(vm.DisplayEvent);
            Assert.IsInstanceOfType(vm.DisplayEvent, typeof(Model.Event));
        }

        [TestMethod]
        public void ViewModelLocatorReturnsEventViewModel()
        {
            Assert.IsNotNull(ViewModelLocator.EventViewModel);
            Assert.IsInstanceOfType(ViewModelLocator.EventViewModel, typeof(EventViewModel));
        }
    }
}
