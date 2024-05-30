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

namespace Android.Os
{
    #region SharedMemory
    public partial class SharedMemory : Android.Os.IParcelable, Java.Io.ICloseable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Android.Os.SharedMemory"/> to <see cref="Android.Os.Parcelable"/>
        /// </summary>
        public static implicit operator Android.Os.Parcelable(Android.Os.SharedMemory t) => t.Cast<Android.Os.Parcelable>();
        /// <summary>
        /// Converter from <see cref="Android.Os.SharedMemory"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Android.Os.SharedMemory t) => t.Cast<Java.Io.Closeable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SharedMemory.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SharedMemory.html#create(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Os.SharedMemory"/></returns>
        /// <exception cref="Android.System.ErrnoException"/>
        public static Android.Os.SharedMemory Create(Java.Lang.String arg0, int arg1)
        {
            return SExecute<Android.Os.SharedMemory>(LocalBridgeClazz, "create", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SharedMemory.html#fromFileDescriptor(android.os.ParcelFileDescriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.ParcelFileDescriptor"/></param>
        /// <returns><see cref="Android.Os.SharedMemory"/></returns>
        public static Android.Os.SharedMemory FromFileDescriptor(Android.Os.ParcelFileDescriptor arg0)
        {
            return SExecuteWithSignature<Android.Os.SharedMemory>(LocalBridgeClazz, "fromFileDescriptor", "(Landroid/os/ParcelFileDescriptor;)Landroid/os/SharedMemory;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SharedMemory.html#unmap(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        public static void Unmap(Java.Nio.ByteBuffer arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "unmap", "(Ljava/nio/ByteBuffer;)V", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SharedMemory.html#getSize()"/> 
        /// </summary>
        public int Size
        {
            get { return IExecuteWithSignature<int>("getSize", "()I"); }
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SharedMemory.html#setProtect(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetProtect(int arg0)
        {
            return IExecuteWithSignature<bool>("setProtect", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SharedMemory.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SharedMemory.html#map(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        /// <exception cref="Android.System.ErrnoException"/>
        public Java.Nio.ByteBuffer Map(int arg0, int arg1, int arg2)
        {
            return IExecute<Java.Nio.ByteBuffer>("map", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SharedMemory.html#mapReadOnly()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        /// <exception cref="Android.System.ErrnoException"/>
        public Java.Nio.ByteBuffer MapReadOnly()
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("mapReadOnly", "()Ljava/nio/ByteBuffer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SharedMemory.html#mapReadWrite()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.ByteBuffer"/></returns>
        /// <exception cref="Android.System.ErrnoException"/>
        public Java.Nio.ByteBuffer MapReadWrite()
        {
            return IExecuteWithSignature<Java.Nio.ByteBuffer>("mapReadWrite", "()Ljava/nio/ByteBuffer;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SharedMemory.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/SharedMemory.html#writeToParcel(android.os.Parcel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Parcel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void WriteToParcel(Android.Os.Parcel arg0, int arg1)
        {
            IExecute("writeToParcel", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}