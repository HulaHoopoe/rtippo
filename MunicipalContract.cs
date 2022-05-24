using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractsList
{
    internal class MunicipalContract
    {
        public int Id;
        private int contractNumber;
        private DateTime conclusion;
        private DateTime validity;
        private int price;
        private float subvencePartPrice;
        private int contractorPayment;
        private float subvencePartContractor;
        private Organization contractor;
        private Organization localGovernment;
        private Locality contractLocality;
        private Subvence subvence;
        private File fileContract;

        public MunicipalContract()
        {

        }
    }
}
