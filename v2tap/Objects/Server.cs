namespace v2tap.Objects
{
    public class Server
    {
        /// <summary>
        /// 唯一 ID
        /// </summary>
        public string ID;

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark;

        /// <summary>
        /// 地址
        /// </summary>
        public string Address;

        /// <summary>
        /// 端口
        /// </summary>
        public int Port;

        /// <summary>
        /// 用户 ID
        /// </summary>
        public string UserID;

        /// <summary>
        /// 额外 ID
        /// </summary>
        public int AlterID;

        /// <summary>
        /// 传输方式
        /// </summary>
        public string TransferMethod;

        /// <summary>
        /// 路径
        /// </summary>
        public string Path;

        /// <summary>
        /// 伪装类型
        /// </summary>
        public string FakeType;

        /// <summary>
        /// TLS 底层传输安全
        /// </summary>
        public bool TLSSecure;
    }
}
