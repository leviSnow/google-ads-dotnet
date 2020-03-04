// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/enums/display_ad_format_setting.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/enums/display_ad_format_setting.proto</summary>
  public static partial class DisplayAdFormatSettingReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/enums/display_ad_format_setting.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DisplayAdFormatSettingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy9kaXNwbGF5X2FkX2Zv",
            "cm1hdF9zZXR0aW5nLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52My5l",
            "bnVtcxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byKBAQoaRGlzcGxh",
            "eUFkRm9ybWF0U2V0dGluZ0VudW0iYwoWRGlzcGxheUFkRm9ybWF0U2V0dGlu",
            "ZxIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIPCgtBTExfRk9STUFU",
            "UxACEg4KCk5PTl9OQVRJVkUQAxIKCgZOQVRJVkUQBELwAQohY29tLmdvb2ds",
            "ZS5hZHMuZ29vZ2xlYWRzLnYzLmVudW1zQhtEaXNwbGF5QWRGb3JtYXRTZXR0",
            "aW5nUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9hZHMvZ29vZ2xlYWRzL3YzL2VudW1zO2VudW1zogIDR0FBqgIdR29v",
            "Z2xlLkFkcy5Hb29nbGVBZHMuVjMuRW51bXPKAh1Hb29nbGVcQWRzXEdvb2ds",
            "ZUFkc1xWM1xFbnVtc+oCIUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYzOjpF",
            "bnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Enums.DisplayAdFormatSettingEnum), global::Google.Ads.GoogleAds.V3.Enums.DisplayAdFormatSettingEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Enums.DisplayAdFormatSettingEnum.Types.DisplayAdFormatSetting) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for display ad format settings.
  /// </summary>
  public sealed partial class DisplayAdFormatSettingEnum : pb::IMessage<DisplayAdFormatSettingEnum> {
    private static readonly pb::MessageParser<DisplayAdFormatSettingEnum> _parser = new pb::MessageParser<DisplayAdFormatSettingEnum>(() => new DisplayAdFormatSettingEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DisplayAdFormatSettingEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Enums.DisplayAdFormatSettingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DisplayAdFormatSettingEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DisplayAdFormatSettingEnum(DisplayAdFormatSettingEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DisplayAdFormatSettingEnum Clone() {
      return new DisplayAdFormatSettingEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DisplayAdFormatSettingEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DisplayAdFormatSettingEnum other) {
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
    public void MergeFrom(DisplayAdFormatSettingEnum other) {
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
    /// <summary>Container for nested types declared in the DisplayAdFormatSettingEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enumerates display ad format settings.
      /// </summary>
      public enum DisplayAdFormatSetting {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Text, image and native formats.
        /// </summary>
        [pbr::OriginalName("ALL_FORMATS")] AllFormats = 2,
        /// <summary>
        /// Text and image formats.
        /// </summary>
        [pbr::OriginalName("NON_NATIVE")] NonNative = 3,
        /// <summary>
        /// Native format, i.e. the format rendering is controlled by the publisher
        /// and not by Google.
        /// </summary>
        [pbr::OriginalName("NATIVE")] Native = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
