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
                domainObject = new Statement(entity.Id, entity.Name, entity.Description, entity.Photo);
            }

            return domainObject;
        }
        public static List<Statement> AsDomain(this List<StatementEntity> entities)
        {
            List<Statement> statements = new List<Statement>();

            foreach (StatementEntity entity in entities)
            {
                statements.Add(entity.AsDomain());
            };

            return statements;
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