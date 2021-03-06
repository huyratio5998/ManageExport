﻿using ManageExport_V2.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageExport_V2.Services.Interfaces
{
    public interface IUserServices
    {
        Task<IQueryable<User>> GetSubsidiaryAgents();
        public Task<IQueryable<User>> GetSubsidiaryAgent(string str);
        Task CreateSubsidiaryAgent(User user);
        Task UpdateSubsidiaryAgent(User user);
        Task DeleteSubsidiaryAgent(int id);
        bool CheckLogin(string username, string password);
        Task<User> GetSubsidiaryAgentById(int id);
        Task DeleteVirtual(int id);
        // Supply 
        Task<IQueryable<User>> GetSupply();

    }
}
