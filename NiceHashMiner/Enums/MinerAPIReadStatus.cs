﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHashMiner.Enums {
    public enum MinerAPIReadStatus {
        NONE,
        WAIT,
        GOT_READ,
        NETWORK_EXCEPTION,
        RESTART
    }
}
