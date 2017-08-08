
namespace TestingCSharp
{
    public class RenderSystem
    {
        public static RenderSystem only = new RenderSystem();

        // ctor only be called in the class
        private RenderSystem()
        {
        }

        public void Initizlize() {

        }

        public bool BeginContent(bool sync = false) {
            return false;
        }

        public void EndContent() {

        }
    }

}

