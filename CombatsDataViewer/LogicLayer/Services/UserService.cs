/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 12.04.2016
 * Time: 5:19
 */
using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer.Entities;
using DataLayer.Interfaces;
using DataLayer.Repositories;
using LogicLayer.DataObject;
using LogicLayer.Interfaces;

namespace LogicLayer.Services
{
    /// <summary>
    /// Description of UserService.
    /// </summary>
    public class UserService : IUserService
    {
        IServiceRepository db;
        public UserService(string connectionService)
        {
            db = new ServiceRepository(connectionService);
        }
        
        public List<UserDTO> GetAllUsers()
        {
            List<UserDTO> users = new List<UserDTO>();
            List<User> dbUsers = db.Users.GetAll().ToList();
            foreach (User u in dbUsers)
            {
                users.Add(new UserDTO
                    {
                        Id = u.Id,
                        Login = u.Login,
                        Password = u.Password,
                        EMail = u.EMail,
                        IsEMailValidated = u.IsEMailValid,
                        CharacterName = u.Character.ToString(),
                        RegistrationDate = u.Date
                    });
            }
            return users;
        }
        
        public UserDTO GetUser(int userId)
        {
            User u = db.Users.GetById(userId);
            UserDTO user = new UserDTO
            {
                Id = u.Id,
                Login = u.Login,
                Password = u.Password,
                EMail = u.EMail,
                IsEMailValidated = u.IsEMailValid,
                CharacterName = u.Character.Name,
                RegistrationDate = u.Date
            };
            return user;
        }
        
        public void AddUser(UserDTO user)
        {
            User u = new User
            {
                Login = user.Login,
                Password = user.Password,
                EMail = user.EMail,
                IsEMailValid = user.IsEMailValidated,
                Date = user.RegistrationDate
            };
            db.Users.Create(u);
            db.Save();
            if (!String.IsNullOrWhiteSpace(user.CharacterName))
            {
                u = (User)db.Users.GetAll().Where(x => x.Login == u.Login);
                Player player = new Player
                {
                    UserId = u.Id,
                    Name = user.CharacterName,
                    Date = DateTime.Now,
                    Statistics = new PlayerStatistic { }
                };
                db.Players.Create(player);
                db.Save();
            }
        }
        
        public void EditUser(UserDTO user)
        {
            User u = db.Users.GetById(user.Id);
            u.Login = user.Login;
            u.Password = user.Password;
            u.EMail = user.EMail;
            u.IsEMailValid = user.IsEMailValidated;
            db.Users.Update(u);
        }
    }
}
