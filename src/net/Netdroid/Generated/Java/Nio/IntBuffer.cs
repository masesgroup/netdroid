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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio
{
    #region IntBuffer
    public partial class IntBuffer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.IntBuffer"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Nio.IntBuffer t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#allocate(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public static Java.Nio.IntBuffer Allocate(int arg0)
        {
            return SExecuteWithSignature<Java.Nio.IntBuffer>(LocalBridgeClazz, "allocate", "(I)Ljava/nio/IntBuffer;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#wrap(int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public static Java.Nio.IntBuffer Wrap(int[] arg0, int arg1, int arg2)
        {
            return SExecute<Java.Nio.IntBuffer>(LocalBridgeClazz, "wrap", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#wrap(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public static Java.Nio.IntBuffer Wrap(int[] arg0)
        {
            return SExecuteWithSignature<Java.Nio.IntBuffer>(LocalBridgeClazz, "wrap", "([I)Ljava/nio/IntBuffer;", new object[] { arg0 });
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#get()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Get()
        {
            return IExecuteWithSignature<int>("get", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Get(int arg0)
        {
            return IExecuteWithSignature<int>("get", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#order()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.ByteOrder"/></returns>
        public Java.Nio.ByteOrder Order()
        {
            return IExecuteWithSignature<Java.Nio.ByteOrder>("order", "()Ljava/nio/ByteOrder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#asReadOnlyBuffer()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer AsReadOnlyBuffer()
        {
            return IExecuteWithSignature<Java.Nio.IntBuffer>("asReadOnlyBuffer", "()Ljava/nio/IntBuffer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#compact()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Compact()
        {
            return IExecuteWithSignature<Java.Nio.IntBuffer>("compact", "()Ljava/nio/IntBuffer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#put(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Put(int arg0, int arg1)
        {
            return IExecute<Java.Nio.IntBuffer>("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#put(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Put(int arg0)
        {
            return IExecuteWithSignature<Java.Nio.IntBuffer>("put", "(I)Ljava/nio/IntBuffer;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#put(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Put(int[] arg0)
        {
            return IExecuteWithSignature<Java.Nio.IntBuffer>("put", "([I)Ljava/nio/IntBuffer;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#compareTo(java.nio.IntBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.IntBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Nio.IntBuffer arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/nio/IntBuffer;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#mismatch(java.nio.IntBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.IntBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        public int Mismatch(Java.Nio.IntBuffer arg0)
        {
            return IExecuteWithSignature<int>("mismatch", "(Ljava/nio/IntBuffer;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#get(int,int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Get(int arg0, int[] arg1, int arg2, int arg3)
        {
            return IExecute<Java.Nio.IntBuffer>("get", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#get(int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Get(int arg0, int[] arg1)
        {
            return IExecute<Java.Nio.IntBuffer>("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#get(int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Get(int[] arg0, int arg1, int arg2)
        {
            return IExecute<Java.Nio.IntBuffer>("get", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#get(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Get(int[] arg0)
        {
            return IExecuteWithSignature<Java.Nio.IntBuffer>("get", "([I)Ljava/nio/IntBuffer;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#put(int,int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Put(int arg0, int[] arg1, int arg2, int arg3)
        {
            return IExecute<Java.Nio.IntBuffer>("put", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#put(int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Put(int arg0, int[] arg1)
        {
            return IExecute<Java.Nio.IntBuffer>("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#put(int,java.nio.IntBuffer,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Nio.IntBuffer"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Put(int arg0, Java.Nio.IntBuffer arg1, int arg2, int arg3)
        {
            return IExecute<Java.Nio.IntBuffer>("put", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#put(int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Put(int[] arg0, int arg1, int arg2)
        {
            return IExecute<Java.Nio.IntBuffer>("put", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/IntBuffer.html#put(java.nio.IntBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.IntBuffer"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Put(Java.Nio.IntBuffer arg0)
        {
            return IExecuteWithSignature<Java.Nio.IntBuffer>("put", "(Ljava/nio/IntBuffer;)Ljava/nio/IntBuffer;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}