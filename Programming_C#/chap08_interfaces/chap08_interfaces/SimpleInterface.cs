using System;
using System.Text;

namespace SimpleInterface
{
    interface IStorable // default as public
    {
        void Read();    // default as public
        void Write(Object obj);

        int Status { get; set; }
    };

    interface ICompressible
    {
        void Compress();
        void Decompress();
    };

    // 扩展借口
    interface ILoggedCompressible: ICompressible
    {
        void LogSavedBytes();
    };

    // 组合借口
    interface IStorableCompressible: IStorable, ILoggedCompressible
    {
        void LogOriginalSize();
    };

    interface IEncryptable
    {
        void Encrypt();
        void Decrypt();
    };

}

