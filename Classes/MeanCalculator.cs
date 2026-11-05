using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1.Classes
{
    internal class MeanCalculator
    {
        //Fields
        private List<double> entries; //Stores each number that is inputted in a list.
        private double total; //Stores a running total of the sum of the numbers in entries.

        //Properties
        public List<double> Entries
        {
            get { return this.entries; }
        }
        public double Total
        {
            get { return this.total; }
        }

        //Constructor
        public MeanCalculator()
        {
            entries = new List<double>(); //Initialise default value upon object instantiation.
            total = 0; //Initialise default value upon object instantiation.
        }

        //Behaviours
        public void add_entry(double p_entry) //A behaviour to add a new entry to the list.
        {

            entries.Add(p_entry);
            total += p_entry;
        }
        public double get_mean() //Returns the mean of the current enties.
        {
            return total / entries.Count; //This does not need much logic as in the add_entry() behaviour we're already adding the new entry to a running total of the set.
        }
        public void display_entries() //Iterate over the list and print its contents.
        {
            for (int i = 0;  i < entries.Count; i++)
            {
                Console.WriteLine($"Entry {i + 1}: {entries[i]}");
            }
        }
    }
}
