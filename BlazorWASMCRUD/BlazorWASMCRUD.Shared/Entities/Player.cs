﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWASMCRUD.Shared.Entities
{
    public class Player(string connectionId, string name)
    {
        public string ConnectionId { get; set; } = connectionId;
        public string Name { get; set; } = name;
    }
}
