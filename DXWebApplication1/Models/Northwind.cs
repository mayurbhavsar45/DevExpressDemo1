using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DXWebApplication1.Models
{
    public class Northwind
    {
    }
    public class Employee
    {
        public int EmployeeID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public Employee()
        {
        }
        public Employee(int _EmployeeID, string _FirstName, string _LastName)
        {
            this.EmployeeID = _EmployeeID;
            this.FirstName = _FirstName;
            this.LastName = _LastName;
        }
    }
    public class Order
    {
        public Order()
        {
        }
        public Order(int _OrderId, DateTime _OrderDate, string _ShipName, string _ShipCountry, string _ShipCity, string _ShipAddress, DateTime _ShippedDate, double _Quantity, double _UnitPrice, int _CustomerID, string _ContactName, string _CompanyName, string _City, string _Address, string _Phone, string _Fax)
        {
            this.OrderID = _OrderId;
            this.OrderDate = _OrderDate;
            this.ShipName = _ShipName;
            this.ShipCountry = _ShipCountry;
            this.ShipCity = _ShipCity;
            this.ShipAddress = _ShipAddress;
            this.ShippedDate = _ShippedDate;
            this.Quantity = _Quantity;
            this.UnitPrice = _UnitPrice;
            this.CustomerID = _CustomerID;
            this.ContactName = _ContactName;
            this.CompanyName = _CompanyName;
            this.City = _City;
            this.Address = _Address;
            this.Phone = _Phone;
            this.Fax = _Fax;
        }
        public int OrderID { set; get; }
        public DateTime OrderDate { set; get; }
        public string ShipName { set; get; }
        public string ShipCountry { set; get; }
        public string ShipCity { set; get; }
        public string ShipAddress { set; get; }
        public DateTime ShippedDate { set; get; }
        public double Quantity { set; get; }
        public double UnitPrice { set; get; }
        public int CustomerID { set; get; }
        public string ContactName { set; get; }
        public string CompanyName { set; get; }
        public string City { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Fax { set; get; }
    }
    public static class NorthwindDataProvider
    {
        public static List<Employee> GetEmployeesList()
        {
            List<Employee> objList = new List<Employee>();

            objList.Add(new Employee(1, "Jainish", "Jariwala"));
            objList.Add(new Employee(2, "Jainish2", "Jariwala"));
            objList.Add(new Employee(3, "Jainish3", "Jariwala"));
            objList.Add(new Employee(4, "Jainish4", "Jariwala"));

            //return objList.Select(e => new
            //{
            //    ID = e.EmployeeID,
            //    Name = e.LastName + " " + e.FirstName
            //}).ToList();
            return objList;
        }
        public static int GetFirstEmployeeID()
        {
            return 1;
        }
        public static IEnumerable GetOrders(int employeeID)
        {
            List<Order> objList = new List<Order>();
            objList.Add(new Order(1, DateTime.Now, "ship1", "Ind", "Surat", "addr ship", DateTime.Now, 2.0, 500.56, 2, "jainish jariwala", "abcd", "mumbai", "addr addr", "1146464", "fx123456"));

            //var query = from order in DB.Orders
            //            where order.EmployeeID == employeeID
            //            join order_detail in DB.Order_Details on order.OrderID equals order_detail.OrderID
            //            join customer in DB.Customers on order.CustomerID equals customer.CustomerID
            //            select new
            //            {
            //                order.OrderID,
            //                order.OrderDate,
            //                order.ShipName,
            //                order.ShipCountry,
            //                order.ShipCity,
            //                order.ShipAddress,
            //                order.ShippedDate,
            //                order_detail.Quantity,
            //                order_detail.UnitPrice,
            //                customer.CustomerID,
            //                customer.ContactName,
            //                customer.CompanyName,
            //                customer.City,
            //                customer.Address,
            //                customer.Phone,
            //                customer.Fax
            //            };
            //return query.ToList();

            return objList;
        }
    }
}