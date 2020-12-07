using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Bucket_Opdracht_Version2.ConvertedCSVToIEnumerable
{
    public class BucketToTest
    {
        public static IEnumerable<object[]> TestContentBucket
        {
            get
            {
                string[] csvLines = File.ReadAllLines("BucketMaxCapacity.csv");
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

        public static IEnumerable<object[]> TestInstanceDataBucket
        {
            get
            {
                string[] csvLines = File.ReadAllLines("BucketInstanceData.csv");
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
