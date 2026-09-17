//namespace OOPASS_03
//{
//    using System;
//    // Q1 PRACTICAL
//    public struct DeliveryAddress
//    {
//        public string City;
//        public string Street;
//        public int BuildingNumber;

//        public DeliveryAddress(string city, string street, int buildingNumber)
//        {
//            City = city;
//            Street = street;
//            BuildingNumber = buildingNumber;
//        }

//        public string GetFullAddress()
//        {
//            return $"{BuildingNumber} {Street}, {City}";
//        }
//    }

//    public class Shipment
//    {
//        private string _trackingCode;
//        private string _description;
//        private double _weight;
//        private decimal _deliveryFee;

//        public string TrackingCode
//        {
//            get
//            {
//                return _trackingCode;
//            }
//        }

//        public string Description
//        {
//            get
//            {
//                return _description;
//            }
//            set
//            {
//                if (!string.IsNullOrWhiteSpace(value))
//                {
//                    _description = value;
//                }
//            }
//        }

//        public double Weight
//        {
//            get
//            {
//                return _weight;
//            }
//            set
//            {
//                if (value > 0)
//                {
//                    _weight = value;
//                }
//            }
//        }

//        public decimal DeliveryFee
//        {
//            get
//            {
//                return _deliveryFee;
//            }
//            private set
//            {
//                if (value > 0)
//                {
//                    _deliveryFee = value;
//                }
//            }
//        }

//        public DeliveryAddress Destination { get; set; }

//        // Point 1: EstimatedCost is virtual
//        public virtual decimal EstimatedCost
//        {
//            get
//            {
//                return DeliveryFee + ((decimal)Weight * 5);
//            }
//        }

//        public Shipment(
//            string trackingCode,
//            string description,
//            double weight,
//            decimal deliveryFee,
//            DeliveryAddress destination)
//        {
//            _trackingCode =
//                string.IsNullOrWhiteSpace(trackingCode)
//                ? "Unknown"
//                : trackingCode;

//            _description =
//                string.IsNullOrWhiteSpace(description)
//                ? "Unknown"
//                : description;

//            _weight =
//                weight > 0
//                ? weight
//                : 1;

//            _deliveryFee =
//                deliveryFee > 0
//                ? deliveryFee
//                : 50;

//            Destination = destination;
//        }

//        public void UpdateDeliveryFee(decimal newFee)
//        {
//            if (newFee > 0)
//            {
//                DeliveryFee = newFee;
//            }
//        }

//        // Method Overloading - Version 1
//        public void UpdateWeight(double newWeight)
//        {
//            if (newWeight > 0)
//            {
//                Weight = newWeight;
//            }
//        }

//        // Method Overloading - Version 2
//        public void UpdateWeight(double newWeight, double extraPackingWeight)
//        {
//            double totalWeight = newWeight + extraPackingWeight;

//            if (totalWeight > 0)
//            {
//                Weight = totalWeight;
//            }
//        }

//        // Point 2: PrintShipment is virtual
//        public virtual void PrintShipment()
//        {
//            Console.WriteLine($"Tracking Code: {TrackingCode}");
//            Console.WriteLine($"Description: {Description}");
//            Console.WriteLine($"Weight: {Weight} KG");
//            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
//            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
//            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            DeliveryAddress address =
//                new DeliveryAddress("Cairo", "Tahrir Street", 15);

//            Shipment shipment =
//                new Shipment(
//                    "SH001",
//                    "Laptop",
//                    3,
//                    80,
//                    address);

//            shipment.PrintShipment();

//            Console.WriteLine();

//            shipment.UpdateWeight(5);
//            Console.WriteLine($"Updated Weight: {shipment.Weight} KG");

//            shipment.UpdateWeight(5, 0.5);
//            Console.WriteLine(
//                $"Updated Weight After Packing: {shipment.Weight} KG");
//        }
//    }
//}






































































// النظري
//Q1  A

//a) What is the difference between Method Overloading and Method Overriding?

//Method Overloading:

//Same method name.
//Different parameters.
//Resolved at Compile Time.


//Method Overriding:

//A child class provides a new implementation of a method from the parent class.
//Uses virtual in the parent and override in the child.
//Resolved at Run Time.

//Q1  B

//What is the difference between Static Binding and Dynamic Binding?

//Static Binding:

//The method to be called is determined at Compile Time.
//Commonly associated with Method Overloading.


//Dynamic Binding:

//The method to be called is determined at Run Time.
//Happens with virtual/override methods.
//The actual object's type determines which overridden method runs.


//Q2 A

// What is the purpose of the sealed keyword when applied to a class?

//The sealed keyword prevents a class from being inherited by another class.


//Q2 B

// What is the difference between a sealed class and a sealed method?

//Sealed Class:

//Prevents other classes from inheriting from it.

//Sealed Method:

//Prevents a derived class from overriding that method again.

//Q2 C
// Can a sealed method be overridden? Why?

//No

//A sealed method cannot be overridden by another derived class because the
//sealed keyword prevents further overriding.