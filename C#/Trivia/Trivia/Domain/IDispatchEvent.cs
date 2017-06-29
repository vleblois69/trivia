namespace Trivia
{
    public interface IDispatchEvent
    {
        void Display(string message);
        void Dispatch<TEvent>(TEvent @event);
    }
}