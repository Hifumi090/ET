
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


namespace ET.YIUITest
{
    [EnableClass]
    public sealed partial class YIUIClientConfig : Luban.BeanBase
    {
        public YIUIClientConfig(ByteBuf _buf) 
        {
            Id = _buf.ReadInt();
            Name = _buf.ReadString();

            EndInit();
        }

        public static YIUIClientConfig DeserializeYIUIClientConfig(ByteBuf _buf)
        {
            return new YIUITest.YIUIClientConfig(_buf);
        }

        /// <summary>
        /// 这是id
        /// </summary>
        public readonly int Id;
        /// <summary>
        /// 名字
        /// </summary>
        public readonly string Name;
    
        public const int __ID__ = -282807991;
        public override int GetTypeId() => __ID__;

        public  void ResolveRef()
        {
            EndRef();
        }

        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "name:" + Name + ","
            + "}";
        }

        partial void EndRef();
    }

}
