// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mediapipe/modules/face_geometry/protos/mesh_3d.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Akihabara.Framework.Protobuf {

  /// <summary>Holder for reflection information generated from mediapipe/modules/face_geometry/protos/mesh_3d.proto</summary>
  public static partial class Mesh3DReflection {

    #region Descriptor
    /// <summary>File descriptor for mediapipe/modules/face_geometry/protos/mesh_3d.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Mesh3DReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRtZWRpYXBpcGUvbW9kdWxlcy9mYWNlX2dlb21ldHJ5L3Byb3Rvcy9tZXNo",
            "XzNkLnByb3RvEhdtZWRpYXBpcGUuZmFjZV9nZW9tZXRyeSL5AQoGTWVzaDNk",
            "Ej8KC3ZlcnRleF90eXBlGAEgASgOMioubWVkaWFwaXBlLmZhY2VfZ2VvbWV0",
            "cnkuTWVzaDNkLlZlcnRleFR5cGUSRQoOcHJpbWl0aXZlX3R5cGUYAiABKA4y",
            "LS5tZWRpYXBpcGUuZmFjZV9nZW9tZXRyeS5NZXNoM2QuUHJpbWl0aXZlVHlw",
            "ZRIVCg12ZXJ0ZXhfYnVmZmVyGAMgAygCEhQKDGluZGV4X2J1ZmZlchgEIAMo",
            "DSIbCgpWZXJ0ZXhUeXBlEg0KCVZFUlRFWF9QVBAAIh0KDVByaW1pdGl2ZVR5",
            "cGUSDAoIVFJJQU5HTEUQAEI4Ciljb20uZ29vZ2xlLm1lZGlhcGlwZS5tb2R1",
            "bGVzLmZhY2VnZW9tZXRyeUILTWVzaDNkUHJvdG8="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mediapipe.FaceGeometry.Mesh3d), global::Mediapipe.FaceGeometry.Mesh3d.Parser, new[]{ "VertexType", "PrimitiveType", "VertexBuffer", "IndexBuffer" }, null, new[]{ typeof(global::Mediapipe.FaceGeometry.Mesh3d.Types.VertexType), typeof(global::Mediapipe.FaceGeometry.Mesh3d.Types.PrimitiveType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Mesh3d : pb::IMessage<Mesh3d> {
    private static readonly pb::MessageParser<Mesh3d> _parser = new pb::MessageParser<Mesh3d>(() => new Mesh3d());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Mesh3d> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mediapipe.FaceGeometry.Mesh3DReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Mesh3d() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Mesh3d(Mesh3d other) : this() {
      _hasBits0 = other._hasBits0;
      vertexType_ = other.vertexType_;
      primitiveType_ = other.primitiveType_;
      vertexBuffer_ = other.vertexBuffer_.Clone();
      indexBuffer_ = other.indexBuffer_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Mesh3d Clone() {
      return new Mesh3d(this);
    }

    /// <summary>Field number for the "vertex_type" field.</summary>
    public const int VertexTypeFieldNumber = 1;
    private readonly static global::Mediapipe.FaceGeometry.Mesh3d.Types.VertexType VertexTypeDefaultValue = global::Mediapipe.FaceGeometry.Mesh3d.Types.VertexType.VertexPt;

    private global::Mediapipe.FaceGeometry.Mesh3d.Types.VertexType vertexType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Mediapipe.FaceGeometry.Mesh3d.Types.VertexType VertexType {
      get { if ((_hasBits0 & 1) != 0) { return vertexType_; } else { return VertexTypeDefaultValue; } }
      set {
        _hasBits0 |= 1;
        vertexType_ = value;
      }
    }
    /// <summary>Gets whether the "vertex_type" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasVertexType {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "vertex_type" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearVertexType() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "primitive_type" field.</summary>
    public const int PrimitiveTypeFieldNumber = 2;
    private readonly static global::Mediapipe.FaceGeometry.Mesh3d.Types.PrimitiveType PrimitiveTypeDefaultValue = global::Mediapipe.FaceGeometry.Mesh3d.Types.PrimitiveType.Triangle;

    private global::Mediapipe.FaceGeometry.Mesh3d.Types.PrimitiveType primitiveType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Mediapipe.FaceGeometry.Mesh3d.Types.PrimitiveType PrimitiveType {
      get { if ((_hasBits0 & 2) != 0) { return primitiveType_; } else { return PrimitiveTypeDefaultValue; } }
      set {
        _hasBits0 |= 2;
        primitiveType_ = value;
      }
    }
    /// <summary>Gets whether the "primitive_type" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasPrimitiveType {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "primitive_type" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearPrimitiveType() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "vertex_buffer" field.</summary>
    public const int VertexBufferFieldNumber = 3;
    private static readonly pb::FieldCodec<float> _repeated_vertexBuffer_codec
        = pb::FieldCodec.ForFloat(29);
    private readonly pbc::RepeatedField<float> vertexBuffer_ = new pbc::RepeatedField<float>();
    /// <summary>
    /// Vertex buffer size is a multiple of the vertex size (e.g., 5 for
    /// VERTEX_PT).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<float> VertexBuffer {
      get { return vertexBuffer_; }
    }

    /// <summary>Field number for the "index_buffer" field.</summary>
    public const int IndexBufferFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_indexBuffer_codec
        = pb::FieldCodec.ForUInt32(32);
    private readonly pbc::RepeatedField<uint> indexBuffer_ = new pbc::RepeatedField<uint>();
    /// <summary>
    /// Index buffer size is a multiple of the primitive size (e.g., 3 for
    /// TRIANGLE).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<uint> IndexBuffer {
      get { return indexBuffer_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Mesh3d);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Mesh3d other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (VertexType != other.VertexType) return false;
      if (PrimitiveType != other.PrimitiveType) return false;
      if(!vertexBuffer_.Equals(other.vertexBuffer_)) return false;
      if(!indexBuffer_.Equals(other.indexBuffer_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasVertexType) hash ^= VertexType.GetHashCode();
      if (HasPrimitiveType) hash ^= PrimitiveType.GetHashCode();
      hash ^= vertexBuffer_.GetHashCode();
      hash ^= indexBuffer_.GetHashCode();
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
      if (HasVertexType) {
        output.WriteRawTag(8);
        output.WriteEnum((int) VertexType);
      }
      if (HasPrimitiveType) {
        output.WriteRawTag(16);
        output.WriteEnum((int) PrimitiveType);
      }
      vertexBuffer_.WriteTo(output, _repeated_vertexBuffer_codec);
      indexBuffer_.WriteTo(output, _repeated_indexBuffer_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasVertexType) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) VertexType);
      }
      if (HasPrimitiveType) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PrimitiveType);
      }
      size += vertexBuffer_.CalculateSize(_repeated_vertexBuffer_codec);
      size += indexBuffer_.CalculateSize(_repeated_indexBuffer_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Mesh3d other) {
      if (other == null) {
        return;
      }
      if (other.HasVertexType) {
        VertexType = other.VertexType;
      }
      if (other.HasPrimitiveType) {
        PrimitiveType = other.PrimitiveType;
      }
      vertexBuffer_.Add(other.vertexBuffer_);
      indexBuffer_.Add(other.indexBuffer_);
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
            VertexType = (global::Mediapipe.FaceGeometry.Mesh3d.Types.VertexType) input.ReadEnum();
            break;
          }
          case 16: {
            PrimitiveType = (global::Mediapipe.FaceGeometry.Mesh3d.Types.PrimitiveType) input.ReadEnum();
            break;
          }
          case 26:
          case 29: {
            vertexBuffer_.AddEntriesFrom(input, _repeated_vertexBuffer_codec);
            break;
          }
          case 34:
          case 32: {
            indexBuffer_.AddEntriesFrom(input, _repeated_indexBuffer_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Mesh3d message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum VertexType {
        /// <summary>
        /// Is defined by 5 coordinates: Position (XYZ) + Texture coordinate (UV).
        /// </summary>
        [pbr::OriginalName("VERTEX_PT")] VertexPt = 0,
      }

      public enum PrimitiveType {
        /// <summary>
        /// Is defined by 3 indices: triangle vertex IDs.
        /// </summary>
        [pbr::OriginalName("TRIANGLE")] Triangle = 0,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code