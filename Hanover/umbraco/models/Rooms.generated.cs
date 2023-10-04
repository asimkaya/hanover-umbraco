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
	/// <summary>Rooms</summary>
	[PublishedModel("rooms")]
	public partial class Rooms : PublishedContentModel, IPageHeader, ISEO
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.2.0+173d8dc")]
		public new const string ModelTypeAlias = "rooms";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.2.0+173d8dc")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.2.0+173d8dc")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.2.0+173d8dc")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<Rooms, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public Rooms(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Page Alt Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.2.0+173d8dc")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageAltName")]
		public virtual string PageAltName => global::Umbraco.Cms.Web.Common.PublishedModels.PageHeader.GetPageAltName(this, _publishedValueFallback);

		///<summary>
		/// Page Image: 1920 × 1200 px
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.2.0+173d8dc")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops PageImage => global::Umbraco.Cms.Web.Common.PublishedModels.PageHeader.GetPageImage(this, _publishedValueFallback);

		///<summary>
		/// Page Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.2.0+173d8dc")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageName")]
		public virtual string PageName => global::Umbraco.Cms.Web.Common.PublishedModels.PageHeader.GetPageName(this, _publishedValueFallback);

		///<summary>
		/// Browser Header
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.2.0+173d8dc")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("browserHeader")]
		public virtual string BrowserHeader => global::Umbraco.Cms.Web.Common.PublishedModels.SEO.GetBrowserHeader(this, _publishedValueFallback);

		///<summary>
		/// Meta Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.2.0+173d8dc")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("metaDescription")]
		public virtual string MetaDescription => global::Umbraco.Cms.Web.Common.PublishedModels.SEO.GetMetaDescription(this, _publishedValueFallback);

		///<summary>
		/// Meta Header
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.2.0+173d8dc")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("metaHeader")]
		public virtual string MetaHeader => global::Umbraco.Cms.Web.Common.PublishedModels.SEO.GetMetaHeader(this, _publishedValueFallback);

		///<summary>
		/// Meta Tags
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "12.2.0+173d8dc")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("metaTags")]
		public virtual string MetaTags => global::Umbraco.Cms.Web.Common.PublishedModels.SEO.GetMetaTags(this, _publishedValueFallback);
	}
}
