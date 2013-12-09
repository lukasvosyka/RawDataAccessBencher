﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Collections.Specialized;
using System.Collections.Generic;

namespace EF6.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'UnitMeasure'.</summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class UnitMeasure : CommonEntityBase
	{
		/// <summary>Initializes a new instance of the <see cref="UnitMeasure"/> class.</summary>
		public UnitMeasure() : base()
		{
			this.BillOfMaterials = new HashSet<BillOfMaterial>();
			this.Products = new HashSet<Product>();
			this.Products_ = new HashSet<Product>();
			this.ProductVendors = new HashSet<ProductVendor>();
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		[DataMember]
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the Name field. </summary>
		[DataMember]
		public System.String Name { get; set;}
		/// <summary>Gets or sets the UnitMeasureCode field. </summary>
		[DataMember]
		public System.String UnitMeasureCode { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'BillOfMaterial.UnitMeasure - UnitMeasure.BillOfMaterials (m:1)'</summary>
		[DataMember]
		public virtual ICollection<BillOfMaterial> BillOfMaterials { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Product.UnitMeasure - UnitMeasure.Products (m:1)'</summary>
		[DataMember]
		public virtual ICollection<Product> Products { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Product.UnitMeasure_ - UnitMeasure.Products_ (m:1)'</summary>
		[DataMember]
		public virtual ICollection<Product> Products_ { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ProductVendor.UnitMeasure - UnitMeasure.ProductVendors (m:1)'</summary>
		[DataMember]
		public virtual ICollection<ProductVendor> ProductVendors { get; set;}
		#endregion
	}
}