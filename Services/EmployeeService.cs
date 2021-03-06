﻿using Database.Core;
using Domain;
using Services.Core;
using System.Collections.Generic;

namespace Services
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeService(IPrintService<User> printService, IUserRepository userRepository)
        {
            PrintService = printService;
            UserRepository = userRepository;
        }

        public IPrintService<User> PrintService { get; }
        public IUserRepository UserRepository { get; }

        public IEnumerable<User> GetAll()
        {
            return UserRepository.FindAll();
        }

        public void Hire(User user)
        {
            UserRepository.Insert(user);
        }
    }
}