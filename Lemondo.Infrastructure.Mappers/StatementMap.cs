using Lemondo.Core.Models.Statements;
using Lemondo.Infrastructure.Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemondo.Infrastructure.Mappers
{
    public static class StatementMap
    {
        public static Statement AsDomain(this StatementEntity entity)
        {
            Statement domainObject = null;
            if (entity != null)
            {
                domainObject = new Statement(entity.Name, entity.Description, entity.Photo);
            }

            return domainObject;
        }
        public static StatementEntity AsEntity(this Statement domainModel)
        {
            StatementEntity statement = null;
            if (domainModel != null)
            {
                statement = new StatementEntity()
                {
                    Name = domainModel.Name,
                    Description = domainModel.Description,
                    Photo = domainModel.Photo
                };
            }

            return statement;
        }
    }
}