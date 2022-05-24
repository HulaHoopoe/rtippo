using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractsList
{
    class BaseRepository
    {
        public MunicipalContract GetContract(int contractID)
        {
            MunicipalContract mc = new MunicipalContract();
            return mc;
        }

        public List<MunicipalContract> GetContractList(User user, Dictionary<string, string> filters)
        {
            List<MunicipalContract> mc = new List<MunicipalContract>();
            return mc;
        }


        public MunicipalContract AddContract(MunicipalContract contract)
        {
            return GetContract(contract.Id);
        }

        public void UpdateContract(MunicipalContract contract)
        {

        }

        public void DeleteContract(List<MunicipalContract> contracts)
        {

        }

        public void SaveFile(int contractID, File file)
        {

        }

        public void DeleteFile(int fileId)
        {

        }
    }
}
