﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace Diadoc.Api.DataXml.Utd820
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class UniversalTransferDocumentBuyerTitle
	{
		private Employee employeeField;

		private OtherIssuer otherIssuerField;

		private AdditionalInfoId additionalInfoIdField;

		private object[] signersField;

		private UniversalTransferDocumentBuyerTitleContentOperCode contentOperCodeField;

		private UniversalTransferDocumentBuyerTitleBuyerInfoCircumPublicProc buyerInfoCircumPublicProcField;

		private string documentCreatorField;

		private string documentCreatorBaseField;

		private string operationCodeField;

		private string operationContentField;

		private string acceptanceDateField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public Employee Employee
		{
			get { return this.employeeField; }
			set { this.employeeField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public OtherIssuer OtherIssuer
		{
			get { return this.otherIssuerField; }
			set { this.otherIssuerField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public AdditionalInfoId AdditionalInfoId
		{
			get { return this.additionalInfoIdField; }
			set { this.additionalInfoIdField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlArrayItemAttribute("SignerDetails", typeof(ExtendedSignerDetails_BuyerTitle820), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		[System.Xml.Serialization.XmlArrayItemAttribute(typeof(SignerReference), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
		public object[] Signers
		{
			get { return this.signersField; }
			set { this.signersField = value; }
		}

		public UniversalTransferDocumentBuyerTitle UseSignerReferences(SignerReference[] signerReferences)
		{
			this.Signers = signerReferences;
			return this;
		}

		public UniversalTransferDocumentBuyerTitle UseSignerDetails(ExtendedSignerDetails_BuyerTitle820[] signerDetails)
		{
			this.Signers = signerDetails;
			return this;
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public UniversalTransferDocumentBuyerTitleContentOperCode ContentOperCode
		{
			get { return this.contentOperCodeField; }
			set { this.contentOperCodeField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public UniversalTransferDocumentBuyerTitleBuyerInfoCircumPublicProc BuyerInfoCircumPublicProc
		{
			get { return this.buyerInfoCircumPublicProcField; }
			set { this.buyerInfoCircumPublicProcField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string DocumentCreator
		{
			get { return this.documentCreatorField; }
			set { this.documentCreatorField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string DocumentCreatorBase
		{
			get { return this.documentCreatorBaseField; }
			set { this.documentCreatorBaseField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string OperationCode
		{
			get { return this.operationCodeField; }
			set { this.operationCodeField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string OperationContent
		{
			get { return this.operationContentField; }
			set { this.operationContentField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string AcceptanceDate
		{
			get { return this.acceptanceDateField; }
			set { this.acceptanceDateField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class UniversalTransferDocumentBuyerTitleContentOperCode
	{
		private UniversalTransferDocumentBuyerTitleContentOperCodeTotalCode totalCodeField;

		private string nameDiscrepDocumentField;

		private UniversalTransferDocumentBuyerTitleContentOperCodeTypeDiscrepDocument typeDiscrepDocumentField;

		private bool typeDiscrepDocumentFieldSpecified;

		private string numberDiscrepDocumentField;

		private string dateDiscrepDocumentField;

		private string idDiscrepDocumentField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public UniversalTransferDocumentBuyerTitleContentOperCodeTotalCode TotalCode
		{
			get { return this.totalCodeField; }
			set { this.totalCodeField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string NameDiscrepDocument
		{
			get { return this.nameDiscrepDocumentField; }
			set { this.nameDiscrepDocumentField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public UniversalTransferDocumentBuyerTitleContentOperCodeTypeDiscrepDocument TypeDiscrepDocument
		{
			get { return this.typeDiscrepDocumentField; }
			set { this.typeDiscrepDocumentField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool TypeDiscrepDocumentSpecified
		{
			get { return this.typeDiscrepDocumentFieldSpecified; }
			set { this.typeDiscrepDocumentFieldSpecified = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string NumberDiscrepDocument
		{
			get { return this.numberDiscrepDocumentField; }
			set { this.numberDiscrepDocumentField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string DateDiscrepDocument
		{
			get { return this.dateDiscrepDocumentField; }
			set { this.dateDiscrepDocumentField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string IdDiscrepDocument
		{
			get { return this.idDiscrepDocumentField; }
			set { this.idDiscrepDocumentField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum UniversalTransferDocumentBuyerTitleContentOperCodeTotalCode
	{
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("1")]
		Accepted,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("2")]
		AcceptedWithDiscrepancies,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("3")]
		NotAccepted,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum UniversalTransferDocumentBuyerTitleContentOperCodeTypeDiscrepDocument
	{
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("2")]
		DiscrepanciesAcceptance,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("3")]
		Discrepancies,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class UniversalTransferDocumentBuyerTitleBuyerInfoCircumPublicProc
	{
		private UniversalTransferDocumentBuyerTitleBuyerInfoCircumPublicProcInfoFundsLiab[] infoFundsLiabField;

		private string procCodeField;

		private string personalAccountBuyerField;

		private string nameFinAuthorityField;

		private string buyerRegistryEntryNumberField;

		private string buyerLiabNumberField;

		private string buyerTreasuryCodeField;

		private string buyerTreasuryNameField;

		private string oKTMOBuyField;

		private string oKTMOPlaceDeliveryField;

		private string payDeadLineField;

		private string numberFundsLiabField;

		private string paymentPriorityField;

		private UniversalTransferDocumentBuyerTitleBuyerInfoCircumPublicProcPaymentType paymentTypeField;

		private bool paymentTypeFieldSpecified;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("InfoFundsLiab", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public UniversalTransferDocumentBuyerTitleBuyerInfoCircumPublicProcInfoFundsLiab[] InfoFundsLiab
		{
			get { return this.infoFundsLiabField; }
			set { this.infoFundsLiabField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ProcCode
		{
			get { return this.procCodeField; }
			set { this.procCodeField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PersonalAccountBuyer
		{
			get { return this.personalAccountBuyerField; }
			set { this.personalAccountBuyerField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string NameFinAuthority
		{
			get { return this.nameFinAuthorityField; }
			set { this.nameFinAuthorityField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string BuyerRegistryEntryNumber
		{
			get { return this.buyerRegistryEntryNumberField; }
			set { this.buyerRegistryEntryNumberField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string BuyerLiabNumber
		{
			get { return this.buyerLiabNumberField; }
			set { this.buyerLiabNumberField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string BuyerTreasuryCode
		{
			get { return this.buyerTreasuryCodeField; }
			set { this.buyerTreasuryCodeField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string BuyerTreasuryName
		{
			get { return this.buyerTreasuryNameField; }
			set { this.buyerTreasuryNameField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string OKTMOBuy
		{
			get { return this.oKTMOBuyField; }
			set { this.oKTMOBuyField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string OKTMOPlaceDelivery
		{
			get { return this.oKTMOPlaceDeliveryField; }
			set { this.oKTMOPlaceDeliveryField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PayDeadLine
		{
			get { return this.payDeadLineField; }
			set { this.payDeadLineField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string NumberFundsLiab
		{
			get { return this.numberFundsLiabField; }
			set { this.numberFundsLiabField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string PaymentPriority
		{
			get { return this.paymentPriorityField; }
			set { this.paymentPriorityField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public UniversalTransferDocumentBuyerTitleBuyerInfoCircumPublicProcPaymentType PaymentType
		{
			get { return this.paymentTypeField; }
			set { this.paymentTypeField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlIgnoreAttribute()]
		public bool PaymentTypeSpecified
		{
			get { return this.paymentTypeFieldSpecified; }
			set { this.paymentTypeFieldSpecified = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class UniversalTransferDocumentBuyerTitleBuyerInfoCircumPublicProcInfoFundsLiab
	{
		private string numberStringField;

		private string objectCodeFAIPField;

		private UniversalTransferDocumentBuyerTitleBuyerInfoCircumPublicProcInfoFundsLiabFundsSourceType fundsSourceTypeField;

		private string buyerBudjetClassCodeField;

		private string buyerTargetCodeField;

		private decimal amountAdvanceField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
		public string NumberString
		{
			get { return this.numberStringField; }
			set { this.numberStringField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string ObjectCodeFAIP
		{
			get { return this.objectCodeFAIPField; }
			set { this.objectCodeFAIPField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public UniversalTransferDocumentBuyerTitleBuyerInfoCircumPublicProcInfoFundsLiabFundsSourceType FundsSourceType
		{
			get { return this.fundsSourceTypeField; }
			set { this.fundsSourceTypeField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string BuyerBudjetClassCode
		{
			get { return this.buyerBudjetClassCodeField; }
			set { this.buyerBudjetClassCodeField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string BuyerTargetCode
		{
			get { return this.buyerTargetCodeField; }
			set { this.buyerTargetCodeField = value; }
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public decimal AmountAdvance
		{
			get { return this.amountAdvanceField; }
			set { this.amountAdvanceField = value; }
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum UniversalTransferDocumentBuyerTitleBuyerInfoCircumPublicProcInfoFundsLiabFundsSourceType
	{
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("1")]
		Budjet,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("2")]
		UntitledSourceType,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("3")]
		AdditionalFunding,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("4")]
		InvestigatingActivitiesFunding,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("5")]
		TemporaryGovernmentSources,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("6")]
		LegalEntitiesSources,
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public enum UniversalTransferDocumentBuyerTitleBuyerInfoCircumPublicProcPaymentType
	{
		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("0")]
		Empty,

		/// <remarks/>
		[System.Xml.Serialization.XmlEnumAttribute("4")]
		Urgent,
	}
}
