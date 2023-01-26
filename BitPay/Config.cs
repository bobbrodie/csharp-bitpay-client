namespace BitPay
{
    public class Config
    {
        public const string TestUrl = "https://test.bitpay.com/";
        public const string ProdUrl = "https://bitpay.com/";
        public const string BitpayApiVersion = "2.0.0";
        public const string BitpayPluginInfo = "BitPay_DotNet_Client_v4.4.2203";
        public const string BitpayApiFrame = "std";
        public const string BitpayApiFrameVersion = "1.0.0";
        public class Tokens
        {
            public string Merchant { get; set; }
            public string Payout { get; set; }
        }
    }
}