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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio
{
    #region DoubleBuffer
    public partial class DoubleBuffer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.DoubleBuffer"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Nio.DoubleBuffer t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/DoubleBuffer.html#allocate(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.DoubleBuffer"/></returns>
        public static Java.Nio.DoubleBuffer Allocate(int arg0)
        {
            return SExecuteWithSignature<Java.Nio.DoubleBuffer>(LocalBridgeClazz, "allocate", "(I)Ljava/nio/DoubleBuffer;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/DoubleBuffer.html#wrap(double[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.DoubleBuffer"/></returns>
        public static Java.Nio.DoubleBuffer Wrap(double[] arg0, int arg1, int arg2)
        {
            return SExecute<Java.Nio.DoubleBuffer>(LocalBridgeClazz, "wrap", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/DoubleBuffer.html#wrap(double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Java.Nio.DoubleBuffer"/></returns>
        public static Java.Nio.DoubleBuffer Wrap(double[] arg0)
        {
            return SExecuteWithSignature<Java.Nio.DoubleBuffer>(LocalBridgeClazz, "wrap", "([D)Ljava/nio/DoubleBuffer;", new object[] { arg0 });
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/DoubleBuffer.html#get()"/>
        /// </summary>
        /// <returns><see cref="double"/></returns>
        public double Get()
        {
            return IExecuteWithSignature<double>("get", "()D");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/DoubleBuffer.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="double"/></returns>
        public double Get(int arg0)
        {
            return IExecuteWithSignature<double>("get", "(I)D", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/DoubleBuffer.html#order()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.ByteOrder"/></returns>
        public Java.Nio.ByteOrder Order()
        {
            return IExecuteWithSignature<Java.Nio.ByteOrder>("order", "()Ljava/nio/ByteOrder;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/DoubleBuffer.html#asReadOnlyBuffer()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.DoubleBuffer"/></returns>
        public Java.Nio.DoubleBuffer AsReadOnlyBuffer()
        {
            return IExecuteWithSignature<Java.Nio.DoubleBuffer>("asReadOnlyBuffer", "()Ljava/nio/DoubleBuffer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/DoubleBuffer.html#compact()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.DoubleBuffer"/></returns>
        public Java.Nio.DoubleBuffer Compact()
        {
            return IExecuteWithSignature<Java.Nio.DoubleBuffer>("compact", "()Ljava/nio/DoubleBuffer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/DoubleBuffer.html#put(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Java.Nio.DoubleBuffer"/></returns>
        public Java.Nio.DoubleBuffer Put(double arg0)
        {
            return IExecuteWithSignature<Java.Nio.DoubleBuffer>("put", "(D)Ljava/nio/DoubleBuffer;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/DoubleBuffer.html#put(int,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="Java.Nio.DoubleBuffer"/></returns>
        public Java.Nio.DoubleBuffer Put(int arg0, double arg1)
        {
            return IExecute<Java.Nio.DoubleBuffer>("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/DoubleBuffer.html#put(double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Java.Nio.DoubleBuffer"/></returns>
        public Java.Nio.DoubleBuffer Put(double[] arg0)
        {
            return IExecuteWithSignature<Java.Nio.DoubleBuffer>("put", "([D)Ljava/nio/DoubleBuffer;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/DoubleBuffer.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/DoubleBuffer.html#compareTo(java.nio.DoubleBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.DoubleBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Nio.DoubleBuffer arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/nio/DoubleBuffer;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/DoubleBuffer.html#mismatch(java.nio.DoubleBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.DoubleBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        public int Mismatch(Java.Nio.DoubleBuffer arg0)
        {
            return IExecuteWithSignature<int>("mismatch", "(Ljava/nio/DoubleBuffer;)I", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/DoubleBuffer.html#get(double[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.DoubleBuffer"/></returns>
        public Java.Nio.DoubleBuffer Get(double[] arg0, int arg1, int arg2)
        {
            return IExecute<Java.Nio.DoubleBuffer>("get", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/DoubleBuffer.html#get(double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Java.Nio.DoubleBuffer"/></returns>
        public Java.Nio.DoubleBuffer Get(double[] arg0)
        {
            return IExecuteWithSignature<Java.Nio.DoubleBuffer>("get", "([D)Ljava/nio/DoubleBuffer;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/DoubleBuffer.html#get(int,double[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.DoubleBuffer"/></returns>
        public Java.Nio.DoubleBuffer Get(int arg0, double[] arg1, int arg2, int arg3)
        {
            return IExecute<Java.Nio.DoubleBuffer>("get", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/DoubleBuffer.html#get(int,double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="Java.Nio.DoubleBuffer"/></returns>
        public Java.Nio.DoubleBuffer Get(int arg0, double[] arg1)
        {
            return IExecute<Java.Nio.DoubleBuffer>("get", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/DoubleBuffer.html#put(double[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.DoubleBuffer"/></returns>
        public Java.Nio.DoubleBuffer Put(double[] arg0, int arg1, int arg2)
        {
            return IExecute<Java.Nio.DoubleBuffer>("put", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/DoubleBuffer.html#put(int,double[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.DoubleBuffer"/></returns>
        public Java.Nio.DoubleBuffer Put(int arg0, double[] arg1, int arg2, int arg3)
        {
            return IExecute<Java.Nio.DoubleBuffer>("put", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/DoubleBuffer.html#put(int,double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="Java.Nio.DoubleBuffer"/></returns>
        public Java.Nio.DoubleBuffer Put(int arg0, double[] arg1)
        {
            return IExecute<Java.Nio.DoubleBuffer>("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/DoubleBuffer.html#put(int,java.nio.DoubleBuffer,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Nio.DoubleBuffer"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.DoubleBuffer"/></returns>
        public Java.Nio.DoubleBuffer Put(int arg0, Java.Nio.DoubleBuffer arg1, int arg2, int arg3)
        {
            return IExecute<Java.Nio.DoubleBuffer>("put", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/DoubleBuffer.html#put(java.nio.DoubleBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.DoubleBuffer"/></param>
        /// <returns><see cref="Java.Nio.DoubleBuffer"/></returns>
        public Java.Nio.DoubleBuffer Put(Java.Nio.DoubleBuffer arg0)
        {
            return IExecuteWithSignature<Java.Nio.DoubleBuffer>("put", "(Ljava/nio/DoubleBuffer;)Ljava/nio/DoubleBuffer;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}