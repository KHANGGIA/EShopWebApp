﻿using Microsoft.AspNetCore.Http;
using SharedObject.Common;

namespace SharedObject.ViewModel.Product
{
    public class ProductImageUpdateRequest
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public Confirm IsDefault { get; set; }
        public int SortOrder { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}