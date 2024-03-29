﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDo.TaskApp.Domain;

namespace ToDo.TaskApp.DataAccess.Repositories.CacheRepositories
{
    public class UserRepository : IRepository<User>
    {
        public void DeleteById(int id)
        {
            User user = CacheDb.Users.FirstOrDefault(u => u.Id == id);
            if(user != null) CacheDb.Users.Remove(user);
        }

        public List<User> GetAll()
        {
            return CacheDb.Users;
        }

        public User GetById(int id)
        {
            return CacheDb.Users.FirstOrDefault(u => u.Id == id);
        }

        public void Insert(User entity)
        {
            CacheDb.UserId++;
            entity.Id = CacheDb.UserId;
            CacheDb.Users.Add(entity);
        }

        public void Update(User entity)
        {
            User user = CacheDb.Users.FirstOrDefault(u => u.Id == entity.Id);

            if(user != null)
            {
                int index = CacheDb.Users.IndexOf(user);
                CacheDb.Users[index] = entity;
            }
        }
    }
}
