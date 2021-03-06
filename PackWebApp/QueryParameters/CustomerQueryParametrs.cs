﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace PackWebApp.QueryParameters
{
    public class CustomerQueryParametrs
    {
        private const int MaxPageCount = 100;

        private int _page = 1; 
        public int Page { get => Math.Max(_page, 1); set => _page = value; }

        private int _pageCount = 100;

        public int PageCount
        {
            get => _pageCount;
            set => _pageCount = (value > MaxPageCount) ? MaxPageCount : value;
        }

        public string Query { get; set; }

        public bool HasQuery => !String.IsNullOrEmpty(Query);
    }
}
