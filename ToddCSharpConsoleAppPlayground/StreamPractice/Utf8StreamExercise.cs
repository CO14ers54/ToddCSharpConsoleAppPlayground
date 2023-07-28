using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Text;
using System.Web;

namespace ToddCSharpConsoleAppPlayground.StreamPractice
{
    public class DecoratorStream : Stream
    {
        private Stream stream;
        private string prefix;

        public override bool CanSeek { get { return false; } }
        public override bool CanWrite { get { return true; } }
        public override long Length { get; }
        public override long Position { get; set; }
        public override bool CanRead { get { return false; } }

        public DecoratorStream(Stream stream, string prefix) : base()
        {
            this.stream = stream;
            this.prefix = prefix;
        }

        public override void SetLength(long length)
        {
            throw new NotSupportedException();
        }

        public override void Write(byte[] bytes, int offset, int count)
        {
            stream.Write(bytes, offset, count);
            //string str = Encoding.UTF8.GetString(bytes);
        }

        public override int Read(byte[] bytes, int offset, int count)
        {
            throw new NotSupportedException();
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotSupportedException();
        }

        public override void Flush()
        {
            stream.Flush();
        }

        public static void RunDecoratorStringExercise()
        {
            byte[] message = new byte[] { 0x48, 0x65, 0x6c, 0x6c, 0x6f, 0x2c, 0x20, 0x77, 0x6f, 0x72, 0x6c, 0x64, 0x21 };
            using (MemoryStream stream = new MemoryStream())
            {
                string asciiPrefix = "First line: ";
                using (DecoratorStream decoratorStream = new DecoratorStream(stream, asciiPrefix))
                {
                    byte[] utf8Prefix = Encoding.UTF8.GetBytes(asciiPrefix);
                    decoratorStream.Write(utf8Prefix, 0, utf8Prefix.Length);
                    decoratorStream.Write(message, 0, message.Length);
                    stream.Position = 0;
                    Console.WriteLine(new StreamReader(decoratorStream.stream).ReadLine());  //should print "First line: Hello, world!"
                }
            }
        }
    }
}
