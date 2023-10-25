//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v12.2.0+173d8dc
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	// Mixin Content Type with alias "footer"
	/// <summary>Footer</summary>
	public partial interface IFooter : IPublishedElement
	{
		/// <summary>Company Name</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.2.0+173d8dc")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string CompanyName { get; }

		/// <summary>E-Mail</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.2.0+173d8dc")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string EMail { get; }

		/// <summary>Phone Number</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.2.0+173d8dc")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string PhoneNumber { get; }
	}

	/// <summary>Footer</summary>
	[PublishedModel("footer")]
	public partial class Footer : PublishedElementModel, IFooter
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.2.0+173d8dc")]
		public new const string ModelTypeAlias = "footer";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.2.0+173d8dc")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.2.0+173d8dc")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.2.0+173d8dc")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<Footer, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public Footer(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Company Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.2.0+173d8dc")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("companyName")]
		public virtual string CompanyName => GetCompanyName(this, _publishedValueFallback);

		/// <summary>Static getter for Company Name</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.2.0+173d8dc")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetCompanyName(IFooter that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "companyName");

		///<summary>
		/// E-Mail
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.2.0+173d8dc")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("eMail")]
		public virtual string EMail => GetEMail(this, _publishedValueFallback);

		/// <summary>Static getter for E-Mail</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.2.0+173d8dc")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetEMail(IFooter that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "eMail");

		///<summary>
		/// Phone Number
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.2.0+173d8dc")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("phoneNumber")]
		public virtual string PhoneNumber => GetPhoneNumber(this, _publishedValueFallback);

		/// <summary>Static getter for Phone Number</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.2.0+173d8dc")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetPhoneNumber(IFooter that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "phoneNumber");
	}
}
