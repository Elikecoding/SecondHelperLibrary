using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecondHelperLibrary.ModelClasses;
using SecondHelperLibrary.ServiceClasses;

namespace SecondHelperLibrary.ServiceClasses
{
    public class UserController
    {
        //Call my list privately 
        private PersonContext _db;
        public UserController()
        {
            _db = new PersonContext();
        }

        //Delete my user by their Id
        public ActionResult DeleteUserById(int id)
        {
            var user = _db.People.FirstOrDefault(b => b.Id == id);
            _db.People.Remove(user);
            _db.SaveChanges();
            return RedirectToAction("user");
        }

        //Return my result 
        private ActionResult RedirectToAction(string user)
        {
            return new RedirectResult();
        }
    }

    public class ActionResult { }

    public class RedirectResult : ActionResult { }

    //Create a Db context for my Person class
    public class PersonContext
    {
        public ISet<Person> People { get; set; }

        public void SaveChanges() { }

    }
}
