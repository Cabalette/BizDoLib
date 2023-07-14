namespace BizDoLib
{
    public interface IImage
    {
        public string Path { get; }
        public object Scope { get; }
        any?
    }
    //     export interface IImage {
    //     path: string;
    //     scope: any;
    // }

    public interface ITypeWithImage
    {
        IImage Image { get; }
    }
    // export interface ITypeWithImage {
    //   image: IImage;
}