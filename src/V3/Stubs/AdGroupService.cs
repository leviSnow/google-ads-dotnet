// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/services/ad_group_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/services/ad_group_service.proto</summary>
  public static partial class AdGroupServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/services/ad_group_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92My9zZXJ2aWNlcy9hZF9ncm91cF9z",
            "ZXJ2aWNlLnByb3RvEiBnb29nbGUuYWRzLmdvb2dsZWFkcy52My5zZXJ2aWNl",
            "cxowZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjMvcmVzb3VyY2VzL2FkX2dyb3Vw",
            "LnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvGhdnb29nbGUv",
            "YXBpL2NsaWVudC5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5w",
            "cm90bxogZ29vZ2xlL3Byb3RvYnVmL2ZpZWxkX21hc2sucHJvdG8aF2dvb2ds",
            "ZS9ycGMvc3RhdHVzLnByb3RvIi8KEUdldEFkR3JvdXBSZXF1ZXN0EhoKDXJl",
            "c291cmNlX25hbWUYASABKAlCA+BBAiKuAQoVTXV0YXRlQWRHcm91cHNSZXF1",
            "ZXN0EhgKC2N1c3RvbWVyX2lkGAEgASgJQgPgQQISSwoKb3BlcmF0aW9ucxgC",
            "IAMoCzIyLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLnNlcnZpY2VzLkFkR3Jv",
            "dXBPcGVyYXRpb25CA+BBAhIXCg9wYXJ0aWFsX2ZhaWx1cmUYAyABKAgSFQoN",
            "dmFsaWRhdGVfb25seRgEIAEoCCLeAQoQQWRHcm91cE9wZXJhdGlvbhIvCgt1",
            "cGRhdGVfbWFzaxgEIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5GaWVsZE1hc2sS",
            "PAoGY3JlYXRlGAEgASgLMiouZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMucmVz",
            "b3VyY2VzLkFkR3JvdXBIABI8CgZ1cGRhdGUYAiABKAsyKi5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52My5yZXNvdXJjZXMuQWRHcm91cEgAEhAKBnJlbW92ZRgD",
            "IAEoCUgAQgsKCW9wZXJhdGlvbiKTAQoWTXV0YXRlQWRHcm91cHNSZXNwb25z",
            "ZRIxChVwYXJ0aWFsX2ZhaWx1cmVfZXJyb3IYAyABKAsyEi5nb29nbGUucnBj",
            "LlN0YXR1cxJGCgdyZXN1bHRzGAIgAygLMjUuZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjMuc2VydmljZXMuTXV0YXRlQWRHcm91cFJlc3VsdCIsChNNdXRhdGVB",
            "ZEdyb3VwUmVzdWx0EhUKDXJlc291cmNlX25hbWUYASABKAkyugMKDkFkR3Jv",
            "dXBTZXJ2aWNlErEBCgpHZXRBZEdyb3VwEjMuZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjMuc2VydmljZXMuR2V0QWRHcm91cFJlcXVlc3QaKi5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52My5yZXNvdXJjZXMuQWRHcm91cCJCgtPkkwIsEiovdjMv",
            "e3Jlc291cmNlX25hbWU9Y3VzdG9tZXJzLyovYWRHcm91cHMvKn3aQQ1yZXNv",
            "dXJjZV9uYW1lEtYBCg5NdXRhdGVBZEdyb3VwcxI3Lmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnYzLnNlcnZpY2VzLk11dGF0ZUFkR3JvdXBzUmVxdWVzdBo4Lmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnYzLnNlcnZpY2VzLk11dGF0ZUFkR3JvdXBz",
            "UmVzcG9uc2UiUYLT5JMCMiItL3YzL2N1c3RvbWVycy97Y3VzdG9tZXJfaWQ9",
            "Kn0vYWRHcm91cHM6bXV0YXRlOgEq2kEWY3VzdG9tZXJfaWQsb3BlcmF0aW9u",
            "cxobykEYZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tQvoBCiRjb20uZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjMuc2VydmljZXNCE0FkR3JvdXBTZXJ2aWNlUHJv",
            "dG9QAVpIZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9h",
            "ZHMvZ29vZ2xlYWRzL3YzL3NlcnZpY2VzO3NlcnZpY2VzogIDR0FBqgIgR29v",
            "Z2xlLkFkcy5Hb29nbGVBZHMuVjMuU2VydmljZXPKAiBHb29nbGVcQWRzXEdv",
            "b2dsZUFkc1xWM1xTZXJ2aWNlc+oCJEdvb2dsZTo6QWRzOjpHb29nbGVBZHM6",
            "OlYzOjpTZXJ2aWNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V3.Resources.AdGroupReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.FieldMaskReflection.Descriptor, global::Google.Rpc.StatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Services.GetAdGroupRequest), global::Google.Ads.GoogleAds.V3.Services.GetAdGroupRequest.Parser, new[]{ "ResourceName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupsRequest), global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupsRequest.Parser, new[]{ "CustomerId", "Operations", "PartialFailure", "ValidateOnly" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Services.AdGroupOperation), global::Google.Ads.GoogleAds.V3.Services.AdGroupOperation.Parser, new[]{ "UpdateMask", "Create", "Update", "Remove" }, new[]{ "Operation" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupsResponse), global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupsResponse.Parser, new[]{ "PartialFailureError", "Results" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupResult), global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupResult.Parser, new[]{ "ResourceName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [AdGroupService.GetAdGroup][google.ads.googleads.v3.services.AdGroupService.GetAdGroup].
  /// </summary>
  public sealed partial class GetAdGroupRequest : pb::IMessage<GetAdGroupRequest> {
    private static readonly pb::MessageParser<GetAdGroupRequest> _parser = new pb::MessageParser<GetAdGroupRequest>(() => new GetAdGroupRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetAdGroupRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Services.AdGroupServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAdGroupRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAdGroupRequest(GetAdGroupRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAdGroupRequest Clone() {
      return new GetAdGroupRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. The resource name of the ad group to fetch.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetAdGroupRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetAdGroupRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetAdGroupRequest other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Request message for [AdGroupService.MutateAdGroups][google.ads.googleads.v3.services.AdGroupService.MutateAdGroups].
  /// </summary>
  public sealed partial class MutateAdGroupsRequest : pb::IMessage<MutateAdGroupsRequest> {
    private static readonly pb::MessageParser<MutateAdGroupsRequest> _parser = new pb::MessageParser<MutateAdGroupsRequest>(() => new MutateAdGroupsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateAdGroupsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Services.AdGroupServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAdGroupsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAdGroupsRequest(MutateAdGroupsRequest other) : this() {
      customerId_ = other.customerId_;
      operations_ = other.operations_.Clone();
      partialFailure_ = other.partialFailure_;
      validateOnly_ = other.validateOnly_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAdGroupsRequest Clone() {
      return new MutateAdGroupsRequest(this);
    }

    /// <summary>Field number for the "customer_id" field.</summary>
    public const int CustomerIdFieldNumber = 1;
    private string customerId_ = "";
    /// <summary>
    /// Required. The ID of the customer whose ad groups are being modified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CustomerId {
      get { return customerId_; }
      set {
        customerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "operations" field.</summary>
    public const int OperationsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V3.Services.AdGroupOperation> _repeated_operations_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Ads.GoogleAds.V3.Services.AdGroupOperation.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V3.Services.AdGroupOperation> operations_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V3.Services.AdGroupOperation>();
    /// <summary>
    /// Required. The list of operations to perform on individual ad groups.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V3.Services.AdGroupOperation> Operations {
      get { return operations_; }
    }

    /// <summary>Field number for the "partial_failure" field.</summary>
    public const int PartialFailureFieldNumber = 3;
    private bool partialFailure_;
    /// <summary>
    /// If true, successful operations will be carried out and invalid
    /// operations will return errors. If false, all operations will be carried
    /// out in one transaction if and only if they are all valid.
    /// Default is false.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool PartialFailure {
      get { return partialFailure_; }
      set {
        partialFailure_ = value;
      }
    }

    /// <summary>Field number for the "validate_only" field.</summary>
    public const int ValidateOnlyFieldNumber = 4;
    private bool validateOnly_;
    /// <summary>
    /// If true, the request is validated but not executed. Only errors are
    /// returned, not results.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ValidateOnly {
      get { return validateOnly_; }
      set {
        validateOnly_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MutateAdGroupsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateAdGroupsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CustomerId != other.CustomerId) return false;
      if(!operations_.Equals(other.operations_)) return false;
      if (PartialFailure != other.PartialFailure) return false;
      if (ValidateOnly != other.ValidateOnly) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CustomerId.Length != 0) hash ^= CustomerId.GetHashCode();
      hash ^= operations_.GetHashCode();
      if (PartialFailure != false) hash ^= PartialFailure.GetHashCode();
      if (ValidateOnly != false) hash ^= ValidateOnly.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (CustomerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CustomerId);
      }
      operations_.WriteTo(output, _repeated_operations_codec);
      if (PartialFailure != false) {
        output.WriteRawTag(24);
        output.WriteBool(PartialFailure);
      }
      if (ValidateOnly != false) {
        output.WriteRawTag(32);
        output.WriteBool(ValidateOnly);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CustomerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomerId);
      }
      size += operations_.CalculateSize(_repeated_operations_codec);
      if (PartialFailure != false) {
        size += 1 + 1;
      }
      if (ValidateOnly != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MutateAdGroupsRequest other) {
      if (other == null) {
        return;
      }
      if (other.CustomerId.Length != 0) {
        CustomerId = other.CustomerId;
      }
      operations_.Add(other.operations_);
      if (other.PartialFailure != false) {
        PartialFailure = other.PartialFailure;
      }
      if (other.ValidateOnly != false) {
        ValidateOnly = other.ValidateOnly;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            CustomerId = input.ReadString();
            break;
          }
          case 18: {
            operations_.AddEntriesFrom(input, _repeated_operations_codec);
            break;
          }
          case 24: {
            PartialFailure = input.ReadBool();
            break;
          }
          case 32: {
            ValidateOnly = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A single operation (create, update, remove) on an ad group.
  /// </summary>
  public sealed partial class AdGroupOperation : pb::IMessage<AdGroupOperation> {
    private static readonly pb::MessageParser<AdGroupOperation> _parser = new pb::MessageParser<AdGroupOperation>(() => new AdGroupOperation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdGroupOperation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Services.AdGroupServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupOperation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupOperation(AdGroupOperation other) : this() {
      updateMask_ = other.updateMask_ != null ? other.updateMask_.Clone() : null;
      switch (other.OperationCase) {
        case OperationOneofCase.Create:
          Create = other.Create.Clone();
          break;
        case OperationOneofCase.Update:
          Update = other.Update.Clone();
          break;
        case OperationOneofCase.Remove:
          Remove = other.Remove;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupOperation Clone() {
      return new AdGroupOperation(this);
    }

    /// <summary>Field number for the "update_mask" field.</summary>
    public const int UpdateMaskFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.FieldMask updateMask_;
    /// <summary>
    /// FieldMask that determines which resource fields are modified in an update.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.FieldMask UpdateMask {
      get { return updateMask_; }
      set {
        updateMask_ = value;
      }
    }

    /// <summary>Field number for the "create" field.</summary>
    public const int CreateFieldNumber = 1;
    /// <summary>
    /// Create operation: No resource name is expected for the new ad group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Resources.AdGroup Create {
      get { return operationCase_ == OperationOneofCase.Create ? (global::Google.Ads.GoogleAds.V3.Resources.AdGroup) operation_ : null; }
      set {
        operation_ = value;
        operationCase_ = value == null ? OperationOneofCase.None : OperationOneofCase.Create;
      }
    }

    /// <summary>Field number for the "update" field.</summary>
    public const int UpdateFieldNumber = 2;
    /// <summary>
    /// Update operation: The ad group is expected to have a valid resource name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Resources.AdGroup Update {
      get { return operationCase_ == OperationOneofCase.Update ? (global::Google.Ads.GoogleAds.V3.Resources.AdGroup) operation_ : null; }
      set {
        operation_ = value;
        operationCase_ = value == null ? OperationOneofCase.None : OperationOneofCase.Update;
      }
    }

    /// <summary>Field number for the "remove" field.</summary>
    public const int RemoveFieldNumber = 3;
    /// <summary>
    /// Remove operation: A resource name for the removed ad group is expected,
    /// in this format:
    ///
    /// `customers/{customer_id}/adGroups/{ad_group_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Remove {
      get { return operationCase_ == OperationOneofCase.Remove ? (string) operation_ : ""; }
      set {
        operation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        operationCase_ = OperationOneofCase.Remove;
      }
    }

    private object operation_;
    /// <summary>Enum of possible cases for the "operation" oneof.</summary>
    public enum OperationOneofCase {
      None = 0,
      Create = 1,
      Update = 2,
      Remove = 3,
    }
    private OperationOneofCase operationCase_ = OperationOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OperationOneofCase OperationCase {
      get { return operationCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearOperation() {
      operationCase_ = OperationOneofCase.None;
      operation_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdGroupOperation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdGroupOperation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(UpdateMask, other.UpdateMask)) return false;
      if (!object.Equals(Create, other.Create)) return false;
      if (!object.Equals(Update, other.Update)) return false;
      if (Remove != other.Remove) return false;
      if (OperationCase != other.OperationCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (updateMask_ != null) hash ^= UpdateMask.GetHashCode();
      if (operationCase_ == OperationOneofCase.Create) hash ^= Create.GetHashCode();
      if (operationCase_ == OperationOneofCase.Update) hash ^= Update.GetHashCode();
      if (operationCase_ == OperationOneofCase.Remove) hash ^= Remove.GetHashCode();
      hash ^= (int) operationCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (operationCase_ == OperationOneofCase.Create) {
        output.WriteRawTag(10);
        output.WriteMessage(Create);
      }
      if (operationCase_ == OperationOneofCase.Update) {
        output.WriteRawTag(18);
        output.WriteMessage(Update);
      }
      if (operationCase_ == OperationOneofCase.Remove) {
        output.WriteRawTag(26);
        output.WriteString(Remove);
      }
      if (updateMask_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(UpdateMask);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (updateMask_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateMask);
      }
      if (operationCase_ == OperationOneofCase.Create) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Create);
      }
      if (operationCase_ == OperationOneofCase.Update) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Update);
      }
      if (operationCase_ == OperationOneofCase.Remove) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Remove);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdGroupOperation other) {
      if (other == null) {
        return;
      }
      if (other.updateMask_ != null) {
        if (updateMask_ == null) {
          UpdateMask = new global::Google.Protobuf.WellKnownTypes.FieldMask();
        }
        UpdateMask.MergeFrom(other.UpdateMask);
      }
      switch (other.OperationCase) {
        case OperationOneofCase.Create:
          if (Create == null) {
            Create = new global::Google.Ads.GoogleAds.V3.Resources.AdGroup();
          }
          Create.MergeFrom(other.Create);
          break;
        case OperationOneofCase.Update:
          if (Update == null) {
            Update = new global::Google.Ads.GoogleAds.V3.Resources.AdGroup();
          }
          Update.MergeFrom(other.Update);
          break;
        case OperationOneofCase.Remove:
          Remove = other.Remove;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            global::Google.Ads.GoogleAds.V3.Resources.AdGroup subBuilder = new global::Google.Ads.GoogleAds.V3.Resources.AdGroup();
            if (operationCase_ == OperationOneofCase.Create) {
              subBuilder.MergeFrom(Create);
            }
            input.ReadMessage(subBuilder);
            Create = subBuilder;
            break;
          }
          case 18: {
            global::Google.Ads.GoogleAds.V3.Resources.AdGroup subBuilder = new global::Google.Ads.GoogleAds.V3.Resources.AdGroup();
            if (operationCase_ == OperationOneofCase.Update) {
              subBuilder.MergeFrom(Update);
            }
            input.ReadMessage(subBuilder);
            Update = subBuilder;
            break;
          }
          case 26: {
            Remove = input.ReadString();
            break;
          }
          case 34: {
            if (updateMask_ == null) {
              UpdateMask = new global::Google.Protobuf.WellKnownTypes.FieldMask();
            }
            input.ReadMessage(UpdateMask);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Response message for an ad group mutate.
  /// </summary>
  public sealed partial class MutateAdGroupsResponse : pb::IMessage<MutateAdGroupsResponse> {
    private static readonly pb::MessageParser<MutateAdGroupsResponse> _parser = new pb::MessageParser<MutateAdGroupsResponse>(() => new MutateAdGroupsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateAdGroupsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Services.AdGroupServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAdGroupsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAdGroupsResponse(MutateAdGroupsResponse other) : this() {
      partialFailureError_ = other.partialFailureError_ != null ? other.partialFailureError_.Clone() : null;
      results_ = other.results_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAdGroupsResponse Clone() {
      return new MutateAdGroupsResponse(this);
    }

    /// <summary>Field number for the "partial_failure_error" field.</summary>
    public const int PartialFailureErrorFieldNumber = 3;
    private global::Google.Rpc.Status partialFailureError_;
    /// <summary>
    /// Errors that pertain to operation failures in the partial failure mode.
    /// Returned only when partial_failure = true and all errors occur inside the
    /// operations. If any errors occur outside the operations (e.g. auth errors),
    /// we return an RPC level error.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Rpc.Status PartialFailureError {
      get { return partialFailureError_; }
      set {
        partialFailureError_ = value;
      }
    }

    /// <summary>Field number for the "results" field.</summary>
    public const int ResultsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupResult> _repeated_results_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupResult.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupResult> results_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupResult>();
    /// <summary>
    /// All results for the mutate.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupResult> Results {
      get { return results_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MutateAdGroupsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateAdGroupsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PartialFailureError, other.PartialFailureError)) return false;
      if(!results_.Equals(other.results_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (partialFailureError_ != null) hash ^= PartialFailureError.GetHashCode();
      hash ^= results_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      results_.WriteTo(output, _repeated_results_codec);
      if (partialFailureError_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PartialFailureError);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (partialFailureError_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PartialFailureError);
      }
      size += results_.CalculateSize(_repeated_results_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MutateAdGroupsResponse other) {
      if (other == null) {
        return;
      }
      if (other.partialFailureError_ != null) {
        if (partialFailureError_ == null) {
          PartialFailureError = new global::Google.Rpc.Status();
        }
        PartialFailureError.MergeFrom(other.PartialFailureError);
      }
      results_.Add(other.results_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 18: {
            results_.AddEntriesFrom(input, _repeated_results_codec);
            break;
          }
          case 26: {
            if (partialFailureError_ == null) {
              PartialFailureError = new global::Google.Rpc.Status();
            }
            input.ReadMessage(PartialFailureError);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The result for the ad group mutate.
  /// </summary>
  public sealed partial class MutateAdGroupResult : pb::IMessage<MutateAdGroupResult> {
    private static readonly pb::MessageParser<MutateAdGroupResult> _parser = new pb::MessageParser<MutateAdGroupResult>(() => new MutateAdGroupResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateAdGroupResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Services.AdGroupServiceReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAdGroupResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAdGroupResult(MutateAdGroupResult other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAdGroupResult Clone() {
      return new MutateAdGroupResult(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Returned for successful operations.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MutateAdGroupResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateAdGroupResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MutateAdGroupResult other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
