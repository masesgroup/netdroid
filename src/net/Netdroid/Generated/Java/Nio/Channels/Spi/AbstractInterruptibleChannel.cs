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
*  This file is generated by MASES.JNetReflector (ver. 2.5.2.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.Channels.Spi
{
    #region AbstractInterruptibleChannel
    public partial class AbstractInterruptibleChannel : Java.Nio.Channels.IChannel, Java.Nio.Channels.IInterruptibleChannel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.Spi.AbstractInterruptibleChannel"/> to <see cref="Java.Nio.Channels.Channel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.Channel(Java.Nio.Channels.Spi.AbstractInterruptibleChannel t) => t.Cast<Java.Nio.Channels.Channel>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.Spi.AbstractInterruptibleChannel"/> to <see cref="Java.Nio.Channels.InterruptibleChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.InterruptibleChannel(Java.Nio.Channels.Spi.AbstractInterruptibleChannel t) => t.Cast<Java.Nio.Channels.InterruptibleChannel>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/spi/AbstractInterruptibleChannel.html#isOpen()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOpen()
        {
            return IExecuteWithSignature<bool>("isOpen", "()Z");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/nio/channels/spi/AbstractInterruptibleChannel.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}