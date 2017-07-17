namespace MyWpf.Infrastructure
{
    public interface IView
    {
        IViewModel ViewModel { get; set; }
    }
}