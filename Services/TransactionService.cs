// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: jp.tamagotchi.proto.business/service/transaction/transactionService.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Jp.Tamagotchi.Business.Shared.Services.Transaction {

  /// <summary>Holder for reflection information generated from jp.tamagotchi.proto.business/service/transaction/transactionService.proto</summary>
  public static partial class TransactionServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for jp.tamagotchi.proto.business/service/transaction/transactionService.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TransactionServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CklqcC50YW1hZ290Y2hpLnByb3RvLmJ1c2luZXNzL3NlcnZpY2UvdHJhbnNh",
            "Y3Rpb24vdHJhbnNhY3Rpb25TZXJ2aWNlLnByb3RvEjJqcC50YW1hZ290Y2hp",
            "LmJ1c2luZXNzLnNoYXJlZC5zZXJ2aWNlcy50cmFuc2FjdGlvbhpHanAudGFt",
            "YWdvdGNoaS5wcm90by5idXNpbmVzcy9zZXJ2aWNlL3RyYW5zYWN0aW9uL3Ry",
            "YW5zYWN0aW9uTW9kZWwucHJvdG8ibgoWU2F2ZVRyYW5zYWN0aW9uUmVxdWVz",
            "dBJUCgt0cmFuc2FjdGlvbhgBIAEoCzI/LmpwLnRhbWFnb3RjaGkuYnVzaW5l",
            "c3Muc2hhcmVkLnNlcnZpY2VzLnRyYW5zYWN0aW9uLlRyYW5zYWN0aW9uIpMB",
            "ChdTYXZlVHJhbnNhY3Rpb25SZXNwb25zZRIRCglzdWNlc3NmdWwYASABKAgS",
            "DwoHbWVzc2FnZRgCIAEoCRJUCgt0cmFuc2FjdGlvbhgDIAEoCzI/LmpwLnRh",
            "bWFnb3RjaGkuYnVzaW5lc3Muc2hhcmVkLnNlcnZpY2VzLnRyYW5zYWN0aW9u",
            "LlRyYW5zYWN0aW9uIngKFkdldFRyYW5zYWN0aW9uc1JlcXVlc3QSDAoEc2l6",
            "ZRgBIAEoBRJQCgdleGFtcGxlGAIgASgLMj8uanAudGFtYWdvdGNoaS5idXNp",
            "bmVzcy5zaGFyZWQuc2VydmljZXMudHJhbnNhY3Rpb24uVHJhbnNhY3Rpb24i",
            "ggEKF0dldFRyYW5zYWN0aW9uc1Jlc3BvbnNlEhEKCXN1Y2Vzc2Z1bBgBIAEo",
            "CBJUCgt0cmFuc2FjdGlvbhgCIAMoCzI/LmpwLnRhbWFnb3RjaGkuYnVzaW5l",
            "c3Muc2hhcmVkLnNlcnZpY2VzLnRyYW5zYWN0aW9uLlRyYW5zYWN0aW9uMu4C",
            "ChJUcmFuc2FjdGlvblNlcnZpY2USqgEKD1NhdmVUcmFuc2FjdGlvbhJKLmpw",
            "LnRhbWFnb3RjaGkuYnVzaW5lc3Muc2hhcmVkLnNlcnZpY2VzLnRyYW5zYWN0",
            "aW9uLlNhdmVUcmFuc2FjdGlvblJlcXVlc3QaSy5qcC50YW1hZ290Y2hpLmJ1",
            "c2luZXNzLnNoYXJlZC5zZXJ2aWNlcy50cmFuc2FjdGlvbi5TYXZlVHJhbnNh",
            "Y3Rpb25SZXNwb25zZRKqAQoPR2V0VHJhbnNhY3Rpb25zEkouanAudGFtYWdv",
            "dGNoaS5idXNpbmVzcy5zaGFyZWQuc2VydmljZXMudHJhbnNhY3Rpb24uR2V0",
            "VHJhbnNhY3Rpb25zUmVxdWVzdBpLLmpwLnRhbWFnb3RjaGkuYnVzaW5lc3Mu",
            "c2hhcmVkLnNlcnZpY2VzLnRyYW5zYWN0aW9uLkdldFRyYW5zYWN0aW9uc1Jl",
            "c3BvbnNlQjQKMmpwLnRhbWFnb3RjaGkuYnVzaW5lc3Muc2hhcmVkLnNlcnZp",
            "Y2VzLnRyYW5zYWN0aW9uYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Jp.Tamagotchi.Business.Shared.Services.Transaction.TransactionModelReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Jp.Tamagotchi.Business.Shared.Services.Transaction.SaveTransactionRequest), global::Jp.Tamagotchi.Business.Shared.Services.Transaction.SaveTransactionRequest.Parser, new[]{ "Transaction" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Jp.Tamagotchi.Business.Shared.Services.Transaction.SaveTransactionResponse), global::Jp.Tamagotchi.Business.Shared.Services.Transaction.SaveTransactionResponse.Parser, new[]{ "Sucessful", "Message", "Transaction" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Jp.Tamagotchi.Business.Shared.Services.Transaction.GetTransactionsRequest), global::Jp.Tamagotchi.Business.Shared.Services.Transaction.GetTransactionsRequest.Parser, new[]{ "Size", "Example" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Jp.Tamagotchi.Business.Shared.Services.Transaction.GetTransactionsResponse), global::Jp.Tamagotchi.Business.Shared.Services.Transaction.GetTransactionsResponse.Parser, new[]{ "Sucessful", "Transaction" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SaveTransactionRequest : pb::IMessage<SaveTransactionRequest> {
    private static readonly pb::MessageParser<SaveTransactionRequest> _parser = new pb::MessageParser<SaveTransactionRequest>(() => new SaveTransactionRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SaveTransactionRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Jp.Tamagotchi.Business.Shared.Services.Transaction.TransactionServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SaveTransactionRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SaveTransactionRequest(SaveTransactionRequest other) : this() {
      Transaction = other.transaction_ != null ? other.Transaction.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SaveTransactionRequest Clone() {
      return new SaveTransactionRequest(this);
    }

    /// <summary>Field number for the "transaction" field.</summary>
    public const int TransactionFieldNumber = 1;
    private global::Jp.Tamagotchi.Business.Shared.Services.Transaction.Transaction transaction_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Jp.Tamagotchi.Business.Shared.Services.Transaction.Transaction Transaction {
      get { return transaction_; }
      set {
        transaction_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SaveTransactionRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SaveTransactionRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Transaction, other.Transaction)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (transaction_ != null) hash ^= Transaction.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (transaction_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Transaction);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (transaction_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Transaction);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SaveTransactionRequest other) {
      if (other == null) {
        return;
      }
      if (other.transaction_ != null) {
        if (transaction_ == null) {
          transaction_ = new global::Jp.Tamagotchi.Business.Shared.Services.Transaction.Transaction();
        }
        Transaction.MergeFrom(other.Transaction);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (transaction_ == null) {
              transaction_ = new global::Jp.Tamagotchi.Business.Shared.Services.Transaction.Transaction();
            }
            input.ReadMessage(transaction_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class SaveTransactionResponse : pb::IMessage<SaveTransactionResponse> {
    private static readonly pb::MessageParser<SaveTransactionResponse> _parser = new pb::MessageParser<SaveTransactionResponse>(() => new SaveTransactionResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SaveTransactionResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Jp.Tamagotchi.Business.Shared.Services.Transaction.TransactionServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SaveTransactionResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SaveTransactionResponse(SaveTransactionResponse other) : this() {
      sucessful_ = other.sucessful_;
      message_ = other.message_;
      Transaction = other.transaction_ != null ? other.Transaction.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SaveTransactionResponse Clone() {
      return new SaveTransactionResponse(this);
    }

    /// <summary>Field number for the "sucessful" field.</summary>
    public const int SucessfulFieldNumber = 1;
    private bool sucessful_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Sucessful {
      get { return sucessful_; }
      set {
        sucessful_ = value;
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 2;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "transaction" field.</summary>
    public const int TransactionFieldNumber = 3;
    private global::Jp.Tamagotchi.Business.Shared.Services.Transaction.Transaction transaction_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Jp.Tamagotchi.Business.Shared.Services.Transaction.Transaction Transaction {
      get { return transaction_; }
      set {
        transaction_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SaveTransactionResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SaveTransactionResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Sucessful != other.Sucessful) return false;
      if (Message != other.Message) return false;
      if (!object.Equals(Transaction, other.Transaction)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Sucessful != false) hash ^= Sucessful.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (transaction_ != null) hash ^= Transaction.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Sucessful != false) {
        output.WriteRawTag(8);
        output.WriteBool(Sucessful);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
      if (transaction_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Transaction);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Sucessful != false) {
        size += 1 + 1;
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (transaction_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Transaction);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SaveTransactionResponse other) {
      if (other == null) {
        return;
      }
      if (other.Sucessful != false) {
        Sucessful = other.Sucessful;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.transaction_ != null) {
        if (transaction_ == null) {
          transaction_ = new global::Jp.Tamagotchi.Business.Shared.Services.Transaction.Transaction();
        }
        Transaction.MergeFrom(other.Transaction);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Sucessful = input.ReadBool();
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
          case 26: {
            if (transaction_ == null) {
              transaction_ = new global::Jp.Tamagotchi.Business.Shared.Services.Transaction.Transaction();
            }
            input.ReadMessage(transaction_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetTransactionsRequest : pb::IMessage<GetTransactionsRequest> {
    private static readonly pb::MessageParser<GetTransactionsRequest> _parser = new pb::MessageParser<GetTransactionsRequest>(() => new GetTransactionsRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetTransactionsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Jp.Tamagotchi.Business.Shared.Services.Transaction.TransactionServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetTransactionsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetTransactionsRequest(GetTransactionsRequest other) : this() {
      size_ = other.size_;
      Example = other.example_ != null ? other.Example.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetTransactionsRequest Clone() {
      return new GetTransactionsRequest(this);
    }

    /// <summary>Field number for the "size" field.</summary>
    public const int SizeFieldNumber = 1;
    private int size_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Size {
      get { return size_; }
      set {
        size_ = value;
      }
    }

    /// <summary>Field number for the "example" field.</summary>
    public const int ExampleFieldNumber = 2;
    private global::Jp.Tamagotchi.Business.Shared.Services.Transaction.Transaction example_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Jp.Tamagotchi.Business.Shared.Services.Transaction.Transaction Example {
      get { return example_; }
      set {
        example_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetTransactionsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetTransactionsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Size != other.Size) return false;
      if (!object.Equals(Example, other.Example)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Size != 0) hash ^= Size.GetHashCode();
      if (example_ != null) hash ^= Example.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Size != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Size);
      }
      if (example_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Example);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Size != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Size);
      }
      if (example_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Example);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetTransactionsRequest other) {
      if (other == null) {
        return;
      }
      if (other.Size != 0) {
        Size = other.Size;
      }
      if (other.example_ != null) {
        if (example_ == null) {
          example_ = new global::Jp.Tamagotchi.Business.Shared.Services.Transaction.Transaction();
        }
        Example.MergeFrom(other.Example);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Size = input.ReadInt32();
            break;
          }
          case 18: {
            if (example_ == null) {
              example_ = new global::Jp.Tamagotchi.Business.Shared.Services.Transaction.Transaction();
            }
            input.ReadMessage(example_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetTransactionsResponse : pb::IMessage<GetTransactionsResponse> {
    private static readonly pb::MessageParser<GetTransactionsResponse> _parser = new pb::MessageParser<GetTransactionsResponse>(() => new GetTransactionsResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetTransactionsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Jp.Tamagotchi.Business.Shared.Services.Transaction.TransactionServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetTransactionsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetTransactionsResponse(GetTransactionsResponse other) : this() {
      sucessful_ = other.sucessful_;
      transaction_ = other.transaction_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetTransactionsResponse Clone() {
      return new GetTransactionsResponse(this);
    }

    /// <summary>Field number for the "sucessful" field.</summary>
    public const int SucessfulFieldNumber = 1;
    private bool sucessful_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Sucessful {
      get { return sucessful_; }
      set {
        sucessful_ = value;
      }
    }

    /// <summary>Field number for the "transaction" field.</summary>
    public const int TransactionFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Jp.Tamagotchi.Business.Shared.Services.Transaction.Transaction> _repeated_transaction_codec
        = pb::FieldCodec.ForMessage(18, global::Jp.Tamagotchi.Business.Shared.Services.Transaction.Transaction.Parser);
    private readonly pbc::RepeatedField<global::Jp.Tamagotchi.Business.Shared.Services.Transaction.Transaction> transaction_ = new pbc::RepeatedField<global::Jp.Tamagotchi.Business.Shared.Services.Transaction.Transaction>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Jp.Tamagotchi.Business.Shared.Services.Transaction.Transaction> Transaction {
      get { return transaction_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetTransactionsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetTransactionsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Sucessful != other.Sucessful) return false;
      if(!transaction_.Equals(other.transaction_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Sucessful != false) hash ^= Sucessful.GetHashCode();
      hash ^= transaction_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Sucessful != false) {
        output.WriteRawTag(8);
        output.WriteBool(Sucessful);
      }
      transaction_.WriteTo(output, _repeated_transaction_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Sucessful != false) {
        size += 1 + 1;
      }
      size += transaction_.CalculateSize(_repeated_transaction_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetTransactionsResponse other) {
      if (other == null) {
        return;
      }
      if (other.Sucessful != false) {
        Sucessful = other.Sucessful;
      }
      transaction_.Add(other.transaction_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Sucessful = input.ReadBool();
            break;
          }
          case 18: {
            transaction_.AddEntriesFrom(input, _repeated_transaction_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
