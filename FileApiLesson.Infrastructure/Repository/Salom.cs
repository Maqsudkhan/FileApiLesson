using FileApiLesson.Infrastructure.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileApiLesson.Infrastructure.Repository
{
    public class Salom : IUserRepository
    {
        public Task<string> Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
