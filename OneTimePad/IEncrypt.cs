using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneTimePad
{
    public interface IEncrypt
    {
        byte[] encrypt(byte[] toEncrypt);

        byte[] decrypt(byte[] toDecrypt);
    }
}
