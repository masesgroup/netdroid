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

namespace Java.Util.Concurrent
{
    #region ScheduledFuture
    public partial class ScheduledFuture
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ScheduledFuture"/> to <see cref="Java.Util.Concurrent.Delayed"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Delayed(Java.Util.Concurrent.ScheduledFuture t) => t.Cast<Java.Util.Concurrent.Delayed>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ScheduledFuture"/> to <see cref="Java.Util.Concurrent.Future"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Future(Java.Util.Concurrent.ScheduledFuture t) => t.Cast<Java.Util.Concurrent.Future>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IScheduledFuture<V>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IScheduledFuture<V>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ScheduledFuture<V>
    public partial class ScheduledFuture<V> : Java.Util.Concurrent.IScheduledFuture<V>, Java.Util.Concurrent.IDelayed, Java.Util.Concurrent.IFuture<V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ScheduledFuture{V}"/> to <see cref="Java.Util.Concurrent.Delayed"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Delayed(Java.Util.Concurrent.ScheduledFuture<V> t) => t.Cast<Java.Util.Concurrent.Delayed>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ScheduledFuture{V}"/> to <see cref="Java.Util.Concurrent.Future{V}"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Future<V>(Java.Util.Concurrent.ScheduledFuture<V> t) => t.Cast<Java.Util.Concurrent.Future<V>>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ScheduledFuture{V}"/> to <see cref="Java.Util.Concurrent.ScheduledFuture"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.ScheduledFuture(Java.Util.Concurrent.ScheduledFuture<V> t) => t.Cast<Java.Util.Concurrent.ScheduledFuture>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}