using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class UserManagementRepository
    {
        public bool CreateUser(User user)
        {
            var status = false;
            using (var context = new MDTContext())
            {
                var dbRow = context.Users.Any(u => u.AMKA == user.AMKA && u.Email == user.Email);
                if (!dbRow)
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                    status = true;
                }
            }

            return status;
        }

        public User Login(User user)
        {
            using (var context = new MDTContext())
            {
                var dbRow = context.Users.SingleOrDefault(u => u.Email == user.Email && u.Password == user.Password);
                return dbRow;

            }
        }
    }
}
