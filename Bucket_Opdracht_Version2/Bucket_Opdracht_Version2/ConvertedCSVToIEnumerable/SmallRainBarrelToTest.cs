using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Bucket_Opdracht_Version2.ConvertedCSVToIEnumerable
{
    class SmallRainBarrelToTest
    {
        public static IEnumerable<object[]> TestContentSmallBarrel
        {
            get
            {
                string[] csvLines = File.ReadAllLines("SmallRainBarrelMaxCapacity.csv");
                var testCases = new List<object[]>();

                foreach (var csvLine in csvLines)
                {
                    IEnumerable<int> values = csvLine.Split(',').Select(int.Parse);

                    object[] testCase = values.Cast<object>().ToArray();

                    testCases.Add(testCase);
                }
                return testCases;
            }
        }

        public static IEnumerable<object[]> TestInstanceDataSmallBarrel
        {
            get
            {
                string[] csvLines = File.ReadAllLines("SmallRainBarrelMaxCapacity.csv");
                var testCases = new List<object[]>();

                foreach (var csvLine in csvLines)
                {
                    IEnumerable<int> values = csvLine.Split(',').Select(int.Parse);

                    object[] testCase = values.Cast<object>().ToArray();

                    testCases.Add(testCase);
                }
                return testCases;
            }
        }
    }
}
