// <copyright file="Repository.cs" company="Computer Technology Solutions, Inc.">
// Copyright (c) 2012 Computer Technology Solutions, Inc.  ALL RIGHTS RESERVED
// </copyright>
// <author>jvandyne</author>
// <date>8/2/2012 2:21:47 PM</date>
// <productName></productName>
namespace com.askcts.demos.entityframework.data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
  
    public class Repository
    {
        public IQueryable<ef.sample.dto.IFirstName> FilterMyQuery(IQueryable<ef.sample.dto.IFirstName> query)
        {
            // get my user name
            var userName = "James";

            return query.Where(q => q.FirstName == userName);
        } 
    }
}
