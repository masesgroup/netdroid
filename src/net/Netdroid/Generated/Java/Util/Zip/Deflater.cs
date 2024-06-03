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

namespace Java.Util.Zip
{
    #region Deflater
    public partial class Deflater
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#%3Cinit%3E(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public Deflater(int arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public Deflater(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#BEST_COMPRESSION"/>
        /// </summary>
        public static int BEST_COMPRESSION { get { if (!_BEST_COMPRESSIONReady) { _BEST_COMPRESSIONContent = SGetField<int>(LocalBridgeClazz, "BEST_COMPRESSION"); _BEST_COMPRESSIONReady = true; } return _BEST_COMPRESSIONContent; } }
        private static int _BEST_COMPRESSIONContent = default;
        private static bool _BEST_COMPRESSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#BEST_SPEED"/>
        /// </summary>
        public static int BEST_SPEED { get { if (!_BEST_SPEEDReady) { _BEST_SPEEDContent = SGetField<int>(LocalBridgeClazz, "BEST_SPEED"); _BEST_SPEEDReady = true; } return _BEST_SPEEDContent; } }
        private static int _BEST_SPEEDContent = default;
        private static bool _BEST_SPEEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#DEFAULT_COMPRESSION"/>
        /// </summary>
        public static int DEFAULT_COMPRESSION { get { if (!_DEFAULT_COMPRESSIONReady) { _DEFAULT_COMPRESSIONContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_COMPRESSION"); _DEFAULT_COMPRESSIONReady = true; } return _DEFAULT_COMPRESSIONContent; } }
        private static int _DEFAULT_COMPRESSIONContent = default;
        private static bool _DEFAULT_COMPRESSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#DEFAULT_STRATEGY"/>
        /// </summary>
        public static int DEFAULT_STRATEGY { get { if (!_DEFAULT_STRATEGYReady) { _DEFAULT_STRATEGYContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_STRATEGY"); _DEFAULT_STRATEGYReady = true; } return _DEFAULT_STRATEGYContent; } }
        private static int _DEFAULT_STRATEGYContent = default;
        private static bool _DEFAULT_STRATEGYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#DEFLATED"/>
        /// </summary>
        public static int DEFLATED { get { if (!_DEFLATEDReady) { _DEFLATEDContent = SGetField<int>(LocalBridgeClazz, "DEFLATED"); _DEFLATEDReady = true; } return _DEFLATEDContent; } }
        private static int _DEFLATEDContent = default;
        private static bool _DEFLATEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#FILTERED"/>
        /// </summary>
        public static int FILTERED { get { if (!_FILTEREDReady) { _FILTEREDContent = SGetField<int>(LocalBridgeClazz, "FILTERED"); _FILTEREDReady = true; } return _FILTEREDContent; } }
        private static int _FILTEREDContent = default;
        private static bool _FILTEREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#FULL_FLUSH"/>
        /// </summary>
        public static int FULL_FLUSH { get { if (!_FULL_FLUSHReady) { _FULL_FLUSHContent = SGetField<int>(LocalBridgeClazz, "FULL_FLUSH"); _FULL_FLUSHReady = true; } return _FULL_FLUSHContent; } }
        private static int _FULL_FLUSHContent = default;
        private static bool _FULL_FLUSHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#HUFFMAN_ONLY"/>
        /// </summary>
        public static int HUFFMAN_ONLY { get { if (!_HUFFMAN_ONLYReady) { _HUFFMAN_ONLYContent = SGetField<int>(LocalBridgeClazz, "HUFFMAN_ONLY"); _HUFFMAN_ONLYReady = true; } return _HUFFMAN_ONLYContent; } }
        private static int _HUFFMAN_ONLYContent = default;
        private static bool _HUFFMAN_ONLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#NO_COMPRESSION"/>
        /// </summary>
        public static int NO_COMPRESSION { get { if (!_NO_COMPRESSIONReady) { _NO_COMPRESSIONContent = SGetField<int>(LocalBridgeClazz, "NO_COMPRESSION"); _NO_COMPRESSIONReady = true; } return _NO_COMPRESSIONContent; } }
        private static int _NO_COMPRESSIONContent = default;
        private static bool _NO_COMPRESSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#NO_FLUSH"/>
        /// </summary>
        public static int NO_FLUSH { get { if (!_NO_FLUSHReady) { _NO_FLUSHContent = SGetField<int>(LocalBridgeClazz, "NO_FLUSH"); _NO_FLUSHReady = true; } return _NO_FLUSHContent; } }
        private static int _NO_FLUSHContent = default;
        private static bool _NO_FLUSHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#SYNC_FLUSH"/>
        /// </summary>
        public static int SYNC_FLUSH { get { if (!_SYNC_FLUSHReady) { _SYNC_FLUSHContent = SGetField<int>(LocalBridgeClazz, "SYNC_FLUSH"); _SYNC_FLUSHReady = true; } return _SYNC_FLUSHContent; } }
        private static int _SYNC_FLUSHContent = default;
        private static bool _SYNC_FLUSHReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#finished()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Finished()
        {
            return IExecuteWithSignature<bool>("finished", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#needsInput()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool NeedsInput()
        {
            return IExecuteWithSignature<bool>("needsInput", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#deflate(byte[],int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Deflate(byte[] arg0, int arg1, int arg2, int arg3)
        {
            return IExecute<int>("deflate", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#deflate(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Deflate(byte[] arg0, int arg1, int arg2)
        {
            return IExecute<int>("deflate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#deflate(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="int"/></returns>
        public int Deflate(byte[] arg0)
        {
            return IExecuteWithSignature<int>("deflate", "([B)I", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#deflate(java.nio.ByteBuffer,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Deflate(Java.Nio.ByteBuffer arg0, int arg1)
        {
            return IExecute<int>("deflate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#deflate(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        public int Deflate(Java.Nio.ByteBuffer arg0)
        {
            return IExecuteWithSignature<int>("deflate", "(Ljava/nio/ByteBuffer;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#getAdler()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetAdler()
        {
            return IExecuteWithSignature<int>("getAdler", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#getTotalIn()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTotalIn()
        {
            return IExecuteWithSignature<int>("getTotalIn", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#getTotalOut()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetTotalOut()
        {
            return IExecuteWithSignature<int>("getTotalOut", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#getBytesRead()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetBytesRead()
        {
            return IExecuteWithSignature<long>("getBytesRead", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#getBytesWritten()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetBytesWritten()
        {
            return IExecuteWithSignature<long>("getBytesWritten", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#end()"/>
        /// </summary>
        public void End()
        {
            IExecuteWithSignature("end", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#finish()"/>
        /// </summary>
        public void Finish()
        {
            IExecuteWithSignature("finish", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#setDictionary(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetDictionary(byte[] arg0, int arg1, int arg2)
        {
            IExecute("setDictionary", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#setDictionary(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public void SetDictionary(byte[] arg0)
        {
            IExecuteWithSignature("setDictionary", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#setDictionary(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        public void SetDictionary(Java.Nio.ByteBuffer arg0)
        {
            IExecuteWithSignature("setDictionary", "(Ljava/nio/ByteBuffer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#setInput(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetInput(byte[] arg0, int arg1, int arg2)
        {
            IExecute("setInput", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#setInput(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public void SetInput(byte[] arg0)
        {
            IExecuteWithSignature("setInput", "([B)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#setInput(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        public void SetInput(Java.Nio.ByteBuffer arg0)
        {
            IExecuteWithSignature("setInput", "(Ljava/nio/ByteBuffer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#setLevel(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetLevel(int arg0)
        {
            IExecuteWithSignature("setLevel", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/util/zip/Deflater.html#setStrategy(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetStrategy(int arg0)
        {
            IExecuteWithSignature("setStrategy", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}