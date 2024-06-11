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

namespace Java.Time
{
    #region ZoneId
    public partial class ZoneId
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZoneId.html#SHORT_IDS"/>
        /// </summary>
        public static Java.Util.Map SHORT_IDS { get { if (!_SHORT_IDSReady) { _SHORT_IDSContent = SGetField<Java.Util.Map>(LocalBridgeClazz, "SHORT_IDS"); _SHORT_IDSReady = true; } return _SHORT_IDSContent; } }
        private static Java.Util.Map _SHORT_IDSContent = default;
        private static bool _SHORT_IDSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZoneId.html#from(java.time.temporal.TemporalAccessor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Temporal.TemporalAccessor"/></param>
        /// <returns><see cref="Java.Time.ZoneId"/></returns>
        public static Java.Time.ZoneId From(Java.Time.Temporal.TemporalAccessor arg0)
        {
            return SExecuteWithSignature<Java.Time.ZoneId>(LocalBridgeClazz, "from", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/ZoneId;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZoneId.html#of(java.lang.String,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Time.ZoneId"/></returns>
        public static Java.Time.ZoneId Of(Java.Lang.String arg0, Java.Util.Map<Java.Lang.String, Java.Lang.String> arg1)
        {
            return SExecute<Java.Time.ZoneId>(LocalBridgeClazz, "of", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZoneId.html#of(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Time.ZoneId"/></returns>
        public static Java.Time.ZoneId Of(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Time.ZoneId>(LocalBridgeClazz, "of", "(Ljava/lang/String;)Ljava/time/ZoneId;", arg0);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZoneId.html#ofOffset(java.lang.String,java.time.ZoneOffset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Time.ZoneOffset"/></param>
        /// <returns><see cref="Java.Time.ZoneId"/></returns>
        public static Java.Time.ZoneId OfOffset(Java.Lang.String arg0, Java.Time.ZoneOffset arg1)
        {
            return SExecute<Java.Time.ZoneId>(LocalBridgeClazz, "ofOffset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZoneId.html#systemDefault()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.ZoneId"/></returns>
        public static Java.Time.ZoneId SystemDefault()
        {
            return SExecuteWithSignature<Java.Time.ZoneId>(LocalBridgeClazz, "systemDefault", "()Ljava/time/ZoneId;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZoneId.html#getAvailableZoneIds()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<Java.Lang.String> GetAvailableZoneIds()
        {
            return SExecuteWithSignature<Java.Util.Set<Java.Lang.String>>(LocalBridgeClazz, "getAvailableZoneIds", "()Ljava/util/Set;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZoneId.html#getId()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetId()
        {
            return IExecuteWithSignature<Java.Lang.String>("getId", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZoneId.html#getRules()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.Zone.ZoneRules"/></returns>
        public Java.Time.Zone.ZoneRules GetRules()
        {
            return IExecuteWithSignature<Java.Time.Zone.ZoneRules>("getRules", "()Ljava/time/zone/ZoneRules;");
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZoneId.html#getDisplayName(java.time.format.TextStyle,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Format.TextStyle"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetDisplayName(Java.Time.Format.TextStyle arg0, Java.Util.Locale arg1)
        {
            return IExecute<Java.Lang.String>("getDisplayName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/java/time/ZoneId.html#normalized()"/>
        /// </summary>
        /// <returns><see cref="Java.Time.ZoneId"/></returns>
        public Java.Time.ZoneId Normalized()
        {
            return IExecuteWithSignature<Java.Time.ZoneId>("normalized", "()Ljava/time/ZoneId;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}