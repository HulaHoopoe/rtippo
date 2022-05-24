using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractsList
{
    internal class Locality
    {
        private int Id;
        private string name;
        private Municipality municipality;

        Locality()
        {

        }
    }

    internal class Municipality
    {
        private int Id;
        private string name;

        Municipality()
        {

        }
    }

    internal class Organization
    {
        private int Id;
        private string nameOrganization;
        private Locality localityOrganization;
        private CategoryOrganization categoryOrganization;

        Organization()
        {
        }
    }

    internal class CategoryOrganization
    {
        private int Id;
        private string name;
        CategoryOrganization()
        {

        }
    }

    internal class Subvence
    {
        private int Id;
        private int year;
        private int sum;
        private Municipality municipalitySubvence;

        Subvence()
        {

        }
    }

    internal class File
    {
        private int Id;
        private string source;

        File()
        {

        }
    }
}
