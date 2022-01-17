using Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        public ICompanyRepository Company => throw new NotImplementedException();

        public ICompanyRepository Employee => throw new NotImplementedException();

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
