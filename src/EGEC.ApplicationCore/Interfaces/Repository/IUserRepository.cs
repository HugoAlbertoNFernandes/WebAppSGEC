﻿using EGEC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EGEC.ApplicationCore.Interfaces.Repository
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> Logar(string vuser, string vsenha);
    }
}
