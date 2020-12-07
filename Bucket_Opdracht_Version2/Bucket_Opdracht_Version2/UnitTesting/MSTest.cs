using Bucket_Opdracht_Version2.EventHandlers;
using Bucket_Opdracht_Version2.MainFunctions;
using Bucket_Opdracht_Version2.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Bucket_Opdracht_Version2.UnitTesting
{
    [TestClass]
    class MSTest
    {
        [DataTestMethod]
        [DynamicData(nameof(ConvertedCSVToIEnumerable.BucketToTest.TestContentBucket), typeof(ConvertedCSVToIEnumerable.BucketToTest))]
        [TestCategory(" Content")]
        public void CheckifCapacityIsCorrectBucket(int valuetocompareto)
        {
            BucketModel bucket = new BucketModel();
            Assert.AreEqual(bucket.MaxCapacity, valuetocompareto, "Values match with the given content type");
        }

        [DataTestMethod]
        [DynamicData(nameof(ConvertedCSVToIEnumerable.OilBarrelToTest.TestContentOilBarrel), typeof(ConvertedCSVToIEnumerable.OilBarrelToTest))]
        [TestCategory(" Content")]
        public void CheckifCapacityIsCorrectOil(int valuetocompareto)
        {
            OilBarrelModel oil = new OilBarrelModel();
            Assert.AreEqual(oil.MaxCapacity, valuetocompareto, "Values match with the given content type");
        }

        [DataTestMethod]
        [DynamicData(nameof(ConvertedCSVToIEnumerable.SmallRainBarrelToTest), typeof(ConvertedCSVToIEnumerable.SmallRainBarrelToTest))]
        [TestCategory(" Content")]
        public void CheckifCapacityIsCorrectSmall(int valuetocompareto)
        {
            RainbarrelSmallModel smallbarrel = new RainbarrelSmallModel();
            Assert.AreEqual(smallbarrel.MaxCapacity, valuetocompareto, "Values match with the given content type");
        }

        [DataTestMethod]
        [DynamicData(nameof(ConvertedCSVToIEnumerable.MediumRainBarrelToTest), typeof(ConvertedCSVToIEnumerable.MediumRainBarrelToTest))]
        [TestCategory(" Content")]

        public void CheckifCapacityIsCorrectMedium(int valuetocompareto)
        {
            RainBarrelMediumModel medium = new RainBarrelMediumModel();
            Assert.AreEqual(medium.MaxCapacity, valuetocompareto, "Values match with the given content type");
        }
        [DataTestMethod]
        [DynamicData(nameof(ConvertedCSVToIEnumerable.LargeRainBarrelToTest.TestContentLargeBarrel), typeof(ConvertedCSVToIEnumerable.LargeRainBarrelToTest))]
        [TestCategory(" Content")]

        public void CheckifCapacityIsCorrectLarge(int valuetocompareto)
        {
            RainBarrelLargeModel large = new RainBarrelLargeModel();
            Assert.AreEqual(large.MaxCapacity, valuetocompareto, "Values match with the given content type");
        }

        public void generateBucket()
        {
            BucketModel bucket = new BucketModel();
        }

        [DataTestMethod]
        [TestCategory("available constructor")]

        public void AvailableConstructorBucket()
        {
            Action action = () => generateBucket();
            Assert.ThrowsException<NullReferenceException>(action,"Constructor is available");
        }

        public void generateOilBarrell()
        {
            OilBarrelModel oil = new OilBarrelModel();
        }

        [DataTestMethod]
        [TestCategory("available constructor")]

        public void AvailableConstructorOilBarrel()
        {
            Action action = () => generateOilBarrell();
            Assert.ThrowsException<NullReferenceException>(action, "Constructor is available");
        }
        public void generateContainer()
        {
            ContainerModel bucket = new ContainerModel();
        }

        [DataTestMethod]
        [TestCategory("available constructor")]

        public void AvailableConstructorContainer()
        {
            Action action = () => generateContainer();
            Assert.ThrowsException<NullReferenceException>(action, "Constructor is available");
        }
        public void generateSmallBarrel()
        {
            RainbarrelSmallModel small = new RainbarrelSmallModel();
        }

        [DataTestMethod]
        [TestCategory("available constructor")]

        public void AvailableConstructorSmallBarrel()
        {
            Action action = () => generateSmallBarrel();
            Assert.ThrowsException<NullReferenceException>(action, "Constructor is available");
        }
        public void generateMediumBarrel()
        {
            RainBarrelMediumModel medium = new RainBarrelMediumModel();
        }

        [DataTestMethod]
        [TestCategory("available constructor")]

        public void AvailableConstructorMediumBarrel()
        {
            Action action = () => generateMediumBarrel();
            Assert.ThrowsException<NullReferenceException>(action, "Constructor is available");
        }
        public void generateLargeBarrel()
        {
            RainBarrelLargeModel bucket = new RainBarrelLargeModel();
        }

        [DataTestMethod]
        [TestCategory("available constructor")]

        public void AvailableConstructorLargeBarrel()
        {
            Action action = () => generateLargeBarrel();
            Assert.ThrowsException<NullReferenceException>(action, "Constructor is available");
        }

        [DataTestMethod]
        [TestCategory("Execution functions working")]

        public void ExecutionFunctionBucket()
        {
            var result = BucketExecutions.GenerateBucket();
            Assert.IsNotNull(result, "Execution working");
        }

        [DataTestMethod]
        [TestCategory("Execution functions working")]

        public void ExecutionFunctionOilBarrel()
        {
            var result = OilBarrelExecution.GenerateOilBarrel();
            Assert.IsNotNull(result, "Execution working");
        }

        [DataTestMethod]
        [TestCategory("Execution functions working")]

        public void ExecutionFunctionSmallBarrel()
        {
            var result = RainBarrelSmallExecution.generateSmallRainbarrel();
            Assert.IsNotNull(result, "Execution working");
        }

        [DataTestMethod]
        [TestCategory("Execution functions working")]

        public void ExecutionFunctionMediumBarrel()
        {
            var result = RainBarrelSmallExecution.generateSmallRainbarrel();
            Assert.IsNotNull(result, "Execution working");
        }

        [DataTestMethod]
        [TestCategory("Execution functions working")]

        public void ExecutionFunctionLargeBarrel()
        {
            var result = RainBarrelLargeExecution.GenerateLargeRainBarrel();
            Assert.IsNotNull(result, "Execution working");
        }

        [DataTestMethod]
        [TestCategory("EventHandlers Executing")]

        public void EventhandlerBucket()
        {
            BucketEventHandlers eventHandlers = new BucketEventHandlers();
            Action action = () => eventHandlers.AddBucket();
            Assert.ThrowsException<Exception>(action, "Event Handler Working");
        }

        [DataTestMethod]
        [TestCategory("EventHandlers Executing")]

        public void EventhandlerOil()
        {
            OilBarrelEventHandlers eventHandlers = new OilBarrelEventHandlers();
            Action action = () => eventHandlers.AddOilBarrel();
            Assert.ThrowsException<Exception>(action, "Event Handler Working");
        }

        [DataTestMethod]
        [TestCategory("EventHandlers Executing")]

        public void EventhandlerSmallBarrel()
        {
            RainBarrelSmallEventhandlers eventHandlers = new RainBarrelSmallEventhandlers();
            Action action = () => eventHandlers.AddSmallBarrel();
            Assert.ThrowsException<Exception>(action, "Event Handler Working");
        }

        [DataTestMethod]
        [TestCategory("EventHandlers Executing")]

        public void EventhandlerMediumBarrel()
        {
            RainBarrelMediumEventHandlers eventHandlers = new RainBarrelMediumEventHandlers();
            Action action = () => eventHandlers.AddMediumBarrel();
            Assert.ThrowsException<Exception>(action, "Event Handler Working");
        }

        [DataTestMethod]
        [TestCategory("EventHandlers Executing")]

        public void EventhandlerLargeBarrel()
        {
            RainBarrelLargeEventHandlers eventHandlers = new RainBarrelLargeEventHandlers();
            Action action = () => eventHandlers.AddLargeBarrel();
            Assert.ThrowsException<Exception>(action, "Event Handler Working");
        }

        public void GenerateItemWithValuesBucket(int content, int maxvalue)
        {
            BucketModel item = new BucketModel()
            {
                id = Guid.NewGuid().ToString(),
                CurrentContentValue = content,
                MaxCapacity = maxvalue
            };
        }

        [DataTestMethod]
        [DynamicData(nameof(ConvertedCSVToIEnumerable.BucketToTest.TestContentBucket), typeof(ConvertedCSVToIEnumerable.BucketToTest))]
        [TestCategory("InstantiateDataWithVariousInput")]

        public void GenerateBucket(int content, int maxvalue)
        {
            Action action = () => GenerateItemWithValuesBucket(content, maxvalue);
            Assert.ThrowsException<Exception>(action, "Able to add data to newly instantiated model");
        }

        public void GenerateItemWithValuesOil(int content, int maxvalue)
        {
            BucketModel item = new BucketModel()
            {
                id = Guid.NewGuid().ToString(),
                CurrentContentValue = content,
                MaxCapacity = maxvalue
            };
        }

        [DataTestMethod]
        [DynamicData(nameof(ConvertedCSVToIEnumerable.OilBarrelToTest.TestInstanceDataOilBarrel), typeof(ConvertedCSVToIEnumerable.OilBarrelToTest))]
        [TestCategory("InstantiateDataWithVariousInput")]

        public void GenerateOil(int content, int maxvalue)
        {
            Action action = () => GenerateItemWithValuesOil(content, maxvalue);
            Assert.ThrowsException<Exception>(action, "Able to add data to newly instantiated model");
        }

        public void GenerateItemWithValuesSmallBarrel(int content, int maxvalue)
        {
            BucketModel item = new BucketModel()
            {
                id = Guid.NewGuid().ToString(),
                CurrentContentValue = content,
                MaxCapacity = maxvalue
            };
        }

        [DataTestMethod]
        [DynamicData(nameof(ConvertedCSVToIEnumerable.SmallRainBarrelToTest.TestInstanceDataSmallBarrel), typeof(ConvertedCSVToIEnumerable.SmallRainBarrelToTest))]
        [TestCategory("InstantiateDataWithVariousInput")]

        public void GenerateSmallbarrel(int content, int maxvalue)
        {
            Action action = () => GenerateItemWithValuesSmallBarrel(content, maxvalue);
            Assert.ThrowsException<Exception>(action, "Able to add data to newly instantiated model");
        }

        public void GenerateItemWithValuesMediumBarrel(int content, int maxvalue)
        {
            BucketModel item = new BucketModel()
            {
                id = Guid.NewGuid().ToString(),
                CurrentContentValue = content,
                MaxCapacity = maxvalue
            };
        }

        [DataTestMethod]
        [DynamicData(nameof(ConvertedCSVToIEnumerable.MediumRainBarrelToTest.TestInstanceDataMediumBarrel), typeof(ConvertedCSVToIEnumerable.MediumRainBarrelToTest))]
        [TestCategory("InstantiateDataWithVariousInput")]

        public void GenerateMediumbarrel(int content, int maxvalue)
        {
            Action action = () => GenerateItemWithValuesMediumBarrel(content, maxvalue);
            Assert.ThrowsException<Exception>(action, "Able to add data to newly instantiated model");
        }

        public void GenerateItemWithValuesLargeBarrel(int content, int maxvalue)
        {
            BucketModel item = new BucketModel()
            {
                id = Guid.NewGuid().ToString(),
                CurrentContentValue = content,
                MaxCapacity = maxvalue
            };
        }

        [DataTestMethod]
        [DynamicData(nameof(ConvertedCSVToIEnumerable.LargeRainBarrelToTest.TestInstanceDataLargeBarrel), typeof(ConvertedCSVToIEnumerable.LargeRainBarrelToTest))]
        [TestCategory("InstantiateDataWithVariousInput")]

        public void GenerateLargeBarrel(int content, int maxvalue)
        {
            Action action = () => GenerateItemWithValuesBucket(content, maxvalue);
            Assert.ThrowsException<Exception>(action, "Able to add data to newly instantiated model");
        }
    }
}
