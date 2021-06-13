﻿using CRUD_BAL.Interface;
using CRUD_DAL.Interface;
using CRUD_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_BAL.Service
{
    public class StatementService : IStatement
    {
        private readonly ICrud<StatementEntity> _statement;

        public StatementService(ICrud<StatementEntity> statement)
        {
            _statement = statement;
        }

        public async Task PutStatement(StatementEntity statement)
        {
            try
            {
                if (statement == null)
                {
                    throw new NullReferenceException("statement object is null.");
                }

                var oldStatement = await _statement.GetById(statement.Id);
                if (oldStatement == null)
                {
                    await _statement.Create(statement);
                }
                else
                {
                    await _statement.Update(statement);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task DeleteStatement(int id)
        {
            await _statement.Delete(id);
        }

        public async Task<IEnumerable<StatementEntity>> GetStatements()
        {
            return await _statement.GetAll();
        }

        public async Task<StatementEntity> GetStatementById(int id)
        {
            return await _statement.GetById(id);
        }
    }
}