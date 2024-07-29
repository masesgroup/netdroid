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

namespace Android.Util
{
    #region StateSet
    public partial class StateSet
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/StateSet.html#NOTHING"/>
        /// </summary>
        public static int[] NOTHING { get { if (!_NOTHINGReady) { _NOTHINGContent = SGetFieldArray<int>(LocalBridgeClazz, "NOTHING"); _NOTHINGReady = true; } return _NOTHINGContent; } }
        private static int[] _NOTHINGContent = default;
        private static bool _NOTHINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/StateSet.html#WILD_CARD"/>
        /// </summary>
        public static int[] WILD_CARD { get { if (!_WILD_CARDReady) { _WILD_CARDContent = SGetFieldArray<int>(LocalBridgeClazz, "WILD_CARD"); _WILD_CARDReady = true; } return _WILD_CARDContent; } }
        private static int[] _WILD_CARDContent = default;
        private static bool _WILD_CARDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/StateSet.html#isWildCard(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsWildCard(int[] arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isWildCard", "([I)Z", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/StateSet.html#stateSetMatches(int[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool StateSetMatches(int[] arg0, int arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "stateSetMatches", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/StateSet.html#stateSetMatches(int[],int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool StateSetMatches(int[] arg0, int[] arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "stateSetMatches", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/StateSet.html#trimStateSet(int[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int[] TrimStateSet(int[] arg0, int arg1)
        {
            return SExecuteArray<int>(LocalBridgeClazz, "trimStateSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://developer.android.com/reference/android/util/StateSet.html#dump(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String Dump(int[] arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "dump", "([I)Ljava/lang/String;", new object[] { arg0 });
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}