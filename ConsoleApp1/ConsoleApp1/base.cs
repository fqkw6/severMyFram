//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: base.proto
namespace @base
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"base_message")]
  public partial class base_message : global::ProtoBuf.IExtensible
  {
    public base_message() {}
    
    private msg_type __type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public msg_type _type
    {
      get { return __type; }
      set { __type = value; }
    }
    private byte[] __data = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] _data
    {
      get { return __data; }
      set { __data = value; }
    }
    private uint __ecode = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"_ecode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint _ecode
    {
      get { return __ecode; }
      set { __ecode = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"msg_type")]
    public enum msg_type
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"test_type", Value=1)]
      test_type = 1
    }
  
}