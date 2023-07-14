namespace BizDoLib
{
    public interface ISearch
    {
        public string search { get; }
        public int Offset { get; }
        public int Limit { get; }
    }
    // export interface ISearch {
    //     search: string;
    //     offset: number;
    //     limit: number;
    // }
}