//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Tests/Redola.Rpc.TestContracts/Benchmark.proto
namespace Redola.Rpc.TestContracts
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BenchmarkRequest")]
  public partial class BenchmarkRequest : global::ProtoBuf.IExtensible
  {
    public BenchmarkRequest() {}
    
    private Redola.Rpc.TestContracts.BenchmarkMessage _Message;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Message", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Redola.Rpc.TestContracts.BenchmarkMessage Message
    {
      get { return _Message; }
      set { _Message = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BenchmarkResponse")]
  public partial class BenchmarkResponse : global::ProtoBuf.IExtensible
  {
    public BenchmarkResponse() {}
    
    private Redola.Rpc.TestContracts.BenchmarkMessage _Message;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Message", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Redola.Rpc.TestContracts.BenchmarkMessage Message
    {
      get { return _Message; }
      set { _Message = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BenchmarkMessage")]
  public partial class BenchmarkMessage : global::ProtoBuf.IExtensible
  {
    public BenchmarkMessage() {}
    
    private string _field1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"field1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string field1
    {
      get { return _field1; }
      set { _field1 = value; }
    }
    private string _field9 = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"field9", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string field9
    {
      get { return _field9; }
      set { _field9 = value; }
    }
    private string _field18 = "";
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"field18", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string field18
    {
      get { return _field18; }
      set { _field18 = value; }
    }
    private bool _field80 = (bool)false;
    [global::ProtoBuf.ProtoMember(80, IsRequired = false, Name=@"field80", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool field80
    {
      get { return _field80; }
      set { _field80 = value; }
    }
    private bool _field81 = (bool)true;
    [global::ProtoBuf.ProtoMember(81, IsRequired = false, Name=@"field81", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)true)]
    public bool field81
    {
      get { return _field81; }
      set { _field81 = value; }
    }
    private int _field2;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"field2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int field2
    {
      get { return _field2; }
      set { _field2 = value; }
    }
    private int _field3;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"field3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int field3
    {
      get { return _field3; }
      set { _field3 = value; }
    }
    private int _field280 = default(int);
    [global::ProtoBuf.ProtoMember(280, IsRequired = false, Name=@"field280", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int field280
    {
      get { return _field280; }
      set { _field280 = value; }
    }
    private int _field6 = (int)0;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"field6", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int field6
    {
      get { return _field6; }
      set { _field6 = value; }
    }
    private long _field22 = default(long);
    [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"field22", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long field22
    {
      get { return _field22; }
      set { _field22 = value; }
    }
    private string _field4 = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"field4", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string field4
    {
      get { return _field4; }
      set { _field4 = value; }
    }
    private readonly global::System.Collections.Generic.List<ulong> _field5 = new global::System.Collections.Generic.List<ulong>();
    [global::ProtoBuf.ProtoMember(5, Name=@"field5", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public global::System.Collections.Generic.List<ulong> field5
    {
      get { return _field5; }
    }
  
    private bool _field59 = (bool)false;
    [global::ProtoBuf.ProtoMember(59, IsRequired = false, Name=@"field59", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool field59
    {
      get { return _field59; }
      set { _field59 = value; }
    }
    private string _field7 = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"field7", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string field7
    {
      get { return _field7; }
      set { _field7 = value; }
    }
    private int _field16 = default(int);
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"field16", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int field16
    {
      get { return _field16; }
      set { _field16 = value; }
    }
    private int _field130 = (int)0;
    [global::ProtoBuf.ProtoMember(130, IsRequired = false, Name=@"field130", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int field130
    {
      get { return _field130; }
      set { _field130 = value; }
    }
    private bool _field12 = (bool)true;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"field12", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)true)]
    public bool field12
    {
      get { return _field12; }
      set { _field12 = value; }
    }
    private bool _field17 = (bool)true;
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"field17", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)true)]
    public bool field17
    {
      get { return _field17; }
      set { _field17 = value; }
    }
    private bool _field13 = (bool)true;
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"field13", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)true)]
    public bool field13
    {
      get { return _field13; }
      set { _field13 = value; }
    }
    private bool _field14 = (bool)true;
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"field14", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)true)]
    public bool field14
    {
      get { return _field14; }
      set { _field14 = value; }
    }
    private int _field104 = (int)0;
    [global::ProtoBuf.ProtoMember(104, IsRequired = false, Name=@"field104", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int field104
    {
      get { return _field104; }
      set { _field104 = value; }
    }
    private int _field100 = (int)0;
    [global::ProtoBuf.ProtoMember(100, IsRequired = false, Name=@"field100", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int field100
    {
      get { return _field100; }
      set { _field100 = value; }
    }
    private int _field101 = (int)0;
    [global::ProtoBuf.ProtoMember(101, IsRequired = false, Name=@"field101", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int field101
    {
      get { return _field101; }
      set { _field101 = value; }
    }
    private string _field102 = "";
    [global::ProtoBuf.ProtoMember(102, IsRequired = false, Name=@"field102", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string field102
    {
      get { return _field102; }
      set { _field102 = value; }
    }
    private string _field103 = "";
    [global::ProtoBuf.ProtoMember(103, IsRequired = false, Name=@"field103", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string field103
    {
      get { return _field103; }
      set { _field103 = value; }
    }
    private int _field29 = (int)0;
    [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"field29", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int field29
    {
      get { return _field29; }
      set { _field29 = value; }
    }
    private bool _field30 = (bool)false;
    [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"field30", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool field30
    {
      get { return _field30; }
      set { _field30 = value; }
    }
    private int _field60 = (int)-1;
    [global::ProtoBuf.ProtoMember(60, IsRequired = false, Name=@"field60", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int field60
    {
      get { return _field60; }
      set { _field60 = value; }
    }
    private int _field271 = (int)-1;
    [global::ProtoBuf.ProtoMember(271, IsRequired = false, Name=@"field271", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int field271
    {
      get { return _field271; }
      set { _field271 = value; }
    }
    private int _field272 = (int)-1;
    [global::ProtoBuf.ProtoMember(272, IsRequired = false, Name=@"field272", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int field272
    {
      get { return _field272; }
      set { _field272 = value; }
    }
    private int _field150 = default(int);
    [global::ProtoBuf.ProtoMember(150, IsRequired = false, Name=@"field150", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int field150
    {
      get { return _field150; }
      set { _field150 = value; }
    }
    private int _field23 = (int)0;
    [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"field23", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int field23
    {
      get { return _field23; }
      set { _field23 = value; }
    }
    private bool _field24 = (bool)false;
    [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"field24", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool field24
    {
      get { return _field24; }
      set { _field24 = value; }
    }
    private int _field25 = (int)0;
    [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"field25", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int field25
    {
      get { return _field25; }
      set { _field25 = value; }
    }
    private bool _field78 = default(bool);
    [global::ProtoBuf.ProtoMember(78, IsRequired = false, Name=@"field78", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool field78
    {
      get { return _field78; }
      set { _field78 = value; }
    }
    private int _field67 = (int)0;
    [global::ProtoBuf.ProtoMember(67, IsRequired = false, Name=@"field67", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int field67
    {
      get { return _field67; }
      set { _field67 = value; }
    }
    private int _field68 = default(int);
    [global::ProtoBuf.ProtoMember(68, IsRequired = false, Name=@"field68", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int field68
    {
      get { return _field68; }
      set { _field68 = value; }
    }
    private int _field128 = (int)0;
    [global::ProtoBuf.ProtoMember(128, IsRequired = false, Name=@"field128", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int field128
    {
      get { return _field128; }
      set { _field128 = value; }
    }
    private string _field129 = @"xxxxxxxxxxxxxxxxxxxxx";
    [global::ProtoBuf.ProtoMember(129, IsRequired = false, Name=@"field129", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(@"xxxxxxxxxxxxxxxxxxxxx")]
    public string field129
    {
      get { return _field129; }
      set { _field129 = value; }
    }
    private int _field131 = (int)0;
    [global::ProtoBuf.ProtoMember(131, IsRequired = false, Name=@"field131", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int field131
    {
      get { return _field131; }
      set { _field131 = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}