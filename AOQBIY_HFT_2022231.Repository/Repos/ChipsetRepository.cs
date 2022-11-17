﻿using AOQBIY_HFT_2022231.Models;
using AOQBIY_HFT_2022231.Repository.Data;
using AOQBIY_HFT_2022231.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AOQBIY_HFT_2022231.Repository.Repos
{
    public class ChipsetRepository : Repository<Chipsets>, IChipsetRepository
    {
        public ChipsetRepository(ProcessorListDbContext ctx) : base(ctx)
        {
        }

    }
}
