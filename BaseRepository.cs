using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractsList
{
    class BaseRepository
    {
        public MunicipalContract GetContract(int numberApplication)
        {
            MunicipalContract mc = new MunicipalContract();
            return mc;
        }

        public List<MunicipalContract> GetContractList(User user, Dictionary<string, string> filters)
        {
            List<MunicipalContract> mc = new List<MunicipalContract>();
            return mc;
        }


        public void AddContract(User user, MunicipalContract contract)
        {

        }

        public void UpdateContract(User user, MunicipalContract contract)
        {

        }

        public void DeleteContract(User user, List<MunicipalContract> contracts)
        {

        }

        public void SaveFile(User user, MunicipalContract contract, File file)
        {

        }

        public void DeleteFile(User user, MunicipalContract contract)
        {

        }
    }
}
