﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shadowrun.Sql.Models;

namespace Shadowrun.Sql
{
    public class ShadowrunRepo
    {
        private readonly ShadowrunDbContext _dbContext;

        public ShadowrunRepo()
        {
            _dbContext = new ShadowrunDbContext();
        }

        public Entity GetEntity(string name)
        {
            return _dbContext.Entities.Where(x => x.name == name).SingleOrDefault();
        }

        public async Task<List<string>> GetAllEntityNamesAsync()
        {
            return await _dbContext.Entities.Select(x => x.name).ToListAsync();
        }

        public async Task UpdateOrSaveEntityAsync(Entity entity)
        {
            if (await _dbContext.Entities.AnyAsync(x => x.name == entity.name))
                _dbContext.Entities.Update(entity);
            else
                await _dbContext.Entities.AddAsync(entity);

            await _dbContext.SaveChangesAsync();
        }
    }
}
