using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
//When using EF [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
namespace WCFSoapService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public static int Ids { get; set; }
        private static readonly List<Dummy> Dummies = new List<Dummy>
        {
            new Dummy("First Dummy")
            {
                Id = ++Ids
            }
        };

        //Gets all items in the list
        public List<Dummy> GetAll()
        {
            return Dummies;
        }

        //Gets all items in list with given name
        public IEnumerable<Dummy> GetDummy(string name)
        {
            return Dummies.Where(x => x.Name == name);
        }

        //Adds new item to list with given name
        public void Add(string name)
        {
            Dummies.Add(new Dummy(name)
            {
                Id = ++Ids
            });
        }

        //Edits item with given id and sets the name to newname
        public void Edit(int id, string newname)
        {
            var d = Dummies.FindIndex(X => X.Id.Equals(id));
            Dummies[d].Name = newname;
        }

        //Deletes the first item from the list with the given name
        public void Delete(string name)
        {
            Dummy dummy = GetDummy(name).First();
            Dummies.Remove(dummy);
        }
    }
}
