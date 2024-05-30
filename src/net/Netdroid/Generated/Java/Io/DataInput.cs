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

namespace Java.Io
{
    #region IDataInput
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDataInput
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readBoolean()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        bool ReadBoolean();
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readByte()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        byte ReadByte();
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readChar()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        char ReadChar();
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readDouble()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        double ReadDouble();
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readFloat()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        float ReadFloat();
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readInt()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        int ReadInt();
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readUnsignedByte()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        int ReadUnsignedByte();
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readUnsignedShort()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        int ReadUnsignedShort();
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#skipBytes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        int SkipBytes(int arg0);
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readLine()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Lang.String ReadLine();
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readUTF()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Lang.String ReadUTF();
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        long ReadLong();
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readShort()"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        short ReadShort();
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readFully(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void ReadFully(byte[] arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readFully(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        void ReadFully(byte[] arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DataInput
    public partial class DataInput : Java.Io.IDataInput
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readBoolean()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool ReadBoolean()
        {
            return IExecuteWithSignature<bool>("readBoolean", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readByte()"/>
        /// </summary>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public byte ReadByte()
        {
            return IExecuteWithSignature<byte>("readByte", "()B");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readChar()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public char ReadChar()
        {
            return IExecuteWithSignature<char>("readChar", "()C");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readDouble()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public double ReadDouble()
        {
            return IExecuteWithSignature<double>("readDouble", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readFloat()"/>
        /// </summary>
        /// <returns><see cref="float"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public float ReadFloat()
        {
            return IExecuteWithSignature<float>("readFloat", "()F");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readInt()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int ReadInt()
        {
            return IExecuteWithSignature<int>("readInt", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readUnsignedByte()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int ReadUnsignedByte()
        {
            return IExecuteWithSignature<int>("readUnsignedByte", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readUnsignedShort()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int ReadUnsignedShort()
        {
            return IExecuteWithSignature<int>("readUnsignedShort", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#skipBytes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int SkipBytes(int arg0)
        {
            return IExecuteWithSignature<int>("skipBytes", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readLine()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.String ReadLine()
        {
            return IExecuteWithSignature<Java.Lang.String>("readLine", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readUTF()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.String ReadUTF()
        {
            return IExecuteWithSignature<Java.Lang.String>("readUTF", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readLong()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long ReadLong()
        {
            return IExecuteWithSignature<long>("readLong", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readShort()"/>
        /// </summary>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public short ReadShort()
        {
            return IExecuteWithSignature<short>("readShort", "()S");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readFully(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(byte[] arg0, int arg1, int arg2)
        {
            IExecute("readFully", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java.base/java/io/DataInput.html#readFully(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(byte[] arg0)
        {
            IExecuteWithSignature("readFully", "([B)V", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}