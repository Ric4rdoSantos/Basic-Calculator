using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Global
    {
        public string globalData;
        public int number;
        public List<string> insertedValues;
        public int insertedOperations;
        public string errorInvalidOperation;
        public string errorOperators;
        public int result;

        public Global() 
        { 
            globalData = "";
            number = 0;
            insertedValues = new List<string>();
            insertedOperations = 0;
            errorInvalidOperation = "Indicate a valide operation!";
            errorOperators  = "Can't do that operation! Can only do operations with Add and Subtract at same time, or only one operation per operator!";
            result = 0;
        }
    }
}
