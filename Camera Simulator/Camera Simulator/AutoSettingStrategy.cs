﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_Simulator
{
    public partial class AutoSettingStrategy : Component
    {
        public AutoSettingStrategy()
        {
            InitializeComponent();
        }

        public AutoSettingStrategy(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
