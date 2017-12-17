﻿using System;
using System.Threading.Tasks;
using Contracts;

namespace UnitTests
{
    public class EncryptionManagerMock : IEncryptionManager
    {
        public Task<byte[]> Encrypt(byte[] data)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> Decrypt(byte[] encryptedData)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> SignAsync(byte[] data)
        {
            throw new NotImplementedException();
        }

        public Task<bool> VerifyAsync(byte[] data, byte[] signature)
        {
            throw new NotImplementedException();
        }
    }
}