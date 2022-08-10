using System;
using System.Collections.Generic;

namespace NET6React.Models
{
    public class UserRepository: IUserRepository
    {
        private List<UserModel> users = new List<UserModel>();
        private int _nextId = 1;

        public UserRepository()
        {
            Add(new UserModel { firstName= "first1", lastName="last1", email="test1@temp.com"});
            Add(new UserModel { firstName= "first2", lastName="last2", email="test2@temp.com"});
            Add(new UserModel { firstName= "first3", lastName="last3", email="test3@temp.com"});
        }

        public IEnumerable<UserModel> GetAll()
        {
            return users;
        }

        public UserModel Add(UserModel item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            users.Add(item);
            return item;
        }
    }
}