using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Bucket_Opdracht_Version2.ConvertedCSVToIEnumerable
{
    public class MediumRainBarrelToTest
    {
        public static IEnumerable<object[]> TestContentMediumBarrel
        {
            get
            {
                string[] csvLines = File.ReadAllLines("MediumRainBarrelMaxCapacity.csv");
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

        public static IEnumerable<object[]> TestInstanceDataMediumBarrel
        {
            get
            {
                string[] csvLines = File.ReadAllLines("MediumBarrelInstanceData.csv");
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
