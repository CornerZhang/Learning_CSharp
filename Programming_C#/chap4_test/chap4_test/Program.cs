using System;

namespace chap4_test
{
    class MainClass
    {
        public static void Main(string[] args) {
            Testing_Interface();
            Testing_AbstractClass();

        }

        public static void Testing_Interface() {
            Render render = new Render();
            IComponent iRender = render;

            iRender.Start();
            iRender.Update();

        }

        public static void Testing_AbstractClass() {
            UIButton btn = new UIButton();
            UIText text = btn;
            text.Init();
            text.Draw();

        }
    }
}
