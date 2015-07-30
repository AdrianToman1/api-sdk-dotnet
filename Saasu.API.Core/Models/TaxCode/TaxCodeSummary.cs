﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saasu.API.Core.Models.TaxCode
{
    /// <summary>
    /// A tax code resource.
    /// </summary>
    public class TaxCodeSummary : BaseModel
    {
        /// <summary>
        /// The Id/key of this resource.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The actual tax code.
        /// </summary>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public string Code { get; set; }
        /// <summary>
        /// The name of this tax code.
        /// </summary>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public string Name { get; set; }
        /// <summary>
        /// The rate associated with this tax code.
        /// </summary>
        public decimal Rate { get; set; }
        /// <summary>
        /// The account tax amounts are posted to when used in transactions.
        /// </summary>
        public int? PostingAccountId { get; set; }
        /// <summary>
        /// Tax code could be used in Sale transactions.
        /// </summary>
        public bool IsSale { get; set; }
        /// <summary>
        /// Tax code could be used in Purchase transactions.
        /// </summary>
        public bool IsPurchase { get; set; }
        /// <summary>
        /// Tax code could be used in Payroll transactions. NOTE: This only applies to inbuilt tax codes. 
        /// </summary>
        public bool IsPayroll { get; set; }
        /// <summary>
        /// Indicates if the Tax code was generated by the system.
        /// </summary>
        public bool IsInbuilt { get; set; }
        /// <summary>
        /// Indicates if the tax code is shared.
        /// </summary>
        public bool IsShared { get; set; }
        /// <summary>
        /// Indicates if the tax code is currently set to active.
        /// </summary>
        public bool IsActive { get; set; }        
        /// <summary>
        /// The date and time that this resource was created in UTC.
        /// </summary>
        public DateTime? CreatedDateUtc { get; set; }
        /// <summary>
        /// The date and time that this resource was last modified in UTC.
        /// </summary>
        public DateTime? LastModifiedDateUtc { get; set; }
        /// <summary>
        /// The user id that last modified this resource
        /// </summary>
        public int? LastModifiedByUserId { get; set; }
        /// <summary>
        /// The unique Id for this version of the record which is required to be passed in when next updating this resource.
        /// </summary>
        [System.Xml.Serialization.XmlElement(IsNullable = true)]
        public string LastUpdatedId { get; set; }

        public override string ModelKeyValue()
        {
            return  Id.ToString();
        }
    }
}
