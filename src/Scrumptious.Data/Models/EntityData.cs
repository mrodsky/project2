﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrumptious.Data.Models
{
    public class EntityData
    {
        private static MockContext Mock = new MockContext();

        private static scrumptiousdbContext context = new scrumptiousdbContext();

        public EntityData() { }


        public async Task<bool> SaveAsync<T>(T a) where T : class
        {
            if (typeof(T) == typeof(Backlog))
            {
                context.Backlog.Add(a as Backlog);
                await context.SaveChangesAsync();
                return true;
            }
            else if (typeof(T) == typeof(Project))
            {
                context.Project.Add(a as Project);
                await context.SaveChangesAsync();
                return true;
            }
            else if (typeof(T) == typeof(Sprint))
            {

                context.Sprint.Add(a as Sprint);
                await context.SaveChangesAsync();
                return true;
            }
            else if (typeof(T) == typeof(Step))
            {

                context.Step.Add(a as Step);
                await context.SaveChangesAsync();
                return true;
            }
            else if (typeof(T) == typeof(Task))
            {

                context.Task.Add(a as Task);
                await context.SaveChangesAsync();
                return true;
            }
            else if (typeof(T) == typeof(User))
            {

                context.User.Add(a as User);
                await context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }
            public async Task<T> ReadListAsync<T>(int id) where T : class
            {
            if (typeof(T) == typeof(Project))
            {
                return await context.Project.SingleOrDefaultAsync(u => u.ProjectId == id) as T;
          
            }
            else if (typeof(T) == typeof(Backlog))
            {
                return await context.Backlog.SingleOrDefaultAsync(u => u.BacklogId == id) as T;
            }
            else if (typeof(T) == typeof(Sprint))
            {
                return await context.Sprint.SingleOrDefaultAsync(u => u.SprintId == id) as T;
            }
            if (typeof(T) == typeof(Step))
            {
                return await context.Step.SingleOrDefaultAsync(u => u.StepId == id) as T;
            }
            else if (typeof(T) == typeof(Task))
            {
                return await context.Task.SingleOrDefaultAsync(u => u.TaskId == id) as T;
            }
            else if (typeof(T) == typeof(User))
            {
                return await context.User.SingleOrDefaultAsync(u => u.UserId == id) as T;
            }
            else
                return default(T);
        }
    }
}
