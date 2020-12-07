using Bucket_Opdracht_Version2.Interfaces;
using Bucket_Opdracht_Version2.Models;
using Bucket_Opdracht_Version2.ModelStructures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime;
using System.Text;

namespace Bucket_Opdracht_Version2.DAL
{
    public class MockDataService :IDataService
    {

        private List<ContainerModel> _containers;

        private static MockDataService _mockdataservice;

        private MockDataService()
        { 
        
        }

        public static MockDataService GetMockDataService()
        {
            if (_mockdataservice == null)
            {
                _mockdataservice = new MockDataService();
                _mockdataservice.InitData();
            }
            return _mockdataservice;
        }

        private void InitData()
        {
            _containers = new List<ContainerModel>()
            {
            new ContainerModel
            {
                id =Guid.NewGuid().ToString()
            }
            };
        
        }

        public bool AddContainer()
        {
            ContainerModel item = new ContainerModel();
            ContainerAbstractionStructure.containers.Add(item);
            item.id = Guid.NewGuid().ToString();
            _containers.Add(item);
            return true;
        }

        public bool AddBucketToContainer(BucketModel bucket)
        {
            bool found = false;
            if (!_containers.Any())
            {
                var item = new ContainerModel
                {
                    id = Guid.NewGuid().ToString(),
                    CurrentContentValue = bucket.MaxCapacity,
                    BucketsStoredInsideThisContainer = new List<BucketModel> 
                    { 
                    bucket
                    }
                };
                StaticResources.CurrentStaticContainer.currentContainer = item;
                _containers.Add(item);
                Console.WriteLine("Bucket and container added");


            }
            foreach (var item in _containers)
            {
                if (found == false)
                {
                    if (item.MaxCapacity > item.CurrentContentValue)
                    {
                        item.BucketsStoredInsideThisContainer.Add(bucket);
                        item.CurrentContentValue = bucket.MaxCapacity;
                        found = true;
                        Console.WriteLine("Bucket added");
                    }
                }
            }
            if (found == false)
            {
                ContainerModel item = new ContainerModel();
                ContainerAbstractionStructure.containers = new List<ContainerModel>();
                ContainerAbstractionStructure.containers.Add(item);
                item.id = Guid.NewGuid().ToString();
                item.BucketsStoredInsideThisContainer = new List<BucketModel>();
                item.BucketsStoredInsideThisContainer.Add(bucket);
                item.CurrentContentValue = bucket.MaxCapacity;
                _containers.Add(item);
                Console.WriteLine("Bucket and container added");
            }

            return true;
        }

        public bool AddOilBarrelToContainer(OilBarrelModel oilbarrel)
        {
            bool found = false;
            if (!_containers.Any())
            {
                var item = new ContainerModel
                {
                    id = Guid.NewGuid().ToString(),
                    CurrentContentValue = oilbarrel.MaxCapacity,
                    OilBarrelsStoredInsideThisContainer = new List<OilBarrelModel>
                    {
                    oilbarrel
                    }
                };
                StaticResources.CurrentStaticContainer.currentContainer = item;
                _containers.Add(item);
                Console.WriteLine("OilBarrel and container added");

            }
            foreach (var item in _containers)
            {
                if (found == false)
                {
                    if (item.MaxCapacity > item.CurrentContentValue)
                    {
                        item.OilBarrelsStoredInsideThisContainer.Add(oilbarrel);
                        item.CurrentContentValue = oilbarrel.MaxCapacity;
                        found = true;
                        Console.WriteLine("OilBarrel added");
                    }
                }
            }
            if (found == false)
            {
                ContainerModel item = new ContainerModel();
                ContainerAbstractionStructure.containers = new List<ContainerModel>();
                ContainerAbstractionStructure.containers.Add(item);
                item.id = Guid.NewGuid().ToString();
                item.OilBarrelsStoredInsideThisContainer = new List<OilBarrelModel>();
                item.OilBarrelsStoredInsideThisContainer.Add(oilbarrel);
                item.CurrentContentValue = oilbarrel.MaxCapacity;
                _containers.Add(item);
                Console.WriteLine("OilBarrel and container added");
            }

            return true;
        }
        
        public bool AddMediumRainBarrelToContainer(RainBarrelMediumModel mediumbarrel)
        {
            bool found = false;
            if (!_containers.Any())
            {
                var item = new ContainerModel
                {
                    id = Guid.NewGuid().ToString(),
                    CurrentContentValue = mediumbarrel.MaxCapacity,
                    MediumRainBarrelsStoredInsideThisContainer = new List<RainBarrelMediumModel>
                    {
                    mediumbarrel
                    }
                };
                StaticResources.CurrentStaticContainer.currentContainer = item;
                _containers.Add(item);
                Console.WriteLine("Medium rainbarrel and container added");

            }
            foreach (var item in _containers)
            {
                if (found == false)
                {
                    if (item.MaxCapacity > item.CurrentContentValue)
                    {
                        item.MediumRainBarrelsStoredInsideThisContainer.Add(mediumbarrel);
                        item.CurrentContentValue = mediumbarrel.MaxCapacity;
                        found = true;
                        Console.WriteLine("Medium rainbarrel added");
                    }
                }
            }
            if (found == false)
            {
                ContainerModel item = new ContainerModel();
                ContainerAbstractionStructure.containers = new List<ContainerModel>();
                ContainerAbstractionStructure.containers.Add(item);
                item.id = Guid.NewGuid().ToString();
                item.MediumRainBarrelsStoredInsideThisContainer = new List<RainBarrelMediumModel>();
                item.MediumRainBarrelsStoredInsideThisContainer.Add(mediumbarrel);
                item.CurrentContentValue = mediumbarrel.MaxCapacity;
                _containers.Add(item);
                Console.WriteLine("Medium rainbarrel and container added");
            }

            return true;
        }


        public bool AddSmallRainBarrelToContainer(RainbarrelSmallModel smallbarrel)
        {
            bool found = false;
            if (!_containers.Any())
            {
                var item = new ContainerModel
                {
                    id = Guid.NewGuid().ToString(),
                    CurrentContentValue = smallbarrel.MaxCapacity,
                    SmallRainBarrelsStoredInsideThisContainer = new List<RainbarrelSmallModel>
                    {
                    smallbarrel
                    }
                };
                StaticResources.CurrentStaticContainer.currentContainer = item;
                _containers.Add(item);
                Console.WriteLine("Small rainbarrel and container added");


            }
            foreach (var item in _containers)
            {
                if (found == false)
                {
                    if (item.MaxCapacity > item.CurrentContentValue)
                    {
                        item.SmallRainBarrelsStoredInsideThisContainer.Add(smallbarrel);
                        item.CurrentContentValue = smallbarrel.MaxCapacity;
                        found = true;
                        Console.WriteLine("Small rainbarrel added");
                    }
                }
            }
            if (found == false)
            {
                ContainerModel item = new ContainerModel();
                ContainerAbstractionStructure.containers = new List<ContainerModel>();
                ContainerAbstractionStructure.containers.Add(item);
                item.id = Guid.NewGuid().ToString();
                item.SmallRainBarrelsStoredInsideThisContainer = new List<RainbarrelSmallModel>();
                item.SmallRainBarrelsStoredInsideThisContainer.Add(smallbarrel);
                item.CurrentContentValue = smallbarrel.MaxCapacity;
                _containers.Add(item);
                Console.WriteLine("Medium rainbarrel and container added");
            }

            return true;
        }


        public bool AddLargeRainBarrelToContainer(RainBarrelLargeModel largeModel)
        {
            bool found = false;
            if (!_containers.Any())
            {
                var item = new ContainerModel
                {
                    id = Guid.NewGuid().ToString(),
                    CurrentContentValue = largeModel.MaxCapacity,
                    LargeRainBarrelsStoredInsideThisContainer = new List<RainBarrelLargeModel>
                    {
                    largeModel
                    }
                };
                StaticResources.CurrentStaticContainer.currentContainer = item;
                _containers.Add(item);
                Console.WriteLine("Large rainbarrel and container added");

            }
            foreach (var item in _containers)
            {
                if (found == false)
                {
                    if (item.MaxCapacity > item.CurrentContentValue)
                    {
                        item.LargeRainBarrelsStoredInsideThisContainer.Add(largeModel);
                        item.CurrentContentValue = largeModel.MaxCapacity;
                        found = true;
                        Console.WriteLine("Large rainbarrel added");
                    }
                }
            }
            if (found == false)
            {
                ContainerModel item = new ContainerModel();
                ContainerAbstractionStructure.containers = new List<ContainerModel>();
                ContainerAbstractionStructure.containers.Add(item);
                item.id = Guid.NewGuid().ToString();
                item.LargeRainBarrelsStoredInsideThisContainer = new List<RainBarrelLargeModel>();
                item.LargeRainBarrelsStoredInsideThisContainer.Add(largeModel);
                item.CurrentContentValue = largeModel.MaxCapacity;
                _containers.Add(item);
                Console.WriteLine("Large rainbarrel and container added");
            }

            return true;
        }

        public bool emptyBucket(BucketModel bucket)
        {
            bucket.CurrentContentValue = 0;
            Console.WriteLine("Bucket emptied");
            return true;
        }

        public bool emptyOilBarrel(OilBarrelModel oil)
        {
            oil.CurrentContentValue = 0;
            Console.WriteLine("OilBarrel emptied");
            return true;
        }

        public bool emptyMediumRainBarrel(RainBarrelMediumModel mediumbarrel)
        {
            mediumbarrel.CurrentContentValue = 0;
            Console.WriteLine("Medium rainbarrel emptied");
            return true;
        }

        public bool emptySmallRainBarrel(RainbarrelSmallModel smallmodel)
        {
            smallmodel.CurrentContentValue = 0;
            Console.WriteLine("Small rainbarrel emptied");
            return true;
        }

        public bool emptyLargeRainBarrel(RainBarrelLargeModel largemodel)
        {
            largemodel.CurrentContentValue = 0;
            Console.WriteLine("Large rainbarrel emptied");
            return true;
        }

        public bool FillBucket(BucketModel bucket)
        {
            bucket.CurrentContentValue = bucket.MaxCapacity;
            Console.WriteLine("Bucket filled");
            return true;
        }

        public bool FillOilBarrel(OilBarrelModel oil)
        {
            oil.CurrentContentValue = oil.MaxCapacity;
            Console.WriteLine("Oilbarrel filled");
            return true;
        }

        public bool FillMediumRainBarrel(RainBarrelMediumModel mediumbarrel)
        {
            mediumbarrel.CurrentContentValue = mediumbarrel.MaxCapacity;
            Console.WriteLine("Medium rainbarrel filled");
            return true;
        }

        public bool FillSmallRainBarrel(RainbarrelSmallModel smallmodel)
        {
            smallmodel.CurrentContentValue = smallmodel.MaxCapacity;
            Console.WriteLine("Small rainbarrel filled");
            return true;
        }

        public bool FillLargeRainBarrel(RainBarrelLargeModel largemodel)
        {
            largemodel.CurrentContentValue = largemodel.MaxCapacity;
            Console.WriteLine("Large rainbarrel filled");
            return true;
        }

#nullable enable
        public ContainerModel? chooseContainer()


        {
            Console.WriteLine("Choose a container number between 1 and {0}", _containers.Count);
            var input = Console.ReadLine();
            int Num;
            bool isnum = int.TryParse(input.ToString(), out Num);
            if (isnum)
            {
                if (int.Parse(input) > 1 && int.Parse(input) <= _containers.Count)
                {
                    StaticResources.CurrentStaticContainer.currentContainer = _containers[int.Parse(input) - 1];
                    Console.WriteLine("the container {0} is chosen", input);
                    return StaticResources.CurrentStaticContainer.currentContainer;
                }
                else
                {
                    Console.WriteLine("This number is not available");
                    return null;
                }
            }
            else
            {
                Console.WriteLine("Please fill in a valid value");
                return null;
            }

        }
#nullable disable

#nullable enable
        public BucketModel? chooseBucket()


        {
            Console.WriteLine("Choose a bucket number between 1 and {0}", StaticResources.CurrentStaticContainer.currentContainer.BucketsStoredInsideThisContainer.Count);
            var input = Console.ReadLine();
            int Num;
            bool isnum = int.TryParse(input.ToString(), out Num);
            if (isnum)
            {
                if (int.Parse(input) > 1 && int.Parse(input) <= StaticResources.CurrentStaticContainer.currentContainer.BucketsStoredInsideThisContainer.Count)
                {
                    Console.WriteLine("the bucket {0} is chosen", input);
                    return StaticResources.CurrentStaticContainer.currentContainer.BucketsStoredInsideThisContainer[int.Parse(input) - 1];
                }
                else
                {
                    Console.WriteLine("This number is not available");
                    return null;
                }
            }
            else
            {
                Console.WriteLine("Please fill in a valid value");
                return null;
            }

        }
#nullable disable

#nullable enable
        public OilBarrelModel? chooseOilBarrel()


        {
            Console.WriteLine("Choose a oilbarrel number between 1 and {0}", StaticResources.CurrentStaticContainer.currentContainer.OilBarrelsStoredInsideThisContainer.Count);
            var input = Console.ReadLine();
            int Num;
            bool isnum = int.TryParse(input.ToString(), out Num);
            if (isnum)
            {
                if (int.Parse(input) > 1 && int.Parse(input) <= StaticResources.CurrentStaticContainer.currentContainer.OilBarrelsStoredInsideThisContainer.Count)
                {
                    Console.WriteLine("the oilbarrel {0} is chosen", input);
                    return StaticResources.CurrentStaticContainer.currentContainer.OilBarrelsStoredInsideThisContainer[int.Parse(input) - 1];
                }
                else
                {
                    Console.WriteLine("This number is not available");
                    return null;
                }
            }
            else
            {
                Console.WriteLine("Please fill in a valid value");
                return null;
            }

        }
#nullable disable

#nullable enable
        public RainbarrelSmallModel? chooseSmallBarrel()


        {
            Console.WriteLine("Choose a small rainbarrel number between 1 and {0}", StaticResources.CurrentStaticContainer.currentContainer.SmallRainBarrelsStoredInsideThisContainer.Count);
            var input = Console.ReadLine();
            int Num;
            bool isnum = int.TryParse(input.ToString(), out Num);
            if (isnum)
            {
                if (int.Parse(input) > 1 && int.Parse(input) <= StaticResources.CurrentStaticContainer.currentContainer.SmallRainBarrelsStoredInsideThisContainer.Count)
                {
                    Console.WriteLine("the small rainbarrel {0} is chosen", input);
                    return StaticResources.CurrentStaticContainer.currentContainer.SmallRainBarrelsStoredInsideThisContainer[int.Parse(input) - 1];
                }
                else
                {
                    Console.WriteLine("This number is not available");
                    return null;
                }
            }
            else
            {
                Console.WriteLine("Please fill in a valid value");
                return null;
            }

        }
#nullable disable

#nullable enable
        public RainBarrelMediumModel? chooseMediumBarrel()


        {
            Console.WriteLine("Choose a medium rainbarrel number between 1 and {0}", StaticResources.CurrentStaticContainer.currentContainer.MediumRainBarrelsStoredInsideThisContainer.Count);
            var input = Console.ReadLine();
            int Num;
            bool isnum = int.TryParse(input.ToString(), out Num);
            if (isnum)
            {
                if (int.Parse(input) > 1 && int.Parse(input) <= StaticResources.CurrentStaticContainer.currentContainer.MediumRainBarrelsStoredInsideThisContainer.Count)
                {
                    Console.WriteLine("the medium rainbarrel {0} is chosen", input);
                    return StaticResources.CurrentStaticContainer.currentContainer.MediumRainBarrelsStoredInsideThisContainer[int.Parse(input) - 1];
                }
                else
                {
                    Console.WriteLine("This number is not available");
                    return null;
                }
            }
            else
            {
                Console.WriteLine("Please fill in a valid value");
                return null;
            }

        }
#nullable disable


#nullable enable
        public RainBarrelLargeModel? chooseLargeBarrel()


        {
            Console.WriteLine("Choose a Large rainbarrel number between 1 and {0}", StaticResources.CurrentStaticContainer.currentContainer.LargeRainBarrelsStoredInsideThisContainer.Count);
            var input = Console.ReadLine();
            int Num;
            bool isnum = int.TryParse(input.ToString(), out Num);
            if (isnum)
            {
                if (int.Parse(input) > 1 && int.Parse(input) <= StaticResources.CurrentStaticContainer.currentContainer.LargeRainBarrelsStoredInsideThisContainer.Count)
                {
                    Console.WriteLine("the Large rainbarrel {0} is chosen", input);
                    return StaticResources.CurrentStaticContainer.currentContainer.LargeRainBarrelsStoredInsideThisContainer[int.Parse(input) - 1];
                }
                else
                {
                    Console.WriteLine("This number is not available");
                    return null;
                }
            }
            else
            {
                Console.WriteLine("Please fill in a valid value");
                return null;
            }

        }
#nullable disable

    }
}
