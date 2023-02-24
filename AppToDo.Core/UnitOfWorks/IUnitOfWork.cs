﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppToDo.Core.UnitOfWorks
{
    internal interface IUnitOfWork
    {
        Task CommitAsync();

        void Commit();
    }
}
