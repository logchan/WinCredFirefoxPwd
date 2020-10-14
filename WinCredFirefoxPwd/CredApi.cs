using System;
using System.Runtime.InteropServices;
using System.Text;

namespace WinCredFirefoxPwd {
    public static class CredApi {
        public enum CRED_TYPE : int
        {
            GENERIC = 1,
            DOMAIN_PASSWORD = 2,
            DOMAIN_CERTIFICATE = 3,
            DOMAIN_VISIBLE_PASSWORD = 4,
            MAXIMUM = 5
        }

        [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)]
        public struct CREDENTIAL
        {
            public int flags;
            public int type;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string targetName;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string comment;
            public FILETIME lastWritten;
            public int credentialBlobSize;        
            public IntPtr credentialBlob;
            public int persist;
            public int attributeCount;
            public IntPtr credAttribute;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string targetAlias;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string userName;        
        }

        [DllImport("advapi32.dll", EntryPoint="CredReadW", CharSet = CharSet.Unicode, SetLastError=true)]
        public static extern bool CredRead(string target, CRED_TYPE type, int reservedFlag, out IntPtr credentialPtr);

        [DllImport("advapi32.dll", SetLastError=true)]
        static extern bool CredFree([In] IntPtr buffer);

        public static string GetPassword(string target) {
            if (!CredRead(target, CRED_TYPE.GENERIC, 0, out var credPtr) || credPtr.Equals(IntPtr.Zero)) {
                return null;
            }

            var cred = (CREDENTIAL) Marshal.PtrToStructure(credPtr, typeof(CREDENTIAL));
            var bytes = new byte[cred.credentialBlobSize];
            Marshal.Copy(cred.credentialBlob, bytes, 0, cred.credentialBlobSize);
            CredFree(credPtr);

            return Encoding.Unicode.GetString(bytes);
        }
    }
}
