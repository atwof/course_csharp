using System;
namespace interface_content.Devices
{
    public abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string document);
    }
}

