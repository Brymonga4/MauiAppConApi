using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppConApi.Services
{
    internal interface IServices<T>
    {
        public Task<T> GetById(int id);
        public Task<List<T>> GetAll();
    }
}
