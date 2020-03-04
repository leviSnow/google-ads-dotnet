// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/resources/label.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/resources/label.proto</summary>
  public static partial class LabelReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/resources/label.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LabelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1nb29nbGUvYWRzL2dvb2dsZWFkcy92My9yZXNvdXJjZXMvbGFiZWwucHJv",
            "dG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLnJlc291cmNlcxovZ29vZ2xl",
            "L2Fkcy9nb29nbGVhZHMvdjMvY29tbW9uL3RleHRfbGFiZWwucHJvdG8aMGdv",
            "b2dsZS9hZHMvZ29vZ2xlYWRzL3YzL2VudW1zL2xhYmVsX3N0YXR1cy5wcm90",
            "bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2Fw",
            "aS9yZXNvdXJjZS5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBwZXJzLnBy",
            "b3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIvoCCgVMYWJlbBI9",
            "Cg1yZXNvdXJjZV9uYW1lGAEgASgJQibgQQX6QSAKHmdvb2dsZWFkcy5nb29n",
            "bGVhcGlzLmNvbS9MYWJlbBIsCgJpZBgCIAEoCzIbLmdvb2dsZS5wcm90b2J1",
            "Zi5JbnQ2NFZhbHVlQgPgQQMSKgoEbmFtZRgDIAEoCzIcLmdvb2dsZS5wcm90",
            "b2J1Zi5TdHJpbmdWYWx1ZRJPCgZzdGF0dXMYBCABKA4yOi5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52My5lbnVtcy5MYWJlbFN0YXR1c0VudW0uTGFiZWxTdGF0",
            "dXNCA+BBAxI9Cgp0ZXh0X2xhYmVsGAUgASgLMikuZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjMuY29tbW9uLlRleHRMYWJlbDpI6kFFCh5nb29nbGVhZHMuZ29v",
            "Z2xlYXBpcy5jb20vTGFiZWwSI2N1c3RvbWVycy97Y3VzdG9tZXJ9L2xhYmVs",
            "cy97bGFiZWx9QvcBCiVjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMucmVz",
            "b3VyY2VzQgpMYWJlbFByb3RvUAFaSmdvb2dsZS5nb2xhbmcub3JnL2dlbnBy",
            "b3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92My9yZXNvdXJjZXM7cmVz",
            "b3VyY2VzogIDR0FBqgIhR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjMuUmVzb3Vy",
            "Y2VzygIhR29vZ2xlXEFkc1xHb29nbGVBZHNcVjNcUmVzb3VyY2Vz6gIlR29v",
            "Z2xlOjpBZHM6Okdvb2dsZUFkczo6VjM6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V3.Common.TextLabelReflection.Descriptor, global::Google.Ads.GoogleAds.V3.Enums.LabelStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Resources.Label), global::Google.Ads.GoogleAds.V3.Resources.Label.Parser, new[]{ "ResourceName", "Id", "Name", "Status", "TextLabel" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A label.
  /// </summary>
  public sealed partial class Label : pb::IMessage<Label> {
    private static readonly pb::MessageParser<Label> _parser = new pb::MessageParser<Label>(() => new Label());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Label> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Resources.LabelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Label() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Label(Label other) : this() {
      resourceName_ = other.resourceName_;
      Id = other.Id;
      Name = other.Name;
      status_ = other.status_;
      textLabel_ = other.textLabel_ != null ? other.textLabel_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Label Clone() {
      return new Label(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. Name of the resource.
    /// Label resource names have the form:
    /// `customers/{customer_id}/labels/{label_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private static readonly pb::FieldCodec<long?> _single_id_codec = pb::FieldCodec.ForStructWrapper<long>(18);
    private long? id_;
    /// <summary>
    /// Output only. Id of the label. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }


    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_name_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string name_;
    /// <summary>
    /// The name of the label.
    ///
    /// This field is required and should not be empty when creating a new label.
    ///
    /// The length of this string should be between 1 and 80, inclusive.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = value;
      }
    }


    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V3.Enums.LabelStatusEnum.Types.LabelStatus status_ = 0;
    /// <summary>
    /// Output only. Status of the label. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Enums.LabelStatusEnum.Types.LabelStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "text_label" field.</summary>
    public const int TextLabelFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V3.Common.TextLabel textLabel_;
    /// <summary>
    /// A type of label displaying text on a colored background.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Common.TextLabel TextLabel {
      get { return textLabel_; }
      set {
        textLabel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Label);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Label other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (Status != other.Status) return false;
      if (!object.Equals(TextLabel, other.TextLabel)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (id_ != null) hash ^= Id.GetHashCode();
      if (name_ != null) hash ^= Name.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
      if (textLabel_ != null) hash ^= TextLabel.GetHashCode();
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
      if (id_ != null) {
        _single_id_codec.WriteTagAndValue(output, Id);
      }
      if (name_ != null) {
        _single_name_codec.WriteTagAndValue(output, Name);
      }
      if (Status != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
      }
      if (textLabel_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(TextLabel);
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
      if (id_ != null) {
        size += _single_id_codec.CalculateSizeWithTag(Id);
      }
      if (name_ != null) {
        size += _single_name_codec.CalculateSizeWithTag(Name);
      }
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (textLabel_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TextLabel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Label other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.id_ != null) {
        if (id_ == null || other.Id != 0L) {
          Id = other.Id;
        }
      }
      if (other.name_ != null) {
        if (name_ == null || other.Name != "") {
          Name = other.Name;
        }
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.textLabel_ != null) {
        if (textLabel_ == null) {
          TextLabel = new global::Google.Ads.GoogleAds.V3.Common.TextLabel();
        }
        TextLabel.MergeFrom(other.TextLabel);
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
          case 18: {
            long? value = _single_id_codec.Read(input);
            if (id_ == null || value != 0L) {
              Id = value;
            }
            break;
          }
          case 26: {
            string value = _single_name_codec.Read(input);
            if (name_ == null || value != "") {
              Name = value;
            }
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V3.Enums.LabelStatusEnum.Types.LabelStatus) input.ReadEnum();
            break;
          }
          case 42: {
            if (textLabel_ == null) {
              TextLabel = new global::Google.Ads.GoogleAds.V3.Common.TextLabel();
            }
            input.ReadMessage(TextLabel);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
