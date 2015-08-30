using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VisualStudio_C.Book_Chapter7 {
    class Widget2D {
        int x;
        int y;
        object _lock = new object();

        public Widget2D(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public void MoveBy(int deltaX, int deltaY) {
            lock(_lock){
                x += deltaX;
                y += deltaY;
            }
        }

        public void GetPos(out int x, out int y) {
            lock(_lock){
                x = this.x;
                y = this.y;
            } 
        }
    }
}