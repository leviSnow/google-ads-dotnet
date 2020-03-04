// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/errors/operator_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/errors/operator_error.proto</summary>
  public static partial class OperatorErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/errors/operator_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OperatorErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92My9lcnJvcnMvb3BlcmF0b3JfZXJy",
            "b3IucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLmVycm9ycxocZ29v",
            "Z2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byJeChFPcGVyYXRvckVycm9yRW51",
            "bSJJCg1PcGVyYXRvckVycm9yEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9X",
            "ThABEhoKFk9QRVJBVE9SX05PVF9TVVBQT1JURUQQAkLtAQoiY29tLmdvb2ds",
            "ZS5hZHMuZ29vZ2xlYWRzLnYzLmVycm9yc0IST3BlcmF0b3JFcnJvclByb3Rv",
            "UAFaRGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRz",
            "L2dvb2dsZWFkcy92My9lcnJvcnM7ZXJyb3JzogIDR0FBqgIeR29vZ2xlLkFk",
            "cy5Hb29nbGVBZHMuVjMuRXJyb3JzygIeR29vZ2xlXEFkc1xHb29nbGVBZHNc",
            "VjNcRXJyb3Jz6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjM6OkVycm9y",
            "c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Errors.OperatorErrorEnum), global::Google.Ads.GoogleAds.V3.Errors.OperatorErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Errors.OperatorErrorEnum.Types.OperatorError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible operator errors.
  /// </summary>
  public sealed partial class OperatorErrorEnum : pb::IMessage<OperatorErrorEnum> {
    private static readonly pb::MessageParser<OperatorErrorEnum> _parser = new pb::MessageParser<OperatorErrorEnum>(() => new OperatorErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OperatorErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Errors.OperatorErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OperatorErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OperatorErrorEnum(OperatorErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OperatorErrorEnum Clone() {
      return new OperatorErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OperatorErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OperatorErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OperatorErrorEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the OperatorErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible operator errors.
      /// </summary>
      public enum OperatorError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Operator not supported.
        /// </summary>
        [pbr::OriginalName("OPERATOR_NOT_SUPPORTED")] OperatorNotSupported = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
