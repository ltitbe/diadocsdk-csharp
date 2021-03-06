//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Documents/AcceptanceCertificateDocument.proto
// Note: requires additional types generated from: Documents/ReceiptStatus.proto
namespace Diadoc.Api.Proto.Documents.AcceptanceCertificateDocument
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AcceptanceCertificateMetadata")]
  public partial class AcceptanceCertificateMetadata : global::ProtoBuf.IExtensible
  {
    public AcceptanceCertificateMetadata() {}
    

    private Diadoc.Api.Proto.Documents.AcceptanceCertificateDocument.AcceptanceCertificateDocumentStatus _DocumentStatus = Diadoc.Api.Proto.Documents.AcceptanceCertificateDocument.AcceptanceCertificateDocumentStatus.UnknownAcceptanceCertificateDocumentStatus;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"DocumentStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Documents.AcceptanceCertificateDocument.AcceptanceCertificateDocumentStatus.UnknownAcceptanceCertificateDocumentStatus)]
    public Diadoc.Api.Proto.Documents.AcceptanceCertificateDocument.AcceptanceCertificateDocumentStatus DocumentStatus
    {
      get { return _DocumentStatus; }
      set { _DocumentStatus = value; }
    }
    private string _Total;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Total", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Total
    {
      get { return _Total; }
      set { _Total = value; }
    }

    private string _Vat = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Vat", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Vat
    {
      get { return _Vat; }
      set { _Vat = value; }
    }

    private string _Grounds = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Grounds", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Grounds
    {
      get { return _Grounds; }
      set { _Grounds = value; }
    }

    private Diadoc.Api.Proto.Documents.ReceiptStatus _ReceiptStatus = Diadoc.Api.Proto.Documents.ReceiptStatus.UnknownReceiptStatus;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ReceiptStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Documents.ReceiptStatus.UnknownReceiptStatus)]
    public Diadoc.Api.Proto.Documents.ReceiptStatus ReceiptStatus
    {
      get { return _ReceiptStatus; }
      set { _ReceiptStatus = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"AcceptanceCertificateDocumentStatus")]
    public enum AcceptanceCertificateDocumentStatus
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"UnknownAcceptanceCertificateDocumentStatus", Value=0)]
      UnknownAcceptanceCertificateDocumentStatus = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundWaitingForRecipientSignature", Value=1)]
      OutboundWaitingForRecipientSignature = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundWithRecipientSignature", Value=2)]
      OutboundWithRecipientSignature = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundWithRecipientPartiallySignature", Value=19)]
      OutboundWithRecipientPartiallySignature = 19,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundRecipientSignatureRequestRejected", Value=3)]
      OutboundRecipientSignatureRequestRejected = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundWaitingForSenderSignature", Value=10)]
      OutboundWaitingForSenderSignature = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundInvalidSenderSignature", Value=11)]
      OutboundInvalidSenderSignature = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundNoRecipientSignatureRequest", Value=16)]
      OutboundNoRecipientSignatureRequest = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InboundWaitingForRecipientSignature", Value=4)]
      InboundWaitingForRecipientSignature = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InboundWithRecipientSignature", Value=5)]
      InboundWithRecipientSignature = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InboundWithRecipientPartiallySignature", Value=20)]
      InboundWithRecipientPartiallySignature = 20,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InboundRecipientSignatureRequestRejected", Value=6)]
      InboundRecipientSignatureRequestRejected = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InboundInvalidRecipientSignature", Value=12)]
      InboundInvalidRecipientSignature = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InboundNoRecipientSignatureRequest", Value=17)]
      InboundNoRecipientSignatureRequest = 17,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InternalWaitingForRecipientSignature", Value=7)]
      InternalWaitingForRecipientSignature = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InternalWithRecipientSignature", Value=8)]
      InternalWithRecipientSignature = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InternalWithRecipientPartiallySignature", Value=21)]
      InternalWithRecipientPartiallySignature = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InternalRecipientSignatureRequestRejected", Value=9)]
      InternalRecipientSignatureRequestRejected = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InternalWaitingForSenderSignature", Value=13)]
      InternalWaitingForSenderSignature = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InternalInvalidSenderSignature", Value=14)]
      InternalInvalidSenderSignature = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InternalInvalidRecipientSignature", Value=15)]
      InternalInvalidRecipientSignature = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InternalNoRecipientSignatureRequest", Value=18)]
      InternalNoRecipientSignatureRequest = 18
    }
  
}