// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/errors/criterion_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/errors/criterion_error.proto</summary>
  public static partial class CriterionErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/errors/criterion_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CriterionErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvYWRzL2dvb2dsZWFkcy92My9lcnJvcnMvY3JpdGVyaW9uX2Vy",
            "cm9yLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52My5lcnJvcnMaHGdv",
            "b2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i4R0KEkNyaXRlcmlvbkVycm9y",
            "RW51bSLKHQoOQ3JpdGVyaW9uRXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdV",
            "TktOT1dOEAESGgoWQ09OQ1JFVEVfVFlQRV9SRVFVSVJFRBACEh0KGUlOVkFM",
            "SURfRVhDTFVERURfQ0FURUdPUlkQAxIYChRJTlZBTElEX0tFWVdPUkRfVEVY",
            "VBAEEhkKFUtFWVdPUkRfVEVYVF9UT09fTE9ORxAFEh4KGktFWVdPUkRfSEFT",
            "X1RPT19NQU5ZX1dPUkRTEAYSHQoZS0VZV09SRF9IQVNfSU5WQUxJRF9DSEFS",
            "UxAHEhkKFUlOVkFMSURfUExBQ0VNRU5UX1VSTBAIEhUKEUlOVkFMSURfVVNF",
            "Ul9MSVNUEAkSGQoVSU5WQUxJRF9VU0VSX0lOVEVSRVNUEAoSJAogSU5WQUxJ",
            "RF9GT1JNQVRfRk9SX1BMQUNFTUVOVF9VUkwQCxIdChlQTEFDRU1FTlRfVVJM",
            "X0lTX1RPT19MT05HEAwSIgoeUExBQ0VNRU5UX1VSTF9IQVNfSUxMRUdBTF9D",
            "SEFSEA0SLAooUExBQ0VNRU5UX1VSTF9IQVNfTVVMVElQTEVfU0lURVNfSU5f",
            "TElORRAOEjkKNVBMQUNFTUVOVF9JU19OT1RfQVZBSUxBQkxFX0ZPUl9UQVJH",
            "RVRJTkdfT1JfRVhDTFVTSU9OEA8SFgoSSU5WQUxJRF9UT1BJQ19QQVRIEBAS",
            "HgoaSU5WQUxJRF9ZT1VUVUJFX0NIQU5ORUxfSUQQERIcChhJTlZBTElEX1lP",
            "VVRVQkVfVklERU9fSUQQEhInCiNZT1VUVUJFX1ZFUlRJQ0FMX0NIQU5ORUxf",
            "REVQUkVDQVRFRBATEioKJllPVVRVQkVfREVNT0dSQVBISUNfQ0hBTk5FTF9E",
            "RVBSRUNBVEVEEBQSGwoXWU9VVFVCRV9VUkxfVU5TVVBQT1JURUQQFRIgChxD",
            "QU5OT1RfRVhDTFVERV9DUklURVJJQV9UWVBFEBYSHAoYQ0FOTk9UX0FERF9D",
            "UklURVJJQV9UWVBFEBcSGgoWSU5WQUxJRF9QUk9EVUNUX0ZJTFRFUhAYEhsK",
            "F1BST0RVQ1RfRklMVEVSX1RPT19MT05HEBkSJAogQ0FOTk9UX0VYQ0xVREVf",
            "U0lNSUxBUl9VU0VSX0xJU1QQGhIfChtDQU5OT1RfQUREX0NMT1NFRF9VU0VS",
            "X0xJU1QQGxI6CjZDQU5OT1RfQUREX0RJU1BMQVlfT05MWV9MSVNUU19UT19T",
            "RUFSQ0hfT05MWV9DQU1QQUlHTlMQHBI1CjFDQU5OT1RfQUREX0RJU1BMQVlf",
            "T05MWV9MSVNUU19UT19TRUFSQ0hfQ0FNUEFJR05TEB0SNwozQ0FOTk9UX0FE",
            "RF9ESVNQTEFZX09OTFlfTElTVFNfVE9fU0hPUFBJTkdfQ0FNUEFJR05TEB4S",
            "MQotQ0FOTk9UX0FERF9VU0VSX0lOVEVSRVNUU19UT19TRUFSQ0hfQ0FNUEFJ",
            "R05TEB8SOQo1Q0FOTk9UX1NFVF9CSURTX09OX0NSSVRFUklPTl9UWVBFX0lO",
            "X1NFQVJDSF9DQU1QQUlHTlMQIBI3CjNDQU5OT1RfQUREX1VSTFNfVE9fQ1JJ",
            "VEVSSU9OX1RZUEVfRk9SX0NBTVBBSUdOX1RZUEUQIRIbChdJTlZBTElEX0NV",
            "U1RPTV9BRkZJTklUWRBgEhkKFUlOVkFMSURfQ1VTVE9NX0lOVEVOVBBhEhYK",
            "EklOVkFMSURfSVBfQUREUkVTUxAiEhUKEUlOVkFMSURfSVBfRk9STUFUECMS",
            "FgoSSU5WQUxJRF9NT0JJTEVfQVBQECQSHwobSU5WQUxJRF9NT0JJTEVfQVBQ",
            "X0NBVEVHT1JZECUSGAoUSU5WQUxJRF9DUklURVJJT05fSUQQJhIbChdDQU5O",
            "T1RfVEFSR0VUX0NSSVRFUklPThAnEiQKIENBTk5PVF9UQVJHRVRfT0JTT0xF",
            "VEVfQ1JJVEVSSU9OECgSIgoeQ1JJVEVSSU9OX0lEX0FORF9UWVBFX01JU01B",
            "VENIECkSHAoYSU5WQUxJRF9QUk9YSU1JVFlfUkFESVVTECoSIgoeSU5WQUxJ",
            "RF9QUk9YSU1JVFlfUkFESVVTX1VOSVRTECsSIAocSU5WQUxJRF9TVFJFRVRB",
            "RERSRVNTX0xFTkdUSBAsEhsKF0lOVkFMSURfQ0lUWU5BTUVfTEVOR1RIEC0S",
            "HQoZSU5WQUxJRF9SRUdJT05DT0RFX0xFTkdUSBAuEh0KGUlOVkFMSURfUkVH",
            "SU9OTkFNRV9MRU5HVEgQLxIdChlJTlZBTElEX1BPU1RBTENPREVfTEVOR1RI",
            "EDASGAoUSU5WQUxJRF9DT1VOVFJZX0NPREUQMRIUChBJTlZBTElEX0xBVElU",
            "VURFEDISFQoRSU5WQUxJRF9MT05HSVRVREUQMxI2CjJQUk9YSU1JVFlfR0VP",
            "UE9JTlRfQU5EX0FERFJFU1NfQk9USF9DQU5OT1RfQkVfTlVMTBA0Eh0KGUlO",
            "VkFMSURfUFJPWElNSVRZX0FERFJFU1MQNRIcChhJTlZBTElEX1VTRVJfRE9N",
            "QUlOX05BTUUQNhIgChxDUklURVJJT05fUEFSQU1FVEVSX1RPT19MT05HEDcS",
            "JgoiQURfU0NIRURVTEVfVElNRV9JTlRFUlZBTFNfT1ZFUkxBUBA4EjIKLkFE",
            "X1NDSEVEVUxFX0lOVEVSVkFMX0NBTk5PVF9TUEFOX01VTFRJUExFX0RBWVMQ",
            "ORIlCiFBRF9TQ0hFRFVMRV9JTlZBTElEX1RJTUVfSU5URVJWQUwQOhIwCixB",
            "RF9TQ0hFRFVMRV9FWENFRURFRF9JTlRFUlZBTFNfUEVSX0RBWV9MSU1JVBA7",
            "Ei8KK0FEX1NDSEVEVUxFX0NSSVRFUklPTl9JRF9NSVNNQVRDSElOR19GSUVM",
            "RFMQPBIkCiBDQU5OT1RfQklEX01PRElGWV9DUklURVJJT05fVFlQRRA9EjIK",
            "LkNBTk5PVF9CSURfTU9ESUZZX0NSSVRFUklPTl9DQU1QQUlHTl9PUFRFRF9P",
            "VVQQPhIoCiRDQU5OT1RfQklEX01PRElGWV9ORUdBVElWRV9DUklURVJJT04Q",
            "PxIfChtCSURfTU9ESUZJRVJfQUxSRUFEWV9FWElTVFMQQBIXChNGRUVEX0lE",
            "X05PVF9BTExPV0VEEEESKAokQUNDT1VOVF9JTkVMSUdJQkxFX0ZPUl9DUklU",
            "RVJJQV9UWVBFEEISLgoqQ1JJVEVSSUFfVFlQRV9JTlZBTElEX0ZPUl9CSURE",
            "SU5HX1NUUkFURUdZEEMSHAoYQ0FOTk9UX0VYQ0xVREVfQ1JJVEVSSU9OEEQS",
            "GwoXQ0FOTk9UX1JFTU9WRV9DUklURVJJT04QRRIaChZQUk9EVUNUX1NDT1BF",
            "X1RPT19MT05HEEYSJQohUFJPRFVDVF9TQ09QRV9UT09fTUFOWV9ESU1FTlNJ",
            "T05TEEcSHgoaUFJPRFVDVF9QQVJUSVRJT05fVE9PX0xPTkcQSBIpCiVQUk9E",
            "VUNUX1BBUlRJVElPTl9UT09fTUFOWV9ESU1FTlNJT05TEEkSHQoZSU5WQUxJ",
            "RF9QUk9EVUNUX0RJTUVOU0lPThBKEiIKHklOVkFMSURfUFJPRFVDVF9ESU1F",
            "TlNJT05fVFlQRRBLEiQKIElOVkFMSURfUFJPRFVDVF9CSURESU5HX0NBVEVH",
            "T1JZEEwSHAoYTUlTU0lOR19TSE9QUElOR19TRVRUSU5HEE0SHQoZSU5WQUxJ",
            "RF9NQVRDSElOR19GVU5DVElPThBOEh8KG0xPQ0FUSU9OX0ZJTFRFUl9OT1Rf",
            "QUxMT1dFRBBPEiQKIElOVkFMSURfRkVFRF9GT1JfTE9DQVRJT05fRklMVEVS",
            "EGISGwoXTE9DQVRJT05fRklMVEVSX0lOVkFMSUQQUBIyCi5DQU5OT1RfQVRU",
            "QUNIX0NSSVRFUklBX0FUX0NBTVBBSUdOX0FORF9BREdST1VQEFESOQo1SE9U",
            "RUxfTEVOR1RIX09GX1NUQVlfT1ZFUkxBUFNfV0lUSF9FWElTVElOR19DUklU",
            "RVJJT04QUhJBCj1IT1RFTF9BRFZBTkNFX0JPT0tJTkdfV0lORE9XX09WRVJM",
            "QVBTX1dJVEhfRVhJU1RJTkdfQ1JJVEVSSU9OEFMSLgoqRklFTERfSU5DT01Q",
            "QVRJQkxFX1dJVEhfTkVHQVRJVkVfVEFSR0VUSU5HEFQSHQoZSU5WQUxJRF9X",
            "RUJQQUdFX0NPTkRJVElPThBVEiEKHUlOVkFMSURfV0VCUEFHRV9DT05ESVRJ",
            "T05fVVJMEFYSKQolV0VCUEFHRV9DT05ESVRJT05fVVJMX0NBTk5PVF9CRV9F",
            "TVBUWRBXEi4KKldFQlBBR0VfQ09ORElUSU9OX1VSTF9VTlNVUFBPUlRFRF9Q",
            "Uk9UT0NPTBBYEi4KKldFQlBBR0VfQ09ORElUSU9OX1VSTF9DQU5OT1RfQkVf",
            "SVBfQUREUkVTUxBZEkUKQVdFQlBBR0VfQ09ORElUSU9OX1VSTF9ET01BSU5f",
            "Tk9UX0NPTlNJU1RFTlRfV0lUSF9DQU1QQUlHTl9TRVRUSU5HEFoSMQotV0VC",
            "UEFHRV9DT05ESVRJT05fVVJMX0NBTk5PVF9CRV9QVUJMSUNfU1VGRklYEFsS",
            "LworV0VCUEFHRV9DT05ESVRJT05fVVJMX0lOVkFMSURfUFVCTElDX1NVRkZJ",
            "WBBcEjkKNVdFQlBBR0VfQ09ORElUSU9OX1VSTF9WQUxVRV9UUkFDS19WQUxV",
            "RV9OT1RfU1VQUE9SVEVEEF0SPAo4V0VCUEFHRV9DUklURVJJT05fVVJMX0VR",
            "VUFMU19DQU5fSEFWRV9PTkxZX09ORV9DT05ESVRJT04QXhI3CjNXRUJQQUdF",
            "X0NSSVRFUklPTl9OT1RfU1VQUE9SVEVEX09OX05PTl9EU0FfQURfR1JPVVAQ",
            "XxI3CjNDQU5OT1RfVEFSR0VUX1VTRVJfTElTVF9GT1JfU01BUlRfRElTUExB",
            "WV9DQU1QQUlHTlMQY0LuAQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYz",
            "LmVycm9yc0ITQ3JpdGVyaW9uRXJyb3JQcm90b1ABWkRnb29nbGUuZ29sYW5n",
            "Lm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjMvZXJy",
            "b3JzO2Vycm9yc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYzLkVy",
            "cm9yc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYzXEVycm9yc+oCIkdvb2ds",
            "ZTo6QWRzOjpHb29nbGVBZHM6OlYzOjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Errors.CriterionErrorEnum), global::Google.Ads.GoogleAds.V3.Errors.CriterionErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Errors.CriterionErrorEnum.Types.CriterionError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible criterion errors.
  /// </summary>
  public sealed partial class CriterionErrorEnum : pb::IMessage<CriterionErrorEnum> {
    private static readonly pb::MessageParser<CriterionErrorEnum> _parser = new pb::MessageParser<CriterionErrorEnum>(() => new CriterionErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CriterionErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Errors.CriterionErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CriterionErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CriterionErrorEnum(CriterionErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CriterionErrorEnum Clone() {
      return new CriterionErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CriterionErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CriterionErrorEnum other) {
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
    public void MergeFrom(CriterionErrorEnum other) {
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
    /// <summary>Container for nested types declared in the CriterionErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible criterion errors.
      /// </summary>
      public enum CriterionError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Concrete type of criterion is required for CREATE and UPDATE operations.
        /// </summary>
        [pbr::OriginalName("CONCRETE_TYPE_REQUIRED")] ConcreteTypeRequired = 2,
        /// <summary>
        /// The category requested for exclusion is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_EXCLUDED_CATEGORY")] InvalidExcludedCategory = 3,
        /// <summary>
        /// Invalid keyword criteria text.
        /// </summary>
        [pbr::OriginalName("INVALID_KEYWORD_TEXT")] InvalidKeywordText = 4,
        /// <summary>
        /// Keyword text should be less than 80 chars.
        /// </summary>
        [pbr::OriginalName("KEYWORD_TEXT_TOO_LONG")] KeywordTextTooLong = 5,
        /// <summary>
        /// Keyword text has too many words.
        /// </summary>
        [pbr::OriginalName("KEYWORD_HAS_TOO_MANY_WORDS")] KeywordHasTooManyWords = 6,
        /// <summary>
        /// Keyword text has invalid characters or symbols.
        /// </summary>
        [pbr::OriginalName("KEYWORD_HAS_INVALID_CHARS")] KeywordHasInvalidChars = 7,
        /// <summary>
        /// Invalid placement URL.
        /// </summary>
        [pbr::OriginalName("INVALID_PLACEMENT_URL")] InvalidPlacementUrl = 8,
        /// <summary>
        /// Invalid user list criterion.
        /// </summary>
        [pbr::OriginalName("INVALID_USER_LIST")] InvalidUserList = 9,
        /// <summary>
        /// Invalid user interest criterion.
        /// </summary>
        [pbr::OriginalName("INVALID_USER_INTEREST")] InvalidUserInterest = 10,
        /// <summary>
        /// Placement URL has wrong format.
        /// </summary>
        [pbr::OriginalName("INVALID_FORMAT_FOR_PLACEMENT_URL")] InvalidFormatForPlacementUrl = 11,
        /// <summary>
        /// Placement URL is too long.
        /// </summary>
        [pbr::OriginalName("PLACEMENT_URL_IS_TOO_LONG")] PlacementUrlIsTooLong = 12,
        /// <summary>
        /// Indicates the URL contains an illegal character.
        /// </summary>
        [pbr::OriginalName("PLACEMENT_URL_HAS_ILLEGAL_CHAR")] PlacementUrlHasIllegalChar = 13,
        /// <summary>
        /// Indicates the URL contains multiple comma separated URLs.
        /// </summary>
        [pbr::OriginalName("PLACEMENT_URL_HAS_MULTIPLE_SITES_IN_LINE")] PlacementUrlHasMultipleSitesInLine = 14,
        /// <summary>
        /// Indicates the domain is blacklisted.
        /// </summary>
        [pbr::OriginalName("PLACEMENT_IS_NOT_AVAILABLE_FOR_TARGETING_OR_EXCLUSION")] PlacementIsNotAvailableForTargetingOrExclusion = 15,
        /// <summary>
        /// Invalid topic path.
        /// </summary>
        [pbr::OriginalName("INVALID_TOPIC_PATH")] InvalidTopicPath = 16,
        /// <summary>
        /// The YouTube Channel Id is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_YOUTUBE_CHANNEL_ID")] InvalidYoutubeChannelId = 17,
        /// <summary>
        /// The YouTube Video Id is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_YOUTUBE_VIDEO_ID")] InvalidYoutubeVideoId = 18,
        /// <summary>
        /// Indicates the placement is a YouTube vertical channel, which is no longer
        /// supported.
        /// </summary>
        [pbr::OriginalName("YOUTUBE_VERTICAL_CHANNEL_DEPRECATED")] YoutubeVerticalChannelDeprecated = 19,
        /// <summary>
        /// Indicates the placement is a YouTube demographic channel, which is no
        /// longer supported.
        /// </summary>
        [pbr::OriginalName("YOUTUBE_DEMOGRAPHIC_CHANNEL_DEPRECATED")] YoutubeDemographicChannelDeprecated = 20,
        /// <summary>
        /// YouTube urls are not supported in Placement criterion. Use YouTubeChannel
        /// and YouTubeVideo criterion instead.
        /// </summary>
        [pbr::OriginalName("YOUTUBE_URL_UNSUPPORTED")] YoutubeUrlUnsupported = 21,
        /// <summary>
        /// Criteria type can not be excluded by the customer, like AOL account type
        /// cannot target site type criteria.
        /// </summary>
        [pbr::OriginalName("CANNOT_EXCLUDE_CRITERIA_TYPE")] CannotExcludeCriteriaType = 22,
        /// <summary>
        /// Criteria type can not be targeted.
        /// </summary>
        [pbr::OriginalName("CANNOT_ADD_CRITERIA_TYPE")] CannotAddCriteriaType = 23,
        /// <summary>
        /// Product filter in the product criteria has invalid characters. Operand
        /// and the argument in the filter can not have "==" or "&amp;+".
        /// </summary>
        [pbr::OriginalName("INVALID_PRODUCT_FILTER")] InvalidProductFilter = 24,
        /// <summary>
        /// Product filter in the product criteria is translated to a string as
        /// operand1==argument1&amp;+operand2==argument2, maximum allowed length for the
        /// string is 255 chars.
        /// </summary>
        [pbr::OriginalName("PRODUCT_FILTER_TOO_LONG")] ProductFilterTooLong = 25,
        /// <summary>
        /// Not allowed to exclude similar user list.
        /// </summary>
        [pbr::OriginalName("CANNOT_EXCLUDE_SIMILAR_USER_LIST")] CannotExcludeSimilarUserList = 26,
        /// <summary>
        /// Not allowed to target a closed user list.
        /// </summary>
        [pbr::OriginalName("CANNOT_ADD_CLOSED_USER_LIST")] CannotAddClosedUserList = 27,
        /// <summary>
        /// Not allowed to add display only UserLists to search only campaigns.
        /// </summary>
        [pbr::OriginalName("CANNOT_ADD_DISPLAY_ONLY_LISTS_TO_SEARCH_ONLY_CAMPAIGNS")] CannotAddDisplayOnlyListsToSearchOnlyCampaigns = 28,
        /// <summary>
        /// Not allowed to add display only UserLists to search plus campaigns.
        /// </summary>
        [pbr::OriginalName("CANNOT_ADD_DISPLAY_ONLY_LISTS_TO_SEARCH_CAMPAIGNS")] CannotAddDisplayOnlyListsToSearchCampaigns = 29,
        /// <summary>
        /// Not allowed to add display only UserLists to shopping campaigns.
        /// </summary>
        [pbr::OriginalName("CANNOT_ADD_DISPLAY_ONLY_LISTS_TO_SHOPPING_CAMPAIGNS")] CannotAddDisplayOnlyListsToShoppingCampaigns = 30,
        /// <summary>
        /// Not allowed to add User interests to search only campaigns.
        /// </summary>
        [pbr::OriginalName("CANNOT_ADD_USER_INTERESTS_TO_SEARCH_CAMPAIGNS")] CannotAddUserInterestsToSearchCampaigns = 31,
        /// <summary>
        /// Not allowed to set bids for this criterion type in search campaigns
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_BIDS_ON_CRITERION_TYPE_IN_SEARCH_CAMPAIGNS")] CannotSetBidsOnCriterionTypeInSearchCampaigns = 32,
        /// <summary>
        /// Final URLs, URL Templates and CustomParameters cannot be set for the
        /// criterion types of Gender, AgeRange, UserList, Placement, MobileApp, and
        /// MobileAppCategory in search campaigns and shopping campaigns.
        /// </summary>
        [pbr::OriginalName("CANNOT_ADD_URLS_TO_CRITERION_TYPE_FOR_CAMPAIGN_TYPE")] CannotAddUrlsToCriterionTypeForCampaignType = 33,
        /// <summary>
        /// Invalid custom affinity criterion.
        /// </summary>
        [pbr::OriginalName("INVALID_CUSTOM_AFFINITY")] InvalidCustomAffinity = 96,
        /// <summary>
        /// Invalid custom intent criterion.
        /// </summary>
        [pbr::OriginalName("INVALID_CUSTOM_INTENT")] InvalidCustomIntent = 97,
        /// <summary>
        /// IP address is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_IP_ADDRESS")] InvalidIpAddress = 34,
        /// <summary>
        /// IP format is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_IP_FORMAT")] InvalidIpFormat = 35,
        /// <summary>
        /// Mobile application is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_MOBILE_APP")] InvalidMobileApp = 36,
        /// <summary>
        /// Mobile application category is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_MOBILE_APP_CATEGORY")] InvalidMobileAppCategory = 37,
        /// <summary>
        /// The CriterionId does not exist or is of the incorrect type.
        /// </summary>
        [pbr::OriginalName("INVALID_CRITERION_ID")] InvalidCriterionId = 38,
        /// <summary>
        /// The Criterion is not allowed to be targeted.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_CRITERION")] CannotTargetCriterion = 39,
        /// <summary>
        /// The criterion is not allowed to be targeted as it is deprecated.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_OBSOLETE_CRITERION")] CannotTargetObsoleteCriterion = 40,
        /// <summary>
        /// The CriterionId is not valid for the type.
        /// </summary>
        [pbr::OriginalName("CRITERION_ID_AND_TYPE_MISMATCH")] CriterionIdAndTypeMismatch = 41,
        /// <summary>
        /// Distance for the radius for the proximity criterion is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_PROXIMITY_RADIUS")] InvalidProximityRadius = 42,
        /// <summary>
        /// Units for the distance for the radius for the proximity criterion is
        /// invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_PROXIMITY_RADIUS_UNITS")] InvalidProximityRadiusUnits = 43,
        /// <summary>
        /// Street address in the address is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_STREETADDRESS_LENGTH")] InvalidStreetaddressLength = 44,
        /// <summary>
        /// City name in the address is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_CITYNAME_LENGTH")] InvalidCitynameLength = 45,
        /// <summary>
        /// Region code in the address is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_REGIONCODE_LENGTH")] InvalidRegioncodeLength = 46,
        /// <summary>
        /// Region name in the address is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_REGIONNAME_LENGTH")] InvalidRegionnameLength = 47,
        /// <summary>
        /// Postal code in the address is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_POSTALCODE_LENGTH")] InvalidPostalcodeLength = 48,
        /// <summary>
        /// Country code in the address is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_COUNTRY_CODE")] InvalidCountryCode = 49,
        /// <summary>
        /// Latitude for the GeoPoint is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_LATITUDE")] InvalidLatitude = 50,
        /// <summary>
        /// Longitude for the GeoPoint is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_LONGITUDE")] InvalidLongitude = 51,
        /// <summary>
        /// The Proximity input is not valid. Both address and geoPoint cannot be
        /// null.
        /// </summary>
        [pbr::OriginalName("PROXIMITY_GEOPOINT_AND_ADDRESS_BOTH_CANNOT_BE_NULL")] ProximityGeopointAndAddressBothCannotBeNull = 52,
        /// <summary>
        /// The Proximity address cannot be geocoded to a valid lat/long.
        /// </summary>
        [pbr::OriginalName("INVALID_PROXIMITY_ADDRESS")] InvalidProximityAddress = 53,
        /// <summary>
        /// User domain name is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_USER_DOMAIN_NAME")] InvalidUserDomainName = 54,
        /// <summary>
        /// Length of serialized criterion parameter exceeded size limit.
        /// </summary>
        [pbr::OriginalName("CRITERION_PARAMETER_TOO_LONG")] CriterionParameterTooLong = 55,
        /// <summary>
        /// Time interval in the AdSchedule overlaps with another AdSchedule.
        /// </summary>
        [pbr::OriginalName("AD_SCHEDULE_TIME_INTERVALS_OVERLAP")] AdScheduleTimeIntervalsOverlap = 56,
        /// <summary>
        /// AdSchedule time interval cannot span multiple days.
        /// </summary>
        [pbr::OriginalName("AD_SCHEDULE_INTERVAL_CANNOT_SPAN_MULTIPLE_DAYS")] AdScheduleIntervalCannotSpanMultipleDays = 57,
        /// <summary>
        /// AdSchedule time interval specified is invalid, endTime cannot be earlier
        /// than startTime.
        /// </summary>
        [pbr::OriginalName("AD_SCHEDULE_INVALID_TIME_INTERVAL")] AdScheduleInvalidTimeInterval = 58,
        /// <summary>
        /// The number of AdSchedule entries in a day exceeds the limit.
        /// </summary>
        [pbr::OriginalName("AD_SCHEDULE_EXCEEDED_INTERVALS_PER_DAY_LIMIT")] AdScheduleExceededIntervalsPerDayLimit = 59,
        /// <summary>
        /// CriteriaId does not match the interval of the AdSchedule specified.
        /// </summary>
        [pbr::OriginalName("AD_SCHEDULE_CRITERION_ID_MISMATCHING_FIELDS")] AdScheduleCriterionIdMismatchingFields = 60,
        /// <summary>
        /// Cannot set bid modifier for this criterion type.
        /// </summary>
        [pbr::OriginalName("CANNOT_BID_MODIFY_CRITERION_TYPE")] CannotBidModifyCriterionType = 61,
        /// <summary>
        /// Cannot bid modify criterion, since it is opted out of the campaign.
        /// </summary>
        [pbr::OriginalName("CANNOT_BID_MODIFY_CRITERION_CAMPAIGN_OPTED_OUT")] CannotBidModifyCriterionCampaignOptedOut = 62,
        /// <summary>
        /// Cannot set bid modifier for a negative criterion.
        /// </summary>
        [pbr::OriginalName("CANNOT_BID_MODIFY_NEGATIVE_CRITERION")] CannotBidModifyNegativeCriterion = 63,
        /// <summary>
        /// Bid Modifier already exists. Use SET operation to update.
        /// </summary>
        [pbr::OriginalName("BID_MODIFIER_ALREADY_EXISTS")] BidModifierAlreadyExists = 64,
        /// <summary>
        /// Feed Id is not allowed in these Location Groups.
        /// </summary>
        [pbr::OriginalName("FEED_ID_NOT_ALLOWED")] FeedIdNotAllowed = 65,
        /// <summary>
        /// The account may not use the requested criteria type. For example, some
        /// accounts are restricted to keywords only.
        /// </summary>
        [pbr::OriginalName("ACCOUNT_INELIGIBLE_FOR_CRITERIA_TYPE")] AccountIneligibleForCriteriaType = 66,
        /// <summary>
        /// The requested criteria type cannot be used with campaign or ad group
        /// bidding strategy.
        /// </summary>
        [pbr::OriginalName("CRITERIA_TYPE_INVALID_FOR_BIDDING_STRATEGY")] CriteriaTypeInvalidForBiddingStrategy = 67,
        /// <summary>
        /// The Criterion is not allowed to be excluded.
        /// </summary>
        [pbr::OriginalName("CANNOT_EXCLUDE_CRITERION")] CannotExcludeCriterion = 68,
        /// <summary>
        /// The criterion is not allowed to be removed. For example, we cannot remove
        /// any of the device criterion.
        /// </summary>
        [pbr::OriginalName("CANNOT_REMOVE_CRITERION")] CannotRemoveCriterion = 69,
        /// <summary>
        /// The combined length of product dimension values of the product scope
        /// criterion is too long.
        /// </summary>
        [pbr::OriginalName("PRODUCT_SCOPE_TOO_LONG")] ProductScopeTooLong = 70,
        /// <summary>
        /// Product scope contains too many dimensions.
        /// </summary>
        [pbr::OriginalName("PRODUCT_SCOPE_TOO_MANY_DIMENSIONS")] ProductScopeTooManyDimensions = 71,
        /// <summary>
        /// The combined length of product dimension values of the product partition
        /// criterion is too long.
        /// </summary>
        [pbr::OriginalName("PRODUCT_PARTITION_TOO_LONG")] ProductPartitionTooLong = 72,
        /// <summary>
        /// Product partition contains too many dimensions.
        /// </summary>
        [pbr::OriginalName("PRODUCT_PARTITION_TOO_MANY_DIMENSIONS")] ProductPartitionTooManyDimensions = 73,
        /// <summary>
        /// The product dimension is invalid (e.g. dimension contains illegal value,
        /// dimension type is represented with wrong class, etc). Product dimension
        /// value can not contain "==" or "&amp;+".
        /// </summary>
        [pbr::OriginalName("INVALID_PRODUCT_DIMENSION")] InvalidProductDimension = 74,
        /// <summary>
        /// Product dimension type is either invalid for campaigns of this type or
        /// cannot be used in the current context. BIDDING_CATEGORY_Lx and
        /// PRODUCT_TYPE_Lx product dimensions must be used in ascending order of
        /// their levels: L1, L2, L3, L4, L5... The levels must be specified
        /// sequentially and start from L1. Furthermore, an "others" product
        /// partition cannot be subdivided with a dimension of the same type but of a
        /// higher level ("others" BIDDING_CATEGORY_L3 can be subdivided with BRAND
        /// but not with BIDDING_CATEGORY_L4).
        /// </summary>
        [pbr::OriginalName("INVALID_PRODUCT_DIMENSION_TYPE")] InvalidProductDimensionType = 75,
        /// <summary>
        /// Bidding categories do not form a valid path in the Shopping bidding
        /// category taxonomy.
        /// </summary>
        [pbr::OriginalName("INVALID_PRODUCT_BIDDING_CATEGORY")] InvalidProductBiddingCategory = 76,
        /// <summary>
        /// ShoppingSetting must be added to the campaign before ProductScope
        /// criteria can be added.
        /// </summary>
        [pbr::OriginalName("MISSING_SHOPPING_SETTING")] MissingShoppingSetting = 77,
        /// <summary>
        /// Matching function is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_MATCHING_FUNCTION")] InvalidMatchingFunction = 78,
        /// <summary>
        /// Filter parameters not allowed for location groups targeting.
        /// </summary>
        [pbr::OriginalName("LOCATION_FILTER_NOT_ALLOWED")] LocationFilterNotAllowed = 79,
        /// <summary>
        /// Feed not found, or the feed is not an enabled location feed.
        /// </summary>
        [pbr::OriginalName("INVALID_FEED_FOR_LOCATION_FILTER")] InvalidFeedForLocationFilter = 98,
        /// <summary>
        /// Given location filter parameter is invalid for location groups targeting.
        /// </summary>
        [pbr::OriginalName("LOCATION_FILTER_INVALID")] LocationFilterInvalid = 80,
        /// <summary>
        /// Criteria type cannot be associated with a campaign and its ad group(s)
        /// simultaneously.
        /// </summary>
        [pbr::OriginalName("CANNOT_ATTACH_CRITERIA_AT_CAMPAIGN_AND_ADGROUP")] CannotAttachCriteriaAtCampaignAndAdgroup = 81,
        /// <summary>
        /// Range represented by hotel length of stay's min nights and max nights
        /// overlaps with an existing criterion.
        /// </summary>
        [pbr::OriginalName("HOTEL_LENGTH_OF_STAY_OVERLAPS_WITH_EXISTING_CRITERION")] HotelLengthOfStayOverlapsWithExistingCriterion = 82,
        /// <summary>
        /// Range represented by hotel advance booking window's min days and max days
        /// overlaps with an existing criterion.
        /// </summary>
        [pbr::OriginalName("HOTEL_ADVANCE_BOOKING_WINDOW_OVERLAPS_WITH_EXISTING_CRITERION")] HotelAdvanceBookingWindowOverlapsWithExistingCriterion = 83,
        /// <summary>
        /// The field is not allowed to be set when the negative field is set to
        /// true, e.g. we don't allow bids in negative ad group or campaign criteria.
        /// </summary>
        [pbr::OriginalName("FIELD_INCOMPATIBLE_WITH_NEGATIVE_TARGETING")] FieldIncompatibleWithNegativeTargeting = 84,
        /// <summary>
        /// The combination of operand and operator in webpage condition is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_WEBPAGE_CONDITION")] InvalidWebpageCondition = 85,
        /// <summary>
        /// The URL of webpage condition is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_WEBPAGE_CONDITION_URL")] InvalidWebpageConditionUrl = 86,
        /// <summary>
        /// The URL of webpage condition cannot be empty or contain white space.
        /// </summary>
        [pbr::OriginalName("WEBPAGE_CONDITION_URL_CANNOT_BE_EMPTY")] WebpageConditionUrlCannotBeEmpty = 87,
        /// <summary>
        /// The URL of webpage condition contains an unsupported protocol.
        /// </summary>
        [pbr::OriginalName("WEBPAGE_CONDITION_URL_UNSUPPORTED_PROTOCOL")] WebpageConditionUrlUnsupportedProtocol = 88,
        /// <summary>
        /// The URL of webpage condition cannot be an IP address.
        /// </summary>
        [pbr::OriginalName("WEBPAGE_CONDITION_URL_CANNOT_BE_IP_ADDRESS")] WebpageConditionUrlCannotBeIpAddress = 89,
        /// <summary>
        /// The domain of the URL is not consistent with the domain in campaign
        /// setting.
        /// </summary>
        [pbr::OriginalName("WEBPAGE_CONDITION_URL_DOMAIN_NOT_CONSISTENT_WITH_CAMPAIGN_SETTING")] WebpageConditionUrlDomainNotConsistentWithCampaignSetting = 90,
        /// <summary>
        /// The URL of webpage condition cannot be a public suffix itself.
        /// </summary>
        [pbr::OriginalName("WEBPAGE_CONDITION_URL_CANNOT_BE_PUBLIC_SUFFIX")] WebpageConditionUrlCannotBePublicSuffix = 91,
        /// <summary>
        /// The URL of webpage condition has an invalid public suffix.
        /// </summary>
        [pbr::OriginalName("WEBPAGE_CONDITION_URL_INVALID_PUBLIC_SUFFIX")] WebpageConditionUrlInvalidPublicSuffix = 92,
        /// <summary>
        /// Value track parameter is not supported in webpage condition URL.
        /// </summary>
        [pbr::OriginalName("WEBPAGE_CONDITION_URL_VALUE_TRACK_VALUE_NOT_SUPPORTED")] WebpageConditionUrlValueTrackValueNotSupported = 93,
        /// <summary>
        /// Only one URL-EQUALS webpage condition is allowed in a webpage
        /// criterion and it cannot be combined with other conditions.
        /// </summary>
        [pbr::OriginalName("WEBPAGE_CRITERION_URL_EQUALS_CAN_HAVE_ONLY_ONE_CONDITION")] WebpageCriterionUrlEqualsCanHaveOnlyOneCondition = 94,
        /// <summary>
        /// A webpage criterion cannot be added to a non-DSA ad group.
        /// </summary>
        [pbr::OriginalName("WEBPAGE_CRITERION_NOT_SUPPORTED_ON_NON_DSA_AD_GROUP")] WebpageCriterionNotSupportedOnNonDsaAdGroup = 95,
        /// <summary>
        /// Cannot add positive user list criteria in Smart Display campaigns.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_USER_LIST_FOR_SMART_DISPLAY_CAMPAIGNS")] CannotTargetUserListForSmartDisplayCampaigns = 99,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
