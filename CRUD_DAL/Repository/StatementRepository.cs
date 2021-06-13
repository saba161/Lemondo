﻿using CRUD_DAL.Data;
using CRUD_DAL.Interface;
using CRUD_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_DAL.Repository
{
    public class StatementRepository : ICrud<Statement>
    {
        private readonly ApplicationDbContext _dbContext;
        public StatementRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }

        public async Task<Statement> Create(Statement _object)
        {
            var statement = await _dbContext.Statements.AddAsync(_object);
            _dbContext.SaveChanges();
            return statement.Entity;
        }

        public async Task Delete(int id)
        {
            var statement = await _dbContext.Statements
                 .Where(x => x.Id == id)
                 .FirstOrDefaultAsync();

            _dbContext.Remove(statement);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Statement>> GetAll()
        {
            return await _dbContext.Statements.ToListAsync();
        }

        public async Task<Statement> GetById(int Id)
        {
            return await _dbContext.Statements
                .Where(x => x.Id == Id)
                .FirstOrDefaultAsync();
        }

        public async Task Update(Statement _object)
        {
            _dbContext.Statements.Update(_object);
            await _dbContext.SaveChangesAsync();
        }
    }
}