/*
*  Copyright 2024 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Android.Nfc.Tech
{
    #region MifareClassic
    public partial class MifareClassic
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#KEY_DEFAULT"/>
        /// </summary>
        public static byte[] KEY_DEFAULT { get { if (!_KEY_DEFAULTReady) { _KEY_DEFAULTContent = SGetFieldArray<byte>(LocalBridgeClazz, "KEY_DEFAULT"); _KEY_DEFAULTReady = true; } return _KEY_DEFAULTContent; } }
        private static byte[] _KEY_DEFAULTContent = default;
        private static bool _KEY_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#KEY_MIFARE_APPLICATION_DIRECTORY"/>
        /// </summary>
        public static byte[] KEY_MIFARE_APPLICATION_DIRECTORY { get { if (!_KEY_MIFARE_APPLICATION_DIRECTORYReady) { _KEY_MIFARE_APPLICATION_DIRECTORYContent = SGetFieldArray<byte>(LocalBridgeClazz, "KEY_MIFARE_APPLICATION_DIRECTORY"); _KEY_MIFARE_APPLICATION_DIRECTORYReady = true; } return _KEY_MIFARE_APPLICATION_DIRECTORYContent; } }
        private static byte[] _KEY_MIFARE_APPLICATION_DIRECTORYContent = default;
        private static bool _KEY_MIFARE_APPLICATION_DIRECTORYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#KEY_NFC_FORUM"/>
        /// </summary>
        public static byte[] KEY_NFC_FORUM { get { if (!_KEY_NFC_FORUMReady) { _KEY_NFC_FORUMContent = SGetFieldArray<byte>(LocalBridgeClazz, "KEY_NFC_FORUM"); _KEY_NFC_FORUMReady = true; } return _KEY_NFC_FORUMContent; } }
        private static byte[] _KEY_NFC_FORUMContent = default;
        private static bool _KEY_NFC_FORUMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#BLOCK_SIZE"/>
        /// </summary>
        public static int BLOCK_SIZE { get { if (!_BLOCK_SIZEReady) { _BLOCK_SIZEContent = SGetField<int>(LocalBridgeClazz, "BLOCK_SIZE"); _BLOCK_SIZEReady = true; } return _BLOCK_SIZEContent; } }
        private static int _BLOCK_SIZEContent = default;
        private static bool _BLOCK_SIZEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#SIZE_1K"/>
        /// </summary>
        public static int SIZE_1K { get { if (!_SIZE_1KReady) { _SIZE_1KContent = SGetField<int>(LocalBridgeClazz, "SIZE_1K"); _SIZE_1KReady = true; } return _SIZE_1KContent; } }
        private static int _SIZE_1KContent = default;
        private static bool _SIZE_1KReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#SIZE_2K"/>
        /// </summary>
        public static int SIZE_2K { get { if (!_SIZE_2KReady) { _SIZE_2KContent = SGetField<int>(LocalBridgeClazz, "SIZE_2K"); _SIZE_2KReady = true; } return _SIZE_2KContent; } }
        private static int _SIZE_2KContent = default;
        private static bool _SIZE_2KReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#SIZE_4K"/>
        /// </summary>
        public static int SIZE_4K { get { if (!_SIZE_4KReady) { _SIZE_4KContent = SGetField<int>(LocalBridgeClazz, "SIZE_4K"); _SIZE_4KReady = true; } return _SIZE_4KContent; } }
        private static int _SIZE_4KContent = default;
        private static bool _SIZE_4KReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#SIZE_MINI"/>
        /// </summary>
        public static int SIZE_MINI { get { if (!_SIZE_MINIReady) { _SIZE_MINIContent = SGetField<int>(LocalBridgeClazz, "SIZE_MINI"); _SIZE_MINIReady = true; } return _SIZE_MINIContent; } }
        private static int _SIZE_MINIContent = default;
        private static bool _SIZE_MINIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#TYPE_CLASSIC"/>
        /// </summary>
        public static int TYPE_CLASSIC { get { if (!_TYPE_CLASSICReady) { _TYPE_CLASSICContent = SGetField<int>(LocalBridgeClazz, "TYPE_CLASSIC"); _TYPE_CLASSICReady = true; } return _TYPE_CLASSICContent; } }
        private static int _TYPE_CLASSICContent = default;
        private static bool _TYPE_CLASSICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#TYPE_PLUS"/>
        /// </summary>
        public static int TYPE_PLUS { get { if (!_TYPE_PLUSReady) { _TYPE_PLUSContent = SGetField<int>(LocalBridgeClazz, "TYPE_PLUS"); _TYPE_PLUSReady = true; } return _TYPE_PLUSContent; } }
        private static int _TYPE_PLUSContent = default;
        private static bool _TYPE_PLUSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#TYPE_PRO"/>
        /// </summary>
        public static int TYPE_PRO { get { if (!_TYPE_PROReady) { _TYPE_PROContent = SGetField<int>(LocalBridgeClazz, "TYPE_PRO"); _TYPE_PROReady = true; } return _TYPE_PROContent; } }
        private static int _TYPE_PROContent = default;
        private static bool _TYPE_PROReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#TYPE_UNKNOWN"/>
        /// </summary>
        public static int TYPE_UNKNOWN { get { if (!_TYPE_UNKNOWNReady) { _TYPE_UNKNOWNContent = SGetField<int>(LocalBridgeClazz, "TYPE_UNKNOWN"); _TYPE_UNKNOWNReady = true; } return _TYPE_UNKNOWNContent; } }
        private static int _TYPE_UNKNOWNContent = default;
        private static bool _TYPE_UNKNOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#get(android.nfc.Tag)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Nfc.Tag"/></param>
        /// <returns><see cref="Android.Nfc.Tech.MifareClassic"/></returns>
        public static Android.Nfc.Tech.MifareClassic Get(Android.Nfc.Tag arg0)
        {
            return SExecuteWithSignature<Android.Nfc.Tech.MifareClassic>(LocalBridgeClazz, "get", "(Landroid/nfc/Tag;)Landroid/nfc/tech/MifareClassic;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#getBlockCount()"/> 
        /// </summary>
        public int BlockCount
        {
            get { return IExecuteWithSignature<int>("getBlockCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#getMaxTransceiveLength()"/> 
        /// </summary>
        public int MaxTransceiveLength
        {
            get { return IExecuteWithSignature<int>("getMaxTransceiveLength", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#getSectorCount()"/> 
        /// </summary>
        public int SectorCount
        {
            get { return IExecuteWithSignature<int>("getSectorCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#getSize()"/> 
        /// </summary>
        public int Size
        {
            get { return IExecuteWithSignature<int>("getSize", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#getTag()"/> 
        /// </summary>
        public Android.Nfc.Tag Tag
        {
            get { return IExecuteWithSignature<Android.Nfc.Tag>("getTag", "()Landroid/nfc/Tag;"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#getTimeout()"/> <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#setTimeout(int)"/>
        /// </summary>
        public int Timeout
        {
            get { return IExecuteWithSignature<int>("getTimeout", "()I"); } set { IExecuteWithSignature("setTimeout", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#getType()"/> 
        /// </summary>
        public int Type
        {
            get { return IExecuteWithSignature<int>("getType", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#authenticateSectorWithKeyA(int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool AuthenticateSectorWithKeyA(int arg0, byte[] arg1)
        {
            return IExecute<bool>("authenticateSectorWithKeyA", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#authenticateSectorWithKeyB(int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool AuthenticateSectorWithKeyB(int arg0, byte[] arg1)
        {
            return IExecute<bool>("authenticateSectorWithKeyB", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#isConnected()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsConnected()
        {
            return IExecuteWithSignature<bool>("isConnected", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#readBlock(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public byte[] ReadBlock(int arg0)
        {
            return IExecuteWithSignatureArray<byte>("readBlock", "(I)[B", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#transceive(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public byte[] Transceive(byte[] arg0)
        {
            return IExecuteWithSignatureArray<byte>("transceive", "([B)[B", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#blockToSector(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int BlockToSector(int arg0)
        {
            return IExecuteWithSignature<int>("blockToSector", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#getBlockCountInSector(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetBlockCountInSector(int arg0)
        {
            return IExecuteWithSignature<int>("getBlockCountInSector", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#sectorToBlock(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int SectorToBlock(int arg0)
        {
            return IExecuteWithSignature<int>("sectorToBlock", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#connect()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Connect()
        {
            IExecuteWithSignature("connect", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#decrement(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Decrement(int arg0, int arg1)
        {
            IExecute("decrement", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#increment(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Increment(int arg0, int arg1)
        {
            IExecute("increment", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#restore(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Restore(int arg0)
        {
            IExecuteWithSignature("restore", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#transfer(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Transfer(int arg0)
        {
            IExecuteWithSignature("transfer", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/nfc/tech/MifareClassic.html#writeBlock(int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteBlock(int arg0, byte[] arg1)
        {
            IExecute("writeBlock", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}