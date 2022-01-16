using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using TedLiu.Demo1.Models.Repository;

namespace TedLiu.Demo1.Models.Service
{
    public class AddressService
    {
        AddressRepository repo = new AddressRepository();

        public IEnumerable<AddressBook> Getall()
        {
            return repo.getAll();
        }

        public void Create(AddressBook model)
        {
            repo.Create(model);
        }


        public AddressBook Getid(int id)
        {
            return repo.getid(id);
        }

        public void Delete(int id)
        {
            repo.Delete(id );
        }

        public void Update(int id , AddressBook Model)
        {
            repo.Update(id, Model);
        }

    }
}