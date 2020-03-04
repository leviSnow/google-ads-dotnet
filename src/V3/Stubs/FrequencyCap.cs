// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/common/frequency_cap.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/common/frequency_cap.proto</summary>
  public static partial class FrequencyCapReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/common/frequency_cap.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FrequencyCapReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvYWRzL2dvb2dsZWFkcy92My9jb21tb24vZnJlcXVlbmN5X2Nh",
            "cC5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuY29tbW9uGjxnb29n",
            "bGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy9mcmVxdWVuY3lfY2FwX2V2ZW50",
            "X3R5cGUucHJvdG8aN2dvb2dsZS9hZHMvZ29vZ2xlYWRzL3YzL2VudW1zL2Zy",
            "ZXF1ZW5jeV9jYXBfbGV2ZWwucHJvdG8aO2dvb2dsZS9hZHMvZ29vZ2xlYWRz",
            "L3YzL2VudW1zL2ZyZXF1ZW5jeV9jYXBfdGltZV91bml0LnByb3RvGh5nb29n",
            "bGUvcHJvdG9idWYvd3JhcHBlcnMucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3Rh",
            "dGlvbnMucHJvdG8iewoRRnJlcXVlbmN5Q2FwRW50cnkSPAoDa2V5GAEgASgL",
            "Mi8uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuY29tbW9uLkZyZXF1ZW5jeUNh",
            "cEtleRIoCgNjYXAYAiABKAsyGy5nb29nbGUucHJvdG9idWYuSW50MzJWYWx1",
            "ZSLfAgoPRnJlcXVlbmN5Q2FwS2V5ElUKBWxldmVsGAEgASgOMkYuZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjMuZW51bXMuRnJlcXVlbmN5Q2FwTGV2ZWxFbnVt",
            "LkZyZXF1ZW5jeUNhcExldmVsEmIKCmV2ZW50X3R5cGUYAyABKA4yTi5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52My5lbnVtcy5GcmVxdWVuY3lDYXBFdmVudFR5",
            "cGVFbnVtLkZyZXF1ZW5jeUNhcEV2ZW50VHlwZRJfCgl0aW1lX3VuaXQYAiAB",
            "KA4yTC5nb29nbGUuYWRzLmdvb2dsZWFkcy52My5lbnVtcy5GcmVxdWVuY3lD",
            "YXBUaW1lVW5pdEVudW0uRnJlcXVlbmN5Q2FwVGltZVVuaXQSMAoLdGltZV9s",
            "ZW5ndGgYBCABKAsyGy5nb29nbGUucHJvdG9idWYuSW50MzJWYWx1ZULsAQoi",
            "Y29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLmNvbW1vbkIRRnJlcXVlbmN5",
            "Q2FwUHJvdG9QAVpEZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9hZHMvZ29vZ2xlYWRzL3YzL2NvbW1vbjtjb21tb26iAgNHQUGqAh5H",
            "b29nbGUuQWRzLkdvb2dsZUFkcy5WMy5Db21tb27KAh5Hb29nbGVcQWRzXEdv",
            "b2dsZUFkc1xWM1xDb21tb27qAiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpW",
            "Mzo6Q29tbW9uYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V3.Enums.FrequencyCapEventTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V3.Enums.FrequencyCapLevelReflection.Descriptor, global::Google.Ads.GoogleAds.V3.Enums.FrequencyCapTimeUnitReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Common.FrequencyCapEntry), global::Google.Ads.GoogleAds.V3.Common.FrequencyCapEntry.Parser, new[]{ "Key", "Cap" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Common.FrequencyCapKey), global::Google.Ads.GoogleAds.V3.Common.FrequencyCapKey.Parser, new[]{ "Level", "EventType", "TimeUnit", "TimeLength" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A rule specifying the maximum number of times an ad (or some set of ads) can
  /// be shown to a user over a particular time period.
  /// </summary>
  public sealed partial class FrequencyCapEntry : pb::IMessage<FrequencyCapEntry> {
    private static readonly pb::MessageParser<FrequencyCapEntry> _parser = new pb::MessageParser<FrequencyCapEntry>(() => new FrequencyCapEntry());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FrequencyCapEntry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Common.FrequencyCapReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrequencyCapEntry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrequencyCapEntry(FrequencyCapEntry other) : this() {
      key_ = other.key_ != null ? other.key_.Clone() : null;
      Cap = other.Cap;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrequencyCapEntry Clone() {
      return new FrequencyCapEntry(this);
    }

    /// <summary>Field number for the "key" field.</summary>
    public const int KeyFieldNumber = 1;
    private global::Google.Ads.GoogleAds.V3.Common.FrequencyCapKey key_;
    /// <summary>
    /// The key of a particular frequency cap. There can be no more
    /// than one frequency cap with the same key.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Common.FrequencyCapKey Key {
      get { return key_; }
      set {
        key_ = value;
      }
    }

    /// <summary>Field number for the "cap" field.</summary>
    public const int CapFieldNumber = 2;
    private static readonly pb::FieldCodec<int?> _single_cap_codec = pb::FieldCodec.ForStructWrapper<int>(18);
    private int? cap_;
    /// <summary>
    /// Maximum number of events allowed during the time range by this cap.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int? Cap {
      get { return cap_; }
      set {
        cap_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FrequencyCapEntry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FrequencyCapEntry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Key, other.Key)) return false;
      if (Cap != other.Cap) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (key_ != null) hash ^= Key.GetHashCode();
      if (cap_ != null) hash ^= Cap.GetHashCode();
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
      if (key_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Key);
      }
      if (cap_ != null) {
        _single_cap_codec.WriteTagAndValue(output, Cap);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (key_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Key);
      }
      if (cap_ != null) {
        size += _single_cap_codec.CalculateSizeWithTag(Cap);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FrequencyCapEntry other) {
      if (other == null) {
        return;
      }
      if (other.key_ != null) {
        if (key_ == null) {
          Key = new global::Google.Ads.GoogleAds.V3.Common.FrequencyCapKey();
        }
        Key.MergeFrom(other.Key);
      }
      if (other.cap_ != null) {
        if (cap_ == null || other.Cap != 0) {
          Cap = other.Cap;
        }
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
            if (key_ == null) {
              Key = new global::Google.Ads.GoogleAds.V3.Common.FrequencyCapKey();
            }
            input.ReadMessage(Key);
            break;
          }
          case 18: {
            int? value = _single_cap_codec.Read(input);
            if (cap_ == null || value != 0) {
              Cap = value;
            }
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A group of fields used as keys for a frequency cap.
  /// There can be no more than one frequency cap with the same key.
  /// </summary>
  public sealed partial class FrequencyCapKey : pb::IMessage<FrequencyCapKey> {
    private static readonly pb::MessageParser<FrequencyCapKey> _parser = new pb::MessageParser<FrequencyCapKey>(() => new FrequencyCapKey());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FrequencyCapKey> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Common.FrequencyCapReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrequencyCapKey() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrequencyCapKey(FrequencyCapKey other) : this() {
      level_ = other.level_;
      eventType_ = other.eventType_;
      timeUnit_ = other.timeUnit_;
      TimeLength = other.TimeLength;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FrequencyCapKey Clone() {
      return new FrequencyCapKey(this);
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 1;
    private global::Google.Ads.GoogleAds.V3.Enums.FrequencyCapLevelEnum.Types.FrequencyCapLevel level_ = 0;
    /// <summary>
    /// The level on which the cap is to be applied (e.g. ad group ad, ad group).
    /// The cap is applied to all the entities of this level.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Enums.FrequencyCapLevelEnum.Types.FrequencyCapLevel Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "event_type" field.</summary>
    public const int EventTypeFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V3.Enums.FrequencyCapEventTypeEnum.Types.FrequencyCapEventType eventType_ = 0;
    /// <summary>
    /// The type of event that the cap applies to (e.g. impression).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Enums.FrequencyCapEventTypeEnum.Types.FrequencyCapEventType EventType {
      get { return eventType_; }
      set {
        eventType_ = value;
      }
    }

    /// <summary>Field number for the "time_unit" field.</summary>
    public const int TimeUnitFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V3.Enums.FrequencyCapTimeUnitEnum.Types.FrequencyCapTimeUnit timeUnit_ = 0;
    /// <summary>
    /// Unit of time the cap is defined at (e.g. day, week).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Enums.FrequencyCapTimeUnitEnum.Types.FrequencyCapTimeUnit TimeUnit {
      get { return timeUnit_; }
      set {
        timeUnit_ = value;
      }
    }

    /// <summary>Field number for the "time_length" field.</summary>
    public const int TimeLengthFieldNumber = 4;
    private static readonly pb::FieldCodec<int?> _single_timeLength_codec = pb::FieldCodec.ForStructWrapper<int>(34);
    private int? timeLength_;
    /// <summary>
    /// Number of time units the cap lasts.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int? TimeLength {
      get { return timeLength_; }
      set {
        timeLength_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FrequencyCapKey);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FrequencyCapKey other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Level != other.Level) return false;
      if (EventType != other.EventType) return false;
      if (TimeUnit != other.TimeUnit) return false;
      if (TimeLength != other.TimeLength) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Level != 0) hash ^= Level.GetHashCode();
      if (EventType != 0) hash ^= EventType.GetHashCode();
      if (TimeUnit != 0) hash ^= TimeUnit.GetHashCode();
      if (timeLength_ != null) hash ^= TimeLength.GetHashCode();
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
      if (Level != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Level);
      }
      if (TimeUnit != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) TimeUnit);
      }
      if (EventType != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) EventType);
      }
      if (timeLength_ != null) {
        _single_timeLength_codec.WriteTagAndValue(output, TimeLength);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Level);
      }
      if (EventType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EventType);
      }
      if (TimeUnit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) TimeUnit);
      }
      if (timeLength_ != null) {
        size += _single_timeLength_codec.CalculateSizeWithTag(TimeLength);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FrequencyCapKey other) {
      if (other == null) {
        return;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.EventType != 0) {
        EventType = other.EventType;
      }
      if (other.TimeUnit != 0) {
        TimeUnit = other.TimeUnit;
      }
      if (other.timeLength_ != null) {
        if (timeLength_ == null || other.TimeLength != 0) {
          TimeLength = other.TimeLength;
        }
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
          case 8: {
            Level = (global::Google.Ads.GoogleAds.V3.Enums.FrequencyCapLevelEnum.Types.FrequencyCapLevel) input.ReadEnum();
            break;
          }
          case 16: {
            TimeUnit = (global::Google.Ads.GoogleAds.V3.Enums.FrequencyCapTimeUnitEnum.Types.FrequencyCapTimeUnit) input.ReadEnum();
            break;
          }
          case 24: {
            EventType = (global::Google.Ads.GoogleAds.V3.Enums.FrequencyCapEventTypeEnum.Types.FrequencyCapEventType) input.ReadEnum();
            break;
          }
          case 34: {
            int? value = _single_timeLength_codec.Read(input);
            if (timeLength_ == null || value != 0) {
              TimeLength = value;
            }
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
