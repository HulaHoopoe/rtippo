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

        public User Authorization(string login, string password)
        {
            return user.Authorization(login, password);
        }

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
            repository.AddContract(contract);
        }

        public void UpdateContract(MunicipalContract contract)
        {
            repository.UpdateContract(contract);
        }

        public void DeleteContract(List<MunicipalContract> contracts)
        {
            repository.DeleteContract(contracts);
        }

        public void SaveFile(int contractID, File file)
        {
            repository.SaveFile(contractID, file);
        }

        public void DeleteFile(int contractID)
        {
            repository.DeleteFile(contractID);
        }

    }
}
