// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/talent/v4beta1/resume_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Talent.V4Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/talent/v4beta1/resume_service.proto</summary>
  public static partial class ResumeServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/talent/v4beta1/resume_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ResumeServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBnb29nbGUvY2xvdWQvdGFsZW50L3Y0YmV0YTEvcmVzdW1lX3NlcnZpY2Uu",
            "cHJvdG8SG2dvb2dsZS5jbG91ZC50YWxlbnQudjRiZXRhMRocZ29vZ2xlL2Fw",
            "aS9hbm5vdGF0aW9ucy5wcm90bxopZ29vZ2xlL2Nsb3VkL3RhbGVudC92NGJl",
            "dGExL3Byb2ZpbGUucHJvdG8iogEKElBhcnNlUmVzdW1lUmVxdWVzdBIOCgZw",
            "YXJlbnQYASABKAkSDgoGcmVzdW1lGAIgASgMEhMKC3JlZ2lvbl9jb2RlGAMg",
            "ASgJEhUKDWxhbmd1YWdlX2NvZGUYBCABKAkSQAoHb3B0aW9ucxgFIAEoCzIv",
            "Lmdvb2dsZS5jbG91ZC50YWxlbnQudjRiZXRhMS5QYXJzZVJlc3VtZU9wdGlv",
            "bnMiTQoSUGFyc2VSZXN1bWVPcHRpb25zEhIKCmVuYWJsZV9vY3IYASABKAgS",
            "IwobZW5hYmxlX2Z1bGxfc2tpbGxfZGV0ZWN0aW9uGAIgASgIIl4KE1BhcnNl",
            "UmVzdW1lUmVzcG9uc2USNQoHcHJvZmlsZRgBIAEoCzIkLmdvb2dsZS5jbG91",
            "ZC50YWxlbnQudjRiZXRhMS5Qcm9maWxlEhAKCHJhd190ZXh0GAIgASgJMrkB",
            "Cg1SZXN1bWVTZXJ2aWNlEqcBCgtQYXJzZVJlc3VtZRIvLmdvb2dsZS5jbG91",
            "ZC50YWxlbnQudjRiZXRhMS5QYXJzZVJlc3VtZVJlcXVlc3QaMC5nb29nbGUu",
            "Y2xvdWQudGFsZW50LnY0YmV0YTEuUGFyc2VSZXN1bWVSZXNwb25zZSI1gtPk",
            "kwIvIiovdjRiZXRhMS97cGFyZW50PXByb2plY3RzLyp9L3Jlc3VtZXM6cGFy",
            "c2U6ASpCgAEKH2NvbS5nb29nbGUuY2xvdWQudGFsZW50LnY0YmV0YTFCElJl",
            "c3VtZVNlcnZpY2VQcm90b1ABWkFnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90",
            "by9nb29nbGVhcGlzL2Nsb3VkL3RhbGVudC92NGJldGExO3RhbGVudKICA0NU",
            "U2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Cloud.Talent.V4Beta1.ProfileReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Talent.V4Beta1.ParseResumeRequest), global::Google.Cloud.Talent.V4Beta1.ParseResumeRequest.Parser, new[]{ "Parent", "Resume", "RegionCode", "LanguageCode", "Options" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Talent.V4Beta1.ParseResumeOptions), global::Google.Cloud.Talent.V4Beta1.ParseResumeOptions.Parser, new[]{ "EnableOcr", "EnableFullSkillDetection" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Talent.V4Beta1.ParseResumeResponse), global::Google.Cloud.Talent.V4Beta1.ParseResumeResponse.Parser, new[]{ "Profile", "RawText" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Parse resume request.
  /// </summary>
  public sealed partial class ParseResumeRequest : pb::IMessage<ParseResumeRequest> {
    private static readonly pb::MessageParser<ParseResumeRequest> _parser = new pb::MessageParser<ParseResumeRequest>(() => new ParseResumeRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ParseResumeRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Talent.V4Beta1.ResumeServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParseResumeRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParseResumeRequest(ParseResumeRequest other) : this() {
      parent_ = other.parent_;
      resume_ = other.resume_;
      regionCode_ = other.regionCode_;
      languageCode_ = other.languageCode_;
      options_ = other.options_ != null ? other.options_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParseResumeRequest Clone() {
      return new ParseResumeRequest(this);
    }

    /// <summary>Field number for the "parent" field.</summary>
    public const int ParentFieldNumber = 1;
    private string parent_ = "";
    /// <summary>
    /// Required.
    ///
    /// The resource name of the project.
    ///
    /// The format is "projects/{project_id}", for example,
    /// "projects/api-test-project".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Parent {
      get { return parent_; }
      set {
        parent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "resume" field.</summary>
    public const int ResumeFieldNumber = 2;
    private pb::ByteString resume_ = pb::ByteString.Empty;
    /// <summary>
    /// Required.
    ///
    /// The bytes of the resume file in common format, for example, PDF, TXT.
    /// UTF-8 encoding is required if the resume is text-based, otherwise an error
    /// is thrown.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Resume {
      get { return resume_; }
      set {
        resume_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "region_code" field.</summary>
    public const int RegionCodeFieldNumber = 3;
    private string regionCode_ = "";
    /// <summary>
    /// Optional.
    ///
    /// The region code indicating where the resume is from. Values
    /// are as per the ISO-3166-2 format. For example, US, FR, DE.
    ///
    /// This value is optional, but providing this value improves the resume
    /// parsing quality and performance.
    ///
    /// An error is thrown if the regionCode is invalid.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RegionCode {
      get { return regionCode_; }
      set {
        regionCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "language_code" field.</summary>
    public const int LanguageCodeFieldNumber = 4;
    private string languageCode_ = "";
    /// <summary>
    /// Optional.
    ///
    /// The language code of contents in the resume.
    ///
    /// Language codes must be in BCP-47 format, such as "en-US" or "sr-Latn".
    /// For more information, see
    /// [Tags for Identifying Languages](https://tools.ietf.org/html/bcp47){:
    /// class="external" target="_blank" }.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LanguageCode {
      get { return languageCode_; }
      set {
        languageCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "options" field.</summary>
    public const int OptionsFieldNumber = 5;
    private global::Google.Cloud.Talent.V4Beta1.ParseResumeOptions options_;
    /// <summary>
    /// Optional.
    ///
    /// Options that change how the resume parse is performed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Talent.V4Beta1.ParseResumeOptions Options {
      get { return options_; }
      set {
        options_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ParseResumeRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ParseResumeRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Parent != other.Parent) return false;
      if (Resume != other.Resume) return false;
      if (RegionCode != other.RegionCode) return false;
      if (LanguageCode != other.LanguageCode) return false;
      if (!object.Equals(Options, other.Options)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Parent.Length != 0) hash ^= Parent.GetHashCode();
      if (Resume.Length != 0) hash ^= Resume.GetHashCode();
      if (RegionCode.Length != 0) hash ^= RegionCode.GetHashCode();
      if (LanguageCode.Length != 0) hash ^= LanguageCode.GetHashCode();
      if (options_ != null) hash ^= Options.GetHashCode();
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
      if (Parent.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (Resume.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Resume);
      }
      if (RegionCode.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RegionCode);
      }
      if (LanguageCode.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(LanguageCode);
      }
      if (options_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Options);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Parent.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Parent);
      }
      if (Resume.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Resume);
      }
      if (RegionCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RegionCode);
      }
      if (LanguageCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LanguageCode);
      }
      if (options_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Options);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ParseResumeRequest other) {
      if (other == null) {
        return;
      }
      if (other.Parent.Length != 0) {
        Parent = other.Parent;
      }
      if (other.Resume.Length != 0) {
        Resume = other.Resume;
      }
      if (other.RegionCode.Length != 0) {
        RegionCode = other.RegionCode;
      }
      if (other.LanguageCode.Length != 0) {
        LanguageCode = other.LanguageCode;
      }
      if (other.options_ != null) {
        if (options_ == null) {
          options_ = new global::Google.Cloud.Talent.V4Beta1.ParseResumeOptions();
        }
        Options.MergeFrom(other.Options);
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
            Parent = input.ReadString();
            break;
          }
          case 18: {
            Resume = input.ReadBytes();
            break;
          }
          case 26: {
            RegionCode = input.ReadString();
            break;
          }
          case 34: {
            LanguageCode = input.ReadString();
            break;
          }
          case 42: {
            if (options_ == null) {
              options_ = new global::Google.Cloud.Talent.V4Beta1.ParseResumeOptions();
            }
            input.ReadMessage(options_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Options that change how the resume parse is performed.
  /// </summary>
  public sealed partial class ParseResumeOptions : pb::IMessage<ParseResumeOptions> {
    private static readonly pb::MessageParser<ParseResumeOptions> _parser = new pb::MessageParser<ParseResumeOptions>(() => new ParseResumeOptions());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ParseResumeOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Talent.V4Beta1.ResumeServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParseResumeOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParseResumeOptions(ParseResumeOptions other) : this() {
      enableOcr_ = other.enableOcr_;
      enableFullSkillDetection_ = other.enableFullSkillDetection_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParseResumeOptions Clone() {
      return new ParseResumeOptions(this);
    }

    /// <summary>Field number for the "enable_ocr" field.</summary>
    public const int EnableOcrFieldNumber = 1;
    private bool enableOcr_;
    /// <summary>
    /// Optional.
    ///
    /// Controls whether Optical Character Recognition (OCR) is enabled.
    ///
    /// OCR is used to decipher pictorial resumes, or resumes that have some
    /// element of pictorial detail (for example, contact information placed within
    /// an image in a pdf). Note that the API call has a higher latency if OCR is
    /// enabled.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool EnableOcr {
      get { return enableOcr_; }
      set {
        enableOcr_ = value;
      }
    }

    /// <summary>Field number for the "enable_full_skill_detection" field.</summary>
    public const int EnableFullSkillDetectionFieldNumber = 2;
    private bool enableFullSkillDetection_;
    /// <summary>
    /// Optional.
    ///
    /// Controls whether detected skills are included in the parsed profile from
    /// sections of the resume other than just skills sections.
    ///
    /// Normally, returned skills are limited to those taken from a resume section
    /// intended to list skills. When enabled, this feature causes detected
    /// skills in other sections to also be included in the returned profile.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool EnableFullSkillDetection {
      get { return enableFullSkillDetection_; }
      set {
        enableFullSkillDetection_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ParseResumeOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ParseResumeOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EnableOcr != other.EnableOcr) return false;
      if (EnableFullSkillDetection != other.EnableFullSkillDetection) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EnableOcr != false) hash ^= EnableOcr.GetHashCode();
      if (EnableFullSkillDetection != false) hash ^= EnableFullSkillDetection.GetHashCode();
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
      if (EnableOcr != false) {
        output.WriteRawTag(8);
        output.WriteBool(EnableOcr);
      }
      if (EnableFullSkillDetection != false) {
        output.WriteRawTag(16);
        output.WriteBool(EnableFullSkillDetection);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EnableOcr != false) {
        size += 1 + 1;
      }
      if (EnableFullSkillDetection != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ParseResumeOptions other) {
      if (other == null) {
        return;
      }
      if (other.EnableOcr != false) {
        EnableOcr = other.EnableOcr;
      }
      if (other.EnableFullSkillDetection != false) {
        EnableFullSkillDetection = other.EnableFullSkillDetection;
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
            EnableOcr = input.ReadBool();
            break;
          }
          case 16: {
            EnableFullSkillDetection = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Parse resume response.
  /// </summary>
  public sealed partial class ParseResumeResponse : pb::IMessage<ParseResumeResponse> {
    private static readonly pb::MessageParser<ParseResumeResponse> _parser = new pb::MessageParser<ParseResumeResponse>(() => new ParseResumeResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ParseResumeResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Talent.V4Beta1.ResumeServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParseResumeResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParseResumeResponse(ParseResumeResponse other) : this() {
      profile_ = other.profile_ != null ? other.profile_.Clone() : null;
      rawText_ = other.rawText_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ParseResumeResponse Clone() {
      return new ParseResumeResponse(this);
    }

    /// <summary>Field number for the "profile" field.</summary>
    public const int ProfileFieldNumber = 1;
    private global::Google.Cloud.Talent.V4Beta1.Profile profile_;
    /// <summary>
    /// The profile parsed from resume.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Talent.V4Beta1.Profile Profile {
      get { return profile_; }
      set {
        profile_ = value;
      }
    }

    /// <summary>Field number for the "raw_text" field.</summary>
    public const int RawTextFieldNumber = 2;
    private string rawText_ = "";
    /// <summary>
    /// Raw text from resume.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RawText {
      get { return rawText_; }
      set {
        rawText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ParseResumeResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ParseResumeResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Profile, other.Profile)) return false;
      if (RawText != other.RawText) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (profile_ != null) hash ^= Profile.GetHashCode();
      if (RawText.Length != 0) hash ^= RawText.GetHashCode();
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
      if (profile_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Profile);
      }
      if (RawText.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RawText);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (profile_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Profile);
      }
      if (RawText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RawText);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ParseResumeResponse other) {
      if (other == null) {
        return;
      }
      if (other.profile_ != null) {
        if (profile_ == null) {
          profile_ = new global::Google.Cloud.Talent.V4Beta1.Profile();
        }
        Profile.MergeFrom(other.Profile);
      }
      if (other.RawText.Length != 0) {
        RawText = other.RawText;
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
            if (profile_ == null) {
              profile_ = new global::Google.Cloud.Talent.V4Beta1.Profile();
            }
            input.ReadMessage(profile_);
            break;
          }
          case 18: {
            RawText = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
