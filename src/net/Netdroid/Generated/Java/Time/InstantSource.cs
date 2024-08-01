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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using android.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Time
{
    #region IInstantSource
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IInstantSource
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region InstantSource
    public partial class InstantSource : Java.Time.IInstantSource
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/InstantSource.html#fixed(java.time.Instant)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Java.Time.InstantSource"/></returns>
        public static Java.Time.InstantSource Fixed(Java.Time.Instant arg0)
        {
            return SExecuteWithSignature<Java.Time.InstantSource>(LocalBridgeClazz, "fixed", "(Ljava/time/Instant;)Ljava/time/InstantSource;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/InstantSource.html#offset(java.time.InstantSource,java.time.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.InstantSource"/></param>
        /// <param name="arg1"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="Java.Time.InstantSource"/></returns>
        public static Java.Time.InstantSource Offset(Java.Time.InstantSource arg0, Java.Time.Duration arg1)
        {
            return SExecute<Java.Time.InstantSource>(LocalBridgeClazz, "offset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/InstantSource.html#system()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.InstantSource"/></returns>
        public static Java.Time.InstantSource System()
        {
            return SExecuteWithSignature<Java.Time.InstantSource>(LocalBridgeClazz, "system", "()Ljava/time/InstantSource;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/InstantSource.html#tick(java.time.InstantSource,java.time.Duration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.InstantSource"/></param>
        /// <param name="arg1"><see cref="Java.Time.Duration"/></param>
        /// <returns><see cref="Java.Time.InstantSource"/></returns>
        public static Java.Time.InstantSource Tick(Java.Time.InstantSource arg0, Java.Time.Duration arg1)
        {
            return SExecute<Java.Time.InstantSource>(LocalBridgeClazz, "tick", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/InstantSource.html#instant()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Instant"/></returns>
        public Java.Time.Instant Instant()
        {
            return IExecuteWithSignature<Java.Time.Instant>("instant", "()Ljava/time/Instant;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/InstantSource.html#withZone(java.time.ZoneId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.ZoneId"/></param>
        /// <returns><see cref="Java.Time.Clock"/></returns>
        public Java.Time.Clock WithZone(Java.Time.ZoneId arg0)
        {
            return IExecuteWithSignature<Java.Time.Clock>("withZone", "(Ljava/time/ZoneId;)Ljava/time/Clock;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/InstantSource.html#millis()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Millis()
        {
            return IExecuteWithSignature<long>("millis", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}