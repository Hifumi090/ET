
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
    public sealed partial class YIUIItemExchange : Luban.BeanBase
    {
        public YIUIItemExchange(ByteBuf _buf) 
        {
            Id = _buf.ReadInt();
            Num = _buf.ReadInt();

            EndInit();
        }

        public static YIUIItemExchange DeserializeYIUIItemExchange(ByteBuf _buf)
        {
            return new YIUITest.YIUIItemExchange(_buf);
        }

        /// <summary>
        /// 道具id
        /// </summary>
        public readonly int Id;
        /// <summary>
        /// 道具数量
        /// </summary>
        public readonly int Num;
    
        public const int __ID__ = -64144206;
        public override int GetTypeId() => __ID__;

        public  void ResolveRef()
        {
            EndRef();
        }

        public override string ToString()
        {
            return "{ "
            + "id:" + Id + ","
            + "num:" + Num + ","
            + "}";
        }

        partial void EndRef();
    }

}

