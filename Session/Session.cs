namespace BizDoLib
{
    public interface ISessionLog
    {
        public string Token { get; }
        public string UserUid { get; }
        public SomeData Data { get; }
        class SomeData
        {
            string host { get; set; }
            string agent { get; set; }
        }
    }
    // export interface ISessionLog {
    //     token: string;
    //     userUid: string;
    //     data: {
    //         host: string;
    //         agent: string;
    //     };
    // }
}