using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Bucket_Opdracht_Version2.ConvertedCSVToIEnumerable
{
    public class OilBarrelToTest
    {

        public static IEnumerable<object[]> TestContentOilBarrel
        {
            get
            {
                string[] csvLines = File.ReadAllLines("OilBarrelMaxCapacity.csv");
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

        public static IEnumerable<object[]> TestInstanceDataOilBarrel
        {
            get
            {
                string[] csvLines = File.ReadAllLines("OilBarrelInstanceData.csv");
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
