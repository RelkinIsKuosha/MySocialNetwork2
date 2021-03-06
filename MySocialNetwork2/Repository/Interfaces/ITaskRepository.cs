﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySocialNetwork2.Models;

namespace MySocialNetwork2.Repository.Interfaces
{
    public interface ITaskRepository : IRepository<Task>
    {
        void AddLike(Task model);
        void AddDislike(Task model);
    }
}