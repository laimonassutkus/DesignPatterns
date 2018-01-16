using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    abstract class FileSystemComponent
    {
        public virtual void AddComponent(FileSystemComponent component)
        {
            throw new NotSupportedException();
        } 

        public virtual void RemoveComponent(FileSystemComponent component)
        {
            throw new NotSupportedException();
        } 

        public virtual FileSystemComponent GetComponent(int componentIndex)
        {
            throw new NotSupportedException();
        } 

        public virtual string GetName()
        {
            throw new NotSupportedException();
        } 

        public virtual void Display()
        {
            throw new NotSupportedException();
        }
    }
}
