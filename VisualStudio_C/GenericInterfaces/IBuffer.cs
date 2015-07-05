using System;
namespace VisualStudio_C.GenericInterfaces {
    public interface IBuffer<T> {
        bool IsEmpty { get; }
        T Read();
        void Write(T value);
    }
}
