using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    //this class implements LSP. LSP is:
    //"Functions that use pointers or references to base classes must be able to use objects of derived classes
    //without knowing it."
    //That is, in other words, the class S can be considered a subclass of T if replacing T objects with S objects
    //does not lead to a change in the operation of the program.
    //The Liskov substitution principle helps to more clearly formulate the class hierarchy, define functionality
    //for base and derived classes, and avoid possible problems when using polymorphism.

    //for example, here we could use Square as an instance of rectangle, which it is.

    class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int GetArea()
        {
            return Width * Height;
        }
    }

    class Square : Rectangle
    {
        public override int Width
        {
            get
            {
                return base.Width;
            }

            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override int Height
        {
            get
            {
                return base.Height;
            }

            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
    }
}
