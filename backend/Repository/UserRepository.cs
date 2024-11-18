using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Interfaces;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDBContext _context;
        public UserRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<List<UserModel>> GetAllAsync()
        {
            return await _context.User.ToListAsync();
        }

        public async Task<UserModel?> GetByIdAsync(int id)
        {
            return await _context.User.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<UserModel> CreateAsync(UserModel userModel)
        {
            await _context.User.AddAsync(userModel);
            await _context.SaveChangesAsync();
            return userModel;
        }


    }
}