using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Bucket_Opdracht_Version2.ConvertedCSVToIEnumerable
{
    public class LargeRainBarrelToTest
    {
        public static IEnumerable<object[]> TestContentLargeBarrel
        {
            get
            {
                string[] csvLines = File.ReadAllLines("LargeRainBarrelMaxCapacity.csv");
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

        public static IEnumerable<object[]> TestInstanceDataLargeBarrel
        {
            get
            {
                string[] csvLines = File.ReadAllLines("LargeBarrelInstanceData.csv");
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
