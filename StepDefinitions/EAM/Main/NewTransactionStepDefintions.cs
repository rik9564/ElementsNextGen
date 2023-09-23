using ElementsNextGen.PageDefinitions;
using ElementsNextGen.PageDefinitions.EAM.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementsNextGen.StepDefinitions.EAM.Main
{
    [Binding]
    public sealed class NewTransactionStepDefintions
    {
        private NewTransactionPageDefintions? _newTransactionPageDefintions { get; }
        private NewTransactionStepDefintions(NewTransactionPageDefintions newTransactionPageDefintions) => _newTransactionPageDefintions = newTransactionPageDefintions;

        //start the StepDefintions writting from here.....   

        [When(@"I Navigated to EAM Main New Transaction -> (.*) Menu")]
        public void WhenINavigatedToEAMMainNewTransaction_NewTransactionMenu(string subMenu)
        {
            _newTransactionPageDefintions?.navigateMainAndSubMenu(subMenu);
        }

    }
}
