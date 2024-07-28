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

namespace Android.Os
{
    #region Message
    public partial class Message
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#replyTo"/>
        /// </summary>
        public Android.Os.Messenger replyTo { get { return IGetField<Android.Os.Messenger>("replyTo"); } set { ISetField("replyTo", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#arg1"/>
        /// </summary>
        public int arg1 { get { return IGetField<int>("arg1"); } set { ISetField("arg1", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#arg2"/>
        /// </summary>
        public int arg2 { get { return IGetField<int>("arg2"); } set { ISetField("arg2", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#sendingUid"/>
        /// </summary>
        public int sendingUid { get { return IGetField<int>("sendingUid"); } set { ISetField("sendingUid", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#what"/>
        /// </summary>
        public int what { get { return IGetField<int>("what"); } set { ISetField("what", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#obj"/>
        /// </summary>
        public object obj { get { return IGetField("obj"); } set { ISetField("obj", value); } }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#CREATOR"/>
        /// </summary>
        public static Android.Os.Parcelable.Creator CREATOR { get { if (!_CREATORReady) { _CREATORContent = SGetField<Android.Os.Parcelable.Creator>(LocalBridgeClazz, "CREATOR"); _CREATORReady = true; } return _CREATORContent; } }
        private static Android.Os.Parcelable.Creator _CREATORContent = default;
        private static bool _CREATORReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#obtain()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Message"/></returns>
        public static Android.Os.Message Obtain()
        {
            return SExecuteWithSignature<Android.Os.Message>(LocalBridgeClazz, "obtain", "()Landroid/os/Message;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#obtain(android.os.Handler,int,int,int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Handler"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        /// <returns><see cref="Android.Os.Message"/></returns>
        public static Android.Os.Message Obtain(Android.Os.Handler arg0, int arg1, int arg2, int arg3, object arg4)
        {
            return SExecute<Android.Os.Message>(LocalBridgeClazz, "obtain", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#obtain(android.os.Handler,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Handler"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Android.Os.Message"/></returns>
        public static Android.Os.Message Obtain(Android.Os.Handler arg0, int arg1, int arg2, int arg3)
        {
            return SExecute<Android.Os.Message>(LocalBridgeClazz, "obtain", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#obtain(android.os.Handler,int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Handler"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="Android.Os.Message"/></returns>
        public static Android.Os.Message Obtain(Android.Os.Handler arg0, int arg1, object arg2)
        {
            return SExecute<Android.Os.Message>(LocalBridgeClazz, "obtain", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#obtain(android.os.Handler,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Handler"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Android.Os.Message"/></returns>
        public static Android.Os.Message Obtain(Android.Os.Handler arg0, int arg1)
        {
            return SExecute<Android.Os.Message>(LocalBridgeClazz, "obtain", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#obtain(android.os.Handler,java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Handler"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Android.Os.Message"/></returns>
        public static Android.Os.Message Obtain(Android.Os.Handler arg0, Java.Lang.Runnable arg1)
        {
            return SExecute<Android.Os.Message>(LocalBridgeClazz, "obtain", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#obtain(android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Handler"/></param>
        /// <returns><see cref="Android.Os.Message"/></returns>
        public static Android.Os.Message Obtain(Android.Os.Handler arg0)
        {
            return SExecuteWithSignature<Android.Os.Message>(LocalBridgeClazz, "obtain", "(Landroid/os/Handler;)Landroid/os/Message;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#obtain(android.os.Message)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Message"/></param>
        /// <returns><see cref="Android.Os.Message"/></returns>
        public static Android.Os.Message Obtain(Android.Os.Message arg0)
        {
            return SExecuteWithSignature<Android.Os.Message>(LocalBridgeClazz, "obtain", "(Landroid/os/Message;)Landroid/os/Message;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#getData()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle GetData()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("getData", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#peekData()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Bundle"/></returns>
        public Android.Os.Bundle PeekData()
        {
            return IExecuteWithSignature<Android.Os.Bundle>("peekData", "()Landroid/os/Bundle;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#getTarget()"/>
        /// </summary>
        /// <returns><see cref="Android.Os.Handler"/></returns>
        public Android.Os.Handler GetTarget()
        {
            return IExecuteWithSignature<Android.Os.Handler>("getTarget", "()Landroid/os/Handler;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#isAsynchronous()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAsynchronous()
        {
            return IExecuteWithSignature<bool>("isAsynchronous", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#describeContents()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int DescribeContents()
        {
            return IExecuteWithSignature<int>("describeContents", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#getCallback()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Runnable"/></returns>
        public Java.Lang.Runnable GetCallback()
        {
            return IExecuteWithSignature<Java.Lang.Runnable>("getCallback", "()Ljava/lang/Runnable;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#getWhen()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GetWhen()
        {
            return IExecuteWithSignature<long>("getWhen", "()J");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#copyFrom(android.os.Message)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Message"/></param>
        public void CopyFrom(Android.Os.Message arg0)
        {
            IExecuteWithSignature("copyFrom", "(Landroid/os/Message;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#recycle()"/>
        /// </summary>
        public void Recycle()
        {
            IExecuteWithSignature("recycle", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#sendToTarget()"/>
        /// </summary>
        public void SendToTarget()
        {
            IExecuteWithSignature("sendToTarget", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#setAsynchronous(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAsynchronous(bool arg0)
        {
            IExecuteWithSignature("setAsynchronous", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#setData(android.os.Bundle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Bundle"/></param>
        public void SetData(Android.Os.Bundle arg0)
        {
            IExecuteWithSignature("setData", "(Landroid/os/Bundle;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#setTarget(android.os.Handler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Android.Os.Handler"/></param>
        public void SetTarget(Android.Os.Handler arg0)
        {
            IExecuteWithSignature("setTarget", "(Landroid/os/Handler;)V", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/os/Message.html#writeToParcel(android.os.Parcel,int)"/>
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