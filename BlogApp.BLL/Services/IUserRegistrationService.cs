using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.BLL.Services
{
    public interface IUserRegistrationService<T>
    {
        public Task<bool> CreateUser(T _object);
        public void DeleteUser(T _object);
        public void UpdateUser(T _object);
        public IEnumerable<T> GetAll();
        public T GetById(int Id);
        public bool GetByName(string name);
    }
}
