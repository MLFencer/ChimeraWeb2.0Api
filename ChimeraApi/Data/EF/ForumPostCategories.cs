﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace ChimeraApi.Data.EF
{
    public partial class ForumPostCategories
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ParentCategoryId { get; set; }
        public Guid CreatedById { get; set; }
    }
}