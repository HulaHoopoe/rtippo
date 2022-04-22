using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractsList
{
    class API
    {
        BaseRepository repository { get; set; }

        User user { get; }

        public MunicipalContract GetContract(int numberApplication)
        {
            return repository.GetContract(numberApplication);
        }

        public List<MunicipalContract> GetContractList(Dictionary<string, string> filters)
        {
            return repository.GetContractList(user, filters);
        }

        public void AddContract(MunicipalContract contract)
        {
            repository.AddContract(user, contract);
        }

        public void UpdateContract(MunicipalContract contract)
        {
            repository.UpdateContract(user, contract);
        }

        public void DeleteContract(List<MunicipalContract> contracts)
        {
            repository.DeleteContract(user, contracts);
        }

        public void SaveFile(MunicipalContract contract, File file)
        {
            repository.SaveFile(user, contract, file);
        }

        public void DeleteFile(MunicipalContract contract)
        {
            repository.DeleteFile(user, contract);
        }

    }
}
