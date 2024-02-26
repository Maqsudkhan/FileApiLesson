using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileApiLesson.Infrastructure.IRepository
{
    public interface IUserRepository
    {
        Task<string> Update(int id);
    }
}
