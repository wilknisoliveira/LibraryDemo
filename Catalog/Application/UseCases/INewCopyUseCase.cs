﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.UseCases
{
    public interface INewCopyUseCase
    {
        void Execute(Guid BookId);
    }
}
