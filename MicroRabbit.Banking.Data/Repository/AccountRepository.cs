﻿using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext _bankingDb;

        public AccountRepository(BankingDbContext bankingDb)
        {
           _bankingDb = bankingDb;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _bankingDb.Accounts;
        }
    }
}
