using PresentationLayer;

namespace ApplicationUser
{
    class Program
    {
        static void Main(string[] args)
        {
            InputManager inputs = new InputManager();
            inputs.InputReader();
            Console.WriteLine();
            InputManager inputs2 = new InputManager();
            inputs.InputReader();
        }
    }
}
