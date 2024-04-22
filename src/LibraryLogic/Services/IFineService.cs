﻿using LibraryRepository.Models;
using LibraryRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogic.Services
{
    internal interface IFineService
    {
        public List<Fine> GetAllFines();
        void AddFine(Fine fine);
    }
}
