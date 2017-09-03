// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: RequestType.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ChatProtos.Networking {

  /// <summary>Holder for reflection information generated from RequestType.proto</summary>
  public static partial class RequestTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for RequestType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RequestTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFSZXF1ZXN0VHlwZS5wcm90bxIVQ2hhdFByb3Rvcy5OZXR3b3JraW5nKp4B",
            "CgtSZXF1ZXN0VHlwZRIJCgVMT0dJThAAEgoKBkxPR09VVBABEhAKDEpPSU5f",
            "Q0hBTk5FTBACEhEKDUxFQVZFX0NIQU5ORUwQAxIMCghCQU5fVVNFUhAEEg0K",
            "CUtJQ0tfVVNFUhAFEhcKE1VQREFURV9ESVNQTEFZX05BTUUQBhIMCghBRERf",
            "Uk9MRRAHEg8KC1JFTU9WRV9ST0xFEAhiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::ChatProtos.Networking.RequestType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum RequestType {
    [pbr::OriginalName("LOGIN")] Login = 0,
    [pbr::OriginalName("LOGOUT")] Logout = 1,
    [pbr::OriginalName("JOIN_CHANNEL")] JoinChannel = 2,
    [pbr::OriginalName("LEAVE_CHANNEL")] LeaveChannel = 3,
    [pbr::OriginalName("BAN_USER")] BanUser = 4,
    [pbr::OriginalName("KICK_USER")] KickUser = 5,
    [pbr::OriginalName("UPDATE_DISPLAY_NAME")] UpdateDisplayName = 6,
    [pbr::OriginalName("ADD_ROLE")] AddRole = 7,
    [pbr::OriginalName("REMOVE_ROLE")] RemoveRole = 8,
  }

  #endregion

}

#endregion Designer generated code
