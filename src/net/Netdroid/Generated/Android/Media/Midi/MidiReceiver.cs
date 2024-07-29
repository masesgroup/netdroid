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

namespace Android.Media.Midi
{
    #region MidiReceiver
    public partial class MidiReceiver
    {
        #region Constructors
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiReceiver.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public MidiReceiver(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiReceiver.html#onSend(byte[],int,int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void OnSend(byte[] arg0, int arg1, int arg2, long arg3)
        {
            IExecute("onSend", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiReceiver.html#getMaxMessageSize()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetMaxMessageSize()
        {
            return IExecuteWithSignature<int>("getMaxMessageSize", "()I");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiReceiver.html#flush()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Flush()
        {
            IExecuteWithSignature("flush", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiReceiver.html#onFlush()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void OnFlush()
        {
            IExecuteWithSignature("onFlush", "()V");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiReceiver.html#send(byte[],int,int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Send(byte[] arg0, int arg1, int arg2, long arg3)
        {
            IExecute("send", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/media/midi/MidiReceiver.html#send(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Send(byte[] arg0, int arg1, int arg2)
        {
            IExecute("send", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}