﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishSchooll
{
    public partial class Client
    {
        public string FIO
        {
            get
            {
                return LastName + ' ' + FirstName + ' ' + Patronymic;
            }
        }
    }
}
