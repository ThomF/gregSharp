using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gregSharp.Models;

    public class House
    {
        public int Id { get; set;}
        public string Title { get; set;}
        public int Floors { get; set;}
        public int Bedrooms { get; set;}
        public double? Bathrooms { get; set;} = 1;
        public int SquareFt { get; set;}
        public int Price { get; set;}
        public string Description { get; set;}
    }
