//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: attack.proto
namespace com.CR.GameDataModel
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Attack")]
  public partial class Attack : global::ProtoBuf.IExtensible
  {
    public Attack() {}
    
    private int _weaponId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"weaponId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int weaponId
    {
      get { return _weaponId; }
      set { _weaponId = value; }
    }
    private string _weaponName;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"weaponName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string weaponName
    {
      get { return _weaponName; }
      set { _weaponName = value; }
    }
    private int _hurtValue;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"hurtValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int hurtValue
    {
      get { return _hurtValue; }
      set { _hurtValue = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
// Generated from: login.proto
namespace com.CR.GameDataModel
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Login")]
  public partial class Login : global::ProtoBuf.IExtensible
  {
    public Login() {}
    
    private string _loginName;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"loginName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string loginName
    {
      get { return _loginName; }
      set { _loginName = value; }
    }
    private string _loginPassword;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"loginPassword", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string loginPassword
    {
      get { return _loginPassword; }
      set { _loginPassword = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
// Generated from: player.proto
namespace com.CR.GameDataModel
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Player")]
  public partial class Player : global::ProtoBuf.IExtensible
  {
    public Player() {}
    
    private int _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _level;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }
    private int _golds;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"golds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int golds
    {
      get { return _golds; }
      set { _golds = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}