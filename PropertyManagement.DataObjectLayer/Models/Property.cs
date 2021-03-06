﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PropertyManagement.DataObjectLayer.Models
{
    public class Property
    {
        [Key]
        public int PropertyId { get; set; }
        public int PropertyTypeId { get; set; }
        public string Address { get; set; }
        public string UnitNumber { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public string ZipCode { get; set; }
        public int StatusId { get; set; }
        public decimal PurchasePrice { get; set; }
        public string PurchaseDate { get; set; }
        public decimal SoldPrice { get; set; }
        public string SoldDate { get; set; }
        public string Notes  { get; set; }
        public string FullAddress { get; set; }
    }

    public class PropertyList
    {
        public int PropertyId { get; set; }
        public int PropertyTypeId { get; set; }
        public string PropertyTypeName { get; set; }
        public string Address { get; set; }
        public string UnitNumber { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public decimal PurchasePrice { get; set; }
        public string PurchaseDate { get; set; }
        public decimal SoldPrice { get; set; }
        public string SoldDate { get; set; }
        public string Notes { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string FullAddress { get; set; }
    }
}
