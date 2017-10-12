// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: interop/AppLauncherService.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Plexus.Interop.Apps.Internal.Generated {

  /// <summary>Holder for reflection information generated from interop/AppLauncherService.proto</summary>
  internal static partial class AppLauncherServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for interop/AppLauncherService.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AppLauncherServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBpbnRlcm9wL0FwcExhdW5jaGVyU2VydmljZS5wcm90bxIHaW50ZXJvcBoW",
            "aW50ZXJvcC9VbmlxdWVJZC5wcm90bxoVaW50ZXJvcC9PcHRpb25zLnByb3Rv",
            "IlwKEEFwcExhdW5jaFJlcXVlc3QSDgoGYXBwX2lkGAEgASgJEhoKEmxhdW5j",
            "aF9wYXJhbXNfanNvbhgCIAEoCTocktsEGGludGVyb3AuQXBwTGF1bmNoUmVx",
            "dWVzdCJeChFBcHBMYXVuY2hSZXNwb25zZRIqCg9hcHBfaW5zdGFuY2VfaWQY",
            "ASABKAsyES5pbnRlcm9wLlVuaXF1ZUlkOh2S2wQZaW50ZXJvcC5BcHBMYXVu",
            "Y2hSZXNwb25zZTJ1ChJBcHBMYXVuY2hlclNlcnZpY2USPwoGTGF1bmNoEhku",
            "aW50ZXJvcC5BcHBMYXVuY2hSZXF1ZXN0GhouaW50ZXJvcC5BcHBMYXVuY2hS",
            "ZXNwb25zZRoemtsEGmludGVyb3AuQXBwTGF1bmNoZXJTZXJ2aWNlQimqAiZQ",
            "bGV4dXMuSW50ZXJvcC5BcHBzLkludGVybmFsLkdlbmVyYXRlZGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Plexus.Interop.Apps.Internal.Generated.UniqueIdReflection.Descriptor, global::Plexus.Interop.Apps.Internal.Generated.OptionsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Plexus.Interop.Apps.Internal.Generated.AppLaunchRequest), global::Plexus.Interop.Apps.Internal.Generated.AppLaunchRequest.Parser, new[]{ "AppId", "LaunchParamsJson" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Plexus.Interop.Apps.Internal.Generated.AppLaunchResponse), global::Plexus.Interop.Apps.Internal.Generated.AppLaunchResponse.Parser, new[]{ "AppInstanceId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class AppLaunchRequest : pb::IMessage<AppLaunchRequest> {
    private static readonly pb::MessageParser<AppLaunchRequest> _parser = new pb::MessageParser<AppLaunchRequest>(() => new AppLaunchRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AppLaunchRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Plexus.Interop.Apps.Internal.Generated.AppLauncherServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppLaunchRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppLaunchRequest(AppLaunchRequest other) : this() {
      appId_ = other.appId_;
      launchParamsJson_ = other.launchParamsJson_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppLaunchRequest Clone() {
      return new AppLaunchRequest(this);
    }

    /// <summary>Field number for the "app_id" field.</summary>
    public const int AppIdFieldNumber = 1;
    private string appId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AppId {
      get { return appId_; }
      set {
        appId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "launch_params_json" field.</summary>
    public const int LaunchParamsJsonFieldNumber = 2;
    private string launchParamsJson_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LaunchParamsJson {
      get { return launchParamsJson_; }
      set {
        launchParamsJson_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AppLaunchRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AppLaunchRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AppId != other.AppId) return false;
      if (LaunchParamsJson != other.LaunchParamsJson) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AppId.Length != 0) hash ^= AppId.GetHashCode();
      if (LaunchParamsJson.Length != 0) hash ^= LaunchParamsJson.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (AppId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AppId);
      }
      if (LaunchParamsJson.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(LaunchParamsJson);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AppId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AppId);
      }
      if (LaunchParamsJson.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LaunchParamsJson);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AppLaunchRequest other) {
      if (other == null) {
        return;
      }
      if (other.AppId.Length != 0) {
        AppId = other.AppId;
      }
      if (other.LaunchParamsJson.Length != 0) {
        LaunchParamsJson = other.LaunchParamsJson;
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
            AppId = input.ReadString();
            break;
          }
          case 18: {
            LaunchParamsJson = input.ReadString();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class AppLaunchResponse : pb::IMessage<AppLaunchResponse> {
    private static readonly pb::MessageParser<AppLaunchResponse> _parser = new pb::MessageParser<AppLaunchResponse>(() => new AppLaunchResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AppLaunchResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Plexus.Interop.Apps.Internal.Generated.AppLauncherServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppLaunchResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppLaunchResponse(AppLaunchResponse other) : this() {
      AppInstanceId = other.appInstanceId_ != null ? other.AppInstanceId.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppLaunchResponse Clone() {
      return new AppLaunchResponse(this);
    }

    /// <summary>Field number for the "app_instance_id" field.</summary>
    public const int AppInstanceIdFieldNumber = 1;
    private global::Plexus.Interop.Apps.Internal.Generated.UniqueId appInstanceId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Plexus.Interop.Apps.Internal.Generated.UniqueId AppInstanceId {
      get { return appInstanceId_; }
      set {
        appInstanceId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AppLaunchResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AppLaunchResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AppInstanceId, other.AppInstanceId)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (appInstanceId_ != null) hash ^= AppInstanceId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (appInstanceId_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AppInstanceId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (appInstanceId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AppInstanceId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AppLaunchResponse other) {
      if (other == null) {
        return;
      }
      if (other.appInstanceId_ != null) {
        if (appInstanceId_ == null) {
          appInstanceId_ = new global::Plexus.Interop.Apps.Internal.Generated.UniqueId();
        }
        AppInstanceId.MergeFrom(other.AppInstanceId);
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
            if (appInstanceId_ == null) {
              appInstanceId_ = new global::Plexus.Interop.Apps.Internal.Generated.UniqueId();
            }
            input.ReadMessage(appInstanceId_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
