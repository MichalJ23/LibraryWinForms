﻿using LibraryRepository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRepository.Repository
{
    internal interface IReaderRepository
    {
        List<Reader> GetAllReaders();
        void AddReader(Reader reader);
        void UpdateReader(Reader reader);
        Reader GetReaderById(int id);
    }
}
