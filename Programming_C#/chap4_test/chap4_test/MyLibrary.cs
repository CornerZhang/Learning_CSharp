using System;

namespace chap4_test
{
    // interface
    public interface IComponent {

        void Start();
        void Update();
    }

    public class Render: IComponent {

        public void Start() {
            
        }

        public void Update() {
            
        }
    }



    // abstract class
    public abstract class UIText {
        private int n = 0;

        public virtual void Init() {
            n += n;
        }

        public abstract void Draw();

    }

    public class UIButton: UIText {

//        public override void Init() {
//            
//        }

        public override void Draw() {
            
        }
    }

    // sealed class
    public sealed class UIMenuItem: UIButton {
        
    }

    // be error!!!
//    public class UIExtItem: UIMenuItem {
//        
//    }
}

