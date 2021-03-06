﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearIterator
{
    public class Year2012_2015Iterator : IIterator
    {
        public List<string> facts;

        private int position;

        public Year2012_2015Iterator(List<string> facts)
        {
            this.facts = facts;
            this.position = 0;
        }

        public string CurrentItem()
        {
            return this.facts.ElementAt(position);
        }

        public void First()
        {
            this.position = 0;
        }

        public bool IsDone()
        {
            return this.position >= this.facts.Count;
        }

        public string Next()
        {
            return this.facts.ElementAt(position++);
        }
    }
}
