﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialsConsoleApp.PartialClasses
{
    public partial class ParticalClassDemoA
    {
        private string _firstNamee;
        private string _lastNamee;

        public string LastName
        {
            get { return _lastNamee; }
            set { _lastNamee = value; }
        }
        public string FirstName
        {
            get
            {
                return _firstNamee;
            }
            set
            {
                _firstNamee = value;
            }
        }
    }
}